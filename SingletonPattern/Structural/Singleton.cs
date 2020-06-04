using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern.Structural
{
    /// <summary>
    /// 单例模式实现方式：由于该实现方式非线程安全，在实际应用中不推荐使用。
    /// </summary>
    public sealed class Singleton
    {
        // 定义一个静态变量来保存类的实例
        private static Singleton _instance;

        // 私有构造函数，防止通过new实例化对象
        private Singleton()
        {
        }

        /// <summary>
        /// 定义公有静态方法，获取实例，并加入判断，保证实例只被创建一次
        /// </summary>
        /// <returns></returns>
        public static Singleton Instance()
        {
            // 使用延迟初始化
            // 若类的实例不存在则创建实例，若存在则返回实例
            // 注: 非线程安全
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }


    /// <summary>
    /// 单例模式实现方式：由于该实现方式非线程安全，在实际应用中不推荐使用。
    /// </summary>
    public sealed class Singleton2
    {
        // 定义一个静态变量来保存类的实例
        private static Singleton2 _instance;

        // 私有构造函数，防止通过new实例化对象
        private Singleton2()
        {
        }

        /// <summary>
        /// 定义公有静态方法，获取实例，并加入判断，保证实例只被创建一次
        /// </summary>
        /// <returns></returns>
        public static Singleton2 Instance()
        {
            // 使用延迟初始化
            // 若类的实例不存在则创建实例，若存在则返回实例
            // 注: 非线程安全
            if (_instance == null)
            {
                Thread.Sleep(1000); // 模拟线程阻塞
                _instance = new Singleton2();
            }

            return _instance;
        }
    }

    /// <summary>
    /// 单例模式实现方式：简单线程安全。
    /// </summary>
    public sealed class Singleton3
    {
        // 定义一个静态变量来保存类的实例
        private static Singleton3 _instance;

        // 定义一个标识确保线程同步
        private static readonly object _syncLock = new object();

        // 私有构造函数，防止通过new实例化对象
        private Singleton3()
        {
        }

        /// <summary>
        /// 定义公有静态方法，获取实例，并加入判断，保证实例只被创建一次
        /// </summary>
        /// <returns></returns>
        public static Singleton3 Instance()
        {
            // 当第一个线程运行到这里时，此时会对_syncLock对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到_syncLock对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            lock (_syncLock)
            {
                // 使用延迟初始化
                // 若类的实例不存在则创建实例，若存在则返回实例
                if (_instance == null)
                {
                    _instance = new Singleton3();
                }
            }

            return _instance;
        }
    }

    /// <summary>
    /// 单例模式实现方式：双重锁定线程安全。
    /// </summary>
    public sealed class Singleton4
    {
        // 定义一个静态变量来保存类的实例
        private static Singleton4 _instance;

        // 定义一个标识确保线程同步
        private static readonly object _syncLock = new object();

        // 私有构造函数，防止通过new实例化对象
        private Singleton4()
        {
        }

        /// <summary>
        /// 定义公有静态方法，获取实例，并加入判断，保证实例只被创建一次
        /// </summary>
        /// <returns></returns>
        public static Singleton4 Instance()
        {
            // 当第一个线程运行到这里时，此时会对_syncLock对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到_syncLock对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            // 双重锁定只需要一句判断即可
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    // 使用延迟初始化
                    // 若类的实例不存在则创建实例，若存在则返回实例
                    if (_instance == null)
                    {
                        _instance = new Singleton4();
                    }
                }
            }

            return _instance;
        }
    }
}
