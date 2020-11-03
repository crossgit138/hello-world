using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab23
{
    class Cityname
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no. of cities:");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] cities = new string[size];
            Console.WriteLine("enter the city name");

            for (int i=0; i < size;i++)
                {
                cities[i] = Console.ReadLine();
                }
            Console.WriteLine("--cities--");
            foreach(string city in cities)
            {
                Console.WriteLine("\n");
                Console.WriteLine(city);
            }
            Console.ReadLine();
        }
    }
}
