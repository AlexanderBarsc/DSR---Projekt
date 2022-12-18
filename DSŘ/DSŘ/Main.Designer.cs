
namespace DSŘ
{
    partial class Main
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.IPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ErrorTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdminModeGroupBox = new System.Windows.Forms.GroupBox();
            this.LogOffAdmin = new System.Windows.Forms.Button();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ClockRateLabel = new System.Windows.Forms.Label();
            this.NightModeStatus = new System.Windows.Forms.CheckBox();
            this.ClockRateSetter = new System.Windows.Forms.ComboBox();
            this.clockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NightMode = new System.Windows.Forms.Button();
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Rack = new System.Windows.Forms.TextBox();
            this.SlotTextBox = new System.Windows.Forms.TextBox();
            this.SlotLabel = new System.Windows.Forms.Label();
            this.AdminMode = new System.Windows.Forms.Button();
            this.AdminModeTextBox = new System.Windows.Forms.TextBox();
            this.ClearConsole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.AdminModeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(25, 70);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // IPAddress
            // 
            this.IPAddress.Location = new System.Drawing.Point(25, 35);
            this.IPAddress.Name = "IPAddress";
            this.IPAddress.Size = new System.Drawing.Size(100, 20);
            this.IPAddress.TabIndex = 3;
            this.IPAddress.Text = "192.168.0.150";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ErrorTextBox
            // 
            this.ErrorTextBox.BackColor = System.Drawing.Color.White;
            this.ErrorTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ErrorTextBox.ForeColor = System.Drawing.Color.Red;
            this.ErrorTextBox.Location = new System.Drawing.Point(0, 564);
            this.ErrorTextBox.Name = "ErrorTextBox";
            this.ErrorTextBox.ReadOnly = true;
            this.ErrorTextBox.Size = new System.Drawing.Size(1094, 20);
            this.ErrorTextBox.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DSŘ.Properties.Resources.CrossroadState0;
            this.pictureBox1.Location = new System.Drawing.Point(186, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 383);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AdminModeGroupBox
            // 
            this.AdminModeGroupBox.Controls.Add(this.LogOffAdmin);
            this.AdminModeGroupBox.Controls.Add(this.StateLabel);
            this.AdminModeGroupBox.Controls.Add(this.ClockRateLabel);
            this.AdminModeGroupBox.Controls.Add(this.NightModeStatus);
            this.AdminModeGroupBox.Controls.Add(this.ClockRateSetter);
            this.AdminModeGroupBox.Controls.Add(this.NightMode);
            this.AdminModeGroupBox.Location = new System.Drawing.Point(697, 13);
            this.AdminModeGroupBox.Name = "AdminModeGroupBox";
            this.AdminModeGroupBox.Size = new System.Drawing.Size(336, 114);
            this.AdminModeGroupBox.TabIndex = 11;
            this.AdminModeGroupBox.TabStop = false;
            this.AdminModeGroupBox.Text = "AdminMode";
            this.AdminModeGroupBox.Visible = false;
            // 
            // LogOffAdmin
            // 
            this.LogOffAdmin.Location = new System.Drawing.Point(245, 15);
            this.LogOffAdmin.Name = "LogOffAdmin";
            this.LogOffAdmin.Size = new System.Drawing.Size(75, 23);
            this.LogOffAdmin.TabIndex = 19;
            this.LogOffAdmin.Text = "Log Off";
            this.LogOffAdmin.UseVisualStyleBackColor = true;
            this.LogOffAdmin.Click += new System.EventHandler(this.LogOffAdmin_Click);
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(20, 20);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(72, 13);
            this.StateLabel.TabIndex = 12;
            this.StateLabel.Text = "Current State:";
            // 
            // ClockRateLabel
            // 
            this.ClockRateLabel.AutoSize = true;
            this.ClockRateLabel.Location = new System.Drawing.Point(159, 79);
            this.ClockRateLabel.Name = "ClockRateLabel";
            this.ClockRateLabel.Size = new System.Drawing.Size(63, 13);
            this.ClockRateLabel.TabIndex = 3;
            this.ClockRateLabel.Text = "ClockRate: ";
            // 
            // NightModeStatus
            // 
            this.NightModeStatus.AutoSize = true;
            this.NightModeStatus.Location = new System.Drawing.Point(111, 47);
            this.NightModeStatus.Name = "NightModeStatus";
            this.NightModeStatus.Size = new System.Drawing.Size(111, 17);
            this.NightModeStatus.TabIndex = 2;
            this.NightModeStatus.Text = "NightMode Status";
            this.NightModeStatus.UseVisualStyleBackColor = true;
            // 
            // ClockRateSetter
            // 
            this.ClockRateSetter.BackColor = System.Drawing.SystemColors.Window;
            this.ClockRateSetter.DataSource = this.clockBindingSource;
            this.ClockRateSetter.FormattingEnabled = true;
            this.ClockRateSetter.Location = new System.Drawing.Point(18, 76);
            this.ClockRateSetter.Name = "ClockRateSetter";
            this.ClockRateSetter.Size = new System.Drawing.Size(121, 21);
            this.ClockRateSetter.TabIndex = 1;
            this.ClockRateSetter.SelectedValueChanged += new System.EventHandler(this.ClockRateSetter_SelectedValueChanged);
            // 
            // clockBindingSource
            // 
            this.clockBindingSource.DataSource = typeof(DSŘ.PLCConfiguration.Clock);
            // 
            // NightMode
            // 
            this.NightMode.Location = new System.Drawing.Point(18, 43);
            this.NightMode.Name = "NightMode";
            this.NightMode.Size = new System.Drawing.Size(75, 23);
            this.NightMode.TabIndex = 0;
            this.NightMode.Text = "NightMode On";
            this.NightMode.UseVisualStyleBackColor = true;
            this.NightMode.Click += new System.EventHandler(this.NightMode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rack";
            // 
            // Rack
            // 
            this.Rack.Location = new System.Drawing.Point(147, 35);
            this.Rack.Name = "Rack";
            this.Rack.Size = new System.Drawing.Size(30, 20);
            this.Rack.TabIndex = 14;
            this.Rack.Text = "0";
            // 
            // SlotTextBox
            // 
            this.SlotTextBox.Location = new System.Drawing.Point(200, 35);
            this.SlotTextBox.Name = "SlotTextBox";
            this.SlotTextBox.Size = new System.Drawing.Size(30, 20);
            this.SlotTextBox.TabIndex = 15;
            this.SlotTextBox.Text = "1";
            // 
            // SlotLabel
            // 
            this.SlotLabel.AutoSize = true;
            this.SlotLabel.Location = new System.Drawing.Point(197, 14);
            this.SlotLabel.Name = "SlotLabel";
            this.SlotLabel.Size = new System.Drawing.Size(25, 13);
            this.SlotLabel.TabIndex = 16;
            this.SlotLabel.Text = "Slot";
            // 
            // AdminMode
            // 
            this.AdminMode.Location = new System.Drawing.Point(573, 33);
            this.AdminMode.Name = "AdminMode";
            this.AdminMode.Size = new System.Drawing.Size(75, 23);
            this.AdminMode.TabIndex = 17;
            this.AdminMode.Text = "AdminMode";
            this.AdminMode.UseVisualStyleBackColor = true;
            this.AdminMode.Click += new System.EventHandler(this.AdminMode_Click);
            // 
            // AdminModeTextBox
            // 
            this.AdminModeTextBox.Location = new System.Drawing.Point(573, 73);
            this.AdminModeTextBox.Name = "AdminModeTextBox";
            this.AdminModeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdminModeTextBox.TabIndex = 18;
            this.AdminModeTextBox.Text = "*****";
            // 
            // ClearConsole
            // 
            this.ClearConsole.Location = new System.Drawing.Point(1018, 541);
            this.ClearConsole.Name = "ClearConsole";
            this.ClearConsole.Size = new System.Drawing.Size(75, 23);
            this.ClearConsole.TabIndex = 19;
            this.ClearConsole.Text = "Clear";
            this.ClearConsole.UseVisualStyleBackColor = true;
            this.ClearConsole.Click += new System.EventHandler(this.ClearConsole_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 584);
            this.Controls.Add(this.ClearConsole);
            this.Controls.Add(this.AdminModeTextBox);
            this.Controls.Add(this.AdminMode);
            this.Controls.Add(this.SlotLabel);
            this.Controls.Add(this.SlotTextBox);
            this.Controls.Add(this.Rack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminModeGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ErrorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPAddress);
            this.Controls.Add(this.ConnectButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1110, 623);
            this.Name = "Main";
            this.Text = "DSR - Projekt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.AdminModeGroupBox.ResumeLayout(false);
            this.AdminModeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox IPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox ErrorTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox AdminModeGroupBox;
        private System.Windows.Forms.ComboBox ClockRateSetter;
        private System.Windows.Forms.Button NightMode;
        private System.Windows.Forms.CheckBox NightModeStatus;
        private System.Windows.Forms.Label ClockRateLabel;
        private System.Windows.Forms.BindingSource messagesBindingSource;
        private System.Windows.Forms.BindingSource clockBindingSource;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Rack;
        private System.Windows.Forms.TextBox SlotTextBox;
        private System.Windows.Forms.Label SlotLabel;
        private System.Windows.Forms.Button LogOffAdmin;
        private System.Windows.Forms.Button AdminMode;
        private System.Windows.Forms.TextBox AdminModeTextBox;
        private System.Windows.Forms.Button ClearConsole;
    }
}

