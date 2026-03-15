using NLog;

namespace Doppler.Core.Services
{
    public class AbstractService
    {
        protected static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        protected DopplerConfig Configuration;
    }
}