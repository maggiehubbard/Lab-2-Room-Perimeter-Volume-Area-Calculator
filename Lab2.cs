using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {

        static double getArea(double l, double w)
        {
            double a;
            a = l * w;
            return a;

        }
        static double getVolume(double l, double w, double h) 
        {
            double p = l * w * h;
            return p;
        }

        static double getPerimeter(double w, double l)
        {
            double p;
            p = 2 * (l + w);
            return p;
        }
        static void Main(string[] args)
        {
            //declare variables:
            double length;
            double width;
            double height;
            double volume;
            double area;
            double perimeter;
            int answer = 1;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Genorator!");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\n");


            while (answer != 2){
            //user prompts

            Console.Write("Enter length: ");
            length = Convert.ToDouble(Console.ReadLine());
            while (length <= 0)
            {
                Console.WriteLine("Error: The number entered is negative.");
                Console.Write("Enter length: ");
                length = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Enter width: ");
            width = Convert.ToDouble(Console.ReadLine());

            while (width <= 0)
            {
                Console.Write("Error: The number entered is negative.");
                Console.Write("Enter width: ");
                width = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());

            while (height <= 0)
            {
                Console.Write("Error: The number entered is negative.");
                Console.Write("Enter height: ");
                height = Convert.ToDouble(Console.ReadLine());
            }

            //calls area and perimeter methods
            area = getArea(length, width);
            perimeter = getPerimeter(length, width);
            volume = getVolume(length, width, height);

            //output displays area, perimeter & volume
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
            Console.WriteLine("Volume: " + volume);

            //
            Console.WriteLine("Do you want to contine? (yes - 1 /no - 2)");
            answer = Convert.ToInt32(Console.ReadLine());
            if (answer != 1 && answer != 2)
            {
                Console.WriteLine("Invalid input. PLease try again." );
                Console.WriteLine("Do you want to contine? (yes - 1 /no - 2)");
                answer = Convert.ToInt32(Console.ReadLine());
            }



           }

            //pauses before application close
            Console.Write("\n\n Press any key to exit. . ");
            Console.ReadKey();




            /*
                     maggie was here :P
             */

        }
    }
}
