using System;

namespace 실습_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이진법으로 전환할 십진수 숫자를 입력해주세요: ");
            int input = int.Parse(Console.ReadLine());
            string binary = "";
            while (input > 0)
            {
                // 현재 수를 2로 나눈 나머지를 binary의 앞에 붙인다.
                int remainder = input % 2;
                binary = remainder.ToString() + binary;
                input /= 2;
            }
            Console.Write("이진수 표기: " + binary);
        }
    }
}