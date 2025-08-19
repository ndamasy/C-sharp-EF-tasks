using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_c__EF_01.Data.Models
{
    internal class CompanyDpContext:DbContext
    {
        //CompanyDpContext(): base ()
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=.;Database=CompanyDp;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<employ> Employs { get; set; }

    }
}
