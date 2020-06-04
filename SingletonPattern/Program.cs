using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        /*
         
         4.1 单件模式使用注意点
　　        （1）不要使用单例模式存取全局变量。这违背了单例模式的用意，最好放到对应类的静态成员中。
　　        （2）不要将数据库连接做成单例，因为一个系统可能会与数据库有多个连接，并且在有连接池的情况下，应当尽可能及时释放连接。Singleton模式由于使用静态成员存储类实例，所以可能会造成资源无法及时释放。
        
         4.2 单件模式适用情形
　　        （1）当类只能有一个实例而且客户可以从一个众所周知的访问点访问时；
　　        （2）当这个唯一实例应该是通过子类化可扩展的，并且客户应该无需更改代码就能适用一个扩展的实例时。
         */
    }
}
