using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment1_QA
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            bool flag = false;
            


            try
            {

                do
                {



                    Console.WriteLine("Enter the length of the rectangle");
                    length = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the width of the rectangle");
                    width= int.Parse(Console.ReadLine());


                    if (length > 0 && width > 0)
                    {


                        Rectangle rectangle = new Rectangle();

                        Console.WriteLine("The length is " +rectangle.SetLength(length));
                        Console.WriteLine("The width is " +rectangle.SetWidth(width));


                        Console.WriteLine("The Perimeter is " +rectangle.GetPerimeter());
                        Console.WriteLine("The area is "  +rectangle.GetArea());



                    }

                    else {

                        Console.WriteLine("The input is less than zero"); 
                        flag = true; 
                    }



                } while (flag);



            } catch
            {

                throw new Exception("Only Intger Numbers");

            }

            


        }
    }
}
