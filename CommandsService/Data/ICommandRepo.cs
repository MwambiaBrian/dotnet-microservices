

using CommandsService.Models;

namespace CommandService.Data
{
    public interface ICommandRepo
    {
        bool SaveChanges();
        //platforms
        IEnumerable<Platform> GetAllPlatforms();
        void createPlatform(Platform plat);
        bool platformExists(int platformId);
        bool ExternalPlatformExists(int externalPlatformId);

        //commands
        IEnumerable<Command> GetAllCommandsForPlatform(int platformId);
        Command GetCommand(int platformId, int commandId );
        void createCommand(int platformId, Command command);
        
    }
}
