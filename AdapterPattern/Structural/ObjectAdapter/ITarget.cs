using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Structural.ObjectAdapter
{
    public interface ITarget
    {
        void Request();
    }
    public class Target : ITarget
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
    public class Adapter : Target
    {
        private Adaptee _adaptee = new Adaptee();

        public override void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    public class Client
    {
        static void Main(string[] args)
        {
            //对象适配器结构实现
            ITarget t = new Adapter();
            t.Request();
        }
    }
}
