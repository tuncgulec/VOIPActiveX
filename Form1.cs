using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACXVoip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axVoipActiveX1.Server = TxtServer.Text;
            axVoipActiveX1.Password = TxtPassword.Text;
            axVoipActiveX1.Proxy = TxtProxy.Text;
            axVoipActiveX1.Extension = TxtExtension.Text;
            axVoipActiveX1.Username = TxtUsername.Text;
            axVoipActiveX1.ConnectVoip();

            if (axVoipActiveX1.Connected == 1)
                MessageBox.Show("Connected");
            else
                MessageBox.Show("No Connected"); 

        }

        private void axVoipActiveX1_OnInCall(object sender, AxTncVoipActiveX.IVoipActiveXEvents_OnInCallEvent e)
        {
            MessageBox.Show(e.number);
        }
    }
}
