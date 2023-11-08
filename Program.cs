using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspitZadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite vrijednost prve stranice");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upišite vrijednost prve stranice");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upišite vrijednost prve stranice");
            int z = Convert.ToInt32(Console.ReadLine());
            if (x > 0 && y > 0 && z > 0)
            {
                int x1 = x * x;
                int y1 = y * y;
                int z1 = z * z;
                if (x > y && x > z)
                {
                    if (x1 == (y1 + z1))
                    {
                        Console.WriteLine("Trokut je pravokutan");

                    }
                    else { Console.WriteLine("Trokut nije pravokutan"); }
                }
                if (y > x && y > z)
                {
                    if (y1 == (x1 + z1))
                    {
                        Console.WriteLine("Trokut je pravokutan");

                    }
                    else { Console.WriteLine("Trokut nije pravokutan"); }
                }
                if (z > y && z > x)
                {
                    if (z1 == (y1 + x1))
                    {
                        Console.WriteLine("Trokut je pravokutan");

                    }
                    else { Console.WriteLine("Trokut nije pravokutan"); }
                }
            }
            else { Console.WriteLine("Unesene vrijednosti ne mogu biti manje od nula"); }
            Console.ReadKey();

        }
    }
}
