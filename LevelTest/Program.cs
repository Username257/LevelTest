namespace LevelTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //문자열 속에 문자 찾기
            Console.WriteLine("문자열 속에 문자 찾기");
            FindWordInString FWIS = new FindWordInString();
            FWIS.Func();

            //문자열을 입력받으면 단어의 갯수를 출력하기
            Console.WriteLine("\n\n문자열을 입력받으면 단어의 갯수를 출력하기");
            InputStringPrintWordNum ISPWN = new InputStringPrintWordNum();
            ISPWN.Func();

            //주어진 숫자가 소수인지 판별하는 solution을 완성하라.
            Console.WriteLine("\n\n주어진 숫자가 소수인지 판별하는 solution을 완성하라");
            IsDecimal ID = new IsDecimal();
            ID.Func();

            //사용자가 입력한 양의 정수의 각 자리수의 합을 구하는 solution을 완성하라
            Console.WriteLine("\n\n사용자가 입력한 양의 정수인 각 자리수의 합을 구하는 solution을 완성하라");
            SumOfDigit SOD = new SumOfDigit();
            SOD.Func();
            
            //k개의 정렬된 배열에서 공통항목을 찾는 Solution을 완성하라. 단, 중복X
            Console.WriteLine("\n\nk개의 정렬된 배열에서 공통항목을 찾는 Solution을 완성하라. 단, 중복X");
            FindSameThingInArrays FSTIA = new FindSameThingInArrays();
            FSTIA.Func();
            
            //Up & Down 게임 만들기
            Console.WriteLine("\n\nUp & Down 게임 만들기");
            GameUpNDown GUND = new GameUpNDown();
            GUND.Func();
            
        }
    }
}