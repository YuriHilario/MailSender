using MailSender.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MailSender.Repositories;
using Newtonsoft.Json;
using RestSharp;

namespace MailSender.Views
{
    public partial class AddSender : Form
    {
        public AddSender()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Sender userSender = new Sender()
                {
                    EmailAddres = txt_Address.Text,
                    Name = txt_Name.Text,
                    Password = txt_Password.Text,
                };
                if (userSender != null || userSender.EmailAddres != string.Empty || userSender.Password != string.Empty || userSender.Name != string.Empty)
                {
                    SenderContext.Add(userSender);
                    MessageBox.Show("Sender User Added Successfully !");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Null Data:" + "\n" + "User cannot be added");
                    ClearForm();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.InnerException.Message);
                ClearForm();
            }
            
        }        

        private void ClearForm()
        {
            txt_Name.Text = string.Empty;
            txt_Address.Text = string.Empty;
            txt_Password.Text = string.Empty;
        }
    }
}
