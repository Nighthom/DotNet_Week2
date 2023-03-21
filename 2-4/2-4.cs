using System;
// Dictionary 사용을 위한 모듈
using System.Collections.Generic;

namespace _2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자열을 입력하세요: ");
            string input = Console.ReadLine();

            // 1. 입력받은 문자열을 공백을 기준으로 나눠서 배열 생성
            string[] words = input.Split(' ');

            // 2. 있는 단어들을 count하기 위한 딕셔너리 정의
            // string: word, int: count.
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            // 3. words 내부의 단어를 쭉 훑으며 
            // 단어 개수를 count함.
            foreach(string word in words)
            {
                if (wordsCount.ContainsKey(word))
                    wordsCount[word]++;
                else
                    wordsCount[word] = 1;
            }

            // 4. wordsCount 딕셔너리 내부를 순회하며 최대 Count값을 갖는
            // 단어를 찾기.
            int maxCount = int.MinValue;
            string maxWord = "";

            foreach(KeyValuePair<string, int> wordCount in wordsCount)
            {
                if(maxCount < wordCount.Value)
                {
                    maxCount = wordCount.Value;
                    maxWord = wordCount.Key;
                }
            }

            // 5. 출력
            Console.WriteLine("가장 많이 사용된 단어: " + maxWord);
            Console.WriteLine("해당 단어가 사용된 횟수: " + maxCount);
        }
    }
}
