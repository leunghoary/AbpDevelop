using Volo.Abp.Modularity;

namespace Volo.Abp.Payment.TenPay
{
    [DependsOn(typeof(AbpPaymentModule))]
    public class AbpPaymentTenPayModule : AbpModule
    {
        
    }
}
