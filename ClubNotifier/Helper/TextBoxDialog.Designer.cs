namespace ClubNotifier.Helper {
    partial class TextBoxDialog {
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
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.CencelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataTextBox
            // 
            this.DataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTextBox.Location = new System.Drawing.Point(12, 12);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(260, 22);
            this.DataTextBox.TabIndex = 0;
            // 
            // CencelButton
            // 
            this.CencelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CencelButton.Location = new System.Drawing.Point(116, 40);
            this.CencelButton.Name = "CencelButton";
            this.CencelButton.Size = new System.Drawing.Size(75, 23);
            this.CencelButton.TabIndex = 1;
            this.CencelButton.Text = "取消";
            this.CencelButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Location = new System.Drawing.Point(197, 40);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "確定";
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // TextBoxDialog
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CencelButton;
            this.ClientSize = new System.Drawing.Size(284, 71);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CencelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextBoxDialog";
            this.Text = "編輯";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CencelButton;
        private System.Windows.Forms.Button OKButton;
        public System.Windows.Forms.TextBox DataTextBox;
    }
}