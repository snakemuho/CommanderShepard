using CommanderShepard.Models;
using Microsoft.EntityFrameworkCore;

namespace CommanderShepard.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
        }

        public DbSet<Command> Commands { get; set; }
    }
}
