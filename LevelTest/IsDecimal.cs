using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest
{
    internal class IsDecimal
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(IsPrime(n));
        }
        static bool IsPrime(int n)
        {
            if (n % 1 == 0 || n % 3 == 0 || n % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
