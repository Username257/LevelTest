using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest
{
    internal class FindWordInString
    {
        public void Func()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            int index = str1.IndexOf(str2);
            Console.Write(index);
        }
    }
}
