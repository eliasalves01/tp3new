using Microsoft.EntityFrameworkCore;
using InfnetWebApp.Models;

namespace InfnetWebApp.Data
{
    public class InfnetDbContext : DbContext
    {
        public InfnetDbContext(DbContextOptions<InfnetDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
