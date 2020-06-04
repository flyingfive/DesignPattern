using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Practical
{
    /// <summary>
    /// The 'Prototype' abstract class
    /// </summary>
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype Clone();
    }

    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    public class Color : ColorPrototype
    {
        private int _red;
        private int _green;
        private int _blue;

        /// <summary>
        /// Constructor
        /// </summary>
        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        /// <summary>
        /// Create a shallow copy
        /// </summary>
        public override ColorPrototype Clone()
        {
            Console.WriteLine("Cloning color RGB: {0,3},{1,3},{2,3}", _red, _green, _blue);
            return this.MemberwiseClone() as ColorPrototype;
        }
    }

    /// <summary>
    /// Prototype manager
    /// </summary>
    public class ColorManager
    {
        private Dictionary<string, ColorPrototype> _colors = new Dictionary<string, ColorPrototype>();

        /// <summary>
        /// Indexer
        /// </summary>
        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors.Add(key, value); }
        }
    }
}
