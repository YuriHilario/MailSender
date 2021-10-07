using MailSender.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MailSender.Repositories;

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
                    Password = txt_Password.Text
                };
                if (userSender != null || userSender.EmailAddres != string.Empty || userSender.Password != string.Empty || userSender.Name != string.Empty)
                {
                    SenderContext.Add(userSender);
                    MessageBox.Show("Usuario Adicionado com Sucesso !");
                }
                else
                {
                    MessageBox.Show("Dados Nulos : "+ "\n" +", O Usuario não pode ser adicionado");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.InnerException.Message);
            }
            
        }
    }
}
