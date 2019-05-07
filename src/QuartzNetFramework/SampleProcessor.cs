using Common.Logging;
using System.Threading.Tasks;

namespace QuartzNetFramework
{
    public class SampleProcessor : IProcessor
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ExampleJob));

        public async Task Process()
        {
            log.Info("Processing");
            await Task.Delay(1000);
        }
    }
}
