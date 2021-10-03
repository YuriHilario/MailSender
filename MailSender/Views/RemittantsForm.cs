using MailSender.Entities;
using MailSender.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MailSender.Views
{
    public partial class RemittantsForm : Form
    {
        Thread thread;

        public RemittantsForm()
        {
            InitializeComponent();
            LoadDataGridView();
        }


        #region Windows
        private void AddRemitte()
        {
            Application.Run(new AddRemittee());
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddRemittee addRemittee = new AddRemittee();
            thread = new Thread(AddRemitte);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        #endregion

        private void LoadDataGridView()
        {
            dataGridView_Remittants.Rows.Clear();
            List<Remittee> remittants = RemitteeContext.FindRemittants();
            foreach (Remittee remittee in remittants)
            {
                dataGridView_Remittants.Rows.Add(remittee.Name,
                                                 remittee.UF,
                                                 remittee.CNPJ,
                                                 remittee.EmailAddress,
                                                 remittee.EmailAddressII,
                                                 remittee.EmailAddressIII,
                                                 remittee.EmailAddressIV,
                                                 remittee.EmailAddressV);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Remittants.Rows.Clear();
            Remittee remittee = RemitteeContext.FindPerCNPJ(txt_FilterCNPJ.Text);
            dataGridView_Remittants.Rows.Add(remittee.Name,
                                             remittee.UF,
                                             remittee.CNPJ,
                                             remittee.EmailAddress,
                                             remittee.EmailAddressII,
                                             remittee.EmailAddressIII,
                                             remittee.EmailAddressIV,
                                             remittee.EmailAddressV);

        }

        private void btn_LoadData_Click(object sender, EventArgs e)
        {
            dataGridView_Remittants.Rows.Clear();
            List<Remittee> remittants = RemitteeContext.FindRemittants();
            foreach (Remittee remittee in remittants)
            {
                dataGridView_Remittants.Rows.Add(remittee.Name,
                                                 remittee.UF,
                                                 remittee.CNPJ,
                                                 remittee.EmailAddress,
                                                 remittee.EmailAddressII,
                                                 remittee.EmailAddressIII,
                                                 remittee.EmailAddressIV,
                                                 remittee.EmailAddressV);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Remittee remittee = new Remittee()
            {
                Name = txt_Name.Text,
                CNPJ = txt_CNPJ.Text,
                EmailAddress = txt_Address.Text,
                EmailAddressII = txt_AddressII.Text,
                EmailAddressIII = txt_AddressIII.Text,
                EmailAddressIV = txt_AddressIV.Text,
                EmailAddressV = txt_AddressV.Text
            };
            try
            {
                RemitteeContext.Update(remittee);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.InnerException.ToString());
            }
            
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            string name = dataGridView_Remittants.CurrentRow.Cells[0].Value.ToString();
            string uf = dataGridView_Remittants.CurrentRow.Cells[1].Value.ToString();
            string cnpj = dataGridView_Remittants.CurrentRow.Cells[2].Value.ToString();
            string address = dataGridView_Remittants.CurrentRow.Cells[3].Value.ToString();
            string addressII = dataGridView_Remittants.CurrentRow.Cells[4].Value.ToString();
            string addressIII = dataGridView_Remittants.CurrentRow.Cells[5].Value.ToString();
            string addressIV = dataGridView_Remittants.CurrentRow.Cells[6].Value.ToString();
            string addressV = dataGridView_Remittants.CurrentRow.Cells[7].Value.ToString();


            txt_Name.Text = name;
            txt_UF.Text = uf;
            txt_CNPJ.Text = cnpj;
            txt_Address.Text = address;
            txt_AddressII.Text = addressII;
            txt_AddressIII.Text = addressIII;
            txt_AddressIV.Text = addressIV;
            txt_AddressV.Text = addressV;

            Remittee remittee = new Remittee()
            {
                Name = txt_Name.Text,
                UF = txt_UF.Text,
                CNPJ = txt_CNPJ.Text,
                EmailAddress = txt_Address.Text,
                EmailAddressII = txt_AddressII.Text,
                EmailAddressIII = txt_AddressIII.Text,
                EmailAddressIV = txt_AddressIV.Text,
                EmailAddressV = txt_AddressV.Text
            };

        }
    }
}
