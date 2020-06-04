using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern.Structural
{ /// <summary>
  /// 解释器上下文环境类。用来存储解释器的上下文环境，比如需要解释的文法等。
  /// </summary>
    class Context
    {
        private int sum;
        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }

    }
    /// <summary>
    /// 解释器抽象类。
    /// </summary>
    abstract class AbstractExpreesion
    {
        public abstract void Interpret(Context context);


    }
    /// <summary>
    ///   解释器具体实现类。自加
    /// </summary>
    class PlusExpression : AbstractExpreesion
    {
        public override void Interpret(Context context)
        {
            int sum = context.Sum;
            sum++;
            context.Sum = sum;

        }
    }
    /// <summary>
    ///   解释器具体实现类。 自减
    /// </summary>
    class MinusExpression : AbstractExpreesion
    {
        public override void Interpret(Context context)
        {
            int sum = context.Sum;
            sum--;
            context.Sum = sum;

        }
    }
}
