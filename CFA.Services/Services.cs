using System;
using System.Collections.Generic;

using System.Text;

namespace CFA.Services
{
    public class Services : IServices
    {
        public int Add(string str)
        {
            int score = 0;
            int stack = 0;
            int p = 0;
            int front_bracket = 0, back_bracket = 0;

            while (p < str.Length)
            {
                if (str[p] == '{')
                {
                    stack += 1;
                    front_bracket += 1;
                }
                else if (str[p] == '}')
                {
                    score += stack;
                    stack -= 1;
                    back_bracket += 1;
                }
                else if (str[p] == '<')
                {
                    p += 1;

                    p = Garbage(str, p);
                }
                p += 1;

            }
            if (front_bracket == back_bracket && p != -1)
            {
                return score;
            }
            return -1;
        }

        public int Garbage(string input, int c)
        {
            int len = input.Length;
            while (input[c] != '>')
            {
                if (c == len)
                {
                    return -2;
                }
                if (input[c] == '!')
                {
                    c += 2;
                    continue;
                }

                c++;
            }
            return c;
        }
    }
}
