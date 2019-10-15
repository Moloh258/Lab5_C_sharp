using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 100 && x > 9)
            {
                int a = x % 10;
                int b = x / 10;
                Console.WriteLine("Полученное число: {0}", x = a * 10 + b);
            }
            else
            {
                Console.WriteLine("Введенное число не является двузначным");
            }
           
        }
    }
}
