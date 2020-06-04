using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Structural.ClassAdapter
{
    public interface ITarget
    {
        void Request();
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }

    public class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            this.SpecificRequest();
        }
    }

    public class Client
    {
        static void Main(string[] args)
        {
            //类适配器结构实现
            ITarget t = new Adapter();
            t.Request();
        }
    }
}
