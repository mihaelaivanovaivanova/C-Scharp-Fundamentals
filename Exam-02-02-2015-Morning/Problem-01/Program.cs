using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            int totalSheets = n * s;
            double numberPacks = totalSheets /500.0;
            double savedMoney = numberPacks * p;
            Console.WriteLine("{0:F2}",savedMoney );
        }
    }
}
