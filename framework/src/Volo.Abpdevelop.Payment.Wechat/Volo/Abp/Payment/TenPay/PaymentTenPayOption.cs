namespace Volo.Abp.Payment.TenPay
{
    /// <summary>
    /// 微信支付配置
    /// </summary>
    public class PaymentTenPayOption
    {
        /// <summary>
        /// 第三方用户唯一凭证appid
        /// </summary>
        public string AppId { get; private set; }

        /// <summary>
        /// 第三方用户唯一凭证密钥，即appsecret
        /// </summary>
        public string AppSecret { get; private set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        public string MchId { get; private set; }

        /// <summary>
        /// 商户支付密钥Key。登录微信商户后台，进入栏目【账户设置】【密码安全】【API 安全】【API 密钥】
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// 微信支付证书位置（物理路径），在 .NET Core 下执行 TenPayV3InfoCollection.Register() 方法会为 HttpClient
        /// </summary>
        public string CertPath { get; private set; }

        /// <summary>
        /// 微信支付证书密码
        /// </summary>
        public string CertSecret { get; private set; }

        /// <summary>
        /// 支付完成后的回调处理页面
        /// </summary>
        public string NotifyUrl { get; private set; }

        /// <summary>
        /// 小程序支付完成后的回调处理页面
        /// </summary>
        public string MiniProgromNotifyUrl { get; private set; }

        /// <summary>
        /// 服务商模式下，特约商户的开发配置中的AppId
        /// </summary>
        public string SubAppId { get; private set; }

        /// <summary>
        /// 服务商模式下，特约商户的开发配置中的AppSecret
        /// </summary>
        public string SubAppSecret { get; private set; }

        /// <summary>
        /// 服务商模式下，特约商户的商户Id
        /// </summary>
        public string SubMchId { get; private set; }


        public PaymentTenPayOption SetAppId(string appId)
        {
            AppId = appId;
            return this;
        }

        public PaymentTenPayOption SetNotifyUrl(string notifyUrl)
        {
            NotifyUrl = notifyUrl;
            return this;
        }

    }
}
