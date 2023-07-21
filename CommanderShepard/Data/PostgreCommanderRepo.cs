using CommanderShepard.Models;
using System.Collections.Generic;
using System.Linq;

namespace CommanderShepard.Data
{
    public class PostgreCommanderRepo : ICommanderRepo
    {
        private readonly CommanderContext _context;
        public PostgreCommanderRepo(CommanderContext context)
        {
            _context = context;
        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}
