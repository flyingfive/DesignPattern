using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityMapPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                  Identity Map（标识映射）模式是通过将所有已加载对象放在一个映射中确保所有对象只被加载一次，并且在引用这些对象时使用该映射来查找对象。
              在处理数据并发访问时，要有一种策略让多个用户共同影响同一个业务实体，这个固然很重要。同样重要的是，单个用户在一个长运行事务或复杂事务中始终使用业务实体的一致版本。
              Identity Map模式提供的功能；为事务中使用所有的业务对象均保存一个版本，如果一个实体被请求两次，返回同一个实体。
　　              每个业务事务使用一个Identity Map，可以确保如果在同一个事务中两次检索同一个实体，则该实体将是唯一的，而且包含该事务所做的任何修改。
             */
        }
    }
}
