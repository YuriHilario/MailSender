using MailSender.Entities;
using MailSender.Repositories;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
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
                    MessageBox.Show("Remittee saved successfully !");
                    ClearForm();
                }
            }
            catch (Exception except)
            {
                MessageBox.Show(except.InnerException.ToString());
            }            
        }

        private void ClearForm()
        {
            txt_Name.Text = string.Empty;
            txt_CNPJ.Text = string.Empty;
            txt_UF.Text = string.Empty;
            txt_Address.Text = string.Empty;
            txt_AddressII.Text = string.Empty;
            txt_AddressIII.Text = string.Empty;
            txt_AddressIV.Text = string.Empty;
            txt_AddressV.Text = string.Empty;
        }
    }
}

