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
    public enum sex
    {
        male,
        female,
        other
    }
    public partial class FormSign_in : Form
    {
        FormLog_in formLogIn;
        public FormSign_in(ref FormLog_in _form)
        {
            InitializeComponent();
            SetStartSettings();

            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Other");

            if (_form != null)
                formLogIn = _form;
            else throw new NullReferenceException();
        }

        private void SetStartSettings()
        {
            labException.Visible = false;
            panel1.BorderStyle = BorderStyle.None;
            panel2.BorderStyle = BorderStyle.None;
            panel3.BorderStyle = BorderStyle.None;
        }

        private void bCreatAccount_Click(object sender, EventArgs e)
        {
            try
            {
                SetStartSettings();

                if (tUserName.Text != "" && tLogin.Text != "" && tPassword.Text != "")
                {
                    using (var context = new DBContext())
                    {
                        var userData = new UserData()
                        {
                            Login = tLogin.Text,
                            Password = tPassword.Text,
                            UserName = tUserName.Text,
                            DateRegister = DateTime.Now,
                            Sex = sex.male,
                        };

                        context.UserDatas.Add(userData);
                        context.SaveChanges();
                        MessageBox.Show($"User {userData.UserName} was successfully registered");
                    }

                    formLogIn.Visible = true;
                    this.Close();
                }
                else throw new FormatException(); 
            }
            catch (FormatException)
            {
                if (tUserName.Text == "")
                    panel2.BorderStyle = BorderStyle.Fixed3D;
                if (tLogin.Text == "")
                    panel1.BorderStyle = BorderStyle.Fixed3D;
                if (tPassword.Text == "")
                    panel3.BorderStyle = BorderStyle.Fixed3D;

                labException.Visible = true; 
            }
        }
    }
}

