using MementoDesignPattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off";
            o.SetMemento(c.Memento);
        }

        /*
         4、备忘录模式应用分析

　　        备忘录模式适用情形：
　　        1>、必须保存一个对象在某一个时刻的部分状态，这样以后需要时才能恢复到先前的状态。
　　        2>、如果用一个接口来让其他对象直接得到被保存对象的内部状态，将会暴露对象的实现细节并破坏对象的封装性。

　　        备忘录模式特点：
　　        1>、保持封装边界。使用备忘录可以避免暴露一些只应由Originator管理却又必须存储在Originator之外的信息。
                该模式把可能很复杂的Originator内部信息对其他对象屏蔽起来，从而保持了封装边界。
　　        2>、简化Originator。在其他的保持封装性的设计中，Originator负责保持Client请求过的内部状态版本。把所存储管理的重任交给了Originator，
                让Client管理它们请求的状态将会简化Originator，并使得Client工作结束时无需通知Originator。

         */
    }
}
