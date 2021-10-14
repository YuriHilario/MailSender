using MailSender.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.Repositories
{
    class MailContext : DbContext
    {
        public DbSet<Mail> Mail { get; set; }

        private static bool _created = false;
        public MailContext()
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
