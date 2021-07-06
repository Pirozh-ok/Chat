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
    public partial class FormSign_in : Form
    {
        FormLog_in formLogIn; 
        public FormSign_in(ref FormLog_in _form)
        {
            InitializeComponent();
            if (_form != null)
                formLogIn = _form;
            else throw new NullReferenceException(); 
        }

        private void bCreatAccount_Click(object sender, EventArgs e)
        {
            var newUserName = tUserName.Text;
            var newLogin = tLogin.Text;
            var newPassword = tPassword.Text;
            MessageBox.Show("New account succesful creat!");
            formLogIn.Visible = true;
            this.Close(); 
        }
    }
}
