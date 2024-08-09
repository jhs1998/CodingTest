namespace FindLargestNumber
{
    ///<summary>
    ///문제 번호 : 120899
    ///문제 이름 : 가장 큰 수 찾기
    ///URL : https://school.programmers.co.kr/learn/courses/30/lessons/120899
    ///</summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8,2,7,9,181,9,98,7,1,4 };
            Solution solution = new Solution ();
            int[] result = solution.solution(array);
            Console.WriteLine($"최댓값 : {result[0]}, 배열의 {result[1]+1}번째");
        }
        public class Solution
        {
            public int[] solution(int[] array)
            {
                int[] answer = new int[2];
                int indexa, indexb = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    indexa = array[i];
                    if (indexb < array[i])
                    {
                        indexb = array[i];
                    }
                }
                indexa = Array.IndexOf(array, indexb);

                answer[0] = indexb;
                answer[1] = indexa;

                return answer;
            }
        }
    }
}
