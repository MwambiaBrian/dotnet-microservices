using CommandsService.Models;

namespace CommandService.SyncDataServices.Grpc 
{
public interface IPlatformDataClient 
{
    IEnumerable<Platform> ReturnAllPlatforms ();
}
}