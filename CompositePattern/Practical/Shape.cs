using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Practical
{
    public abstract class Shape
    {
        protected string _name;

        public Shape(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// 面积
        /// </summary>
        /// <returns></returns>
        public abstract double Area();

        /// <summary>
        /// 显示
        /// </summary>
        public abstract void Display();
    }

    /// <summary>
    /// 圆形
    /// </summary>
    public class Circle : Shape
    {
        private double _radius;

        public Circle(string name, double radius)
            : base(name)
        {
            this._radius = radius;
        }

        public override double Area()
        {
            return Math.Round(Math.PI * _radius * _radius, 2);
        }

        public override void Display()
        {
            Console.WriteLine("{0} 半径：{1}，面积：{2}", _name, _radius, this.Area());
        }
    }

    /// <summary>
    /// 矩形
    /// </summary>
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public Rectangle(string name, double width, double height)
            : base(name)
        {
            this._width = width;
            this._height = height;
        }

        public override double Area()
        {
            return _width * _height;
        }

        public override void Display()
        {
            Console.WriteLine("{0} 长：{1}，宽：{2}，面积：{3}", _name, _width, _height, this.Area());
        }
    }

    /// <summary>
    /// 三角形
    /// </summary>
    public class Triangle : Shape
    {
        private double _a;
        private double _b;
        private double _c;

        /// <summary>
        /// 三角形构造函数
        /// 参数：三角形名称和三条边长
        /// </summary>
        /// <param name="name">三角形名称</param>
        /// <param name="a">第一条边长</param>
        /// <param name="b">第二条边长</param>
        /// <param name="c">第三条边长</param>
        public Triangle(string name, double a, double b, double c)
            : base(name)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public override double Area()
        {
            double p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public override void Display()
        {
            Console.WriteLine("{0} 三条边长：{1}，{2}，{3},面积：{3}", _name, _a, _b, _c, this.Area());
        }
    }

    public class Graphics : Shape
    {
        private List<Shape> _children = new List<Shape>();

        public Graphics(string name)
            : base(name)
        { }

        public override double Area()
        {
            double sum = 0;
            foreach (Shape child in _children)
            {
                sum += child.Area();
            }
            return sum;
        }

        public override void Display()
        {
            foreach (Shape child in _children)
            {
                child.Display();
            }

            Console.WriteLine("{0} 总面积：{1}", _name, this.Area());
        }

        public void Add(Shape child)
        {
            _children.Add(child);
        }

        public void Remove(Shape child)
        {
            _children.Remove(child);
        }
    }

    public class Client
    {
        static void Main(string[] args)
        {
            Graphics graphics = new Graphics("全部图形");

            Circle circle = new Circle("圆形", 5);
            graphics.Add(circle);

            Rectangle rectangle = new Rectangle("矩形", 4, 5);
            graphics.Add(rectangle);

            Triangle triangle = new Triangle("三角形", 3, 4, 5);
            graphics.Add(triangle);

            graphics.Display();
        }
    }
}
