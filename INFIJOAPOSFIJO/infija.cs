﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFIJOAPOSFIJO
{
    class infija
    {
     
            internal static int Prec(char ch)
            {
                switch (ch)
                {
                    case '+':
                    case '-':
                        return 1;

                    case '*':
                    case '/':
                        return 2;

                    case '^':
                        return 3;
                }
                return -1;
            }

            public  string infixToPostfix(string exp)
            {

                string result = "";


                Stack<char> stack = new Stack<char>();

                for (int i = 0; i < exp.Length; ++i)
                {
                    char c = exp[i];


                    if (char.IsLetterOrDigit(c))
                    {
                        result += c;
                    }


                    else if (c == '(')
                    {
                        stack.Push(c);
                    }


                    else if (c == ')')
                    {
                        while (stack.Count > 0 &&
                                stack.Peek() != '(')
                        {
                            result += stack.Pop();
                        }

                        if (stack.Count > 0 && stack.Peek() != '(')
                        {
                            return "Invalid Expression";
                        }
                        else
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        while (stack.Count > 0 && Prec(c) <=
                                          Prec(stack.Peek()))
                        {
                            result += stack.Pop();
                        }
                        stack.Push(c);
                    }

                }


                while (stack.Count > 0)
                {
                    result += stack.Pop();
                }

                return result;
            }


        }
    
}