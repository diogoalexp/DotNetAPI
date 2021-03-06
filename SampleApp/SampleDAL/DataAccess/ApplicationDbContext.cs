﻿using Microsoft.EntityFrameworkCore;
using SampleModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDAL.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
            {
            }

        public DbSet<Person> Person { get; set; }
        public DbSet<Auth> User { get; set; }

    }
}
