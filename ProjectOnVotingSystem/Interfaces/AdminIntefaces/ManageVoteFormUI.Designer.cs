namespace ProjectOnVotingSystem.Interfaces.AdminIntefaces
{
    partial class ManageVoteFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageVoteFormUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.candidateEntrySaveButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.symbolTextBox = new System.Windows.Forms.TextBox();
            this.candidateNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.candidateDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteTextBox = new System.Windows.Forms.TextBox();
            this.voteOnButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.withholdResultButton = new System.Windows.Forms.Button();
            this.publishButton = new System.Windows.Forms.Button();
            this.resultButton = new System.Windows.Forms.Button();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemStatusPanel = new System.Windows.Forms.Panel();
            this.voteOffButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.systemStatusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.candidateEntrySaveButton);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.symbolTextBox);
            this.groupBox1.Controls.Add(this.candidateNameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Candidate Entry";
            // 
            // candidateEntrySaveButton
            // 
            this.candidateEntrySaveButton.BackColor = System.Drawing.Color.LightYellow;
            this.candidateEntrySaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.candidateEntrySaveButton.Location = new System.Drawing.Point(259, 155);
            this.candidateEntrySaveButton.Name = "candidateEntrySaveButton";
            this.candidateEntrySaveButton.Size = new System.Drawing.Size(83, 38);
            this.candidateEntrySaveButton.TabIndex = 3;
            this.candidateEntrySaveButton.Text = "Save";
            this.candidateEntrySaveButton.UseVisualStyleBackColor = false;
            this.candidateEntrySaveButton.Click += new System.EventHandler(this.candidateEntrySaveButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passwordTextBox.Location = new System.Drawing.Point(173, 121);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(288, 28);
            this.passwordTextBox.TabIndex = 2;
            // 
            // symbolTextBox
            // 
            this.symbolTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.symbolTextBox.Location = new System.Drawing.Point(173, 75);
            this.symbolTextBox.Name = "symbolTextBox";
            this.symbolTextBox.Size = new System.Drawing.Size(288, 28);
            this.symbolTextBox.TabIndex = 1;
            // 
            // candidateNameTextBox
            // 
            this.candidateNameTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.candidateNameTextBox.Location = new System.Drawing.Point(173, 31);
            this.candidateNameTextBox.Name = "candidateNameTextBox";
            this.candidateNameTextBox.Size = new System.Drawing.Size(288, 28);
            this.candidateNameTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Symbol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Candidate\'s Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Put the name of Candidates";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.showButton);
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.candidateDataGridView);
            this.groupBox2.Controls.Add(this.deleteTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(523, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 404);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Candidates";
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.LightYellow;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showButton.Location = new System.Drawing.Point(192, 357);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(83, 38);
            this.showButton.TabIndex = 3;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightYellow;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Location = new System.Drawing.Point(252, 58);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(83, 28);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // candidateDataGridView
            // 
            this.candidateDataGridView.AllowUserToDeleteRows = false;
            this.candidateDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.candidateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7});
            this.candidateDataGridView.Location = new System.Drawing.Point(6, 95);
            this.candidateDataGridView.Name = "candidateDataGridView";
            this.candidateDataGridView.ReadOnly = true;
            this.candidateDataGridView.Size = new System.Drawing.Size(446, 256);
            this.candidateDataGridView.TabIndex = 0;
            this.candidateDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.candidateDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Serial Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name of the Candidates";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Symbol";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Password";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // deleteTextBox
            // 
            this.deleteTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.deleteTextBox.Location = new System.Drawing.Point(18, 58);
            this.deleteTextBox.Name = "deleteTextBox";
            this.deleteTextBox.Size = new System.Drawing.Size(228, 28);
            this.deleteTextBox.TabIndex = 1;
            // 
            // voteOnButton
            // 
            this.voteOnButton.BackColor = System.Drawing.Color.LightYellow;
            this.voteOnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voteOnButton.Image = ((System.Drawing.Image)(resources.GetObject("voteOnButton.Image")));
            this.voteOnButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voteOnButton.Location = new System.Drawing.Point(89, 13);
            this.voteOnButton.Name = "voteOnButton";
            this.voteOnButton.Size = new System.Drawing.Size(134, 55);
            this.voteOnButton.TabIndex = 0;
            this.voteOnButton.Text = "Voting On";
            this.voteOnButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.voteOnButton.UseVisualStyleBackColor = false;
            this.voteOnButton.Click += new System.EventHandler(this.voteOnButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightYellow;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Location = new System.Drawing.Point(812, 37);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(83, 28);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.LightYellow;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Location = new System.Drawing.Point(901, 37);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(83, 28);
            this.logOutButton.TabIndex = 5;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox3.Controls.Add(this.withholdResultButton);
            this.groupBox3.Controls.Add(this.publishButton);
            this.groupBox3.Controls.Add(this.resultButton);
            this.groupBox3.Controls.Add(this.resultDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(21, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 278);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // withholdResultButton
            // 
            this.withholdResultButton.BackColor = System.Drawing.Color.LightYellow;
            this.withholdResultButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withholdResultButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withholdResultButton.Location = new System.Drawing.Point(358, 203);
            this.withholdResultButton.Name = "withholdResultButton";
            this.withholdResultButton.Size = new System.Drawing.Size(103, 46);
            this.withholdResultButton.TabIndex = 2;
            this.withholdResultButton.Text = "Withhold Result";
            this.withholdResultButton.UseVisualStyleBackColor = false;
            this.withholdResultButton.Click += new System.EventHandler(this.withholdResultButton_Click);
            // 
            // publishButton
            // 
            this.publishButton.BackColor = System.Drawing.Color.LightYellow;
            this.publishButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.publishButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishButton.Location = new System.Drawing.Point(358, 151);
            this.publishButton.Name = "publishButton";
            this.publishButton.Size = new System.Drawing.Size(103, 46);
            this.publishButton.TabIndex = 1;
            this.publishButton.Text = "Publish Result";
            this.publishButton.UseVisualStyleBackColor = false;
            this.publishButton.Click += new System.EventHandler(this.publishButton_Click);
            // 
            // resultButton
            // 
            this.resultButton.BackColor = System.Drawing.Color.LightYellow;
            this.resultButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultButton.Location = new System.Drawing.Point(358, 99);
            this.resultButton.Name = "resultButton";
            this.resultButton.Size = new System.Drawing.Size(103, 46);
            this.resultButton.TabIndex = 0;
            this.resultButton.Text = "See Result";
            this.resultButton.UseVisualStyleBackColor = false;
            this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AllowUserToDeleteRows = false;
            this.resultDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.resultDataGridView.Location = new System.Drawing.Point(6, 27);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
            this.resultDataGridView.Size = new System.Drawing.Size(346, 245);
            this.resultDataGridView.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Serial Number";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Candidate\'s Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Total Vote Achieved";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // systemStatusPanel
            // 
            this.systemStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.systemStatusPanel.Controls.Add(this.voteOffButton);
            this.systemStatusPanel.Controls.Add(this.voteOnButton);
            this.systemStatusPanel.Location = new System.Drawing.Point(523, 494);
            this.systemStatusPanel.Name = "systemStatusPanel";
            this.systemStatusPanel.Size = new System.Drawing.Size(461, 74);
            this.systemStatusPanel.TabIndex = 2;
            // 
            // voteOffButton
            // 
            this.voteOffButton.BackColor = System.Drawing.Color.LightYellow;
            this.voteOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.voteOffButton.Image = ((System.Drawing.Image)(resources.GetObject("voteOffButton.Image")));
            this.voteOffButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.voteOffButton.Location = new System.Drawing.Point(249, 13);
            this.voteOffButton.Name = "voteOffButton";
            this.voteOffButton.Size = new System.Drawing.Size(134, 55);
            this.voteOffButton.TabIndex = 1;
            this.voteOffButton.Text = "Voting Off";
            this.voteOffButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.voteOffButton.UseVisualStyleBackColor = false;
            this.voteOffButton.Click += new System.EventHandler(this.voteOffButton_Click);
            // 
            // ManageVoteFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 578);
            this.Controls.Add(this.systemStatusPanel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageVoteFormUI";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Manage Vote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManageVoteFormUI_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.systemStatusPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox candidateNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button candidateEntrySaveButton;
        private System.Windows.Forms.TextBox symbolTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView candidateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button voteOnButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button resultButton;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button publishButton;
        private System.Windows.Forms.Panel systemStatusPanel;
        private System.Windows.Forms.Button voteOffButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button withholdResultButton;
    }
}