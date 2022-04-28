using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Config
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<ItemTarefa> ItemTarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConnection());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public string GetStringConnection()
        {
            return "Server=NOTEBOOK-5KP7FMEG\\SQLEXPRESS;Database=Tarefas;Trusted_Connection=True";
        }
    }
}
