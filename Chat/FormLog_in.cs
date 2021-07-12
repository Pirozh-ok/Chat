using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Chat
{
    public partial class FormLog_in : Form
    {
        public FormLog_in()
        {
            InitializeComponent();
            labException.Visible = false; 
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.tLogin.Text != "" && this.tPassword.Text != "")
                {
                    var login = this.tLogin.Text;
                    var password = this.tPassword.Text;
                }
                else
                    throw new FormatException(); 
            }
            catch (FormatException)
            {
                if (tLogin.Text == "")
                    panel2.BorderStyle = BorderStyle.Fixed3D;

                if (tPassword.Text == "")
                    panel3.BorderStyle = BorderStyle.Fixed3D;

                labException.Visible = true; 
            }

            // ищем в базе данных по пользователю, если такой есть, то сравниваем пароли

        }

        private void bSign_up_Click(object sender, EventArgs e)
        {
            FormLog_in formLog_In = this; 
            FormSign_in formSignIn = new FormSign_in (ref formLog_In);
            formSignIn.Show();
            this.Visible = false;
        }
    }
}
