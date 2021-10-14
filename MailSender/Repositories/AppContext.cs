using MailSender.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MailSender.Repositories
{
    class AppContext : DbContext
    {
        public DbSet<Mail> Mail { get; set; }
        public DbSet<Remittee> Remittees { get; set; }
        public DbSet<Sender> Sender { get; set; }

        private static bool _created = false;

        public AppContext()
        {
            if (!_created)
            {
                _created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"DataSource=X:\DatabaseSender.db");

        
    }
}
