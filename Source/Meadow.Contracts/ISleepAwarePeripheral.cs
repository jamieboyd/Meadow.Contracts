using System.Threading;
using System.Threading.Tasks;

namespace Meadow
{
    public interface ISleepAwarePeripheral
    {
        public Task BeforeSleep(CancellationToken cancellationToken);
        public Task AfterWake(CancellationToken cancellationToken);
    }
}
