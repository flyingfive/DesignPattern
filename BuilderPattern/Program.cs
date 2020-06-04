using BuilderPattern.Practical;
using BuilderPattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create director and builders
            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();


            //1.练习
            VehicleBuilder builder;
            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            Console.ReadKey();
        }

        /*
         5、建造者模式应用分析

　　        建造者模式适用情形：
　　        ◊ 需要生成的产品对象有复杂的内部结构
　　        ◊ 需要生成的产品对象的属性相互依赖，建造者模式可以强迫生成顺序
　　        ◊ 在对象创建过程中会使用到系统中的一些其他对象，这些对象在产品对象的创建过程中不易得到

　　        建造者模式特点：
　　        ◊ 建造者模式的使用使得产品的内部表对象可以独立地变化。使用建造者模式可以使客户不必知道产品内部组成的细节
　　        ◊ 每一个Builder都相对独立，而与其他Builder无关
　　        ◊ 可使对构造过程更加精细控制
　　        ◊ 将构建代码和表示代码分开
　　        ◊ 建造者模式的缺点在于难于应付分步骤构建算法的需求变动
         */
    }
}
