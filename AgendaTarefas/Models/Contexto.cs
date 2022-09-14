using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

// Manipulação das tabelas

namespace AgendaTarefas.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes):base(opcoes)
        {

        }
    }
}
