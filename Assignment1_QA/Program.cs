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
            string option;
            string lengthString;
            string widthString;
            bool flag;


            //Rectangle Object
            Rectangle rectangle = new Rectangle();


            try
            {
                //Accepting only positive integers for length & width 
               do
                    {

                        Console.WriteLine("Please enter the length of the rectangle");
                        lengthString = Console.ReadLine();                                             

                    } while ((!int.TryParse(lengthString, out length) || length < 1));

                    
                    do
                    {

                        Console.WriteLine("Please enter the width of the rectangle");
                        widthString = Console.ReadLine();

                    } while ((!int.TryParse(widthString, out width) || width < 1));



                do
                {

                    do {
                        Console.WriteLine("\nChoose one option for the following menu:");
                        Console.WriteLine("1.Get Rectangle Length\n" +
                                            "2.Change Rectangle Length\n" +
                                            "3.Get Rectangle Width\n" +
                                            "4.Change Rectangle Width\n" +
                                            "5.Get Rectangle Perimeter\n" +
                                            "6.Get Rectangle Area\n" +
                                            "7.Exit\n");

                        option = Console.ReadLine();

                    } while (!int.TryParse(option, out int userOption) || (userOption < 1 || userOption > 7));
                    
                    //to keep showing the main menu 
                    flag = true;                    

                    switch (option)
                    {
                        case "1":

                            Console.WriteLine("The length is " + rectangle.GetLength());
                            Console.ReadLine();
                            break;

                        case "2":
                            Console.WriteLine("The new length is " + rectangle.SetLength(length));
                            Console.ReadLine();
                            break;

                        case "3":
                            Console.WriteLine("The width is " + rectangle.GetWidth());
                            Console.ReadLine();
                            break;

                        case "4":
                            Console.WriteLine("The new width is " + rectangle.SetWidth(width));
                            Console.ReadLine();
                            break;

                        case "5":
                            Console.WriteLine("The Rectangle Perimete is " + rectangle.GetPerimeter());
                            Console.ReadLine();
                            break;

                        case "6":
                            Console.WriteLine("The Rectangle Area is " + rectangle.GetArea());
                            Console.ReadLine();
                            break;

                        case "7":
                            Console.WriteLine("Sorry to see you leave! GoodBye....");

                            //to stop showing the main menu and exit the application
                            flag = false;
                            break;
                            
                        default:
                            Console.WriteLine("Something went wrong");
                            break;

                    }
                } while (flag);


            } catch (Exception)
                {
                    
                    Console.WriteLine("Something went wrong");
                    Console.ReadLine();

                }

           

        }
        
    }
}
