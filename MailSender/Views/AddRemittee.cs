using MailSender.Entities;
using MailSender.Repositories;
using System;
using System.Windows.Forms;
using AppContext = MailSender.Repositories.AppContext;

namespace MailSender.Views
{
    public partial class AddRemittee : Form
    {
        public AddRemittee()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {            
            Remittee remittee = new Remittee()
            {
                Name = txt_Name.Text,
                CNPJ = txt_CNPJ.Text.Replace(",", "").Replace("/", "").Replace("-", "").Replace(".", ""),
                UF = txt_UF.Text,
                EmailAddress = txt_Address.Text,
                EmailAddressII = txt_AddressII.Text,
                EmailAddressIII = txt_AddressIII.Text,
                EmailAddressIV = txt_AddressIV.Text,
                EmailAddressV = txt_AddressV.Text
            };
            try
            {
                using (var context = new AppContext())
                {
                    context.Remittees.Add(remittee);
                    context.SaveChanges();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.InnerException.ToString());
            }
        }       
    }
}

