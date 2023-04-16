using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest
{
    internal class SlideGame
    {
        enum InputKey { Up, Down, Left, Right, X, None }


        public void Func()
        {
            Console.CursorVisible = false;
            int[,] room = new int[5,5];
            List<int> list = new List<int>();
            
            while (true)
            {
                Random random = new Random();
                int num = random.Next(0, 25);
                list.Add(num);
                list = list.Distinct().ToList();
                if (list.Count == 25)
                    break;
            }

            int cnt = 0;
            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 5; k++)
                {
                    room[j, k] = list[cnt];
                    cnt++;
                }
            }

            int colPoint = 0;
            int rowPoint = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (room[i, j] == 0)
                    {
                        colPoint = i;
                        rowPoint = j;
                    }
                }
            }

            while (true)
            {
                //게임 입력
                InputKey key = GameInput();

                if (key == InputKey.X)
                    break;

                //게임 갱신
                var gameUpdateReturn = GameUpdate(key, colPoint, rowPoint, room);
                room = gameUpdateReturn.room;
                colPoint = gameUpdateReturn.col;
                rowPoint = gameUpdateReturn.row;

                //게임 출력
                GameRender(room, colPoint, rowPoint);
            }
        }
        
        static InputKey GameInput()
        {
            InputKey key;
            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    key = InputKey.Up;
                    break;
                case ConsoleKey.DownArrow:
                    key = InputKey.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    key = InputKey.Left;
                    break;
                case ConsoleKey.RightArrow:
                    key = InputKey.Right;
                    break;
                case ConsoleKey.X:
                    key = InputKey.X;
                    break;
                default:
                    key = InputKey.None;
                    break;
            }
            return key;
        }

        static (int[,] room, int col, int row) GameUpdate(InputKey input, int colPoint, int rowPoint, int[,]room)
        {
            int col = colPoint;
            int row = rowPoint;

            switch (input)
            {
                case InputKey.Up:
                    if (col != 0)
                    {
                        room[col, row] = room[col - 1, row];
                        room[col - 1, row] = 0;
                        col--;
                    }
                    break;
                case InputKey.Down:
                    if (col != 4)
                    {
                        room[col, row] = room[col + 1, row];
                        room[col+ 1, row] = 0;
                        col++;
                    }
                    break;
                case InputKey.Left:
                    if (row != 0)
                    {
                        room[col, row] = room[col, row - 1];
                        room[col, row -1] = 0;
                        row--;
                    }
                    break;
                case InputKey.Right:
                    if (row != 4)
                    {
                        room[col, row] = room[col, row + 1];
                        room[col, row + 1] = 0;
                        row++;
                    }
                    break;
                case InputKey.X:
                    break;
            }

            return (room, col, row);
        }

        static void GameRender(int[,] room, int col, int row)
        {
            Console.Clear();
            Console.WriteLine("0을 움직여 숫자를 차례대로 배열하세요.");
            Console.WriteLine("[X]키로 게임 그만하기\n");
            Console.WriteLine($"현재 위치 : {col + 1}열 {row + 1}행");

            Console.WriteLine("┌───┐┌───┐┌───┐┌───┐┌───┐");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("│");
                if (room[0, i] >= 10)
                {
                    Console.Write(" ");
                    Console.Write(room[0, i]);
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(" ");
                    Console.Write(room[0, i]);
                }
                Console.Write("│");
            }
            Console.WriteLine("");
            Console.WriteLine("└───┘└───┘└───┘└───┘└───┘");
            Console.WriteLine("┌───┐┌───┐┌───┐┌───┐┌───┐");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("│");
                if (room[1, i] >= 10)
                {
                    Console.Write(" ");
                    Console.Write(room[1, i]);
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(" ");
                    Console.Write(room[1, i]);
                }
                Console.Write("│");
            }
            Console.WriteLine("");
            Console.WriteLine("└───┘└───┘└───┘└───┘└───┘");
            Console.WriteLine("┌───┐┌───┐┌───┐┌───┐┌───┐");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("│");
                if (room[2, i] >= 10)
                {
                    Console.Write(" ");
                    Console.Write(room[2, i]);
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(" ");
                    Console.Write(room[2, i]);
                }
                Console.Write("│");
            }
            Console.WriteLine("");
            Console.WriteLine("└───┘└───┘└───┘└───┘└───┘");
            Console.WriteLine("┌───┐┌───┐┌───┐┌───┐┌───┐");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("│");
                if (room[3, i] >= 10)
                {
                    Console.Write(" ");
                    Console.Write(room[3, i]);
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(" ");
                    Console.Write(room[3, i]);
                }
                Console.Write("│");
            }
            Console.WriteLine("");
            Console.WriteLine("└───┘└───┘└───┘└───┘└───┘");
            Console.WriteLine("┌───┐┌───┐┌───┐┌───┐┌───┐");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("│");
                if (room[4, i] >= 10)
                {
                    Console.Write(" ");
                    Console.Write(room[4, i]);
                }
                else
                {
                    Console.Write(" ");
                    Console.Write(" ");
                    Console.Write(room[4, i]);
                }
                Console.Write("│");
            }
            Console.WriteLine("");
            Console.WriteLine("└───┘└───┘└───┘└───┘└───┘");
        }
    }

}
