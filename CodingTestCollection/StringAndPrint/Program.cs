namespace StringAndPrint
{
    /// <summary>
    /// 문제 번호 : 181946
    /// 문제 이름 : 문자열 붙여서 출력하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/181946
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] input;

            Console.Clear();
            input = Console.ReadLine().Split(' ');

            String s1 = input[0];
            String s2 = input[1];

            Console.WriteLine($"{s1 + s2}");
        }
    }
}
