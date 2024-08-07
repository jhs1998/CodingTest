namespace Additive_Output
{
    /// <summary>
    /// 문제 번호 : 181947
    /// 문제 이름 : 덧셈식 출력하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/181947
    /// </summary>
    internal class Program
    {
        public static void Main()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);

            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}
