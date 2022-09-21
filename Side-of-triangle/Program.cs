using static System.Console;
using System;
namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Equi, Iso, sca;

            
            
            Write("Check whether a triangle is Equilateral, Isosceles or Scalene:\n");
            Write("----------------------------------------------------------------");
            Write("\n\n");



            Console.Write("Input side 1 of triangle: ");
             Equi= Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            Iso = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            sca = Convert.ToInt32(Console.ReadLine());



            if (Equi == Iso && Iso == sca)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (Equi == Iso || Equi == sca || Iso == sca)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }

        }
    }
}
