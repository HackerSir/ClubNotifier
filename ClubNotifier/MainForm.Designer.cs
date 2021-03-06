﻿using System.Windows.Forms;
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.sendEmailToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContactToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mailToButton = new System.Windows.Forms.Button();
            this.mailCCButton = new System.Windows.Forms.Button();
            this.mailBodyTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.mailBccButton = new System.Windows.Forms.Button();
            this.mailFromTextBox = new System.Windows.Forms.TextBox();
            this.mailFromLabel = new System.Windows.Forms.Label();
            this.attachmentsButton = new System.Windows.Forms.Button();
            this.mailToListBox = new System.Windows.Forms.ListBox();
            this.mailCCListBox = new System.Windows.Forms.ListBox();
            this.mailBccListBox = new System.Windows.Forms.ListBox();
            this.attachmentsListBox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刪除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.sendEmailToolStripButton.Click += new System.EventHandler(this.sendEmailToolStripButton_Click);
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
            this.ContactToolStripButton.Click += new System.EventHandler(this.ContactToolStripButton_Click);
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
            // mailToButton
            // 
            this.mailToButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailToButton.Location = new System.Drawing.Point(12, 90);
            this.mailToButton.Name = "mailToButton";
            this.mailToButton.Size = new System.Drawing.Size(81, 27);
            this.mailToButton.TabIndex = 5;
            this.mailToButton.Text = "收件者...";
            this.mailToButton.UseVisualStyleBackColor = true;
            this.mailToButton.Click += new System.EventHandler(this.mailToButton_Click);
            // 
            // mailCCButton
            // 
            this.mailCCButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailCCButton.Location = new System.Drawing.Point(12, 134);
            this.mailCCButton.Name = "mailCCButton";
            this.mailCCButton.Size = new System.Drawing.Size(81, 27);
            this.mailCCButton.TabIndex = 7;
            this.mailCCButton.Text = "副本...";
            this.mailCCButton.UseVisualStyleBackColor = true;
            this.mailCCButton.Click += new System.EventHandler(this.mailCCButton_Click);
            // 
            // mailBodyTextBox
            // 
            this.mailBodyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailBodyTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailBodyTextBox.Location = new System.Drawing.Point(12, 299);
            this.mailBodyTextBox.Multiline = true;
            this.mailBodyTextBox.Name = "mailBodyTextBox";
            this.mailBodyTextBox.Size = new System.Drawing.Size(503, 218);
            this.mailBodyTextBox.TabIndex = 14;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subjectTextBox.Location = new System.Drawing.Point(99, 266);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(416, 27);
            this.subjectTextBox.TabIndex = 12;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subjectLabel.Location = new System.Drawing.Point(22, 269);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(47, 17);
            this.subjectLabel.TabIndex = 13;
            this.subjectLabel.Text = "主旨：";
            // 
            // mailBccButton
            // 
            this.mailBccButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailBccButton.Location = new System.Drawing.Point(12, 178);
            this.mailBccButton.Name = "mailBccButton";
            this.mailBccButton.Size = new System.Drawing.Size(81, 27);
            this.mailBccButton.TabIndex = 9;
            this.mailBccButton.Text = "密件副本...";
            this.mailBccButton.UseVisualStyleBackColor = true;
            this.mailBccButton.Click += new System.EventHandler(this.mailBccButton_Click);
            // 
            // mailFromTextBox
            // 
            this.mailFromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailFromTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ClubNotifier.Properties.Settings.Default, "UesrEmail", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.mailFromTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailFromTextBox.Location = new System.Drawing.Point(99, 57);
            this.mailFromTextBox.Name = "mailFromTextBox";
            this.mailFromTextBox.ReadOnly = true;
            this.mailFromTextBox.Size = new System.Drawing.Size(416, 27);
            this.mailFromTextBox.TabIndex = 3;
            this.mailFromTextBox.Text = global::ClubNotifier.Properties.Settings.Default.UesrEmail;
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
            this.attachmentsButton.Location = new System.Drawing.Point(12, 222);
            this.attachmentsButton.Name = "attachmentsButton";
            this.attachmentsButton.Size = new System.Drawing.Size(81, 27);
            this.attachmentsButton.TabIndex = 11;
            this.attachmentsButton.Text = "夾帶檔案...";
            this.attachmentsButton.UseVisualStyleBackColor = true;
            this.attachmentsButton.Click += new System.EventHandler(this.attachmentsButton_Click);
            // 
            // mailToListBox
            // 
            this.mailToListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailToListBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailToListBox.FormattingEnabled = true;
            this.mailToListBox.ItemHeight = 17;
            this.mailToListBox.Location = new System.Drawing.Point(99, 90);
            this.mailToListBox.Name = "mailToListBox";
            this.mailToListBox.ScrollAlwaysVisible = true;
            this.mailToListBox.Size = new System.Drawing.Size(416, 38);
            this.mailToListBox.TabIndex = 16;
            // 
            // mailCCListBox
            // 
            this.mailCCListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailCCListBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailCCListBox.FormattingEnabled = true;
            this.mailCCListBox.ItemHeight = 17;
            this.mailCCListBox.Location = new System.Drawing.Point(99, 134);
            this.mailCCListBox.Name = "mailCCListBox";
            this.mailCCListBox.ScrollAlwaysVisible = true;
            this.mailCCListBox.Size = new System.Drawing.Size(416, 38);
            this.mailCCListBox.TabIndex = 17;
            // 
            // mailBccListBox
            // 
            this.mailBccListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailBccListBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailBccListBox.FormattingEnabled = true;
            this.mailBccListBox.ItemHeight = 17;
            this.mailBccListBox.Location = new System.Drawing.Point(99, 178);
            this.mailBccListBox.Name = "mailBccListBox";
            this.mailBccListBox.ScrollAlwaysVisible = true;
            this.mailBccListBox.Size = new System.Drawing.Size(416, 38);
            this.mailBccListBox.TabIndex = 18;
            // 
            // attachmentsListBox
            // 
            this.attachmentsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.attachmentsListBox.ContextMenuStrip = this.contextMenuStrip1;
            this.attachmentsListBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.attachmentsListBox.FormattingEnabled = true;
            this.attachmentsListBox.ItemHeight = 17;
            this.attachmentsListBox.Location = new System.Drawing.Point(99, 222);
            this.attachmentsListBox.Name = "attachmentsListBox";
            this.attachmentsListBox.ScrollAlwaysVisible = true;
            this.attachmentsListBox.Size = new System.Drawing.Size(416, 38);
            this.attachmentsListBox.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刪除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // 刪除ToolStripMenuItem
            // 
            this.刪除ToolStripMenuItem.Name = "刪除ToolStripMenuItem";
            this.刪除ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.刪除ToolStripMenuItem.Text = "刪除";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 529);
            this.Controls.Add(this.mailFromLabel);
            this.Controls.Add(this.mailFromTextBox);
            this.Controls.Add(this.mailToButton);
            this.Controls.Add(this.mailToListBox);
            this.Controls.Add(this.mailCCButton);
            this.Controls.Add(this.mailCCListBox);
            this.Controls.Add(this.mailBccButton);
            this.Controls.Add(this.mailBccListBox);
            this.Controls.Add(this.attachmentsButton);
            this.Controls.Add(this.attachmentsListBox);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.mailBodyTextBox);
            this.Controls.Add(this.toolStrip);
            this.MinimumSize = new System.Drawing.Size(543, 568);
            this.Name = "MainForm";
            this.Text = "社團通知e-mail發送器";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton sendEmailToolStripButton;
        private Button mailToButton;
        private Button mailCCButton;
        private TextBox mailBodyTextBox;
        private TextBox subjectTextBox;
        private Label subjectLabel;
        private Button mailBccButton;
        private TextBox mailFromTextBox;
        private Label mailFromLabel;
        private Button attachmentsButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ContactToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton SettingsToolStripButton;
        private ToolStripButton AboutToolStripButton;
        private ListBox mailToListBox;
        private ListBox mailCCListBox;
        private ListBox mailBccListBox;
        private ListBox attachmentsListBox;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 刪除ToolStripMenuItem;
    }
}

