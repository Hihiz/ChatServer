
namespace ChatClientWinForm
{
    partial class Client
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectButton = new System.Windows.Forms.Button();
            this.HideCheckBox = new System.Windows.Forms.CheckBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.LocAddrLabel = new System.Windows.Forms.Label();
            this.AddrTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.SendLabel = new System.Windows.Forms.Label();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(108, 31);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.TabStop = false;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // HideCheckBox
            // 
            this.HideCheckBox.AutoSize = true;
            this.HideCheckBox.Location = new System.Drawing.Point(460, 68);
            this.HideCheckBox.Name = "HideCheckBox";
            this.HideCheckBox.Size = new System.Drawing.Size(72, 19);
            this.HideCheckBox.TabIndex = 18;
            this.HideCheckBox.Text = "Hide key";
            this.HideCheckBox.UseVisualStyleBackColor = true;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(420, 44);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(29, 15);
            this.KeyLabel.TabIndex = 17;
            this.KeyLabel.Text = "Key:";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(460, 42);
            this.KeyTextBox.MaxLength = 200;
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(132, 20);
            this.KeyTextBox.TabIndex = 16;
            this.KeyTextBox.TabStop = false;
            this.KeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(417, 9);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(32, 15);
            this.PortLabel.TabIndex = 15;
            this.PortLabel.Text = "Port:";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(460, 7);
            this.PortTextBox.MaxLength = 200;
            this.PortTextBox.Multiline = true;
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(132, 20);
            this.PortTextBox.TabIndex = 14;
            this.PortTextBox.TabStop = false;
            this.PortTextBox.Text = "9000";
            this.PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(181, 47);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 15);
            this.UserNameLabel.TabIndex = 13;
            this.UserNameLabel.Text = "Username:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(259, 44);
            this.UserNameTextBox.MaxLength = 200;
            this.UserNameTextBox.Multiline = true;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(132, 20);
            this.UserNameTextBox.TabIndex = 12;
            this.UserNameTextBox.TabStop = false;
            this.UserNameTextBox.Text = "Server";
            this.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocAddrLabel
            // 
            this.LocAddrLabel.AutoSize = true;
            this.LocAddrLabel.Location = new System.Drawing.Point(192, 12);
            this.LocAddrLabel.Name = "LocAddrLabel";
            this.LocAddrLabel.Size = new System.Drawing.Size(52, 15);
            this.LocAddrLabel.TabIndex = 11;
            this.LocAddrLabel.Text = "Address:";
            // 
            // AddrTextBox
            // 
            this.AddrTextBox.Location = new System.Drawing.Point(259, 9);
            this.AddrTextBox.MaxLength = 200;
            this.AddrTextBox.Multiline = true;
            this.AddrTextBox.Name = "AddrTextBox";
            this.AddrTextBox.Size = new System.Drawing.Size(132, 20);
            this.AddrTextBox.TabIndex = 10;
            this.AddrTextBox.TabStop = false;
            this.AddrTextBox.Text = "127.0.0.1";
            this.AddrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(484, 93);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(108, 31);
            this.ClearButton.TabIndex = 19;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(569, 446);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(28, 15);
            this.VersionLabel.TabIndex = 23;
            this.VersionLabel.Text = "v1.5";
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(12, 464);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(590, 23);
            this.SendTextBox.TabIndex = 22;
            this.SendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendTextBox_KeyDown_1);
            // 
            // SendLabel
            // 
            this.SendLabel.AutoSize = true;
            this.SendLabel.Location = new System.Drawing.Point(12, 445);
            this.SendLabel.Name = "SendLabel";
            this.SendLabel.Size = new System.Drawing.Size(33, 15);
            this.SendLabel.TabIndex = 21;
            this.SendLabel.Text = "Send";
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(12, 153);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(590, 289);
            this.LogTextBox.TabIndex = 20;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(293, 122);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(27, 15);
            this.LogLabel.TabIndex = 24;
            this.LogLabel.Text = "Log";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 494);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.SendLabel);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.HideCheckBox);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.LocAddrLabel);
            this.Controls.Add(this.AddrTextBox);
            this.Controls.Add(this.ConnectButton);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.CheckBox HideCheckBox;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label LocAddrLabel;
        private System.Windows.Forms.TextBox AddrTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Label SendLabel;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label LogLabel;
    }
}

