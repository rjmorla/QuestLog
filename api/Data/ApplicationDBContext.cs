using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) 
        : base(dbContextOptions)
        {
            
        }

        public DbSet<Quest> Quests { get; set; }
        public DbSet<Subtask> Subtasks { get; set; }

    }
}