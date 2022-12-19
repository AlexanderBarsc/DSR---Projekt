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
        private PLCConfiguration PLCConfiguration;
        private CommunicationsDataBlock CommunicationsDataBlock;
        private bool AdminModeStatus = false;
       
        public Main()
        {
            Client = new S7Client();
            PLCConfiguration = new PLCConfiguration();
            InitializeComponent();

            ClockRateSetter.DataSource = Enum.GetValues(typeof(PLCConfiguration.Clock));
            ClockRateSetter.SelectedIndex = ClockRateSetter.FindStringExact(PLCConfiguration.Clock.HZ1.ToString());
        }


        /// <summary>
        /// Timer tick that calls GUI Update.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Client.Connected)
            {
                UpdateGui();
            }
            
        }

        /// <summary>
        /// Receives data from PLC and updates GUI.
        /// </summary>
        private void UpdateGui()
        {
            if (AdminModeStatus)
            {
                AdminMode.Visible = false;
                AdminModeTextBox.Visible = false;
                AdminModeGroupBox.Visible = true;
            }
            else
            {
                AdminMode.Visible = true;
                AdminModeTextBox.Visible = true;
                AdminModeGroupBox.Visible = false;
            }

            var result = UpdateCommunicationsDataBlock(); //GUI logic according to received DB

            if(result == 0)
            {
                
                switch((PLCConfiguration.State)CommunicationsDataBlock.State)
                {
                    case PLCConfiguration.State.GreenVerticalRedHorizontal:
                        pictureBox1.Image = Properties.Resources.CrossroadState0;
                        break;
                    case PLCConfiguration.State.SwitchToGreenHorizontalFirst:
                        pictureBox1.Image = Properties.Resources.CrossroadState1;
                        break;
                    case PLCConfiguration.State.SwitchToGreenHorizontalSecond:
                        pictureBox1.Image = Properties.Resources.CrossroadState2;
                        break;
                    case PLCConfiguration.State.RedVerticalGreenHorizontal:
                        pictureBox1.Image = Properties.Resources.CrossroadState3;
                        break;
                    case PLCConfiguration.State.SwitchToGreenVerticalFirst:
                        pictureBox1.Image = Properties.Resources.CrossroadeState4;
                        break;
                    case PLCConfiguration.State.SwitchToGreenVerticalSecond:
                        pictureBox1.Image = Properties.Resources.CrossroadState5;
                        break;
                    case PLCConfiguration.State.NightModeOrangeOn:
                        pictureBox1.Image = Properties.Resources.CrossroadState6_drawio;
                        break;
                    case PLCConfiguration.State.NightModeOrangeOff:
                        pictureBox1.Image = Properties.Resources.CrossroadState7_drawio;
                        break;
                }


                NightModeStatus.Checked = CommunicationsDataBlock.NightModeSwitch;
                ClockRateLabel.Text = $"ClockRate: {(PLCConfiguration.Clock)CommunicationsDataBlock.Clock}";
                StateLabel.Text = $"Current State: {CommunicationsDataBlock.State}";

                
            }

            

        }

        /// <summary>
        /// Handles connection to PLC.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            int result = 0; 
            if(!Client.Connected)
            {
                try
                {
                    result = Client.ConnectTo(IPAddress.Text, Convert.ToInt32(Rack.Text), Convert.ToInt32(SlotTextBox.Text));
                }
                catch(Exception ex)
                {
                    ErrorTextBox.Text = ex.Message;
                    return;
                }

                if(result != 0)
                {
                    ErrorTextBox.Text = "Error during connection";
                    return;
                }
                ConnectButton.Text = "Disconnect";
            }
            else
            {
                result = Client.Disconnect();

                if (result != 0)
                {
                    ErrorTextBox.Text = "Error during disconnection";
                    return;
                }
                ConnectButton.Text = "Connect";
                AdminModeStatus = false;
            }
        }

        /// <summary>
        /// Update CommunicationsDB
        /// </summary>
        /// <returns></returns>
        private int UpdateCommunicationsDataBlock()
        {
            var result = 0;
            byte[] buf = new byte[5];
            result = Client.DBRead(4, 0, 5, buf);

            if(result == 0)
            {
                CommunicationsDataBlock = new CommunicationsDataBlock(buf[1], buf[3], Convert.ToBoolean(buf[4]));
                return result;
            }

            return result;
        }

        private void NightMode_Click(object sender, EventArgs e)
        {
            if(ChangeNightMode(!NightModeStatus.Checked) != 0)
            {
                ErrorTextBox.Text = "NightMode was not able to be changed";
            }
        }

        private int ChangeNightMode(bool toggle)
        {
            byte[] arr = { Convert.ToByte(toggle) };
            return Client.DBWrite(4, 4, 1, arr);
        }

        private void ClockRateSetter_SelectedValueChanged(object sender, EventArgs e)
        {
            if(Client.Connected)
            {
                var value = (PLCConfiguration.Clock)ClockRateSetter.SelectedValue;

                if(ChangeClockRate(Convert.ToByte(value)) != 0)
                {
                    ErrorTextBox.Text = "ClockRate was not able to be changed";
                }
            }
            
        }
        /// <summary>
        /// Method to change the frequency of the counter clock.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int ChangeClockRate(byte value)
        {
            byte[] arr = { value };
            return Client.DBWrite(4, 3, 1, arr);
        }

        /// <summary>
        /// Admin mode logic.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminMode_Click(object sender, EventArgs e)
        {
            if(!Client.Connected)
            {
                ErrorTextBox.Text = "Client is not connected";
                return;
            }

            if(AdminModeTextBox.Text == "admin")
            {
                AdminModeStatus = true;
            }
            else
            {
                ErrorTextBox.Text = "Invalid password";
            }
        }

        /// <summary>
        /// Log off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogOffAdmin_Click(object sender, EventArgs e)
        {
            AdminModeStatus = false;
        }

        private void ClearConsole_Click(object sender, EventArgs e)
        {
            ErrorTextBox.Text = string.Empty;
        }

    }
}
