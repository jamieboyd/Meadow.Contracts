using System.Threading.Tasks;

namespace Meadow.Cloud;

public interface IHealthReporter
{
    void Start(int interval);
}