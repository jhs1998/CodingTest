namespace SortStringsAsDesired
{
    ///<summary>
    ///문제 번호 : 12915
    ///문제 이름 : 문자열 내 마음대로 정렬하기
    ///URL : https://school.programmers.co.kr/learn/courses/30/lessons/12915
    ///</summary>
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] strings = { "sun", "bed", "car" };
            int n = 1;
            Solution solution = new Solution();
            string[] resurts = solution.solution(strings, n);
            for (int i = 0; i < resurts.Length; i++)
            {
                Console.Write($"{resurts[i]} ");
            }           
        }
        // 받아온 배열의 단어들에 n번째 값을 기준으로 오름차순 정리
        public class Solution
        {
            public string[] solution(string[] strings, int n)
            {
                int lon = strings.Length;
                string[] answer = new string[lon];

                for (int i = 0; i < lon; i++)
                {
                    //i번째 answer에 n번째 자리 문자를 더해준다
                    answer[i] = strings[i].Substring(n, 1) + strings[i];
                }
                //문자열 정렬
                Array.Sort(answer);

                for (int i = 0; i < lon; i++)
                {
                    //더해준 가장 앞 문자 삭제
                    answer[i] = answer[i].Remove(0, 1);
                }
                return answer;
            }
        }
    }
}
