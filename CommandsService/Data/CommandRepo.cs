using System.Linq;
using CommandsService.Data;
using CommandsService.Models;

namespace CommandService.Data 
{
    public class CommandRepo : ICommandRepo
    {
        private readonly AppDbContext _context;

        public CommandRepo(AppDbContext context)
        {
           _context = context; 
        }
        public void createCommand(int platformId, Command command)
        {
             if(command==null) {
                throw new ArgumentNullException(nameof(command));
            }
            command.PlatformId = platformId;
            _context.Commands.Add(command);
        }

        public void createPlatform(Platform plat)
        {
             if(plat==null) {
                throw new ArgumentNullException(nameof(plat));
            }
            _context.Platforms.Add(plat);
        }

        public bool ExternalPlatformExists(int externalPlatformId)
        {
             return _context.Platforms.Any(p => p.ExternalID == externalPlatformId);
        }

        public IEnumerable<Command> GetAllCommandsForPlatform(int platformId)
        {
            return _context.Commands
                        .Where(c => c.PlatformId == platformId)
                        .OrderBy(c => c.Platform.Name);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Command GetCommand(int platformId, int commandId)
        {
            return _context.Commands
                        .Where(c => c.PlatformId == platformId && c.Id == commandId).FirstOrDefault();
                       
        }

        public bool platformExists(int platformId)
        {
            return _context.Platforms.Any(p => p.Id == platformId);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }
    }
}