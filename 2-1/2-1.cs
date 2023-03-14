using System;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("임의의 정수 하나를 입력하세요: ");
            int input = int.Parse(Console.ReadLine());

            string output = input > 0 ? "양수" :  // 0 이상인 경우 양수
                (input < 0 ? "음수" : "0");       // 미만인 경우 음수
                                                 // 둘 모두 아니면 0
            Console.WriteLine("실행 결과");
            Console.WriteLine("입력한 값은 " + output + "입니다.");
        }

    }
}
