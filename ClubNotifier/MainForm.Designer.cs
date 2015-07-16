using System.Windows.Forms;
namespace ClubNotifier {
    partial class MainForm {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContactToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mailToTextBox = new System.Windows.Forms.TextBox();
            this.mailToButton = new System.Windows.Forms.Button();
            this.mailCCButton = new System.Windows.Forms.Button();
            this.mailBodyTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.mailCCTextBox = new System.Windows.Forms.TextBox();
            this.mailBccButton = new System.Windows.Forms.Button();
            this.mailFromTextBox = new System.Windows.Forms.TextBox();
            this.mailBccTextBox = new System.Windows.Forms.TextBox();
            this.mailFromLabel = new System.Windows.Forms.Label();
            this.attachmentsButton = new System.Windows.Forms.Button();
            this.attachmentsTextBox = new System.Windows.Forms.TextBox();
            this.sendEmailToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 507);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(527, 22);
            this.statusStrip.TabIndex = 15;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(31, 17);
            this.statusLabel.Text = "就緒";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendEmailToolStripButton,
            this.toolStripSeparator1,
            this.ContactToolStripButton,
            this.toolStripSeparator2,
            this.SettingsToolStripButton,
            this.AboutToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(527, 54);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // ContactToolStripButton
            // 
            this.ContactToolStripButton.AutoToolTip = false;
            this.ContactToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ContactToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ContactToolStripButton.Name = "ContactToolStripButton";
            this.ContactToolStripButton.Size = new System.Drawing.Size(47, 51);
            this.ContactToolStripButton.Text = "聯絡人";
            this.ContactToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // SettingsToolStripButton
            // 
            this.SettingsToolStripButton.AutoToolTip = false;
            this.SettingsToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingsToolStripButton.Name = "SettingsToolStripButton";
            this.SettingsToolStripButton.Size = new System.Drawing.Size(71, 51);
            this.SettingsToolStripButton.Text = "E-mail設定";
            this.SettingsToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SettingsToolStripButton.Click += new System.EventHandler(this.SettingsToolStripButton_Click);
            // 
            // AboutToolStripButton
            // 
            this.AboutToolStripButton.AutoToolTip = false;
            this.AboutToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutToolStripButton.Name = "AboutToolStripButton";
            this.AboutToolStripButton.Size = new System.Drawing.Size(35, 51);
            this.AboutToolStripButton.Text = "關於";
            this.AboutToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AboutToolStripButton.Click += new System.EventHandler(this.AboutToolStripButton_Click);
            // 
            // mailToTextBox
            // 
            this.mailToTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailToTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailToTextBox.Location = new System.Drawing.Point(99, 90);
            this.mailToTextBox.Multiline = true;
            this.mailToTextBox.Name = "mailToTextBox";
            this.mailToTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mailToTextBox.Size = new System.Drawing.Size(416, 27);
            this.mailToTextBox.TabIndex = 4;
            // 
            // mailToButton
            // 
            this.mailToButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailToButton.Location = new System.Drawing.Point(12, 90);
            this.mailToButton.Name = "mailToButton";
            this.mailToButton.Size = new System.Drawing.Size(81, 27);
            this.mailToButton.TabIndex = 5;
            this.mailToButton.Text = "收件者...";
            this.mailToButton.UseVisualStyleBackColor = true;
            // 
            // mailCCButton
            // 
            this.mailCCButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailCCButton.Location = new System.Drawing.Point(12, 123);
            this.mailCCButton.Name = "mailCCButton";
            this.mailCCButton.Size = new System.Drawing.Size(81, 27);
            this.mailCCButton.TabIndex = 7;
            this.mailCCButton.Text = "副本...";
            this.mailCCButton.UseVisualStyleBackColor = true;
            // 
            // mailBodyTextBox
            // 
            this.mailBodyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailBodyTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailBodyTextBox.Location = new System.Drawing.Point(12, 255);
            this.mailBodyTextBox.Multiline = true;
            this.mailBodyTextBox.Name = "mailBodyTextBox";
            this.mailBodyTextBox.Size = new System.Drawing.Size(503, 249);
            this.mailBodyTextBox.TabIndex = 14;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subjectTextBox.Location = new System.Drawing.Point(99, 222);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(416, 27);
            this.subjectTextBox.TabIndex = 12;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subjectLabel.Location = new System.Drawing.Point(22, 225);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(47, 17);
            this.subjectLabel.TabIndex = 13;
            this.subjectLabel.Text = "主旨：";
            // 
            // mailCCTextBox
            // 
            this.mailCCTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailCCTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailCCTextBox.Location = new System.Drawing.Point(99, 123);
            this.mailCCTextBox.Multiline = true;
            this.mailCCTextBox.Name = "mailCCTextBox";
            this.mailCCTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mailCCTextBox.Size = new System.Drawing.Size(416, 27);
            this.mailCCTextBox.TabIndex = 6;
            // 
            // mailBccButton
            // 
            this.mailBccButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailBccButton.Location = new System.Drawing.Point(12, 156);
            this.mailBccButton.Name = "mailBccButton";
            this.mailBccButton.Size = new System.Drawing.Size(81, 27);
            this.mailBccButton.TabIndex = 9;
            this.mailBccButton.Text = "密件副本...";
            this.mailBccButton.UseVisualStyleBackColor = true;
            // 
            // mailFromTextBox
            // 
            this.mailFromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailFromTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailFromTextBox.Location = new System.Drawing.Point(99, 57);
            this.mailFromTextBox.Name = "mailFromTextBox";
            this.mailFromTextBox.ReadOnly = true;
            this.mailFromTextBox.Size = new System.Drawing.Size(416, 27);
            this.mailFromTextBox.TabIndex = 3;
            // 
            // mailBccTextBox
            // 
            this.mailBccTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailBccTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailBccTextBox.Location = new System.Drawing.Point(99, 156);
            this.mailBccTextBox.Multiline = true;
            this.mailBccTextBox.Name = "mailBccTextBox";
            this.mailBccTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mailBccTextBox.Size = new System.Drawing.Size(416, 27);
            this.mailBccTextBox.TabIndex = 8;
            // 
            // mailFromLabel
            // 
            this.mailFromLabel.AutoSize = true;
            this.mailFromLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailFromLabel.Location = new System.Drawing.Point(22, 60);
            this.mailFromLabel.Name = "mailFromLabel";
            this.mailFromLabel.Size = new System.Drawing.Size(60, 17);
            this.mailFromLabel.TabIndex = 2;
            this.mailFromLabel.Text = "寄件者：";
            // 
            // attachmentsButton
            // 
            this.attachmentsButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.attachmentsButton.Location = new System.Drawing.Point(12, 189);
            this.attachmentsButton.Name = "attachmentsButton";
            this.attachmentsButton.Size = new System.Drawing.Size(81, 27);
            this.attachmentsButton.TabIndex = 11;
            this.attachmentsButton.Text = "夾帶檔案...";
            this.attachmentsButton.UseVisualStyleBackColor = true;
            // 
            // attachmentsTextBox
            // 
            this.attachmentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentsTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.attachmentsTextBox.Location = new System.Drawing.Point(99, 189);
            this.attachmentsTextBox.Multiline = true;
            this.attachmentsTextBox.Name = "attachmentsTextBox";
            this.attachmentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attachmentsTextBox.Size = new System.Drawing.Size(416, 27);
            this.attachmentsTextBox.TabIndex = 10;
            // 
            // sendEmailToolStripButton
            // 
            this.sendEmailToolStripButton.AutoToolTip = false;
            this.sendEmailToolStripButton.Image = global::ClubNotifier.Properties.Resources.SendEmailIcon;
            this.sendEmailToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sendEmailToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sendEmailToolStripButton.Name = "sendEmailToolStripButton";
            this.sendEmailToolStripButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.sendEmailToolStripButton.Size = new System.Drawing.Size(52, 51);
            this.sendEmailToolStripButton.Text = "發送";
            this.sendEmailToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 529);
            this.Controls.Add(this.mailFromLabel);
            this.Controls.Add(this.mailFromTextBox);
            this.Controls.Add(this.mailToButton);
            this.Controls.Add(this.mailToTextBox);
            this.Controls.Add(this.mailCCButton);
            this.Controls.Add(this.mailCCTextBox);
            this.Controls.Add(this.mailBccButton);
            this.Controls.Add(this.mailBccTextBox);
            this.Controls.Add(this.attachmentsButton);
            this.Controls.Add(this.attachmentsTextBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.mailBodyTextBox);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.MinimumSize = new System.Drawing.Size(543, 568);
            this.Name = "MainForm";
            this.Text = "社團通知e-mail發送器";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton sendEmailToolStripButton;
        private TextBox mailToTextBox;
        private Button mailToButton;
        private Button mailCCButton;
        private TextBox mailBodyTextBox;
        private TextBox subjectTextBox;
        private Label subjectLabel;
        private TextBox mailCCTextBox;
        private Button mailBccButton;
        private TextBox mailFromTextBox;
        private TextBox mailBccTextBox;
        private Label mailFromLabel;
        private Button attachmentsButton;
        private TextBox attachmentsTextBox;
        private ToolStripStatusLabel statusLabel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ContactToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton SettingsToolStripButton;
        private ToolStripButton AboutToolStripButton;
    }
}

