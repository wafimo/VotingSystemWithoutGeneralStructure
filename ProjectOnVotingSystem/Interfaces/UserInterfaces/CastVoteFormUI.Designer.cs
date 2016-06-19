namespace ProjectOnVotingSystem.Interfaces.UserInterfaces
{
    partial class CastVoteFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CastVoteFormUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.symbolComboBox = new System.Windows.Forms.ComboBox();
            this.castButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.voterEmailLabel = new System.Windows.Forms.Label();
            this.candidateListGroupBox = new System.Windows.Forms.GroupBox();
            this.candidateGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.candidateListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voter Emai Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select Symbol of Candidate";
            // 
            // symbolComboBox
            // 
            this.symbolComboBox.FormattingEnabled = true;
            this.symbolComboBox.Location = new System.Drawing.Point(255, 98);
            this.symbolComboBox.Name = "symbolComboBox";
            this.symbolComboBox.Size = new System.Drawing.Size(142, 28);
            this.symbolComboBox.TabIndex = 0;
            this.symbolComboBox.Text = "Select";
            // 
            // castButton
            // 
            this.castButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.castButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.castButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.castButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.castButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.castButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.castButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castButton.Location = new System.Drawing.Point(86, 132);
            this.castButton.Name = "castButton";
            this.castButton.Size = new System.Drawing.Size(262, 124);
            this.castButton.TabIndex = 1;
            this.castButton.Text = "Cast";
            this.castButton.UseVisualStyleBackColor = false;
            this.castButton.Click += new System.EventHandler(this.castButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(683, 40);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(91, 34);
            this.logOutButton.TabIndex = 2;
            this.logOutButton.Text = "Log out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // voterEmailLabel
            // 
            this.voterEmailLabel.AutoSize = true;
            this.voterEmailLabel.Location = new System.Drawing.Point(251, 59);
            this.voterEmailLabel.Name = "voterEmailLabel";
            this.voterEmailLabel.Size = new System.Drawing.Size(0, 20);
            this.voterEmailLabel.TabIndex = 4;
            // 
            // candidateListGroupBox
            // 
            this.candidateListGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.candidateListGroupBox.Controls.Add(this.candidateGridView);
            this.candidateListGroupBox.Location = new System.Drawing.Point(421, 95);
            this.candidateListGroupBox.Name = "candidateListGroupBox";
            this.candidateListGroupBox.Size = new System.Drawing.Size(358, 363);
            this.candidateListGroupBox.TabIndex = 3;
            this.candidateListGroupBox.TabStop = false;
            this.candidateListGroupBox.Text = "List of Candidates";
            // 
            // candidateGridView
            // 
            this.candidateGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.candidateGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.candidateGridView.Location = new System.Drawing.Point(7, 27);
            this.candidateGridView.Name = "candidateGridView";
            this.candidateGridView.Size = new System.Drawing.Size(346, 330);
            this.candidateGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seiral No.";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Candidate\'s Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Symbol";
            this.Column3.Name = "Column3";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.voterEmailLabel);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.symbolComboBox);
            this.groupBox3.Controls.Add(this.castButton);
            this.groupBox3.Location = new System.Drawing.Point(10, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 279);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Voter Panel";
            // 
            // CastVoteFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 491);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.candidateListGroupBox);
            this.Controls.Add(this.logOutButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CastVoteFormUI";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Cast Vote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CastVoteFormUI_FormClosing);
            this.candidateListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.candidateGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox symbolComboBox;
        private System.Windows.Forms.Button castButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label voterEmailLabel;
        private System.Windows.Forms.GroupBox candidateListGroupBox;
        private System.Windows.Forms.DataGridView candidateGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}