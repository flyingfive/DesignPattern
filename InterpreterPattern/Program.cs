using InterpreterPattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Sum = 10;
            List<AbstractExpreesion> list = new List<AbstractExpreesion>();
            //运行加法三次
            list.Add(new PlusExpression());
            list.Add(new PlusExpression());
            list.Add(new PlusExpression());
            //运行减法两次
            list.Add(new MinusExpression());
            list.Add(new MinusExpression());
            for (int i = 0; i < list.Count(); i++)
            {
                AbstractExpreesion expression = list[i];
                expression.Interpret(context);
            }
            Console.WriteLine(context.Sum);
            Console.ReadLine();
            //得出结果为11
        }

        /*
         
         适用场景：
            1.当有一个语言需要解释执行，并且你可将该语言中的句子表示为一个抽象语法树，可以使用解释器模式。而当存在以下情况时该模式效果最好
            2.该文法的类层次结构变得庞大而无法管理。此时语法分析程序生成器这样的工具是最好的选择。他们无需构建抽象语法树即可解释表达式，这样可以节省空间而且还可能节省时间。
            3.效率不是一个关键问题，最高效的解释器通常不是通过直接解释语法分析树实现的，而是首先将他们装换成另一种形式，
                例如，正则表达式通常被装换成状态机，即使在这种情况下，转换器仍可用解释器模式实现，该模式仍是有用的
         
         */
    }
}
