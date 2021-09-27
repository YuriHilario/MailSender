using MailSender.Entities;
using MailSender.Views;
using System;
using System.Threading;
using System.Windows.Forms;

namespace MailSender
{
    public partial class Main : Form
    {
        Thread thread;
        public Main()
        {
            InitializeComponent();
        }

        #region Window
        private void Remittants()
        {
            Application.Run(new RemittantsForm());
        }
        private void btn_Remittants_Click(object sender, EventArgs e)
        {
            RemittantsForm configForm = new RemittantsForm();
            thread = new Thread(Remittants);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        
        private void Start()
        {
            Application.Run(new SenderForm());
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            SenderForm senderForm = new SenderForm();
            thread = new Thread(Start);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }



        #endregion

        
    }
}
