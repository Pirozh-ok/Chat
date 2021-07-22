
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
            this.lbCurrentChat = new System.Windows.Forms.ListBox();
            this.lbAllChat = new System.Windows.Forms.ListBox();
            this.tbSearchChat = new System.Windows.Forms.TextBox();
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
            // lbCurrentChat
            // 
            this.lbCurrentChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lbCurrentChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCurrentChat.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentChat.ForeColor = System.Drawing.Color.White;
            this.lbCurrentChat.FormattingEnabled = true;
            this.lbCurrentChat.ItemHeight = 32;
            this.lbCurrentChat.Location = new System.Drawing.Point(323, 35);
            this.lbCurrentChat.Name = "lbCurrentChat";
            this.lbCurrentChat.Size = new System.Drawing.Size(627, 512);
            this.lbCurrentChat.TabIndex = 2;
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
            this.lbAllChat.Size = new System.Drawing.Size(283, 448);
            this.lbAllChat.TabIndex = 3;
            // 
            // tbSearchChat
            // 
            this.tbSearchChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tbSearchChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchChat.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSearchChat.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearchChat.ForeColor = System.Drawing.Color.White;
            this.tbSearchChat.Location = new System.Drawing.Point(24, 56);
            this.tbSearchChat.Name = "tbSearchChat";
            this.tbSearchChat.Size = new System.Drawing.Size(283, 32);
            this.tbSearchChat.TabIndex = 4;
            this.tbSearchChat.Text = "Search:";
            this.tbSearchChat.Click += new System.EventHandler(this.tbSearchChat_Click);
            // 
            // MainFormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(974, 575);
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
        private System.Windows.Forms.ListBox lbCurrentChat;
        private System.Windows.Forms.ListBox lbAllChat;
        private System.Windows.Forms.TextBox tbSearchChat;
    }
}