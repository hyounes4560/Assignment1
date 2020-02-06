using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_QA
{
    class Rectangle
    {

        private int length;
        private int width;

        //public int Length { get => length; set => length = value; }
        //public int Width { get => width; set => width = value; }

        public Rectangle() {

            this.length = 1;

            this.width = 1;
        }

        public Rectangle(int lengthInput, int widthInput)
        {

            this.length = lengthInput;
            this.width = widthInput; 

        }

        public int GetLength()
        {

            return this.length; 


        }
        public int SetLength(int length)
        {

            this.length = length;
            return length; 

        }
        public int GetWidth()
        {
            return this.width;

        }
        public int SetWidth(int width)
        {
            this.width = width;
            return width; 


        }
        public int GetPerimeter()
        {
            int perimeter = 2 * (length + width);
            return perimeter;

        }
        public int GetArea()
        {

            int area = length * width;
            return area;

        }





    }
}
