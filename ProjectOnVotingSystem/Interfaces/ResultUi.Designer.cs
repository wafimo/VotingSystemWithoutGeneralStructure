namespace ProjectOnVotingSystem.Interfaces.UserInterfaces
{
    partial class ResultUi
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
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resultStatusButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.winnerNameTextBox = new System.Windows.Forms.TextBox();
            this.winnerPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.achievedVoteTextBox = new System.Windows.Forms.TextBox();
            this.resultGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.winnerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resultGroupBox.Controls.Add(this.resultGridView);
            this.resultGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultGroupBox.Location = new System.Drawing.Point(341, 97);
            this.resultGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultGroupBox.Size = new System.Drawing.Size(358, 262);
            this.resultGroupBox.TabIndex = 7;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Reuslt of Candidates";
            // 
            // resultGridView
            // 
            this.resultGridView.AllowUserToAddRows = false;
            this.resultGridView.AllowUserToDeleteRows = false;
            this.resultGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.resultGridView.Location = new System.Drawing.Point(5, 31);
            this.resultGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.ReadOnly = true;
            this.resultGridView.Size = new System.Drawing.Size(348, 223);
            this.resultGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Serial Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name of the Candidates";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Achieved Vote";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.resultStatusButton);
            this.panel2.Location = new System.Drawing.Point(33, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 100);
            this.panel2.TabIndex = 8;
            // 
            // resultStatusButton
            // 
            this.resultStatusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.resultStatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultStatusButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultStatusButton.ForeColor = System.Drawing.Color.White;
            this.resultStatusButton.Location = new System.Drawing.Point(11, 13);
            this.resultStatusButton.Name = "resultStatusButton";
            this.resultStatusButton.Size = new System.Drawing.Size(256, 73);
            this.resultStatusButton.TabIndex = 0;
            this.resultStatusButton.UseVisualStyleBackColor = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Black;
            this.backButton.Location = new System.Drawing.Point(608, 36);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 32);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "The winner of the vote is";
            // 
            // winnerNameTextBox
            // 
            this.winnerNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerNameTextBox.Location = new System.Drawing.Point(31, 46);
            this.winnerNameTextBox.Multiline = true;
            this.winnerNameTextBox.Name = "winnerNameTextBox";
            this.winnerNameTextBox.Size = new System.Drawing.Size(213, 29);
            this.winnerNameTextBox.TabIndex = 10;
            // 
            // winnerPanel
            // 
            this.winnerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.winnerPanel.Controls.Add(this.label2);
            this.winnerPanel.Controls.Add(this.label1);
            this.winnerPanel.Controls.Add(this.achievedVoteTextBox);
            this.winnerPanel.Controls.Add(this.winnerNameTextBox);
            this.winnerPanel.Location = new System.Drawing.Point(33, 220);
            this.winnerPanel.Name = "winnerPanel";
            this.winnerPanel.Size = new System.Drawing.Size(279, 148);
            this.winnerPanel.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Got vote";
            // 
            // achievedVoteTextBox
            // 
            this.achievedVoteTextBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achievedVoteTextBox.Location = new System.Drawing.Point(115, 80);
            this.achievedVoteTextBox.Multiline = true;
            this.achievedVoteTextBox.Name = "achievedVoteTextBox";
            this.achievedVoteTextBox.Size = new System.Drawing.Size(129, 29);
            this.achievedVoteTextBox.TabIndex = 10;
            // 
            // ResultUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 382);
            this.Controls.Add(this.winnerPanel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.resultGroupBox);
            this.MinimizeBox = false;
            this.Name = "ResultUi";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultUi_FormClosing);
            this.resultGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.winnerPanel.ResumeLayout(false);
            this.winnerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox resultGroupBox;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button resultStatusButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox winnerNameTextBox;
        private System.Windows.Forms.Panel winnerPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox achievedVoteTextBox;
    }
}