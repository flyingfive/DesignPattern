using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Practical.IntrinsicIterator
{
    /// <summary>
    /// 定义一个迭代器接口-内禀迭代器
    /// </summary>
    public interface Iterator
    {
        /// <summary>
        /// 迭代器定位到聚合的第一个元素
        /// </summary>
        void First();

        /// <summary>
        /// 遍历下一个
        /// </summary>
        void Next();

        /// <summary>
        /// 判断是否完成遍历
        /// </summary>
        /// <returns></returns>
        bool IsDone();

        /// <summary>
        /// 获得当前遍历的项
        /// </summary>
        /// <returns></returns>
        object CurrentItem();
    }

    /// <summary>
    /// 定义一个抽象的聚合类
    /// </summary>
    public abstract class Aggregate
    {
        /// <summary>
        /// 只有一个功能，创建迭代器
        /// </summary>
        /// <returns></returns>
        public virtual Iterator CreateIterator()
        {
            return null;
        }
    }

    /// <summary>
    /// 定义一个具体的聚合类
    /// </summary>
    public class ConcreteAggregate : Aggregate
    {
        // 存储元素的集合
        private static object[] objs = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        /// <summary>
        /// 定义具体的迭代器类
        /// </summary>
        private class ConcreteIterator : Iterator
        {
            private int _index = 0;

            public void First()
            {
                _index = 0;
            }

            public void Next()
            {
                if (_index < objs.Length)
                {
                    _index++;
                }
            }

            public bool IsDone()
            {
                return _index == objs.Length;
            }

            public object CurrentItem()
            {
                return objs[_index];
            }
        }

        /// <summary>
        /// 获得元素个数
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            return objs.Length;
        }

        /// <summary>
        /// 获取指定序号的元素
        /// </summary>
        /// <param name="index">指定的序号</param>
        /// <returns></returns>
        public object GetElement(int index)
        {
            if (index < 0 || index > objs.Length)
            {
                return null;
            }

            return objs[index];
        }

        /// <summary>
        /// 创建该聚合类的迭代器
        /// </summary>
        /// <returns></returns>
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator();
        }
    }
    public class Client
    {
        private Iterator _iterator;
        private Aggregate _aggregate = new ConcreteAggregate();

        public void Operation()
        {
            // 获得迭代器
            _iterator = _aggregate.CreateIterator();

            while (!_iterator.IsDone())
            {
                Console.WriteLine(_iterator.CurrentItem());
                _iterator.Next();
            }
        }

        static void Main(string[] args)
        {
            Client client = new Client();
            client.Operation();
        }
    }
}
