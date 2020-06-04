using IteratorPattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            ConcreteIterator i = new ConcreteIterator(a);

            Console.WriteLine("Iterating over collection:");
            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            Console.ReadKey();
        }

        /*
         
         5、迭代器模式应用分析

　　        迭代器模式适用情形：
　　        1>、访问一个具体对象的内容而不暴露它的内部表示；
　　        2>、支持对聚合对象的多种遍历；
　　        3>、为遍历不同的聚合结构提供一个统一的接口（即支持多态迭代）。

　　        迭代器模式特点：
　　        1>、简化聚集的行为，迭代器具备了遍历的接口，这样聚集的接口就不必具备遍历接口；
　　        2>、每一个聚集对象都可以有一个或者更多的迭代器对象，每一个迭代器的迭代状态可以彼此独立（外禀迭代器）；
　　        3>、遍历算法被封装到迭代器对象中，迭代算法可以独立于聚集对象变化。Client不必知道聚集对象的类型，通过迭代器可以就读取和遍历聚集对象。
                这样的好处是聚集本身内部数据发生变化而不影响Client的程序。

         */
    }
}
