using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Payment
{
    public class OrderService
    {
        public bool CreateOrder(string bank)
        {
            decimal money = 100m;
            var payment = PaymentFactory.CreatePayment(bank);

            return payment.Payfor(money);
        }
    }
}
