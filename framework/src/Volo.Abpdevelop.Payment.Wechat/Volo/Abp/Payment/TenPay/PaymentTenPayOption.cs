using System;
using System.Collections.Generic;
using System.Text;

namespace Volo.Abp.Payment.TenPay
{
    /// <summary>
    /// 微信支付配置
    /// </summary>
    public class PaymentTenPayOption
    {
        /// <summary>
        /// 
        /// </summary>
        public string AppId { get; private set; }

        /// <summary>
        /// 通知回调地址
        /// </summary>
        public string NotifyUrl { get; private set; }

        
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
