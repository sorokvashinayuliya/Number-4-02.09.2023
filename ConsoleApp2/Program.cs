using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите угол в радианах");
            int y = Convert.ToInt32(Console.ReadLine());
            double cosAngle = Math.Cos(y);
            Console.WriteLine("Косинус угла:"+cosAngle);

        }
    }
}
