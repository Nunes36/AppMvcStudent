using Microsoft.EntityFrameworkCore;
using AppMvc.Models;
namespace AppMvc.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
                
        }

        public DbSet<Tarefa> Banco { get; set; } 
    }
}
