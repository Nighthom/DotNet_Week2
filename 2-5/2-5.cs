using System;

namespace _2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("입력할 정수의 개수를 입력하세요: ");
            int count = int.Parse(Console.ReadLine());
            int[] nums = new int[count];

            // 변수 목록 입력
            for (int i = 0; i < count; i++)
            {
                Console.Write(i + 1 + "번째 정수 입력: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            // 입력값을 정렬한다. (선택 정렬 사용)
            // O(n^2)
            for(int firstIdx = 0; firstIdx < count; firstIdx++)
            {
                
                int minIdx = firstIdx;

                // 최소값이 담겨있는 Idx 탐색
                for(int secondIdx = firstIdx + 1; secondIdx < count; secondIdx++)
                {
                    if (nums[secondIdx] < nums[minIdx])
                    {
                        minIdx = secondIdx;
                    }
                }

                // firstIdx부터 count - 1까지의 배열 중 최소값이 있는 위치를
                // firstIdx와 바꿔준다.
                int temp = nums[firstIdx];
                nums[firstIdx] = nums[minIdx];
                nums[minIdx] = temp;
            }

            // 정렬이 끝난 배열을 출력한다.
            Console.Write("정렬 완료된 배열: ");
            Console.Write("[ ");
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.Write("]");
        }
    }
}
