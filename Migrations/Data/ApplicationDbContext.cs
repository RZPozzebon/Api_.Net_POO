using Api_Venda.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Venda.Migrations.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
                base(options)
        {

        }
        //Definindo as entidades
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<User> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }

    }
}