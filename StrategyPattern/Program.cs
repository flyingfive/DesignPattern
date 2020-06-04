using StrategyPattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;

            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadKey();
        }


        /*
         
         4.1 策略模式适用情形
　　        ◊ 如果在一个系统里面有许多类，它们之间的区别仅在于它们的行为，那么使用策略模式可以动态地让一个对象在许多行为中选择一种行为。
　　        ◊ 一个系统需要动态地在几种算法中选择一种。这些具体算法类均有统一的接口，由于多态性原则，客户端可以选择使用任何一个具体算法类，并只持有一个数据类型是抽象算法类的对象。
　　        ◊ 一个系统的算法使用的数据不可以让客户端知道。策略模式可以避免让客户端涉及到不必要接触到的复杂的和只与算法有关的数据。
　　        ◊ 如果一个对象有很多的行为，如果不用恰当的模式，这些行为就只好使用多重的条件选择语句来实现。此时，使用策略模式，把这些行为转移到相应的具体策略类里面，
                可以避免使用难以维护的多重条件选择语句。

         4.2 策略模式优点
            （1）支持开闭原则（OCP）。
            （2）策略模式使用继承模式抽取公共代码到基类，避免重复代码。
            （3）策略模式避免使用多重条件判断语句(if/else、switch等)。

         4.3 策略模式缺点
            （1）客户端(Client)必须知道所有的策略类，并自行决定使用哪一个策略类。策略模式只适用于客户端知道所有的算法或行为的情况。
            （2）策略模式造成很多的策略类。
         
         */
    }
}
