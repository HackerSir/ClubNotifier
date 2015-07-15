﻿namespace ClubNotifier {
    partial class EmailSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.userInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.serverInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SmtpServerLabel = new System.Windows.Forms.Label();
            this.SmtpServerTextBox = new System.Windows.Forms.TextBox();
            this.serverPortLabel = new System.Windows.Forms.Label();
            this.serverPortTextBox = new System.Windows.Forms.TextBox();
            this.enableSSLCheckBox = new System.Windows.Forms.CheckBox();
            this.loginInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginUsernameTextBox = new System.Windows.Forms.TextBox();
            this.loginPassewordLabel = new System.Windows.Forms.Label();
            this.loginPassewordTextBox = new System.Windows.Forms.TextBox();
            this.noSavePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sendTestMailButton = new System.Windows.Forms.Button();
            this.userInfoGroupBox.SuspendLayout();
            this.serverInfoGroupBox.SuspendLayout();
            this.loginInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userInfoGroupBox
            // 
            this.userInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInfoGroupBox.Controls.Add(this.userNameLabel);
            this.userInfoGroupBox.Controls.Add(this.userNameTextBox);
            this.userInfoGroupBox.Controls.Add(this.mailLabel);
            this.userInfoGroupBox.Controls.Add(this.mailTextBox);
            this.userInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.userInfoGroupBox.Name = "userInfoGroupBox";
            this.userInfoGroupBox.Size = new System.Drawing.Size(502, 96);
            this.userInfoGroupBox.TabIndex = 0;
            this.userInfoGroupBox.TabStop = false;
            this.userInfoGroupBox.Text = "使用者資訊";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userNameLabel.Location = new System.Drawing.Point(6, 24);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(73, 17);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "您的名稱：";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClubNotifier.Properties.Settings.Default, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userNameTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.userNameTextBox.Location = new System.Drawing.Point(141, 21);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(355, 27);
            this.userNameTextBox.TabIndex = 1;
            this.userNameTextBox.Text = global::ClubNotifier.Properties.Settings.Default.UserName;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailLabel.Location = new System.Drawing.Point(6, 57);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(99, 17);
            this.mailLabel.TabIndex = 2;
            this.mailLabel.Text = "電子郵件地址：";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClubNotifier.Properties.Settings.Default, "UesrEmail", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailTextBox.Location = new System.Drawing.Point(141, 54);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(355, 27);
            this.mailTextBox.TabIndex = 3;
            this.mailTextBox.Text = global::ClubNotifier.Properties.Settings.Default.UesrEmail;
            // 
            // serverInfoGroupBox
            // 
            this.serverInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverInfoGroupBox.Controls.Add(this.SmtpServerLabel);
            this.serverInfoGroupBox.Controls.Add(this.SmtpServerTextBox);
            this.serverInfoGroupBox.Controls.Add(this.serverPortLabel);
            this.serverInfoGroupBox.Controls.Add(this.serverPortTextBox);
            this.serverInfoGroupBox.Controls.Add(this.enableSSLCheckBox);
            this.serverInfoGroupBox.Location = new System.Drawing.Point(12, 114);
            this.serverInfoGroupBox.Name = "serverInfoGroupBox";
            this.serverInfoGroupBox.Size = new System.Drawing.Size(502, 84);
            this.serverInfoGroupBox.TabIndex = 1;
            this.serverInfoGroupBox.TabStop = false;
            this.serverInfoGroupBox.Text = "伺服器資訊";
            // 
            // SmtpServerLabel
            // 
            this.SmtpServerLabel.AutoSize = true;
            this.SmtpServerLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SmtpServerLabel.Location = new System.Drawing.Point(6, 24);
            this.SmtpServerLabel.Name = "SmtpServerLabel";
            this.SmtpServerLabel.Size = new System.Drawing.Size(129, 17);
            this.SmtpServerLabel.TabIndex = 0;
            this.SmtpServerLabel.Text = "外送伺服器(SMTP)：";
            // 
            // SmtpServerTextBox
            // 
            this.SmtpServerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SmtpServerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClubNotifier.Properties.Settings.Default, "SmtpServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SmtpServerTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SmtpServerTextBox.Location = new System.Drawing.Point(141, 21);
            this.SmtpServerTextBox.Name = "SmtpServerTextBox";
            this.SmtpServerTextBox.Size = new System.Drawing.Size(234, 27);
            this.SmtpServerTextBox.TabIndex = 1;
            this.SmtpServerTextBox.Text = global::ClubNotifier.Properties.Settings.Default.SmtpServer;
            // 
            // serverPortLabel
            // 
            this.serverPortLabel.AutoSize = true;
            this.serverPortLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serverPortLabel.Location = new System.Drawing.Point(381, 24);
            this.serverPortLabel.Name = "serverPortLabel";
            this.serverPortLabel.Size = new System.Drawing.Size(47, 17);
            this.serverPortLabel.TabIndex = 2;
            this.serverPortLabel.Text = "Port：";
            // 
            // serverPortTextBox
            // 
            this.serverPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverPortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClubNotifier.Properties.Settings.Default, "SmtpServerPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.serverPortTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.serverPortTextBox.Location = new System.Drawing.Point(442, 21);
            this.serverPortTextBox.Name = "serverPortTextBox";
            this.serverPortTextBox.Size = new System.Drawing.Size(54, 27);
            this.serverPortTextBox.TabIndex = 3;
            this.serverPortTextBox.Text = global::ClubNotifier.Properties.Settings.Default.SmtpServerPort;
            this.serverPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // enableSSLCheckBox
            // 
            this.enableSSLCheckBox.AutoSize = true;
            this.enableSSLCheckBox.Checked = global::ClubNotifier.Properties.Settings.Default.IsEnableSSL;
            this.enableSSLCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ClubNotifier.Properties.Settings.Default, "IsEnableSSL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.enableSSLCheckBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.enableSSLCheckBox.Location = new System.Drawing.Point(141, 54);
            this.enableSSLCheckBox.Name = "enableSSLCheckBox";
            this.enableSSLCheckBox.Size = new System.Drawing.Size(74, 21);
            this.enableSSLCheckBox.TabIndex = 4;
            this.enableSSLCheckBox.Text = "啟用SSL";
            this.enableSSLCheckBox.UseVisualStyleBackColor = true;
            // 
            // loginInfoGroupBox
            // 
            this.loginInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginInfoGroupBox.Controls.Add(this.loginUsernameLabel);
            this.loginInfoGroupBox.Controls.Add(this.loginUsernameTextBox);
            this.loginInfoGroupBox.Controls.Add(this.loginPassewordLabel);
            this.loginInfoGroupBox.Controls.Add(this.loginPassewordTextBox);
            this.loginInfoGroupBox.Controls.Add(this.noSavePasswordCheckBox);
            this.loginInfoGroupBox.Location = new System.Drawing.Point(12, 204);
            this.loginInfoGroupBox.Name = "loginInfoGroupBox";
            this.loginInfoGroupBox.Size = new System.Drawing.Size(502, 116);
            this.loginInfoGroupBox.TabIndex = 2;
            this.loginInfoGroupBox.TabStop = false;
            this.loginInfoGroupBox.Text = "登入資訊";
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginUsernameLabel.Location = new System.Drawing.Point(6, 24);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(86, 17);
            this.loginUsernameLabel.TabIndex = 0;
            this.loginUsernameLabel.Text = "使用者名稱：";
            // 
            // loginUsernameTextBox
            // 
            this.loginUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginUsernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClubNotifier.Properties.Settings.Default, "LoginUserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.loginUsernameTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginUsernameTextBox.Location = new System.Drawing.Point(141, 21);
            this.loginUsernameTextBox.Name = "loginUsernameTextBox";
            this.loginUsernameTextBox.Size = new System.Drawing.Size(355, 27);
            this.loginUsernameTextBox.TabIndex = 1;
            this.loginUsernameTextBox.Text = global::ClubNotifier.Properties.Settings.Default.LoginUserName;
            // 
            // loginPassewordLabel
            // 
            this.loginPassewordLabel.AutoSize = true;
            this.loginPassewordLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginPassewordLabel.Location = new System.Drawing.Point(6, 57);
            this.loginPassewordLabel.Name = "loginPassewordLabel";
            this.loginPassewordLabel.Size = new System.Drawing.Size(47, 17);
            this.loginPassewordLabel.TabIndex = 2;
            this.loginPassewordLabel.Text = "密碼：";
            // 
            // loginPassewordTextBox
            // 
            this.loginPassewordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPassewordTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginPassewordTextBox.Location = new System.Drawing.Point(141, 54);
            this.loginPassewordTextBox.Name = "loginPassewordTextBox";
            this.loginPassewordTextBox.Size = new System.Drawing.Size(355, 27);
            this.loginPassewordTextBox.TabIndex = 3;
            this.loginPassewordTextBox.UseSystemPasswordChar = true;
            // 
            // noSavePasswordCheckBox
            // 
            this.noSavePasswordCheckBox.AutoSize = true;
            this.noSavePasswordCheckBox.Checked = global::ClubNotifier.Properties.Settings.Default.IsNoSavePassword;
            this.noSavePasswordCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ClubNotifier.Properties.Settings.Default, "IsNoSavePassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.noSavePasswordCheckBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.noSavePasswordCheckBox.Location = new System.Drawing.Point(141, 87);
            this.noSavePasswordCheckBox.Name = "noSavePasswordCheckBox";
            this.noSavePasswordCheckBox.Size = new System.Drawing.Size(131, 21);
            this.noSavePasswordCheckBox.TabIndex = 4;
            this.noSavePasswordCheckBox.Text = "寄信前再詢問密碼";
            this.noSavePasswordCheckBox.UseVisualStyleBackColor = true;
            this.noSavePasswordCheckBox.CheckedChanged += new System.EventHandler(this.noSavePasswordCheckBox_CheckedChanged);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(358, 330);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "確定";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(439, 330);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "取消";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // sendTestMailButton
            // 
            this.sendTestMailButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendTestMailButton.Location = new System.Drawing.Point(12, 330);
            this.sendTestMailButton.Name = "sendTestMailButton";
            this.sendTestMailButton.Size = new System.Drawing.Size(75, 23);
            this.sendTestMailButton.TabIndex = 3;
            this.sendTestMailButton.Text = "寄測試信";
            this.sendTestMailButton.UseVisualStyleBackColor = true;
            this.sendTestMailButton.Click += new System.EventHandler(this.sendTestMailButton_Click);
            // 
            // EmailSettings
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(526, 363);
            this.Controls.Add(this.userInfoGroupBox);
            this.Controls.Add(this.serverInfoGroupBox);
            this.Controls.Add(this.loginInfoGroupBox);
            this.Controls.Add(this.sendTestMailButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.cancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailSettings";
            this.Text = "E-mail 設定";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmailSettings_FormClosed);
            this.Load += new System.EventHandler(this.EmailSettings_Load);
            this.userInfoGroupBox.ResumeLayout(false);
            this.userInfoGroupBox.PerformLayout();
            this.serverInfoGroupBox.ResumeLayout(false);
            this.serverInfoGroupBox.PerformLayout();
            this.loginInfoGroupBox.ResumeLayout(false);
            this.loginInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox userInfoGroupBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.GroupBox serverInfoGroupBox;
        private System.Windows.Forms.Label serverPortLabel;
        private System.Windows.Forms.TextBox serverPortTextBox;
        private System.Windows.Forms.TextBox SmtpServerTextBox;
        private System.Windows.Forms.Label SmtpServerLabel;
        private System.Windows.Forms.GroupBox loginInfoGroupBox;
        private System.Windows.Forms.Label loginPassewordLabel;
        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.TextBox loginPassewordTextBox;
        private System.Windows.Forms.TextBox loginUsernameTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox enableSSLCheckBox;
        private System.Windows.Forms.Button sendTestMailButton;
        private System.Windows.Forms.CheckBox noSavePasswordCheckBox;
    }
}