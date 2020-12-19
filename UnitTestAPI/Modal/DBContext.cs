using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTestAPI.Models;

namespace UnitTestAPI.Modal
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
