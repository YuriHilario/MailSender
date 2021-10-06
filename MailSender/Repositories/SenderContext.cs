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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"DataSource=X:\DatabaseSender.db");


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

        public static List<Sender> FindSenders()
        {
            List<Sender> senders = new List<Sender>();
            using (var context = new SenderContext())
            {
                senders = context.Sender.ToList();
                return senders;
            }
        }

        
    }
}
