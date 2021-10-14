using MailSender.Entities;
using MailSender.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using AppContext = MailSender.Repositories.AppContext;

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

            List<Remittee> remittants = new List<Remittee>();
            using (var context = new AppContext())
            {
                remittants = context.Remittees.ToList();
            }

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
            string cnpj = txt_FilterCNPJ.Text.Trim().Replace(",","").Replace(".", "").Replace("/", "").Replace("-", "");
            Remittee remittee = new Remittee();

            using (var context = new AppContext())
            {
                remittee = context.Remittees.Find(cnpj);                
            }

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

            List<Remittee> remittants = new List<Remittee>();
            using (var context = new AppContext())
            {
                remittants = context.Remittees.ToList();
            }

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
                    if (remittee != null)
                    {
                        context.Remittees.Update(remittee);
                        context.SaveChanges();
                    }
                }
                MessageBox.Show("Registration updated successfully !", "Record Update", MessageBoxButtons.OK);
                dataGridView_Remittants.Rows.Clear();
                LoadDataGridView();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.InnerException.ToString(), "Error", MessageBoxButtons.OK);
            }
            
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            string name = dataGridView_Remittants.CurrentRow.Cells[0].Value.ToString();
            string uf = dataGridView_Remittants.CurrentRow.Cells[1].Value.ToString();
            string cnpj = dataGridView_Remittants.CurrentRow.Cells[2].Value.ToString().Replace(",","").Replace("/", "").Replace("-", "").Replace(".", "");
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
