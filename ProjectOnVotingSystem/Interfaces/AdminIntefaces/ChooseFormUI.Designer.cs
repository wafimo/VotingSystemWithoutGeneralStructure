namespace ProjectOnVotingSystem.Interfaces.AdminIntefaces
{
    partial class ChooseFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseFormUI));
            this.label1 = new System.Windows.Forms.Label();
            this.manageVoterButton = new System.Windows.Forms.Button();
            this.manageVoteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Choose to Proceed";
            // 
            // manageVoterButton
            // 
            this.manageVoterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.manageVoterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageVoterButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageVoterButton.Location = new System.Drawing.Point(172, 86);
            this.manageVoterButton.Name = "manageVoterButton";
            this.manageVoterButton.Size = new System.Drawing.Size(292, 48);
            this.manageVoterButton.TabIndex = 0;
            this.manageVoterButton.Text = "Manage Voter";
            this.manageVoterButton.UseVisualStyleBackColor = false;
            this.manageVoterButton.Click += new System.EventHandler(this.manageVoterButton_Click);
            // 
            // manageVoteButton
            // 
            this.manageVoteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.manageVoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manageVoteButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageVoteButton.Location = new System.Drawing.Point(172, 151);
            this.manageVoteButton.Name = "manageVoteButton";
            this.manageVoteButton.Size = new System.Drawing.Size(292, 48);
            this.manageVoteButton.TabIndex = 2;
            this.manageVoteButton.Text = "Manage Vote";
            this.manageVoteButton.UseVisualStyleBackColor = false;
            this.manageVoteButton.Click += new System.EventHandler(this.manageVoteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(496, 245);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 32);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ChooseFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 300);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.manageVoteButton);
            this.Controls.Add(this.manageVoterButton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChooseFormUI";
            this.Padding = new System.Windows.Forms.Padding(27, 83, 27, 28);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseFormUI_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button manageVoterButton;
        private System.Windows.Forms.Button manageVoteButton;
        private System.Windows.Forms.Button exitButton;
    }
}