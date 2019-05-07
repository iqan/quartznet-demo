using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Configuration.Interpreters;
using Quartz;
using System;

namespace QuartzNetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer(new XmlInterpreter());
            container.Register(Component.For<IProcessor>().ImplementedBy<SampleProcessor>());
            var scheduler = container.Resolve<IScheduler>();
            Console.WriteLine("Starting scheduler");
            scheduler.Start();
            Console.ReadLine();
        }
    }
}
