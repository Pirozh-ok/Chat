using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class FormLog_in : Form
    {
        public FormLog_in()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            var login = this.tLogin.Text;
            var password = this.tPassword;

            // ищем в базе данных по пользователю, если такой есть, то сравниваем пароли
            
        }

        private void bSign_up_Click(object sender, EventArgs e)
        {
            FormLog_in formLog_In = this; 
            FormSign_in form = new FormSign_in (ref formLog_In);
            form.Show();
            this.Visible = false;
        }
    }
}
