using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelTest
{
    internal class FindSameThingInArrays
    {
        public void Func()
        {
            int[] arr1 = { };
            int[] arr2 = { };
            int[] arr3 = {};
            List<int> list = new List<int>();
            int cnt = 0;
            int cntArr = 1;
            int num = 0;
            string str;

            while (true)
            {
                Console.Write($"배열 {cntArr}의 {cnt}번째 방 요소를 입력 해 주세요(그만하기 -> 문자, null 입력) : ");
                str = Console.ReadLine();

                if (int.TryParse(str, out num))
                {
                    list.Add(num);
                    cnt++;
                }
                else
                {
                    cntArr++;
                    cnt = 0;
                }

                if (cntArr == 2 && cnt == 0)
                {
                    Array.Resize(ref arr1, list.Count);
                    arr1 = list.ToArray();
                    list.Clear();
                }

                if (cntArr == 3 && cnt == 0)
                {
                    Array.Resize(ref arr2, list.Count);
                    arr2 = list.ToArray();
                    list.Clear();
                }

                if (cntArr == 4)
                {
                    Array.Resize(ref arr3, list.Count);
                    arr3 = list.ToArray();
                    break;
                }
            }
            list.Clear();
            list = FindCommonItems(arr1, arr2, arr3).ToList();
            Console.WriteLine("결과 :");
            foreach (int i in list)
                Console.WriteLine(i);
        }
            

        static int[] FindCommonItems(int[] arr1, int[] arr2, int[] arr3)
        {
            List<int> list = new List<int>();
            int[] items = { };
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    for (int k = 0; k < arr3.Length; k++)
                    {
                        if (arr1[i] == arr2[j] && arr1[i] == arr3[k])
                        {
                            list.Add(arr1[i]);
                        }
                        
                    }
                }
            }
            list = list.Distinct().ToList();
            Array.Resize(ref items, list.Count);
            items = list.ToArray();
            return items;
        }

        
    }
}
