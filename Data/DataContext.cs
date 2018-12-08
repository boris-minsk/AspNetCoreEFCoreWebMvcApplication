﻿using AspNetCoreAppEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreAppEFCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<File> Files { get; set; }
        public DbSet<DataModel> DataModels { get; set; }
    }
}
