using SimpleFactoryPattern.Payment;
using SimpleFactoryPattern.Practical;
using SimpleFactoryPattern.Structural;
using SimpleFactoryPattern.StructuralInterfaceImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.抽象类实现
            var product = Structural.Factory.CreateProduct();
            Console.WriteLine("Created {0}", product.GetType().Name);

            //2.接口实现
            var product2 = StructuralInterfaceImplementation.Factory.Create();
            product2.Display();

            //3.计算器练习
            Operation operateion = OperationFactory.CreateOperate("+");
            operateion.NumberA = 10;
            operateion.NumberB = 5;
            Console.WriteLine(operateion.GetResult());

            //4.银行支付练习
            var orderService = new OrderService();
            orderService.CreateOrder("ICBC");

            Console.ReadLine();

            /*
             
             5.1 简单工厂模式优点
　　            ◊ 实现创建和使用分离；
　　            ◊ Client无需知道所创建的ConcreteProduct类名，只需要知道ConcreteProduct所对应的参数。
             5.2 简单工厂模式缺点
　　            ◊ Factory类集中所有ConcreteProduct的创建逻辑，职责过重。一旦需要添加新的ConcreteProduct，则需要修改Factory逻辑。这样违背了OCP（开放-关闭原则）。
　　            ◊ 由于使用了static方法，造成Factory无法形成基于继承的结构。
             
             */
        }
    }
}
