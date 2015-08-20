namespace ClubNotifier.Contacts {
    partial class ClubDataForm {
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clubData1 = new ClubNotifier.Contacts.ClubData();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(134, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(215, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "確定";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // clubData1
            // 
            club1.ClubCode = null;
            club1.Name = null;
            this.clubData1.Data = club1;
            this.clubData1.isDataReadOnly = false;
            this.clubData1.Location = new System.Drawing.Point(12, 12);
            this.clubData1.Name = "clubData1";
            this.clubData1.Size = new System.Drawing.Size(278, 69);
            this.clubData1.TabIndex = 0;
            // 
            // ClubDataForm
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(300, 118);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clubData1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClubDataForm";
            this.Text = "編輯";
            this.ResumeLayout(false);

        }

        #endregion

        private ClubData clubData1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}