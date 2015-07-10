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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.聯絡人ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.sendToolStripButton = new System.Windows.Forms.ToolStripButton();
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
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 448);
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
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.聯絡人ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(527, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 聯絡人ToolStripMenuItem
            // 
            this.聯絡人ToolStripMenuItem.Name = "聯絡人ToolStripMenuItem";
            this.聯絡人ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.聯絡人ToolStripMenuItem.Text = "聯絡人";
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設定ToolStripMenuItem,
            this.toolStripSeparator1,
            this.關於ToolStripMenuItem});
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.ShortcutKeyDisplayString = "H";
            this.說明ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.說明ToolStripMenuItem.Text = "其他";
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.關於ToolStripMenuItem.Text = "關於";
            this.關於ToolStripMenuItem.Click += new System.EventHandler(this.關於ToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(527, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // sendToolStripButton
            // 
            this.sendToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("sendToolStripButton.Image")));
            this.sendToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sendToolStripButton.Name = "sendToolStripButton";
            this.sendToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.sendToolStripButton.Text = "傳送";
            // 
            // mailToTextBox
            // 
            this.mailToTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mailToTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailToTextBox.Location = new System.Drawing.Point(99, 85);
            this.mailToTextBox.Multiline = true;
            this.mailToTextBox.Name = "mailToTextBox";
            this.mailToTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mailToTextBox.Size = new System.Drawing.Size(416, 27);
            this.mailToTextBox.TabIndex = 4;
            // 
            // mailToButton
            // 
            this.mailToButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailToButton.Location = new System.Drawing.Point(12, 85);
            this.mailToButton.Name = "mailToButton";
            this.mailToButton.Size = new System.Drawing.Size(81, 27);
            this.mailToButton.TabIndex = 5;
            this.mailToButton.Text = "收件者...";
            this.mailToButton.UseVisualStyleBackColor = true;
            // 
            // mailCCButton
            // 
            this.mailCCButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailCCButton.Location = new System.Drawing.Point(12, 118);
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
            this.mailBodyTextBox.Location = new System.Drawing.Point(12, 252);
            this.mailBodyTextBox.Multiline = true;
            this.mailBodyTextBox.Name = "mailBodyTextBox";
            this.mailBodyTextBox.Size = new System.Drawing.Size(503, 193);
            this.mailBodyTextBox.TabIndex = 14;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subjectTextBox.Location = new System.Drawing.Point(99, 217);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(416, 27);
            this.subjectTextBox.TabIndex = 12;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.subjectLabel.Location = new System.Drawing.Point(22, 220);
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
            this.mailCCTextBox.Location = new System.Drawing.Point(99, 118);
            this.mailCCTextBox.Multiline = true;
            this.mailCCTextBox.Name = "mailCCTextBox";
            this.mailCCTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mailCCTextBox.Size = new System.Drawing.Size(416, 27);
            this.mailCCTextBox.TabIndex = 6;
            // 
            // mailBccButton
            // 
            this.mailBccButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.mailBccButton.Location = new System.Drawing.Point(12, 151);
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
            this.mailFromTextBox.Location = new System.Drawing.Point(99, 52);
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
            this.mailBccTextBox.Location = new System.Drawing.Point(99, 151);
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
            this.mailFromLabel.Location = new System.Drawing.Point(22, 55);
            this.mailFromLabel.Name = "mailFromLabel";
            this.mailFromLabel.Size = new System.Drawing.Size(60, 17);
            this.mailFromLabel.TabIndex = 2;
            this.mailFromLabel.Text = "寄件者：";
            // 
            // attachmentsButton
            // 
            this.attachmentsButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.attachmentsButton.Location = new System.Drawing.Point(12, 184);
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
            this.attachmentsTextBox.Location = new System.Drawing.Point(99, 184);
            this.attachmentsTextBox.Multiline = true;
            this.attachmentsTextBox.Name = "attachmentsTextBox";
            this.attachmentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.attachmentsTextBox.Size = new System.Drawing.Size(416, 27);
            this.attachmentsTextBox.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 470);
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
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(543, 509);
            this.Name = "MainForm";
            this.Text = "社團通知e-mail發送器";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton sendToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private ToolStripMenuItem 聯絡人ToolStripMenuItem;
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
        private ToolStripMenuItem 設定ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripStatusLabel statusLabel;
    }
}

