using CommanderShepard.Models;
using System.Collections.Generic;

namespace CommanderShepard.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
    }
}
