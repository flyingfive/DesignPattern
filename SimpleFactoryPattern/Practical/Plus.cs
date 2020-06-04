using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Practical
{
    /// <summary>
    /// 加法运算
    /// </summary>
    public class Plus : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
