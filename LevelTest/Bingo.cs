using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest
{
    internal class Bingo
    {
        public void Func()
        {
            Console.CursorVisible = true;
            string[,] pan = new string[5, 5];
            List<string> list = new List<string>();

            while (true)
            {
                Random random = new Random();
                string argument = random.Next(1, 26).ToString();
                list.Add(argument);
                list = list.Distinct().ToList();
                if (list.Count == 25)
                    break;
            }

            int cnt = 0;
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    pan[j, k] = list[cnt];
                    cnt++;
                }
            }

            int bingoCnt = 0;
            string numForCheck = null;

            while (true)
            {
                GameRender(pan, bingoCnt);
                Console.Write("\n체크 할 숫자 입력(1 ~ 25) : ");
                numForCheck = Console.ReadLine();

                GameInput(numForCheck, pan);

                bingoCnt = GameUpdate(pan);

                if (bingoCnt == 3)
                {
                    Console.WriteLine("3 빙고를 모두 달성하셨습니다!");
                    break;
                }
                    
            }
        }
        static int GameUpdate(string[,] pan)
        {
            int bingoCnt = 0;

            for(int i = 0; i < 5; i++)
            {
                if (pan[i, 0] == "0" && pan[i, 1] == "0" && pan[i, 2] == "0" && pan[i, 3] == "0" && pan[i, 4] == "0")
                    bingoCnt++;
                if (pan[0, i] == "0" && pan[1, i] == "0" && pan[2, i] == "0" && pan[3, i] == "0" && pan[4, i] == "0")
                    bingoCnt++;
            }

            if (pan[0,0] == "0" && pan[1,1] == "0" && pan[2,2] == "0" && pan[3,3] == "0" && pan[4,4] == "0") //좌측 상단 -> 우측 하단 대각선이 전부 0이면
                bingoCnt++;
            
            if (pan[0, 4] == "0" && pan[1, 3] == "0" && pan[2, 2] == "0" && pan[3, 1] == "0" && pan[4, 0] == "0") //우측 상단 -> 좌측 하단 대각선이 전부 0이면
                bingoCnt++;

            return bingoCnt;
        }
        static void GameInput(string numForCheck, string[,]pan)
        {
            int tryParseResult;
            bool isNum = int.TryParse(numForCheck, out tryParseResult);
            while (string.IsNullOrEmpty(numForCheck) || !isNum || tryParseResult > 25 || tryParseResult < 1)
            {
                Console.Write("1 ~ 25 사이의 숫자만 입력 해 주세요 : ");
                numForCheck = Console.ReadLine();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (pan[i, j] == numForCheck)
                    {
                        pan[i, j] = "0";
                    }
                }
            }
        }
        static void GameRender(string[,] pan, int bingoCnt)
        {
            Console.Clear();
            Console.WriteLine("☆  B I N G O  G A M E  ☆");
            Console.WriteLine($"현재 {bingoCnt}빙고\n\n");

            Console.WriteLine("┌───┐┌───┐┌───┐┌───┐┌───┐");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("│");
                if (int.Parse(pan[0, i]) >= 10)
                {
                    Console.Write(" ");
                    Console.Write(pan[0, i]);
                }
                else if (int.Parse(pan[0,i]) == 0)
                {
                    Console.Write(" ");
                    Console.Write("X");
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(" ");
                    Console.Write(pan[0, i]);
                }
                Console.Write("│");
            }
            Console.WriteLine("");
            Console.WriteLine("└───┘└───┘└───┘└───┘└───┘");
            Console.WriteLine("┌───┐┌───┐┌───┐┌───┐┌───┐");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("│");
                if (int.Parse(pan[1, i]) >= 10)
                {
                    Console.Write(" ");
                    Console.Write(pan[1, i]);
                }
                else if (int.Parse(pan[1, i]) == 0)
                {
                    Console.Write(" ");
                    Console.Write("X");
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(" ");
                    Console.Write(pan[1, i]);
                }
                Console.Write("│");
            }
            Console.WriteLine("");
            Console.WriteLine("└───┘└───┘└───┘└───┘└───┘");
            Console.WriteLine("┌───┐┌───┐┌───┐┌───┐┌───┐");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("│");
                if (int.Parse(pan[2, i]) >= 10)
                {
                    Console.Write(" ");
                    Console.Write(pan[2, i]);
                }
                else if (int.Parse(pan[2, i]) == 0)
                {
                    Console.Write(" ");
                    Console.Write("X");
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(" ");
                    Console.Write(pan[2, i]);
                }
                Console.Write("│");
            }
            Console.WriteLine("");
            Console.WriteLine("└───┘└───┘└───┘└───┘└───┘");
            Console.WriteLine("┌───┐┌───┐┌───┐┌───┐┌───┐");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("│");
                if (int.Parse(pan[3, i]) >= 10)
                {
                    Console.Write(" ");
                    Console.Write(pan[3, i]);
                }
                else if (int.Parse(pan[3, i]) == 0)
                {
                    Console.Write(" ");
                    Console.Write("X");
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(" ");
                    Console.Write(pan[3, i]);
                }
                Console.Write("│");
            }
            Console.WriteLine("");
            Console.WriteLine("└───┘└───┘└───┘└───┘└───┘");
            Console.WriteLine("┌───┐┌───┐┌───┐┌───┐┌───┐");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("│");
                if (int.Parse(pan[4, i]) >= 10)
                {
                    Console.Write(" ");
                    Console.Write(pan[4, i]);
                }
                else if (int.Parse(pan[4, i]) == 0)
                {
                    Console.Write(" ");
                    Console.Write("X");
                    Console.Write(" ");
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(" ");
                    Console.Write(pan[4, i]);
                }
                Console.Write("│");
            }
            Console.WriteLine("");
            Console.WriteLine("└───┘└───┘└───┘└───┘└───┘");
        }
    }
}
