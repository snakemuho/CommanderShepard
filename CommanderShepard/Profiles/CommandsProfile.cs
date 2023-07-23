using AutoMapper;
using CommanderShepard.DTOs;
using CommanderShepard.Models;

namespace CommanderShepard.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // source -> target
            CreateMap<Command, CommandReadDTO>();
            CreateMap<CommandCreateDTO, Command>();
        }
    }
}
