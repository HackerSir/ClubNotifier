namespace ClubNotifier.Contacts {
    partial class PersonData {
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.EmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.JobLabel = new System.Windows.Forms.Label();
            this.ClubLabel = new System.Windows.Forms.Label();
            this.JobsComboBox = new System.Windows.Forms.ComboBox();
            this.ClubsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmailLabel.Location = new System.Drawing.Point(7, 39);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(53, 17);
            this.EmailLabel.TabIndex = 20;
            this.EmailLabel.Text = "Email：";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameLabel.Location = new System.Drawing.Point(7, 6);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 17);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = "姓名：";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.EmailTextBox.Location = new System.Drawing.Point(83, 36);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(192, 27);
            this.EmailTextBox.TabIndex = 18;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameTextBox.Location = new System.Drawing.Point(83, 3);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(192, 27);
            this.NameTextBox.TabIndex = 17;
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.JobLabel.Location = new System.Drawing.Point(7, 72);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(47, 17);
            this.JobLabel.TabIndex = 21;
            this.JobLabel.Text = "職位：";
            // 
            // ClubLabel
            // 
            this.ClubLabel.AutoSize = true;
            this.ClubLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClubLabel.Location = new System.Drawing.Point(7, 103);
            this.ClubLabel.Name = "ClubLabel";
            this.ClubLabel.Size = new System.Drawing.Size(47, 17);
            this.ClubLabel.TabIndex = 22;
            this.ClubLabel.Text = "社團：";
            // 
            // JobsComboBox
            // 
            this.JobsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JobsComboBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.JobsComboBox.FormattingEnabled = true;
            this.JobsComboBox.Location = new System.Drawing.Point(83, 69);
            this.JobsComboBox.Name = "JobsComboBox";
            this.JobsComboBox.Size = new System.Drawing.Size(192, 25);
            this.JobsComboBox.TabIndex = 23;
            // 
            // ClubsComboBox
            // 
            this.ClubsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClubsComboBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClubsComboBox.FormattingEnabled = true;
            this.ClubsComboBox.Location = new System.Drawing.Point(83, 100);
            this.ClubsComboBox.Name = "ClubsComboBox";
            this.ClubsComboBox.Size = new System.Drawing.Size(192, 25);
            this.ClubsComboBox.TabIndex = 24;
            // 
            // PersonData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.JobsComboBox);
            this.Controls.Add(this.ClubLabel);
            this.Controls.Add(this.ClubsComboBox);
            this.Name = "PersonData";
            this.Size = new System.Drawing.Size(278, 135);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Label ClubLabel;
        private System.Windows.Forms.ComboBox JobsComboBox;
        private System.Windows.Forms.ComboBox ClubsComboBox;
    }
}
