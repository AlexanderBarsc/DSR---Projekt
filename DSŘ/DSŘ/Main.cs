using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sharp7;

namespace DSŘ
{
    public partial class Main : Form
    {
        private S7Client Client;
        public Main()
        {
            Client = new S7Client();
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateGui();
        }

        private void UpdateGui()
        {
            Client.MBRead()
        }

        /// <summary>
        /// Handles connection to PLC.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            int result = 0; //TODO add better error handling
            if(!Client.Connected)
            {
                result = Client.ConnectTo(IPAddress.Text, 0, 1);

                if(result != 0)
                {
                    ErrorTextBox.Text = "Something went wrong during connection";
                    return;
                }
                ConnectButton.Text = "Disconnect";
            }
            else
            {
                result = Client.Disconnect();

                if (result != 0)
                {
                    ErrorTextBox.Text = "Something went wrong during disconnection";
                    return;
                }
                ConnectButton.Text = "Connect";
            }
        }
    }
}
