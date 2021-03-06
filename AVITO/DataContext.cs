﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AVITO
{
    public class DataContext : DbContext
    {
        public DbSet<Announcement> Announcements { set; get; }
        public DbSet<ImageDB> Images { set; get; }
        public DbSet<Account> Accounts { set; get; }

        public DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=mysql60.hostland.ru; UserId=host1323541_itstep; Password=269f43dc; database=host1323541_itstep3;");
        }
    }
}
