using StatePattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup context in a state
            Context c = new Context(new ConcreteStateA());

            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();
            Console.ReadKey();
        }

        /*
         
        5、状态模式应用分析

　　        状态模式效果：
　　        1>、状态模式的本质是将条件语句的各个分支封装起来，从而实现了状态逻辑与动作的分离。当分支很多时，状态模式可以给代码的维护带来很大的便利。
　　        2>、多态性的实现。
　　        3>、状态转换的显示化。状态模式将状态的切换逻辑存放到状态对象中，可以实现状态的自动切换，使各个状态界限分明，相互独立。
　　        4>、采用分支结构时，Context对象需要关心所有状态的切换逻辑，当分支越来越多时，复杂度也会越来越大。而状态模式中Context无需关心状态的切换逻辑，
                每个状态对象也只需关心状态的下一个可能状态的切换逻辑。

　　        状态模式主要解决的是当控制一个对象状态的条件表达式过于复杂时的情况。把状态的判断逻辑表示不同状态的一系列类中，可以把复杂的判断逻辑简化。
                状态模式的目的是为了将状态与不同状态下的行为进行分离，从而简化复杂的条件判断。

　　        状态模式主要适用场景：
　　        ◊ 一个对象的行为取决于它的状态，并且必须在运行时刻根据状态改变其行为；
　　        ◊ 一个操作中包含庞大的分支结构，并且这些分支决定于对象的状态。
         
         */
    }
}
