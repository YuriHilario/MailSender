using MailSender.Entities;
using MailSender.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MailSender.Repositories;
using System.Linq;
using AppContext = MailSender.Repositories.AppContext;

namespace MailSender.Views
{
    public partial class SenderForm : Form
    {
        public SenderForm()
        {
            InitializeComponent();
            LoadSender();
            LoadTo();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                var from = SenderContext.SearchSender_PerEmail(txt_From.Text.Trim());
                string uf = txt_To.Text.Trim().ToUpper();

                List<Remittee> remittants = new List<Remittee>();
                using (var context = new AppContext())
                {
                    remittants = context.Remittees.Where(r => r.UF.Contains(uf)).ToList();
                }
                foreach (var remittee in remittants)
                {
                    if (remittee.UF == uf && remittee.EmailAddress != string.Empty)
                    {
                        Mail mail = new Mail()
                        {
                            Id = new Random().Next(),
                            SendDate = DateTime.Now,
                            Sender = from,
                            Remittee = remittee,
                            Body = txt_Body.Text,
                            Title = txt_Subject.Text
                        };
                        ToSend._toSend(mail);
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.InnerException.Message, "Error", MessageBoxButtons.OK);
            }
            
        }

        private void LoadSender()
        {
            List<Sender> senders = new List<Sender>();
            using (var context = new AppContext())
            {
                senders = context.Sender.ToList();
            }

            foreach (var sender in senders)
            {
                txt_From.Items.Add(sender.EmailAddres);
            }
        }

        private void LoadTo()
        {
            var ufs = LoadUF.LoadDataLocates();
            foreach (var to in ufs)
            {
                txt_To.Items.Add(to.sigla);
            }
        }
    }
}
