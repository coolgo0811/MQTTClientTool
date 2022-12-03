namespace MqttClientTest
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.txtPMessage = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPTopic = new System.Windows.Forms.TextBox();
            this.lblPTopic = new System.Windows.Forms.Label();
            this.tabSub = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSubQos = new System.Windows.Forms.Label();
            this.cboSubQos = new System.Windows.Forms.ComboBox();
            this.listSubTopics = new System.Windows.Forms.ListBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.lblSubTopic = new System.Windows.Forms.Label();
            this.txtSubTopic = new System.Windows.Forms.TextBox();
            this.tabPub = new System.Windows.Forms.TabPage();
            this.cboPubRetain = new System.Windows.Forms.ComboBox();
            this.lblPubRetain = new System.Windows.Forms.Label();
            this.btnClearMsg = new System.Windows.Forms.Button();
            this.lblPubQos = new System.Windows.Forms.Label();
            this.cboPubQos = new System.Windows.Forms.ComboBox();
            this.lblPMessage = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listRecvMessage = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMsgCount = new System.Windows.Forms.Label();
            this.lblMonitorStatus = new System.Windows.Forms.Label();
            this.txtMsgCount = new System.Windows.Forms.Label();
            this.linkMonitor = new System.Windows.Forms.LinkLabel();
            this.linkClear = new System.Windows.Forms.LinkLabel();
            this.linkExport = new System.Windows.Forms.LinkLabel();
            this.grpFunction = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabSub.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPub.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(15, 49);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(204, 26);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(13, 24);
            this.lblIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(76, 20);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "IP Address";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(226, 24);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(33, 20);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(229, 49);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(83, 26);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "1883";
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(695, 92);
            this.btnPublish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(72, 28);
            this.btnPublish.TabIndex = 4;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // txtPMessage
            // 
            this.txtPMessage.Location = new System.Drawing.Point(80, 56);
            this.txtPMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPMessage.MaxLength = 9999999;
            this.txtPMessage.Multiline = true;
            this.txtPMessage.Name = "txtPMessage";
            this.txtPMessage.Size = new System.Drawing.Size(592, 26);
            this.txtPMessage.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(465, 78);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 26);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPTopic
            // 
            this.txtPTopic.Location = new System.Drawing.Point(80, 20);
            this.txtPTopic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPTopic.Name = "txtPTopic";
            this.txtPTopic.Size = new System.Drawing.Size(592, 26);
            this.txtPTopic.TabIndex = 7;
            this.txtPTopic.Text = "test";
            // 
            // lblPTopic
            // 
            this.lblPTopic.AutoSize = true;
            this.lblPTopic.Location = new System.Drawing.Point(30, 25);
            this.lblPTopic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPTopic.Name = "lblPTopic";
            this.lblPTopic.Size = new System.Drawing.Size(42, 20);
            this.lblPTopic.TabIndex = 8;
            this.lblPTopic.Text = "Topic";
            // 
            // tabSub
            // 
            this.tabSub.Controls.Add(this.tabPage2);
            this.tabSub.Controls.Add(this.tabPub);
            this.tabSub.Controls.Add(this.tabPage3);
            this.tabSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSub.Location = new System.Drawing.Point(0, 168);
            this.tabSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSub.Name = "tabSub";
            this.tabSub.SelectedIndex = 0;
            this.tabSub.Size = new System.Drawing.Size(853, 378);
            this.tabSub.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSubQos);
            this.tabPage2.Controls.Add(this.cboSubQos);
            this.tabPage2.Controls.Add(this.listSubTopics);
            this.tabPage2.Controls.Add(this.btnSubscribe);
            this.tabPage2.Controls.Add(this.lblSubTopic);
            this.tabPage2.Controls.Add(this.txtSubTopic);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(845, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Subscribe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSubQos
            // 
            this.lblSubQos.AutoSize = true;
            this.lblSubQos.Location = new System.Drawing.Point(36, 59);
            this.lblSubQos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubQos.Name = "lblSubQos";
            this.lblSubQos.Size = new System.Drawing.Size(34, 20);
            this.lblSubQos.TabIndex = 17;
            this.lblSubQos.Text = "Qos";
            // 
            // cboSubQos
            // 
            this.cboSubQos.FormattingEnabled = true;
            this.cboSubQos.Location = new System.Drawing.Point(76, 56);
            this.cboSubQos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboSubQos.Name = "cboSubQos";
            this.cboSubQos.Size = new System.Drawing.Size(92, 28);
            this.cboSubQos.TabIndex = 16;
            // 
            // listSubTopics
            // 
            this.listSubTopics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listSubTopics.FormattingEnabled = true;
            this.listSubTopics.ItemHeight = 20;
            this.listSubTopics.Location = new System.Drawing.Point(4, 96);
            this.listSubTopics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listSubTopics.Name = "listSubTopics";
            this.listSubTopics.Size = new System.Drawing.Size(837, 244);
            this.listSubTopics.TabIndex = 15;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(409, 18);
            this.btnSubscribe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(76, 28);
            this.btnSubscribe.TabIndex = 12;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSubscribe_Click);
            // 
            // lblSubTopic
            // 
            this.lblSubTopic.AutoSize = true;
            this.lblSubTopic.Location = new System.Drawing.Point(28, 25);
            this.lblSubTopic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTopic.Name = "lblSubTopic";
            this.lblSubTopic.Size = new System.Drawing.Size(42, 20);
            this.lblSubTopic.TabIndex = 10;
            this.lblSubTopic.Text = "Topic";
            // 
            // txtSubTopic
            // 
            this.txtSubTopic.Location = new System.Drawing.Point(76, 20);
            this.txtSubTopic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSubTopic.Name = "txtSubTopic";
            this.txtSubTopic.Size = new System.Drawing.Size(325, 26);
            this.txtSubTopic.TabIndex = 9;
            this.txtSubTopic.Text = "#";
            // 
            // tabPub
            // 
            this.tabPub.Controls.Add(this.cboPubRetain);
            this.tabPub.Controls.Add(this.lblPubRetain);
            this.tabPub.Controls.Add(this.btnClearMsg);
            this.tabPub.Controls.Add(this.lblPubQos);
            this.tabPub.Controls.Add(this.cboPubQos);
            this.tabPub.Controls.Add(this.lblPMessage);
            this.tabPub.Controls.Add(this.lblPTopic);
            this.tabPub.Controls.Add(this.btnPublish);
            this.tabPub.Controls.Add(this.txtPTopic);
            this.tabPub.Controls.Add(this.txtPMessage);
            this.tabPub.Location = new System.Drawing.Point(4, 29);
            this.tabPub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPub.Name = "tabPub";
            this.tabPub.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPub.Size = new System.Drawing.Size(845, 345);
            this.tabPub.TabIndex = 0;
            this.tabPub.Text = "Publish";
            this.tabPub.UseVisualStyleBackColor = true;
            // 
            // cboPubRetain
            // 
            this.cboPubRetain.FormattingEnabled = true;
            this.cboPubRetain.Location = new System.Drawing.Point(279, 92);
            this.cboPubRetain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPubRetain.Name = "cboPubRetain";
            this.cboPubRetain.Size = new System.Drawing.Size(92, 28);
            this.cboPubRetain.TabIndex = 26;
            // 
            // lblPubRetain
            // 
            this.lblPubRetain.AutoSize = true;
            this.lblPubRetain.Location = new System.Drawing.Point(224, 97);
            this.lblPubRetain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPubRetain.Name = "lblPubRetain";
            this.lblPubRetain.Size = new System.Drawing.Size(46, 20);
            this.lblPubRetain.TabIndex = 25;
            this.lblPubRetain.Text = "Retain";
            // 
            // btnClearMsg
            // 
            this.btnClearMsg.Location = new System.Drawing.Point(695, 56);
            this.btnClearMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearMsg.Name = "btnClearMsg";
            this.btnClearMsg.Size = new System.Drawing.Size(72, 28);
            this.btnClearMsg.TabIndex = 23;
            this.btnClearMsg.Text = "clear";
            this.btnClearMsg.UseVisualStyleBackColor = true;
            this.btnClearMsg.Click += new System.EventHandler(this.btnClearMsg_Click);
            // 
            // lblPubQos
            // 
            this.lblPubQos.AutoSize = true;
            this.lblPubQos.Location = new System.Drawing.Point(42, 97);
            this.lblPubQos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPubQos.Name = "lblPubQos";
            this.lblPubQos.Size = new System.Drawing.Size(34, 20);
            this.lblPubQos.TabIndex = 12;
            this.lblPubQos.Text = "Qos";
            // 
            // cboPubQos
            // 
            this.cboPubQos.FormattingEnabled = true;
            this.cboPubQos.Location = new System.Drawing.Point(80, 92);
            this.cboPubQos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboPubQos.Name = "cboPubQos";
            this.cboPubQos.Size = new System.Drawing.Size(92, 28);
            this.cboPubQos.TabIndex = 11;
            // 
            // lblPMessage
            // 
            this.lblPMessage.AutoSize = true;
            this.lblPMessage.Location = new System.Drawing.Point(14, 61);
            this.lblPMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPMessage.Name = "lblPMessage";
            this.lblPMessage.Size = new System.Drawing.Size(65, 20);
            this.lblPMessage.TabIndex = 9;
            this.lblPMessage.Text = "Message";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listRecvMessage);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(845, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Message";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listRecvMessage
            // 
            this.listRecvMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listRecvMessage.FormattingEnabled = true;
            this.listRecvMessage.ItemHeight = 20;
            this.listRecvMessage.Location = new System.Drawing.Point(4, 48);
            this.listRecvMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listRecvMessage.Name = "listRecvMessage";
            this.listRecvMessage.Size = new System.Drawing.Size(837, 292);
            this.listRecvMessage.TabIndex = 14;
            this.listRecvMessage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listRecvMessage_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMsgCount);
            this.panel1.Controls.Add(this.lblMonitorStatus);
            this.panel1.Controls.Add(this.txtMsgCount);
            this.panel1.Controls.Add(this.linkMonitor);
            this.panel1.Controls.Add(this.linkClear);
            this.panel1.Controls.Add(this.linkExport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 43);
            this.panel1.TabIndex = 20;
            // 
            // lblMsgCount
            // 
            this.lblMsgCount.AutoSize = true;
            this.lblMsgCount.Location = new System.Drawing.Point(12, 9);
            this.lblMsgCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsgCount.Name = "lblMsgCount";
            this.lblMsgCount.Size = new System.Drawing.Size(47, 20);
            this.lblMsgCount.TabIndex = 16;
            this.lblMsgCount.Text = "Count:";
            // 
            // lblMonitorStatus
            // 
            this.lblMonitorStatus.BackColor = System.Drawing.Color.Gray;
            this.lblMonitorStatus.Location = new System.Drawing.Point(769, 9);
            this.lblMonitorStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonitorStatus.Name = "lblMonitorStatus";
            this.lblMonitorStatus.Size = new System.Drawing.Size(16, 20);
            this.lblMonitorStatus.TabIndex = 19;
            // 
            // txtMsgCount
            // 
            this.txtMsgCount.AutoSize = true;
            this.txtMsgCount.Location = new System.Drawing.Point(66, 9);
            this.txtMsgCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMsgCount.Name = "txtMsgCount";
            this.txtMsgCount.Size = new System.Drawing.Size(16, 20);
            this.txtMsgCount.TabIndex = 17;
            this.txtMsgCount.Text = "0";
            // 
            // linkMonitor
            // 
            this.linkMonitor.AutoSize = true;
            this.linkMonitor.Location = new System.Drawing.Point(710, 9);
            this.linkMonitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkMonitor.Name = "linkMonitor";
            this.linkMonitor.Size = new System.Drawing.Size(53, 20);
            this.linkMonitor.TabIndex = 18;
            this.linkMonitor.TabStop = true;
            this.linkMonitor.Text = "Monitor";
            this.linkMonitor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMonitor_LinkClicked);
            // 
            // linkClear
            // 
            this.linkClear.AutoSize = true;
            this.linkClear.Location = new System.Drawing.Point(606, 9);
            this.linkClear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkClear.Name = "linkClear";
            this.linkClear.Size = new System.Drawing.Size(40, 20);
            this.linkClear.TabIndex = 15;
            this.linkClear.TabStop = true;
            this.linkClear.Text = "Clear";
            this.linkClear.Click += new System.EventHandler(this.linkClear_Click);
            // 
            // linkExport
            // 
            this.linkExport.AutoSize = true;
            this.linkExport.Location = new System.Drawing.Point(654, 9);
            this.linkExport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkExport.Name = "linkExport";
            this.linkExport.Size = new System.Drawing.Size(48, 20);
            this.linkExport.TabIndex = 16;
            this.linkExport.TabStop = true;
            this.linkExport.Text = "Export";
            this.linkExport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExport_LinkClicked);
            // 
            // grpFunction
            // 
            this.grpFunction.Controls.Add(this.btnDisconnect);
            this.grpFunction.Controls.Add(this.lblPassword);
            this.grpFunction.Controls.Add(this.lblUserName);
            this.grpFunction.Controls.Add(this.txtPassword);
            this.grpFunction.Controls.Add(this.txtUserName);
            this.grpFunction.Controls.Add(this.txtIP);
            this.grpFunction.Controls.Add(this.lblIP);
            this.grpFunction.Controls.Add(this.btnConnect);
            this.grpFunction.Controls.Add(this.txtPort);
            this.grpFunction.Controls.Add(this.lblPort);
            this.grpFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFunction.Location = new System.Drawing.Point(0, 0);
            this.grpFunction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFunction.Name = "grpFunction";
            this.grpFunction.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFunction.Size = new System.Drawing.Size(853, 168);
            this.grpFunction.TabIndex = 10;
            this.grpFunction.TabStop = false;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(465, 114);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(87, 26);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(224, 89);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 20);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(13, 89);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(72, 20);
            this.lblUserName.TabIndex = 9;
            this.lblUserName.Text = "UserName";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(227, 114);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 26);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(13, 112);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(204, 26);
            this.txtUserName.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 546);
            this.Controls.Add(this.tabSub);
            this.Controls.Add(this.grpFunction);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "MQTTClientTool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabSub.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPub.ResumeLayout(false);
            this.tabPub.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpFunction.ResumeLayout(false);
            this.grpFunction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.TextBox txtPMessage;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPTopic;
        private System.Windows.Forms.Label lblPTopic;
        private System.Windows.Forms.TabControl tabSub;
        private System.Windows.Forms.TabPage tabPub;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label lblSubTopic;
        private System.Windows.Forms.TextBox txtSubTopic;
        private System.Windows.Forms.GroupBox grpFunction;
        private System.Windows.Forms.Label lblPMessage;
        private System.Windows.Forms.Label lblPubQos;
        private System.Windows.Forms.ComboBox cboPubQos;
        private System.Windows.Forms.ListBox listSubTopics;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkClear;
        private System.Windows.Forms.ListBox listRecvMessage;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnClearMsg;
        private System.Windows.Forms.Label lblPubRetain;
        private System.Windows.Forms.ComboBox cboPubRetain;
        private System.Windows.Forms.Label lblSubQos;
        private System.Windows.Forms.ComboBox cboSubQos;
        private System.Windows.Forms.Label txtMsgCount;
        private System.Windows.Forms.Label lblMsgCount;
        private System.Windows.Forms.LinkLabel linkExport;
        private System.Windows.Forms.Label lblMonitorStatus;
        private System.Windows.Forms.LinkLabel linkMonitor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}

