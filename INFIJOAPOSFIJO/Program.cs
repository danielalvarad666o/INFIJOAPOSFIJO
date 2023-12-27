using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFIJOAPOSFIJO
{
    class Program
    {

        public class Test
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

            public static string infixToPostfix(string exp)
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
                            return "Expression no valida";
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





            //-----------------------------------------------------------------------------------------
            
            public static void Main(string[] args)
            {
                menu elmanu = new menu();
                string exp = "";
                int option;
                do
                {
                    option = elmanu.menus();
                    
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Escribe la operacion infija por favor :D");
                            exp = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("LA EXPRECION POSFIJA ES: " + infixToPostfix(exp));
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Alumno: JESUS DANIEL GASCA ALVARADO 4°B");
                            Console.ReadKey();
                            break;
                    }
                } while (option != 3);
            }
        }
    }
}
            
            
            
      