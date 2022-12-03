using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MqttClientTest
{
    public partial class Form1 : Form
    {
        private string clientId;
        private MqttClient client;

        private bool _isMonitor = false;
        private StreamWriter _monitorWriter;

        private double _msgCount = 0;

        public Form1()
        {
            InitializeComponent();

            clientId = Guid.NewGuid().ToString();
        }

        private void logMessage( string message )
        {
            listRecvMessage.BeginUpdate();

            listRecvMessage.Items.Add( message );
            if ( listRecvMessage.Items.Count > 5000 )
                listRecvMessage.Items.RemoveAt( 0 );

            listRecvMessage.EndUpdate();

            listRecvMessage.SelectedIndex = listRecvMessage.Items.Count - 1;
        }

        /*bool RemoteCertificateValidationCallback( object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors )
        {
            // logic for validation here
            return true;
        }*/

        private void Form1_Load( object sender, EventArgs e )
        {
            cboPubQos.Items.Add( new ComboBoxItem( MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, "0" ) );
            cboPubQos.Items.Add( new ComboBoxItem( MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, "1" ) );
            cboPubQos.Items.Add( new ComboBoxItem( MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, "2" ) );
            cboPubQos.SelectedIndex = 1;
            cboSubQos.Items.Add( new ComboBoxItem( MqttMsgBase.QOS_LEVEL_AT_MOST_ONCE, "0" ) );
            cboSubQos.Items.Add( new ComboBoxItem( MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, "1" ) );
            cboSubQos.Items.Add( new ComboBoxItem( MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, "2" ) );
            cboSubQos.SelectedIndex = 1;

            cboPubRetain.Items.Add( new ComboBoxItem( false, "0" ) );
            cboPubRetain.Items.Add( new ComboBoxItem( true, "1" ) );
            cboPubRetain.SelectedIndex = 0;
        }

        private void btnConnect_Click( object sender, EventArgs e )
        {
            try
            {
                // create client instance 
                //client = new MqttClient( txtIP.Text.Trim(), Convert.ToInt32( txtPort.Text ), true, null, null, MqttSslProtocols.TLSv1_2, RemoteCertificateValidationCallback );
                client = new MqttClient( txtIP.Text.Trim(), Convert.ToInt32( txtPort.Text ), false, null, null, MqttSslProtocols.None );
                // register to message received 
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;
                client.ConnectionClosed += client_ConnectionClosed;

                byte result;
                if ( string.IsNullOrEmpty( txtUserName.Text ) == false && string.IsNullOrEmpty( txtPassword.Text ) == false )
                    result = client.Connect( clientId, txtUserName.Text, txtPassword.Text );
                else
                    result = client.Connect( clientId );

                if ( result == MqttMsgConnack.CONN_ACCEPTED )
                    MessageBox.Show("Connect Success!");
            }
            catch(Exception ex)
            {
                MessageBox.Show( ex.Message );
            }
        }

        private async Task TryReconnectAsync(CancellationToken cancellationToken)
        {
            var connected = client.IsConnected;
            while (!connected && !cancellationToken.IsCancellationRequested)
            {
                try
                {
                    client.Connect(clientId, txtUserName.Text, txtPassword.Text);
                }
                catch
                {
                }
                connected = client.IsConnected;
                await Task.Delay(10000, cancellationToken);
            }
        }

        private void client_ConnectionClosed(object sender, EventArgs e)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            Task T = Task.Run(() => TryReconnectAsync(source.Token));
            T.Wait();
            foreach(var item in listSubTopics.Items)
            {
                client.Subscribe(new string[] { item.ToString() }, new byte[] { (byte)((ComboBoxItem)cboPubQos.SelectedItem).Value });

            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (txtPTopic.Text == string.Empty || txtPMessage.Text == string.Empty || cboPubQos.SelectedIndex < 0)
                return;

            if (client.IsConnected == false)
            {
                MessageBox.Show("Connect Error!");
                return;
            }

            client.Publish(txtPTopic.Text, Encoding.UTF8.GetBytes(txtPMessage.Text.Trim()), (byte)((ComboBoxItem)cboPubQos.SelectedItem).Value, (bool)((ComboBoxItem)cboPubRetain.SelectedItem).Value);

        }

        private void btnSubscribe_Click( object sender, EventArgs e )
        {
            if ( client == null || client.IsConnected == false )
            {
                MessageBox.Show( "Connect Error!" );
                return;
            }

            int rsult = client.Subscribe( new string[] { txtSubTopic.Text.Trim() }, new byte[] { ( byte ) ( ( ComboBoxItem ) cboPubQos.SelectedItem ).Value } );
            if ( rsult > 0 )
                listSubTopics.Items.Add( txtSubTopic.Text.Trim() );
        }

        private void client_MqttMsgPublishReceived( object sender, MqttMsgPublishEventArgs e )
        {
            // handle message received\
            string message = string.Format("[{0}] [{1}] : {2}", DateTime.Now.ToString("HH:mm:ss"), e.Topic, System.Text.Encoding.UTF8.GetString( e.Message ) );
            UpdateMessage( message, listRecvMessage );
            writeMonitorLog(message);
        }

        private delegate void UpdateListBoxCallBack( string value, ListBox list );
        private void UpdateMessage( string value, ListBox list )
        {
            if ( this.InvokeRequired )
            {
                UpdateListBoxCallBack uu = new UpdateListBoxCallBack( UpdateMessage );
                this.Invoke( uu, value, list );
            }
            else
            {
                logMessage( value );
                _msgCount++;
                txtMsgCount.Text = _msgCount.ToString();
            }
        }

        private void linkClear_Click( object sender, EventArgs e )
        {
            listRecvMessage.Items.Clear();
            _msgCount = 0;
            txtMsgCount.Text = _msgCount.ToString();
        }

        private void btnDisconnect_Click( object sender, EventArgs e )
        {
            if ( client != null )
                client.Disconnect();
            listSubTopics.Items.Clear();
        }

        private void listRecvMessage_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            int index = listRecvMessage.IndexFromPoint( e.Location );
            if ( index != ListBox.NoMatches )
            {
                using ( FrmMessage frmMessage = new FrmMessage() )
                {
                    frmMessage.Text = listRecvMessage.SelectedItem.ToString();
                    frmMessage.ShowDialog( this );
                }
            }
        }

        private void btnClearMsg_Click( object sender, EventArgs e )
        {
            txtPMessage.Text = string.Empty;
        }

        private void Form1_FormClosed( object sender, FormClosedEventArgs e )
        {
            if ( client != null && client.IsConnected )
                client.Disconnect();
        }

        private void linkExport_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            try
            {
                using ( StreamWriter writer = new StreamWriter( "export.txt" ) )
                {
                    foreach ( var item in listRecvMessage.Items )
                    {
                        writer.WriteLine( item.ToString() );
                    }
                }
                MessageBox.Show( "Export success !" );
            }
            catch (Exception ex )
            {
                MessageBox.Show( ex.ToString() );
            }
        }

        private void linkMonitor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _isMonitor = !_isMonitor;
            lblMonitorStatus.BackColor = (_isMonitor) ? Color.Red : Color.Gray;

            if(_isMonitor == true)
            {
                _monitorWriter?.Dispose();
                FileStream fs = new FileStream("monitor.txt", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                _monitorWriter = new StreamWriter(fs, Encoding.Default, 16 * 1024);
                _monitorWriter.AutoFlush = false;
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                _monitorWriter.Close();
            }
        }
        private void writeMonitorLog(string message)
        {
            if (!_isMonitor)
                return;

            _monitorWriter.WriteLine(message);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!_isMonitor)
                return;

            _monitorWriter?.Flush();
        }
    }

    public class ComboBoxItem
    {
        public ComboBoxItem( object value, string text )
        {
            Value = value;
            Text = text;
        }
        public object Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
