
namespace ChatServerWinForm
{
    partial class Form1
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
            this.StartButton = new System.Windows.Forms.Button();
            this.AddrTextBox = new System.Windows.Forms.TextBox();
            this.AddrLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ClientsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalClientsLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.SendLabel = new System.Windows.Forms.Label();
            this.SendTextBox = new System.Windows.Forms.TextBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(108, 31);
            this.StartButton.TabIndex = 0;
            this.StartButton.TabStop = false;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // AddrTextBox
            // 
            this.AddrTextBox.Location = new System.Drawing.Point(233, 9);
            this.AddrTextBox.MaxLength = 200;
            this.AddrTextBox.Multiline = true;
            this.AddrTextBox.Name = "AddrTextBox";
            this.AddrTextBox.Size = new System.Drawing.Size(132, 20);
            this.AddrTextBox.TabIndex = 1;
            this.AddrTextBox.TabStop = false;
            this.AddrTextBox.Text = "127.0.0.1";
            this.AddrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddrLabel
            // 
            this.AddrLabel.AutoSize = true;
            this.AddrLabel.Location = new System.Drawing.Point(166, 12);
            this.AddrLabel.Name = "AddrLabel";
            this.AddrLabel.Size = new System.Drawing.Size(52, 15);
            this.AddrLabel.TabIndex = 2;
            this.AddrLabel.Text = "Address:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(155, 47);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 15);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "Username:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(233, 44);
            this.UserNameTextBox.MaxLength = 200;
            this.UserNameTextBox.Multiline = true;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(132, 20);
            this.UserNameTextBox.TabIndex = 3;
            this.UserNameTextBox.TabStop = false;
            this.UserNameTextBox.Text = "Server";
            this.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(406, 47);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(29, 15);
            this.KeyLabel.TabIndex = 8;
            this.KeyLabel.Text = "Key:";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(470, 44);
            this.KeyTextBox.MaxLength = 200;
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(132, 20);
            this.KeyTextBox.TabIndex = 7;
            this.KeyTextBox.TabStop = false;
            this.KeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(403, 12);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(32, 15);
            this.PortLabel.TabIndex = 6;
            this.PortLabel.Text = "Port:";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(470, 9);
            this.PortTextBox.MaxLength = 200;
            this.PortTextBox.Multiline = true;
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(132, 20);
            this.PortTextBox.TabIndex = 5;
            this.PortTextBox.TabStop = false;
            this.PortTextBox.Text = "9000";
            this.PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(470, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 19);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Hide key";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ClientsDataGridView1
            // 
            this.ClientsDataGridView1.AllowUserToAddRows = false;
            this.ClientsDataGridView1.AllowUserToDeleteRows = false;
            this.ClientsDataGridView1.AllowUserToResizeColumns = false;
            this.ClientsDataGridView1.AllowUserToResizeRows = false;
            this.ClientsDataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ClientsDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ClientsDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ClientsDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ClientsDataGridView1.ColumnHeadersHeight = 24;
            this.ClientsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ClientsDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Kick});
            this.ClientsDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ClientsDataGridView1.EnableHeadersVisualStyles = false;
            this.ClientsDataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ClientsDataGridView1.Location = new System.Drawing.Point(608, 9);
            this.ClientsDataGridView1.MultiSelect = false;
            this.ClientsDataGridView1.Name = "ClientsDataGridView1";
            this.ClientsDataGridView1.ReadOnly = true;
            this.ClientsDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ClientsDataGridView1.RowHeadersVisible = false;
            this.ClientsDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ClientsDataGridView1.RowTemplate.Height = 25;
            this.ClientsDataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClientsDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientsDataGridView1.ShowCellErrors = false;
            this.ClientsDataGridView1.ShowCellToolTips = false;
            this.ClientsDataGridView1.ShowEditingIcon = false;
            this.ClientsDataGridView1.ShowRowErrors = false;
            this.ClientsDataGridView1.Size = new System.Drawing.Size(280, 501);
            this.ClientsDataGridView1.TabIndex = 10;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Kick
            // 
            this.Kick.HeaderText = "Disconnect";
            this.Kick.Name = "Kick";
            this.Kick.ReadOnly = true;
            // 
            // TotalClientsLabel
            // 
            this.TotalClientsLabel.AutoSize = true;
            this.TotalClientsLabel.Location = new System.Drawing.Point(521, 105);
            this.TotalClientsLabel.Name = "TotalClientsLabel";
            this.TotalClientsLabel.Size = new System.Drawing.Size(81, 15);
            this.TotalClientsLabel.TabIndex = 11;
            this.TotalClientsLabel.Text = "Total clients: 0";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(12, 139);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(108, 31);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.TabStop = false;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Log";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(494, 139);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(108, 31);
            this.DisconnectButton.TabIndex = 14;
            this.DisconnectButton.TabStop = false;
            this.DisconnectButton.Text = "Disconnect all";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(12, 176);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(590, 289);
            this.LogTextBox.TabIndex = 15;
            // 
            // SendLabel
            // 
            this.SendLabel.AutoSize = true;
            this.SendLabel.Location = new System.Drawing.Point(12, 468);
            this.SendLabel.Name = "SendLabel";
            this.SendLabel.Size = new System.Drawing.Size(33, 15);
            this.SendLabel.TabIndex = 16;
            this.SendLabel.Text = "Send";
            // 
            // SendTextBox
            // 
            this.SendTextBox.Location = new System.Drawing.Point(12, 487);
            this.SendTextBox.Name = "SendTextBox";
            this.SendTextBox.Size = new System.Drawing.Size(590, 23);
            this.SendTextBox.TabIndex = 17;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(569, 469);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(28, 15);
            this.VersionLabel.TabIndex = 18;
            this.VersionLabel.Text = "v1.5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 522);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.SendTextBox);
            this.Controls.Add(this.SendLabel);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TotalClientsLabel);
            this.Controls.Add(this.ClientsDataGridView1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.AddrLabel);
            this.Controls.Add(this.AddrTextBox);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Server";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox AddrTextBox;
        private System.Windows.Forms.Label AddrLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView ClientsDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kick;
        private System.Windows.Forms.Label TotalClientsLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label SendLabel;
        private System.Windows.Forms.TextBox SendTextBox;
        private System.Windows.Forms.Label VersionLabel;
    }
}

