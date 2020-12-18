using Microsoft.EntityFrameworkCore;
using MVC_VET.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_VET.Web.Data
{
    public class DataContext : DbContext
    {
        

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }


        // obter da DB os Animais
        public DbSet<Animal> Animals { get; set; }

    }
}
