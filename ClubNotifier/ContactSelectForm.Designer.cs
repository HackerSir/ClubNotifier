namespace ClubNotifier {
    partial class ContactSelectForm {
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectedColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JobColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectedColumn,
            this.NameColumn,
            this.EmailColumn,
            this.ClubColumn,
            this.JobColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(561, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // SelectedColumn
            // 
            this.SelectedColumn.Frozen = true;
            this.SelectedColumn.HeaderText = "選擇";
            this.SelectedColumn.Name = "SelectedColumn";
            this.SelectedColumn.Width = 50;
            // 
            // NameColumn
            // 
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "姓名";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            this.EmailColumn.ReadOnly = true;
            // 
            // ClubColumn
            // 
            this.ClubColumn.HeaderText = "社團";
            this.ClubColumn.Name = "ClubColumn";
            this.ClubColumn.ReadOnly = true;
            // 
            // JobColumn
            // 
            this.JobColumn.HeaderText = "職位";
            this.JobColumn.Name = "JobColumn";
            this.JobColumn.ReadOnly = true;
            // 
            // YesButton
            // 
            this.YesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.YesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.YesButton.Location = new System.Drawing.Point(498, 330);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(75, 23);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "確定";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NoButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.NoButton.Location = new System.Drawing.Point(417, 330);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "取消";
            this.NoButton.UseVisualStyleBackColor = true;
            // 
            // ContactSelectForm
            // 
            this.AcceptButton = this.YesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NoButton;
            this.ClientSize = new System.Drawing.Size(585, 365);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactSelectForm";
            this.Text = "選擇...";
            this.Load += new System.EventHandler(this.ContactSelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn JobColumn;

    }
}