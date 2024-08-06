namespace FruitVendor
{
    /// <summary>
    /// 문제 번호 : 135808
    /// 문제 이름 : 과일 장수
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/135808
    /// </summary>
    public class Solution
    {
        public int solution(int k, int m, int[] score)
        {
            int answer = 0;

            Array.Sort(score);

            for (int i = score.Length; i >= m; i -= m)
            {
                answer += m * score[i - m];
            }
                return answer;
        }
    }
}
