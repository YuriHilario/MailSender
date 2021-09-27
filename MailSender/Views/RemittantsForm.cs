using MailSender.Entities;
using MailSender.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MailSender.Views
{
    public partial class RemittantsForm : Form
    {
        public RemittantsForm()
        {
            InitializeComponent();
        }

        private void Remittants_Load(object sender, EventArgs e)
        {

        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            Remittee remittee = new Remittee()
            {
                Name = "",
                CNPJ = "00.000.000/0001-00",
                EmailAddress = "teste@Aleand.com.br",
                EmailAddressII = string.Empty,
                EmailAddressIII = string.Empty,
                EmailAddressIV = string.Empty,
                EmailAddressV = string.Empty
            };
            using (var db = new RemitteeContext())
            {
                db.Remittees.Find(remittee.CNPJ);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           
        }
    }
}
