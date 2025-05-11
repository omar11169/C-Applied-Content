using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakkenWebMuscatERF.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MakkenWebMuscatERF.Context
{
    internal class ApplicationDbContext : DbContext
        {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            //base.OnConfiguring(optionsBuilder);
             optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog= newDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

              }
        public DbSet<Employee> employees { get; set; }
        }
}