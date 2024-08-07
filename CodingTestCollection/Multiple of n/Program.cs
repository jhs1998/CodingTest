namespace Multiple_of_n
{
    /// <summary>
    /// 문제 번호 : 181937
    /// 문제 이름 : n의 배수
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/181937
    /// </summary>
    /// 
    public class Solution
    {
        public int solution(int num, int n)
        {
            if (num % n == 0)            
                return 1;           
            else            
                return 0;           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int num = Int32.Parse(s[0]);
            int n = Int32.Parse(s[1]);
            Solution answer = new Solution();
            int result = answer.solution(num, n);

            Console.WriteLine(result);
        }
    }
}
