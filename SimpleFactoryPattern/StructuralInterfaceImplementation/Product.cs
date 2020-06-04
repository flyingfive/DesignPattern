using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern.StructuralInterfaceImplementation
{
    public class Product : IProduct
    {
        public void Display()
        {
            Console.WriteLine("SimpleFactoryPattern.StructuralInterfaceImplementation.Product");
        }
    }
}
