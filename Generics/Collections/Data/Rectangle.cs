using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Collections.Data
{
    class Rectangle
    {
        private int width, length;

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public int Length
        {
            get { return this.length; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(Length), "Can not be zero or negative");
                else this.length = value;
            }
        }

        public Rectangle(){ }
        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;
           
        }
    }

}

