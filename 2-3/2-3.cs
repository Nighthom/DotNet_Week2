using System;

// 프로그램 제약사항 : 임의의 입력받은 수 n의 범위(0 <= n < 1000)
namespace _2_3
{
    class Program
    {
        const int RANGE = 1000;
        static void Main(string[] args)
        {
            int[] countNums = new int[RANGE];
            Console.Write("입력할 정수의 개수를 입력하세요: ");
            int count = int.Parse(Console.ReadLine());
            int[] nums = new int[count];            

            // 중복 확인할 변수의 목록 입력
            for(int i=0; i<count; i++)
            {
                Console.Write(i+1 + "번째 정수 입력: ");
                nums[i] = int.Parse(Console.ReadLine());

                if(RANGE <= nums[i] || nums[i] < 0)
                {
                    Console.WriteLine("ERROR: 입력값이 범위를 벗어났습니다. " +
                        "다시 입력해주세요.");
                    i--;
                }
            }

            // 수 세기
            foreach (int num in nums)
            {
                countNums[num]++;
            }

            Console.Write("중복되지 않은 수 목록: [ ");
            foreach (int num in nums)
            {
                if (countNums[num] == 1)
                    Console.Write(num + " ");
            }
            Console.Write("]");
        }
    }
}
