using System.Threading.Tasks;
using Common.Logging;
using Quartz;

namespace QuartzNetFramework
{
    public class ExampleJob : IJob
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ExampleJob));
        private readonly IProcessor processor;

        public ExampleJob(IProcessor processor)
        {
            this.processor = processor;
        }

        public void Execute(IJobExecutionContext context)
        {
            processor.Process().GetAwaiter().GetResult();
            log.Info("Job executed");
        }
    }
}
