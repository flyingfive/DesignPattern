using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.Practical
{
    /// <summary>
    /// 运算类
    /// </summary>
    public abstract class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }

        public virtual double GetResult()
        {
            const double result = 0;
            return result;
        }
    }
}
