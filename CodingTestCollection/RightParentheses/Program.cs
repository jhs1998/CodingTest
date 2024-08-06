namespace RightParentheses
{
    /// <summary>
    /// 문제 번호 : 12909
    /// 문제 이름 : 올바른 괄호
    /// URL : https://school.programmers.co.kr/learn/courses/30/lessons/12909
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();

            Console.WriteLine("괄호를 입력해 주세요");
            string input = Console.ReadLine();

            bool succes = true;
            foreach (char bracket in input)
            {
                switch (bracket)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(bracket);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (stack.Count == 0)
                        {
                            succes = false;
                            break;
                        }
                        char brackets = stack.Pop();
                        if (cheak(brackets, bracket) == false)
                        {
                            succes = false;
                            break;
                        }
                        break;
                }
                if (succes == false)
                {
                    break;
                }
            }
            if (stack.Count > 0)
            {
                succes = false;
            }
            if (succes == true)
            {
                Console.WriteLine("성공");
            }
            else
            {
                Console.WriteLine("실패");
            }
        }

        static bool cheak(char op, char cr)
        {
            return (op == '(' && cr == ')') ||
                   (op == '{' && cr == '}') ||
                   (op == '[' && cr == ']');
        }
    }
}

