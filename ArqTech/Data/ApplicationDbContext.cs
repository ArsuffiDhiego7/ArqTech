using ArqTech.Models;
using Microsoft.EntityFrameworkCore;

namespace ArqTech.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<CadastroModel> Cadastros {  get; set; }

    }
}
