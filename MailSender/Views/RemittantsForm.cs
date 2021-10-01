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

        }
    }
}
