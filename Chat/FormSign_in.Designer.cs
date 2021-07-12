
namespace Chat
{
    partial class FormSign_in
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.bCreatAccount = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter you profile";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(28)))), ((int)(((byte)(113)))));
            this.panel2.Controls.Add(this.tUserName);
            this.panel2.Location = new System.Drawing.Point(210, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 75);
            this.panel2.TabIndex = 3;
            // 
            // tUserName
            // 
            this.tUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(28)))), ((int)(((byte)(113)))));
            this.tUserName.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tUserName.Location = new System.Drawing.Point(3, 14);
            this.tUserName.MaxLength = 20;
            this.tUserName.Name = "tUserName";
            this.tUserName.Size = new System.Drawing.Size(170, 51);
            this.tUserName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(-8, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "User name";
            // 
            // tLogin
            // 
            this.tLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(28)))), ((int)(((byte)(113)))));
            this.tLogin.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tLogin.Location = new System.Drawing.Point(3, 14);
            this.tLogin.MaxLength = 20;
            this.tLogin.Name = "tLogin";
            this.tLogin.Size = new System.Drawing.Size(170, 51);
            this.tLogin.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(28)))), ((int)(((byte)(113)))));
            this.panel1.Controls.Add(this.tLogin);
            this.panel1.Location = new System.Drawing.Point(210, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 75);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(76, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Login";
            // 
            // tPassword
            // 
            this.tPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(28)))), ((int)(((byte)(113)))));
            this.tPassword.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tPassword.Location = new System.Drawing.Point(3, 14);
            this.tPassword.MaxLength = 20;
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(170, 51);
            this.tPassword.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(28)))), ((int)(((byte)(113)))));
            this.panel3.Controls.Add(this.tPassword);
            this.panel3.Location = new System.Drawing.Point(210, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(172, 75);
            this.panel3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(6, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 36);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // bCreatAccount
            // 
            this.bCreatAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(187)))), ((int)(((byte)(63)))));
            this.bCreatAccount.Font = new System.Drawing.Font("Ravie", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCreatAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bCreatAccount.Location = new System.Drawing.Point(91, 388);
            this.bCreatAccount.Name = "bCreatAccount";
            this.bCreatAccount.Size = new System.Drawing.Size(230, 50);
            this.bCreatAccount.TabIndex = 9;
            this.bCreatAccount.Text = "Creat Account";
            this.bCreatAccount.UseVisualStyleBackColor = false;
            this.bCreatAccount.Click += new System.EventHandler(this.bCreatAccount_Click);
            // 
            // FormSign_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(51)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.bCreatAccount);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSign_in";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCreatAccount;
    }
}