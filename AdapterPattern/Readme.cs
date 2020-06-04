using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /*
     
         5、适配器模式应用分析
　　        适配器模式适用情形：
　　        ◊ 当适用一个已存在的类，而它的接口不符合所要求的情况；
　　        ◊ 想要创建一个可以复用的类，该类可以与原接口的类协调工作；
　　        ◊ 在对象适配中，当要匹配数个子类的时候，对象适配器可以适配它们的父类接口。

 　      适配器模式特点：
　　        类适配器
　　        ◊ 使得Adapter可以重定义Adaptee的部分行为。因为Adapter是Adaptee的一个子类；
　　        ◊ 仅仅引入了一个对象，并不需要额外的指针间接得到Adaptee。

　　        对象适配器
　　        ◊ 允许一个Adapter与多个Adaptee同时工作。Adapter也可以一次给所有的Adaptee添加功能；
　　        ◊ 使得重定义Adaptee的行为比较困难。需要生成一个Adaptee的子类，然后使Adapter引入这个子类而不是引用Adaptee本身。
  
     */
}
