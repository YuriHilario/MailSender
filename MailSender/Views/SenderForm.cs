using MailSender.Entities;
using MailSender.Services;
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
    public partial class SenderForm : Form
    {
        public SenderForm()
        {
            InitializeComponent();
            LoadSender();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {            
            Remittee to = new Remittee()
            {
                Name = "Aleand Seguros LTDA",
                EmailAddress = "aleand.licita@gmail.com",
                EmailAddressII = "alex@aleand.com.br",
                EmailAddressIII = "danielle@aleand.com.br",
                EmailAddressIV = "cotacoes@aleand.com.br",
                EmailAddressV = "vendas@aleand.com.br"
            };
            Sender from = new Sender()
            {
                Name = "Sender Mail",
                EmailAddres = "aleand.bot@gmail.com"
            };            
            Mail mail = new Mail()
            {
                Id = new Random().Next(),
                SendDate = DateTime.Now,
                Sender = from,
                Remittee = to,
                Body = txt_Body.Text,
                Title = txt_Subject.Text
            };

            ToSend._toSend(mail);
        }

        private void LoadSender()
        {
            var senders = SenderContext.FindSenders();
            foreach (var sender in senders)
            {
                txt_From.Items.Add(sender);
            }
        }

        private void btn_SelectMode_Click(object sender, EventArgs e)
        {
            string modeSelected = cb_ModeSend.SelectedItem.ToString().ToUpper();
            if (modeSelected == "MUTIPLE")
            {

            }
            else
            {

            }
        }
    }
}
