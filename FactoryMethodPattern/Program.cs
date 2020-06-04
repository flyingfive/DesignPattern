using FactoryMethodPattern.Practical;
using FactoryMethodPattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory[] factories = new Factory[2];
            factories[0] = new ConcreteFactoryA();
            factories[1] = new ConcreteFactoryB();

            foreach (Factory item in factories)
            {
                Product product = item.CreateProduct();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            //练习
            // 定义一个鸡腿工厂
            IKFCFactory factory = new ChickenFactory();
            // 生产鸡腿
            KFCFood food1 = factory.CreateFood();
            food1.Display();
            // 生产鸡腿
            KFCFood food2 = factory.CreateFood();
            food2.Display();
            // 生产鸡腿
            KFCFood food3 = factory.CreateFood();
            food3.Display();

            Console.ReadKey();
        }

        /*
         5.1 工厂方法模式适用情形
　　        ◊ 当一个类不知道它所必须创建的对象的类信息的时候
　　        ◊ 当一个类希望由它来指定它所创建的对象的时候
　　        ◊ 当类将创建对象的职责委托给多个辅助子类中的某一个，并且希望将哪一个辅助之类是代理者这一信息局部化的时候

         5.2 工厂方法模式特点
　　        ◊ 使用工厂方法在一个类的内部创建对象通常比直接创建对象更灵活
　　        ◊ 工厂方法模式通过面向对象的手法，将所要创建的具体对象的创建工作延迟到子类，从而提供了一种扩展的策略，较好的解决了紧耦合的关系
　　        ◊ 工厂方法模式遵守依赖倒置原则（Dependency Inversion Principle，DIP）

         5.3 工厂方法模式与简单工厂模式区别
　　        ◊ 工厂方法模式和简单工厂模式在结构上的不同是很明显的。工厂方法模式的核心是一个抽象工厂类，而简单工厂模式把核心放在一个具体工厂类上。工厂方法模式可以允许很多具体工厂类从抽象工厂类中将创建行为继承下来，从而可以成为多个简单工厂模式的综合，进而推广了简单工厂模式。
　　        ◊ 工厂方法模式退化后可以变得很像简单工厂模式。如果非常确定一个系统只需要一个具体工厂类，那么就不妨把抽象工厂类合并到具体的工厂类中去。由于只有一个具体工厂类，所以不妨将工厂方法改成为静态方法，这时候就得到了简单工厂模式
         
         */
    }
}
