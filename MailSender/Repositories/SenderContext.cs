using MailSender.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailSender.Repositories
{
    public class SenderContext : DbContext
    {        
        public DbSet<Sender> Sender { get; set; }

        private static bool _created = false;
        public SenderContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"Data Source=C:\Users\pablo\OneDrive\Área de Trabalho\Dev_Aleand\MailSender\MailSender\Repositories\Database\DatabaseSender.db");
        //Prod: X:\DatabaseSender.db
        //Homolog: C:\Users\pablo\OneDrive\Área de Trabalho\Dev_Aleand\MailSender\MailSender\Repositories\Database\DatabaseSender.db


        public static Sender SearchSender_PerEmail(string email)
        {
            Sender sender = new Sender();
            using (var context = new AppContext())
            {
                sender = context.Sender.Find(email);
            }
            return sender;
        }

        public static void Add(Sender sender)
        {
            using (var context = new SenderContext())
            {
                context.Sender.Add(sender);
                context.SaveChanges();
            }
        }

        public static void Update(Sender sender)
        {
            using (var context = new SenderContext())
            {
                if (sender != null)
                {
                    context.Sender.Update(sender);
                    context.SaveChanges();
                }
            }
        }
    }
}
