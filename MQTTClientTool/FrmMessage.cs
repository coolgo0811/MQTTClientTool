using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MqttClientTest
{
    public partial class FrmMessage : Form
    {
        public override string Text
        {
            set
            {
                textBox1.Text = value;
            }
        }

        public FrmMessage()
        {
            InitializeComponent();
        }
    }
}
