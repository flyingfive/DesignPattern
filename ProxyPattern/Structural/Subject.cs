using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Structural
{
    public abstract class Subject
    {
        public abstract void Request();
    }

    public class ConcreteSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called ConcreteSubject.Request()");
        }
    }

    public class Proxy : Subject
    {
        private ConcreteSubject _concreteSubject;

        public override void Request()
        {
            // Use 'lazy initialization'
            if (_concreteSubject == null)
            {
                _concreteSubject = new ConcreteSubject();
            }

            _concreteSubject.Request();
        }
    }

}
