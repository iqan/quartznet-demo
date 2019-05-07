using System.Threading.Tasks;

namespace QuartzNetFramework
{
    public interface IProcessor
    {
        Task Process();
    }
}