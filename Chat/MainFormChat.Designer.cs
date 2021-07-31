
namespace Chat
{
    partial class MainFormChat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormChat));
            this.bYourProfile = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lbAllChat = new System.Windows.Forms.ListBox();
            this.tbSearchChat = new System.Windows.Forms.TextBox();
            this.bStartChat = new System.Windows.Forms.Button();
            this.lblNotChats = new System.Windows.Forms.Label();
            this.lblSelectChat = new System.Windows.Forms.Label();
            this.lbCurrentChat = new System.Windows.Forms.ListBox();
            this.lblNotMsg = new System.Windows.Forms.Label();
            this.tMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bYourProfile
            // 
            this.bYourProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bYourProfile.BackgroundImage")));
            this.bYourProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bYourProfile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bYourProfile.FlatAppearance.BorderSize = 0;
            this.bYourProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bYourProfile.Location = new System.Drawing.Point(0, 0);
            this.bYourProfile.Name = "bYourProfile";
            this.bYourProfile.Size = new System.Drawing.Size(62, 50);
            this.bYourProfile.TabIndex = 0;
            this.bYourProfile.UseVisualStyleBackColor = true;
            this.bYourProfile.Click += new System.EventHandler(this.bYourProfile_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(68, 15);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 35);
            this.lblUserName.TabIndex = 1;
            // 
            // lbAllChat
            // 
            this.lbAllChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbAllChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAllChat.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllChat.ForeColor = System.Drawing.Color.White;
            this.lbAllChat.FormattingEnabled = true;
            this.lbAllChat.ItemHeight = 32;
            this.lbAllChat.Location = new System.Drawing.Point(24, 99);
            this.lbAllChat.Name = "lbAllChat";
            this.lbAllChat.Size = new System.Drawing.Size(318, 384);
            this.lbAllChat.TabIndex = 3;
            this.lbAllChat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbAllChat_MouseClick);
            // 
            // tbSearchChat
            // 
            this.tbSearchChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbSearchChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchChat.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSearchChat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchChat.ForeColor = System.Drawing.Color.White;
            this.tbSearchChat.Location = new System.Drawing.Point(24, 56);
            this.tbSearchChat.Name = "tbSearchChat";
            this.tbSearchChat.Size = new System.Drawing.Size(318, 23);
            this.tbSearchChat.TabIndex = 4;
            this.tbSearchChat.Text = "Search:";
            this.tbSearchChat.Click += new System.EventHandler(this.tbSearchChat_Click);
            // 
            // bStartChat
            // 
            this.bStartChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(63)))));
            this.bStartChat.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bStartChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bStartChat.Location = new System.Drawing.Point(108, 164);
            this.bStartChat.Name = "bStartChat";
            this.bStartChat.Size = new System.Drawing.Size(119, 45);
            this.bStartChat.TabIndex = 6;
            this.bStartChat.Text = "Start chat";
            this.bStartChat.UseVisualStyleBackColor = false;
            this.bStartChat.Click += new System.EventHandler(this.bStartChat_Click);
            // 
            // lblNotChats
            // 
            this.lblNotChats.AutoSize = true;
            this.lblNotChats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblNotChats.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNotChats.ForeColor = System.Drawing.Color.White;
            this.lblNotChats.Location = new System.Drawing.Point(30, 108);
            this.lblNotChats.Name = "lblNotChats";
            this.lblNotChats.Size = new System.Drawing.Size(452, 19);
            this.lblNotChats.TabIndex = 7;
            this.lblNotChats.Text = "You don\'t have any dialogs yet. Start chatting right now!";
            // 
            // lblSelectChat
            // 
            this.lblSelectChat.AutoSize = true;
            this.lblSelectChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblSelectChat.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSelectChat.ForeColor = System.Drawing.Color.White;
            this.lblSelectChat.Location = new System.Drawing.Point(505, 238);
            this.lblSelectChat.Name = "lblSelectChat";
            this.lblSelectChat.Size = new System.Drawing.Size(364, 27);
            this.lblSelectChat.TabIndex = 8;
            this.lblSelectChat.Text = "Select a chat to start  messaging";
            this.lblSelectChat.Visible = false;
            // 
            // lbCurrentChat
            // 
            this.lbCurrentChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbCurrentChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCurrentChat.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentChat.ForeColor = System.Drawing.Color.White;
            this.lbCurrentChat.FormattingEnabled = true;
            this.lbCurrentChat.ItemHeight = 26;
            this.lbCurrentChat.Location = new System.Drawing.Point(359, 19);
            this.lbCurrentChat.Name = "lbCurrentChat";
            this.lbCurrentChat.Size = new System.Drawing.Size(594, 494);
            this.lbCurrentChat.TabIndex = 2;
            // 
            // lblNotMsg
            // 
            this.lblNotMsg.AutoSize = true;
            this.lblNotMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lblNotMsg.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNotMsg.ForeColor = System.Drawing.Color.White;
            this.lblNotMsg.Location = new System.Drawing.Point(471, 66);
            this.lblNotMsg.Name = "lblNotMsg";
            this.lblNotMsg.Size = new System.Drawing.Size(426, 27);
            this.lblNotMsg.TabIndex = 9;
            this.lblNotMsg.Text = "The chat is empty! Be the first to write!";
            this.lblNotMsg.Visible = false;
            // 
            // tMsg
            // 
            this.tMsg.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tMsg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tMsg.Location = new System.Drawing.Point(391, 471);
            this.tMsg.MaxLength = 1500;
            this.tMsg.Name = "tMsg";
            this.tMsg.Size = new System.Drawing.Size(518, 28);
            this.tMsg.TabIndex = 10;
            this.tMsg.Text = "Enter message: ";
            this.tMsg.Visible = false;
            this.tMsg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tMsg_MouseClick);
            this.tMsg.MouseLeave += new System.EventHandler(this.tMsg_MouseLeave);
            // 
            // MainFormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(974, 546);
            this.Controls.Add(this.tMsg);
            this.Controls.Add(this.lblNotMsg);
            this.Controls.Add(this.lblSelectChat);
            this.Controls.Add(this.lblNotChats);
            this.Controls.Add(this.bStartChat);
            this.Controls.Add(this.tbSearchChat);
            this.Controls.Add(this.lbAllChat);
            this.Controls.Add(this.lbCurrentChat);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.bYourProfile);
            this.Name = "MainFormChat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormChat_FormClosing);
            this.Load += new System.EventHandler(this.MainFormChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bYourProfile;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ListBox lbAllChat;
        private System.Windows.Forms.TextBox tbSearchChat;
        private System.Windows.Forms.Button bStartChat;
        private System.Windows.Forms.Label lblNotChats;
        private System.Windows.Forms.Label lblSelectChat;
        private System.Windows.Forms.ListBox lbCurrentChat;
        private System.Windows.Forms.Label lblNotMsg;
        private System.Windows.Forms.TextBox tMsg;
    }
}