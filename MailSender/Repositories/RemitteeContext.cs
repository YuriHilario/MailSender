using MailSender.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailSender.Repositories
{
    class RemitteeContext : DbContext
    {
        public DbSet<Remittee> Remittees { get; set; }

        private static bool _created = false;
        public RemitteeContext()
        {
            if (!_created)
            {
                _created = true;
                //Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"DataSource=C:\Users\pablo\source\repos\MailSender\MailSender\Repositories\Database\DatabaseSender.db");

        public static List<Remittee> FindRemittants()
        {
            List<Remittee> remittants = new List<Remittee>();
            using (var context = new RemitteeContext())
            {
                remittants = context.Remittees.ToList();
                return remittants;
            }
        }

        public static void Add(Remittee remittee)
        {
            using (var context = new RemitteeContext())
            {
                context.Remittees.Add(remittee);
                context.SaveChanges();
            }
        }

        public static Remittee FindPerCNPJ(string cnpj)
        {            
            using (var context = new RemitteeContext())
            {
                Remittee remittee = context.Remittees.Find(cnpj);
                return remittee;
            }
        }

        public static void Update(Remittee remittee)
        {
            using (var context = new RemitteeContext())
            {
                if (remittee != null)
                {
                    context.Remittees.Update(remittee);
                    context.SaveChanges();
                }
            }
        }
    }
}
