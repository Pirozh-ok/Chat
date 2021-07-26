
namespace Chat
{
    partial class CreatNewChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatNewChat));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCreatChat = new System.Windows.Forms.Button();
            this.tbSearchChat = new System.Windows.Forms.TextBox();
            this.lbSearchMembers = new System.Windows.Forms.ListBox();
            this.lblNoFound = new System.Windows.Forms.Label();
            this.bComeBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creat new chat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(335, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choise members for chat";
            // 
            // bCreatChat
            // 
            this.bCreatChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(63)))));
            this.bCreatChat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreatChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bCreatChat.Location = new System.Drawing.Point(420, 518);
            this.bCreatChat.Name = "bCreatChat";
            this.bCreatChat.Size = new System.Drawing.Size(119, 45);
            this.bCreatChat.TabIndex = 7;
            this.bCreatChat.Text = "Creat chat";
            this.bCreatChat.UseVisualStyleBackColor = false;
            this.bCreatChat.Click += new System.EventHandler(this.bCreatChat_Click);
            // 
            // tbSearchChat
            // 
            this.tbSearchChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbSearchChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchChat.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSearchChat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchChat.ForeColor = System.Drawing.Color.White;
            this.tbSearchChat.Location = new System.Drawing.Point(317, 122);
            this.tbSearchChat.Name = "tbSearchChat";
            this.tbSearchChat.Size = new System.Drawing.Size(318, 23);
            this.tbSearchChat.TabIndex = 8;
            this.tbSearchChat.Text = "Search: ";
            this.tbSearchChat.Click += new System.EventHandler(this.tbSearchChat_Click);
            this.tbSearchChat.TextChanged += new System.EventHandler(this.tbSearchChat_TextChanged);
            this.tbSearchChat.MouseLeave += new System.EventHandler(this.tbSearchChat_MouseLeave);
            // 
            // lbSearchMembers
            // 
            this.lbSearchMembers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbSearchMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSearchMembers.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSearchMembers.ForeColor = System.Drawing.Color.White;
            this.lbSearchMembers.FormattingEnabled = true;
            this.lbSearchMembers.ItemHeight = 26;
            this.lbSearchMembers.Location = new System.Drawing.Point(243, 174);
            this.lbSearchMembers.Name = "lbSearchMembers";
            this.lbSearchMembers.Size = new System.Drawing.Size(509, 338);
            this.lbSearchMembers.TabIndex = 9;
            // 
            // lblNoFound
            // 
            this.lblNoFound.AutoSize = true;
            this.lblNoFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblNoFound.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNoFound.ForeColor = System.Drawing.Color.White;
            this.lblNoFound.Location = new System.Drawing.Point(297, 181);
            this.lblNoFound.Name = "lblNoFound";
            this.lblNoFound.Size = new System.Drawing.Size(381, 27);
            this.lblNoFound.TabIndex = 10;
            this.lblNoFound.Text = "No user found with this user name";
            this.lblNoFound.Visible = false;
            // 
            // bComeBack
            // 
            this.bComeBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bComeBack.BackgroundImage")));
            this.bComeBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bComeBack.FlatAppearance.BorderSize = 0;
            this.bComeBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bComeBack.Location = new System.Drawing.Point(12, 9);
            this.bComeBack.Name = "bComeBack";
            this.bComeBack.Size = new System.Drawing.Size(77, 56);
            this.bComeBack.TabIndex = 11;
            this.bComeBack.UseVisualStyleBackColor = true;
            this.bComeBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreatNewChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(974, 575);
            this.Controls.Add(this.bComeBack);
            this.Controls.Add(this.lblNoFound);
            this.Controls.Add(this.lbSearchMembers);
            this.Controls.Add(this.tbSearchChat);
            this.Controls.Add(this.bCreatChat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreatNewChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreatNewChat_FormClosing);
            this.Load += new System.EventHandler(this.CreatNewChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCreatChat;
        private System.Windows.Forms.TextBox tbSearchChat;
        private System.Windows.Forms.ListBox lbSearchMembers;
        private System.Windows.Forms.Label lblNoFound;
        private System.Windows.Forms.Button bComeBack;
    }
}