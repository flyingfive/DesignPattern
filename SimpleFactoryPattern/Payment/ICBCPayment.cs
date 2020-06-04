using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Payment
{
    public class ICBCPayment : IPayment
    {
        public bool Payfor(decimal money)
        {
            // 调用中国工商银行支付接口进行支付
            return true;
        }
    }
}
