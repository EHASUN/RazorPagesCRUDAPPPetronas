using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using employeewebapp.Models;

namespace employeewebapp.Data
{
    public class employeewebappContext : DbContext
    {
        public employeewebappContext (DbContextOptions<employeewebappContext> options)
            : base(options)
        {
        }

        public DbSet<employeewebapp.Models.Employee> Employee { get; set; }
    }
}
