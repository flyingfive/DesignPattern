using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Structural
{
    /// <summary>
    /// 定义Product抽象类，Client调用Product抽象类，并由Factory来创建具体类。
    /// </summary>
    public abstract class Product
    {
    }

    public class ConcreteProductA : Product
    {
    }

    public class ConcreteProductB : Product
    {
    }

}
