using DecoratorPattern.Structural;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create ConcreteComponent and two Decorators
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            // Link decorators
            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();
        }

        /*
         4、装饰模式应用分析
　　        装饰模式适用情形：
　　        ◊ 在不影响其他对象的情况下，以动态、透明的方式给单个对象添加职责
　　        ◊ 处理那些可以撤销的职责

　　        装饰模式的特点：
　　        ◊ 比静态类更灵活。使用装饰模式可以很容易地向对象添加职责的方式。可以用添加和分离的方法，对装饰在运行时添加和删除职责。相比之下，继承机制要求为每个添加的职责创建一个新的子类。这会产生很多新的类，并会增加系统的复杂度。
　　        ◊ 使用装饰模式可以很容易地重复添加一个特性，而两次继承特性类则极容易出错。
　　        ◊ 为了避免处理顶层的类有太多的特征。装饰模式下，你可以定义一个简单的类，并用装饰类给它逐渐地添加功能。这样可以从简单的部件组合出复杂的功能，具有低依赖性和地复杂性。
　　        ◊ 有许多小对象。采用装饰模式进行系统设计往往会产生许多看上去类似的小对象，尽管对于了解这些系统的人来说，很容易进行定制，但是很难学习这些系统，排错很恶化呢困难。
         */
    }
}
