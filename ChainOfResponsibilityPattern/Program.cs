﻿using ChainOfResponsibilityPattern.Structural;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process request
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }
        }

        /*
         4、职责链模式应用分析

　　        职责链模式适用情形：
　　        1>、可能处理请求的对象集合以及它们在链表中的顺序是由Client根据当前应用的状态在运行时动态决定的；
　　        2>、Client根据状态，对于不同的请求类型，可以拥有不同的可能处理请求的对象集合。一个处理请求的对象也可以根据Client的状态和请求类型，把请求传递给不同的处理对象。
　　        3>、Client初始化请求，或者在不知道这些对象是否能处理这个请求的情况下初始化任何可能处理请求的对象。Client和在处理链表中的处理对象都不需要知道到底哪个对象去处理这个请求。
　　        4>、请求不能保证被处理。在没有处理的情况下，请求已经到达了处理链的表尾。

　　        职责链模式特点：
　　        1>、职责链模式降低了发出命令的对象和处理命令的对象之间的耦合，它允许多于一个的处理者对象根据自己的逻辑来决定哪个处理者最终处理这个命令。
                发出命令的对象只是把命令传给链结构的起始者，而不需要知道到底是链上的哪一个节点处理了这个命令。这样在处理命令上，允许系统由更多的灵活性。
                哪一个对象最终处理一个命令可以由那些对象参加职责链，以及随着这些对象在职责链上的位置不同而不同。
　　        2>、既然一个请求没有明确的接收者，那么就不能保证它一定会被处理。该请求可能一直到链的末端都得不到处理。一个请求也可以因该链没有被正确配置而得不到响应，
                并且处理消息传递和处理不当会出现消息的循环重复执行。
         
         */
    }
}
