using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер файла в байтах");
            int X = Convert.ToInt32(Console.ReadLine());
            X = X / 1024;
            Console.WriteLine("Количество полных килобайтов равно {0}", X);
        }
    }
}
