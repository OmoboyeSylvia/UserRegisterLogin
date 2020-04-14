
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegLog.Models
{
    public class RegLogDbContext : DbContext

    {
        public string ConnectionString;


        public RegLogDbContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

      
        public RegLogDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
