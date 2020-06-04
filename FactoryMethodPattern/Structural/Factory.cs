using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Structural
{
    public abstract class Factory
    {
        public abstract Product CreateProduct();
    }
    public class ConcreteFactoryA : Factory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
    public class ConcreteFactoryB : Factory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
