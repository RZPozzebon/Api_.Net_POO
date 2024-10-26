using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Venda.Model;
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
        public DbSet<Cliente> Clientes{get;set;}
        
    }
}