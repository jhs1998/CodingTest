using static System.Net.Mime.MediaTypeNames;

namespace ObtainMedianValue
{
    ///<summary>
    ///문제 번호 : 120811
    ///문제 이름 : 중앙값 구하기
    ///URL : https://school.programmers.co.kr/learn/courses/30/lessons/120811
    ///</summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // 값 입력
            int[] array = { 9, -1, 0, 5, 3 };
            Solution solution = new Solution();
            int result = solution.solution(array);
            Console.WriteLine(result);
        }

        public class Solution
        {
            public int solution(int[] array)
            {
                // 배열을 오름차순으로 정렬
                Array.Sort(array);
                int answer = 0;
                // 배열 을 받아서 길이를 잰뒤 2로 나눠서 그자리 배열 찾기
                int share = array.Length / 2;
                int remain = array.Length % 2;
                if (remain == 1)
                {
                    // array배열의 중앙에 위치란 값을 answer에 입력
                    answer = array[share];
                }
               // 배열이 짝수일 경우 0을 리턴
                else if (remain == 0)                
                    answer = 0;
               // 배열이 1개일 경우 1개 값을 리턴
                else               
                    answer = array[0];
                
                return answer;
            }
        }
    }
}
