using CommanderShepard.Models;
using System.Collections.Generic;

namespace CommanderShepard.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command command);
    }
}
