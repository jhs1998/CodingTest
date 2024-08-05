namespace String_Repeated_Output
{
    /// <summary>
    /// 문제 번호 : 181950
    /// 문제 : 문자열 반복해서 출력하기
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/181950
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] hap = str.Split(' ');
            str = hap[0];
            string nstr = hap[1];
            int n;
            bool succes;
            succes = int.TryParse(nstr, out n);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{str}");
            }
        }
    }
}
