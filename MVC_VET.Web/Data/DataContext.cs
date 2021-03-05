using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_VET.Web.Data.Entities;

namespace MVC_VET.Web.Data
{
    public class DataContext : IdentityDbContext<User>
    {


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        // obter da DB os Animais
        public DbSet<Animal> Animals { get; set; }


        // obter da DB os Animais
        public DbSet<MVC_VET.Web.Data.Entities.Owner> Owner { get; set; }


        // obter da DB os Animais
        public DbSet<MVC_VET.Web.Data.Entities.Doctor> Doctor { get; set; }



    }
}
