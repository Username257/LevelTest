using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest
{
    internal class GameUpNDown
    {
        public void Func()
        {
            Random randNum = new Random();
            int com = randNum.Next(0, 10);
            int my = 0;
            int chance = 1;
            string restart = "";

            while (true)
            {
                Console.WriteLine($"{chance} 번째 입력");
                Console.Write("수를 입력 해 주세요(0 ~ 999) : ");
                my = int.Parse(Console.ReadLine());
                if (chance < 10)
                {
                    chance++;
                    if (com < my)
                        Console.WriteLine("더 작습니다.");
                    else if (com > my)
                        Console.WriteLine("더 큽니다.");
                    else
                        break;
                }
                else
                {
                    Console.WriteLine("졌습니다. 재시작 하려면 Y를 입력 해 주세요.");
                    restart = Console.ReadLine();
                    if (restart != "Y")
                    {
                        break;
                    }
                    else
                    {
                        chance = 1;
                    }
                }


            }
            Console.WriteLine("게임이 종료되었습니다.");

        }
    }
}
