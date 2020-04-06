using System.Threading.Tasks;

namespace Volo.Abp
{
    public class NullPaymenter : IPaymenter
    {
        public Task MicroPayAsync()
        {
            return Task.CompletedTask;
        }

        public Task UnifiedOrderAsync()
        {
            return Task.CompletedTask;
        }
    }
}
