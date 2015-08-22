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
            this.PersonTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PersonListBox = new System.Windows.Forms.ListBox();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.EditPersonButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ClubTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ClubListBox = new System.Windows.Forms.ListBox();
            this.AddClubButton = new System.Windows.Forms.Button();
            this.EditClubButton = new System.Windows.Forms.Button();
            this.RemoveClubButton = new System.Windows.Forms.Button();
            this.personData1 = new ClubNotifier.Contacts.PersonData();
            this.clubData1 = new ClubNotifier.Contacts.ClubData();
            this.tabControl1.SuspendLayout();
            this.PersonTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ClubTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PersonTabPage);
            this.tabControl1.Controls.Add(this.ClubTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 378);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Deselecting);
            // 
            // PersonTabPage
            // 
            this.PersonTabPage.Controls.Add(this.splitContainer1);
            this.PersonTabPage.Location = new System.Drawing.Point(4, 22);
            this.PersonTabPage.Name = "PersonTabPage";
            this.PersonTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PersonTabPage.Size = new System.Drawing.Size(474, 352);
            this.PersonTabPage.TabIndex = 0;
            this.PersonTabPage.Text = "聯絡人";
            this.PersonTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.PersonListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AddPersonButton);
            this.splitContainer1.Panel2.Controls.Add(this.EditPersonButton);
            this.splitContainer1.Panel2.Controls.Add(this.RemoveButton);
            this.splitContainer1.Panel2.Controls.Add(this.personData1);
            this.splitContainer1.Size = new System.Drawing.Size(468, 346);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 0;
            // 
            // PersonListBox
            // 
            this.PersonListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonListBox.FormattingEnabled = true;
            this.PersonListBox.ItemHeight = 12;
            this.PersonListBox.Location = new System.Drawing.Point(0, 0);
            this.PersonListBox.Name = "PersonListBox";
            this.PersonListBox.Size = new System.Drawing.Size(156, 346);
            this.PersonListBox.TabIndex = 0;
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(3, 3);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(75, 23);
            this.AddPersonButton.TabIndex = 1;
            this.AddPersonButton.Text = "新增";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            // 
            // EditPersonButton
            // 
            this.EditPersonButton.Location = new System.Drawing.Point(165, 3);
            this.EditPersonButton.Name = "EditPersonButton";
            this.EditPersonButton.Size = new System.Drawing.Size(75, 23);
            this.EditPersonButton.TabIndex = 3;
            this.EditPersonButton.Text = "刪除";
            this.EditPersonButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(84, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "修改";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // ClubTabPage
            // 
            this.ClubTabPage.Controls.Add(this.splitContainer2);
            this.ClubTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClubTabPage.Name = "ClubTabPage";
            this.ClubTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClubTabPage.Size = new System.Drawing.Size(474, 352);
            this.ClubTabPage.TabIndex = 1;
            this.ClubTabPage.Text = "社團";
            this.ClubTabPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ClubListBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.AddClubButton);
            this.splitContainer2.Panel2.Controls.Add(this.EditClubButton);
            this.splitContainer2.Panel2.Controls.Add(this.RemoveClubButton);
            this.splitContainer2.Panel2.Controls.Add(this.clubData1);
            this.splitContainer2.Size = new System.Drawing.Size(468, 346);
            this.splitContainer2.SplitterDistance = 156;
            this.splitContainer2.TabIndex = 0;
            // 
            // ClubListBox
            // 
            this.ClubListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClubListBox.FormattingEnabled = true;
            this.ClubListBox.ItemHeight = 12;
            this.ClubListBox.Location = new System.Drawing.Point(0, 0);
            this.ClubListBox.Name = "ClubListBox";
            this.ClubListBox.Size = new System.Drawing.Size(156, 346);
            this.ClubListBox.TabIndex = 0;
            this.ClubListBox.SelectedIndexChanged += new System.EventHandler(this.ClubListBox_SelectedIndexChanged);
            // 
            // AddClubButton
            // 
            this.AddClubButton.Location = new System.Drawing.Point(5, 3);
            this.AddClubButton.Name = "AddClubButton";
            this.AddClubButton.Size = new System.Drawing.Size(75, 23);
            this.AddClubButton.TabIndex = 1;
            this.AddClubButton.Text = "新增";
            this.AddClubButton.UseVisualStyleBackColor = true;
            this.AddClubButton.Click += new System.EventHandler(this.AddClubButton_Click);
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
            this.EditClubButton.Click += new System.EventHandler(this.EditClubButton_Click);
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
            this.RemoveClubButton.Click += new System.EventHandler(this.RemoveClubButton_Click);
            // 
            // personData1
            // 
            this.personData1.isDataReadOnly = true;
            this.personData1.Location = new System.Drawing.Point(2, 32);
            this.personData1.Name = "personData1";
            this.personData1.Size = new System.Drawing.Size(301, 135);
            this.personData1.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.PersonTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ClubTabPage.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PersonTabPage;
        private System.Windows.Forms.TabPage ClubTabPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox ClubListBox;
        private ClubData clubData1;
        private System.Windows.Forms.Button RemoveClubButton;
        private System.Windows.Forms.Button EditClubButton;
        private System.Windows.Forms.Button AddClubButton;
        private System.Windows.Forms.ListBox PersonListBox;
        private System.Windows.Forms.Button EditPersonButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddPersonButton;
        private PersonData personData1;

    }
}