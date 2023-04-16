using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest
{
    internal class SumOfDigit
    {
        public void Func()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(SumOfDigits(num));
            
            static int SumOfDigits(int num)
            {
                string str = num.ToString();
                int result = 0;
                int temp = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    temp = int.Parse(str[i].ToString());
                    result += temp;
                }
                return result;
            }

        }
    }
}
