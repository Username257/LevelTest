using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int wordsNum = 1;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ')
                {
                    wordsNum++;
                }
            }
            Console.Write(wordsNum);
        }
    }
}

