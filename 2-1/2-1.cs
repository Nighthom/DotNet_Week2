using System;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("임의의 정수 하나를 입력하세요: ");
            int input = int.Parse(Console.ReadLine());

            if (input > 0)
                Console.WriteLine(input + "은 양수입니다.");
            else if (input < 0)
                Console.WriteLine(input + "은 음수입니다.");
            else
                Console.WriteLine(input + "은 0입니다.");
        }

    }
}
