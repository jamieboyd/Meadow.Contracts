using System.Threading.Tasks;
using Meadow.Logging;

namespace Meadow.Cloud;

public interface IMeadowCloudService
{
    string CurrentJwt { get; }
    Task<bool> Authenticate();
    Task<bool> SendLog(CloudLog cloudLog);
}