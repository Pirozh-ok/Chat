﻿using System;
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
        public FormSign_in()
        {
            InitializeComponent();
            SetStartSettings();

            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Other");
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

                    FormLog_in formLog_In = new FormLog_in();
                    formLog_In.Show(); 
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

        private void bLog_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormLog_in().Show();
        }

        private void FormSign_in_FormClosing(object sender, FormClosingEventArgs e)
        {            
                Application.Exit(); 
        }
    }
}

