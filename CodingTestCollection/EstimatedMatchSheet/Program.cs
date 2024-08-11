namespace OddEvenDistinction
{
    ///<summary>
    ///문제 번호 : 181944
    ///문제 이름 : 홀짝 구분하기
    ///URL : https://school.programmers.co.kr/learn/courses/30/lessons/181944
    ///</summary>
    public class Example
    {
        public static void Main()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);

            if (a % 2 == 1)
            {
                Console.WriteLine($"{a} is odd");
            }
            else if (a % 2 == 0)
            {
                Console.WriteLine($"{a} is even");
            }
        }
    }
}
