using System.Threading.Tasks;

namespace Volo.Abp
{
    public interface IPaymenter
    {
        /// <summary>
        /// 扫码支付
        /// </summary>
        /// <returns></returns>
        Task MicroPayAsync();

        /// <summary>
        /// 统一下单
        /// </summary>
        /// <returns></returns>
        Task UnifiedOrderAsync();

    }
}
