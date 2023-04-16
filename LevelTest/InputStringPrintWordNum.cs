using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest
{
    internal class InputStringPrintWordNum
    {
        public void Func()
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

