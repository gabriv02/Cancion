﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Song> cancion { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
        {

        }
    }
}
