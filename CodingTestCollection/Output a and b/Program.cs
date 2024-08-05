namespace Output_a_and_b
{
    /// <summary>
    /// 문제 번호 : 181951
    /// 문제 이름 : a와 b 출력하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/181951
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string ab1 = Console.ReadLine();
            string[] ab2 = ab1.Split(' ');

            Console.WriteLine($"a = {ab2[0]}");
            Console.WriteLine($"b = {ab2[1]}");
        }
    }
}
