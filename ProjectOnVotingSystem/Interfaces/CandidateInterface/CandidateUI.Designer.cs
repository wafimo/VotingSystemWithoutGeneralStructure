namespace ProjectOnVotingSystem.Interfaces.CandidateInterface
{
    partial class CandidateUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.candidateListGroupBox = new System.Windows.Forms.GroupBox();
            this.candidateGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.candidateNameTextBox = new System.Windows.Forms.TextBox();
            this.symbolTextBox = new System.Windows.Forms.TextBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.candidateListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // candidateListGroupBox
            // 
            this.candidateListGroupBox.BackColor = System.Drawing.Color.Cyan;
            this.candidateListGroupBox.Controls.Add(this.candidateGridView);
            this.candidateListGroupBox.Location = new System.Drawing.Point(349, 85);
            this.candidateListGroupBox.Name = "candidateListGroupBox";
            this.candidateListGroupBox.Size = new System.Drawing.Size(358, 363);
            this.candidateListGroupBox.TabIndex = 0;
            this.candidateListGroupBox.TabStop = false;
            this.candidateListGroupBox.Text = "List of Candidates";
            // 
            // candidateGridView
            // 
            this.candidateGridView.AllowUserToAddRows = false;
            this.candidateGridView.AllowUserToDeleteRows = false;
            this.candidateGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.candidateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.candidateGridView.Location = new System.Drawing.Point(7, 27);
            this.candidateGridView.Name = "candidateGridView";
            this.candidateGridView.ReadOnly = true;
            this.candidateGridView.Size = new System.Drawing.Size(346, 330);
            this.candidateGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seiral No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Candidate\'s Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Symbol";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Candidate Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Symbol";
            // 
            // candidateNameTextBox
            // 
            this.candidateNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateNameTextBox.Location = new System.Drawing.Point(38, 61);
            this.candidateNameTextBox.Multiline = true;
            this.candidateNameTextBox.Name = "candidateNameTextBox";
            this.candidateNameTextBox.Size = new System.Drawing.Size(225, 36);
            this.candidateNameTextBox.TabIndex = 6;
            this.candidateNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolTextBox.Location = new System.Drawing.Point(39, 129);
            this.symbolTextBox.Multiline = true;
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(225, 36);
            this.symbolTextBox.TabIndex = 6;
            this.symbolTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(603, 40);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(99, 39);
            this.logOutButton.TabIndex = 7;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.symbolTextBox);
            this.panel1.Controls.Add(this.candidateNameTextBox);
            this.panel1.Location = new System.Drawing.Point(23, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 190);
            this.panel1.TabIndex = 8;
            // 
            // CandidateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.candidateListGroupBox);
            this.Name = "CandidateUI";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "CandidateUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CandidateUI_FormClosing);
            this.candidateListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.candidateGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox candidateListGroupBox;
        private System.Windows.Forms.DataGridView candidateGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox candidateNameTextBox;
        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel panel1;
    }
}