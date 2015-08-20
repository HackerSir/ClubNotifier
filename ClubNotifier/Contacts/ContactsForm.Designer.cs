namespace ClubNotifier.Contacts {
    partial class ContactsForm {
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
            ClubNotifier.Contacts.Club club1 = new ClubNotifier.Contacts.Club();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RemoveClubButton = new System.Windows.Forms.Button();
            this.EditClubButton = new System.Windows.Forms.Button();
            this.AddClubButton = new System.Windows.Forms.Button();
            this.clubData1 = new ClubNotifier.Contacts.ClubData();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(468, 346);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "社團";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.RemoveClubButton);
            this.splitContainer2.Panel2.Controls.Add(this.EditClubButton);
            this.splitContainer2.Panel2.Controls.Add(this.AddClubButton);
            this.splitContainer2.Panel2.Controls.Add(this.clubData1);
            this.splitContainer2.Size = new System.Drawing.Size(468, 346);
            this.splitContainer2.SplitterDistance = 156;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 346);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RemoveClubButton
            // 
            this.RemoveClubButton.Enabled = false;
            this.RemoveClubButton.Location = new System.Drawing.Point(167, 3);
            this.RemoveClubButton.Name = "RemoveClubButton";
            this.RemoveClubButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveClubButton.TabIndex = 3;
            this.RemoveClubButton.Text = "刪除";
            this.RemoveClubButton.UseVisualStyleBackColor = true;
            // 
            // EditClubButton
            // 
            this.EditClubButton.Enabled = false;
            this.EditClubButton.Location = new System.Drawing.Point(86, 3);
            this.EditClubButton.Name = "EditClubButton";
            this.EditClubButton.Size = new System.Drawing.Size(75, 23);
            this.EditClubButton.TabIndex = 2;
            this.EditClubButton.Text = "編輯";
            this.EditClubButton.UseVisualStyleBackColor = true;
            // 
            // AddClubButton
            // 
            this.AddClubButton.Location = new System.Drawing.Point(5, 3);
            this.AddClubButton.Name = "AddClubButton";
            this.AddClubButton.Size = new System.Drawing.Size(75, 23);
            this.AddClubButton.TabIndex = 1;
            this.AddClubButton.Text = "新增";
            this.AddClubButton.UseVisualStyleBackColor = true;
            this.AddClubButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clubData1
            // 
            club1.ClubCode = null;
            club1.Name = null;
            this.clubData1.Data = club1;
            this.clubData1.isDataReadOnly = true;
            this.clubData1.Location = new System.Drawing.Point(2, 32);
            this.clubData1.Name = "clubData1";
            this.clubData1.Size = new System.Drawing.Size(300, 69);
            this.clubData1.TabIndex = 0;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 378);
            this.Controls.Add(this.tabControl1);
            this.Name = "ContactsForm";
            this.Text = "ContactsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactsForm_FormClosing);
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox listBox1;
        private ClubData clubData1;
        private System.Windows.Forms.Button RemoveClubButton;
        private System.Windows.Forms.Button EditClubButton;
        private System.Windows.Forms.Button AddClubButton;

    }
}