﻿using System;

namespace _2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자열을 입력해주세요: ");
            string input = Console.ReadLine();
            // Output 문자열
            string output = "";

            foreach(char chr in input)
            {
                if('A' <= chr)
                {
                    if (chr <= 'Z')
                        output += (char)(chr + 32);
                }
            }

            Console.WriteLine("대문자 -> 소문자 문자열: " + output);
        }
    }
}
