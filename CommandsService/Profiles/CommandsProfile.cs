using AutoMapper;
using CommandService.Dto;
using CommandService.Dtos;
using CommandsService.Models;

namespace CommandService.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // source -> target
            CreateMap<Platform, PlatformReadDto>();

            CreateMap<CommandCreateDto, Command>();
            CreateMap<Command, CommandReadDto>();
        }
    }
}