using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /*
     5、桥接模式应用分析
　　    桥接模式可以适用于以下情形：
　　    ◊ 不希望在抽象与实现部分之间有固定的绑定关系；
　　    ◊ 类的抽象以及它的实现都应该可以通过生成子类的方法加以扩充。这时桥接模式可以对不同的抽象接口和实现部分进行组合，并分别对它们进行扩充；
　　    ◊ 对抽象的实现部分进行修改应对客户不产生影响，即客户的代码不必重新编译；
　　    ◊ 想对客户完全隐藏抽象的实现部分；
　　    ◊ 想在多个对象间共享实现，但同时要求客户并不知道这点。

　　    桥接模式具有以下特点：
　　    ◊ 分离接口及其实现部分，一个实现未必不变地绑定在一个接口上。抽象类的实现可以在运行时刻进行配置，一个对象甚至可以在运行时刻改变它的实现；
　　    ◊ 将Abstraction与Implementor分离有助于降低对实现部分编译时刻的依赖性；当改变一个实现类时，并不需要重新编译Abstraction类和Client类。为了保证一个类库的不同版本之间的兼容，需要有这个特性；
　　    ◊ 接口与实现分离有助于分层，从而产生更好的结构化系统。系统的高层部分仅需要知道Abstraction和Implementor即可；
　　    ◊ 提高可扩充性。可以独立的对Abstraction和Implementor层次结构进行扩充；
　　    ◊ 实现细节对Client透明。可以对Client隐藏实现细节，如共享Implementor对象以及相应的引用计数机制。
     */
}
