using MailSender.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
                Database.EnsureDeleted();
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(@"DataSource=MailSender\Repositories\Database\DatabaseSender.db");
    }
}
