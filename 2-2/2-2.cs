﻿using System;

namespace _2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("임의의 문자열을 입력하세요: ");
            string input = Console.ReadLine();
            int count = 0;
            

            foreach(char chr in input)
            {
                
                if (chr == 'a' || chr == 'e' || chr == 'i'
                    || chr == 'o' || chr == 'u')
                    count++;
            }

            Console.WriteLine("임의의 문자열 속 모음의 개수: " + count);
        }
    }
}
