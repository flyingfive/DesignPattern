using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Practical
{
    /// <summary>
    /// 减法运算
    /// </summary>
    public class Minus : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }
}
