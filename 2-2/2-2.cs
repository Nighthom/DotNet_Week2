using System;

namespace _2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("임의의 문자열을 입력하세요: ");
            string input = Console.ReadLine();
            int count = 0;
            // 모음만 모아놓은 문자열
            string vowels = "aeiou";

            foreach(char chr in input)
            {
                // chr이 모음일 경우 vowels에서 해당 문자를 찾을 수 있음.
                if (vowels.Contains(chr))
                    count++;
            }

            Console.WriteLine("임의의 문자열 속 모음의 개수: " + count);
        }
    }
}
