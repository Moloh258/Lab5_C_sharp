using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа A и В");
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            A = A / B;
            Console.WriteLine("Ответ: {0}", A);
        }
    }
}
