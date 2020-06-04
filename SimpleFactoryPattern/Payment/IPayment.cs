using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Payment
{
    public interface IPayment
    {
        bool Payfor(decimal money);
    }
}
