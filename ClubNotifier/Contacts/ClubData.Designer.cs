namespace ClubNotifier.Contacts {
    partial class ClubData {
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
            this.ClubCodeTextBox = new System.Windows.Forms.TextBox();
            this.ClubNameTextBox = new System.Windows.Forms.TextBox();
            this.ClubCodeLabel = new System.Windows.Forms.Label();
            this.ClubNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClubCodeTextBox
            // 
            this.ClubCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClubCodeTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClubCodeTextBox.Location = new System.Drawing.Point(79, 3);
            this.ClubCodeTextBox.Name = "ClubCodeTextBox";
            this.ClubCodeTextBox.Size = new System.Drawing.Size(196, 27);
            this.ClubCodeTextBox.TabIndex = 13;
            // 
            // ClubNameTextBox
            // 
            this.ClubNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClubNameTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClubNameTextBox.Location = new System.Drawing.Point(79, 36);
            this.ClubNameTextBox.Name = "ClubNameTextBox";
            this.ClubNameTextBox.Size = new System.Drawing.Size(196, 27);
            this.ClubNameTextBox.TabIndex = 14;
            // 
            // ClubCodeLabel
            // 
            this.ClubCodeLabel.AutoSize = true;
            this.ClubCodeLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClubCodeLabel.Location = new System.Drawing.Point(3, 6);
            this.ClubCodeLabel.Name = "ClubCodeLabel";
            this.ClubCodeLabel.Size = new System.Drawing.Size(73, 17);
            this.ClubCodeLabel.TabIndex = 15;
            this.ClubCodeLabel.Text = "社團代號：";
            // 
            // ClubNameLabel
            // 
            this.ClubNameLabel.AutoSize = true;
            this.ClubNameLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ClubNameLabel.Location = new System.Drawing.Point(3, 39);
            this.ClubNameLabel.Name = "ClubNameLabel";
            this.ClubNameLabel.Size = new System.Drawing.Size(73, 17);
            this.ClubNameLabel.TabIndex = 16;
            this.ClubNameLabel.Text = "社團名稱：";
            // 
            // ClubData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClubCodeLabel);
            this.Controls.Add(this.ClubCodeTextBox);
            this.Controls.Add(this.ClubNameLabel);
            this.Controls.Add(this.ClubNameTextBox);
            this.Name = "ClubData";
            this.Size = new System.Drawing.Size(278, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ClubCodeTextBox;
        private System.Windows.Forms.TextBox ClubNameTextBox;
        private System.Windows.Forms.Label ClubCodeLabel;
        private System.Windows.Forms.Label ClubNameLabel;
    }
}
