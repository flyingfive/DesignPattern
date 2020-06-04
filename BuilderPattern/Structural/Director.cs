using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Structural
{
    public class Director
    {
        /// <summary>
        /// Builder uses a complex series of steps
        /// </summary>
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
