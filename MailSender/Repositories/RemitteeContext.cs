using MailSender.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"DataSource=D:\MailSender\MailSender\Repositories\Database\DatabaseSender.db");
    }
}
