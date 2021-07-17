using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Yakovlev_Tree
{
    public static class StringAndCharExtensions
    {
        public static bool IsOperatorOrBracket(this char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '(' || c == ')') 
                return true;
            else return false;
        }

        public static bool IsMathOperator(this char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/') return true;
            else return false;
        }

        public static bool IsBracket(this char c)
        {
            if (c == '(' || c == ')') return true;
            else return false;
        }

        public static bool IsLetterOrDigit(this char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')
                || (c>='а'&&c<='я') || (c>='А'&&c<='Я'))
                return true;
            else return false;
        }

        public static string GetStringForm(this string s)
        {
            string form = "";

            if (s.Length == 1) form = "infix";
            if (s.Length >= 3)
            {
                if ((s[s.Length - 1].IsLetterOrDigit() && s[s.Length - 2].IsMathOperator()) ||
                    (s[s.Length - 1].IsBracket() && s[s.Length - 2].IsLetterOrDigit()))
                    form = "infix";
                else if (s[s.Length - 1].IsMathOperator() && s[0].IsLetterOrDigit())
                    form = "postfix";
                else if (s[s.Length - 1].IsLetterOrDigit() && s[s.Length - 2].IsLetterOrDigit()
                    && s[0].IsMathOperator())
                    form = "prefix";
            }
            return form;
        }

        public static int GetOperatorPriority(this char c)
        {
            int priority = 0;
            if (c == '*' || c == '/') priority = 2;
            else if (c == '+' || c == '-') priority = 1;
            return priority;
        }

        public static string PostfixToPrefix(this string postfix)
        {
            NodeStack<string> stack = new NodeStack<string>();
            string temp, op1, op2;
            for (int i = 0; i < postfix.Length; i++)
            {
                if (!postfix[i].IsOperatorOrBracket())
                {
                    stack.Push(postfix[i].ToString());
                }
                else
                {
                    op1 = stack.Pop();
                    op2 = stack.Pop();
                    temp = postfix[i].ToString() + op2 + op1;
                    stack.Push(temp);
                }
            }
            return stack.Pop();
        }

        public static string InfixToPrefix(this string infix)
        {
            infix = '(' + infix + ')';
            string postfix = "";
            NodeStack<char> stack = new NodeStack<char>();
            for (int i = 0; i < infix.Length; i++)
            {
                if (infix[i].IsLetterOrDigit()) postfix += infix[i];
                else if (infix[i] == '(') stack.Push(infix[i]);
                else if (infix[i] == ')')
                {
                    while (stack.Peek() != '(')
                    {
                        postfix += stack.Pop();
                    }
                    stack.Pop();
                }
                else
                {
                    if (stack.Peek().IsOperatorOrBracket())
                    {
                        while (GetOperatorPriority(infix[i]) <=
                            GetOperatorPriority(stack.Peek())) postfix += stack.Pop();
                        stack.Push(infix[i]);
                    }
                }
            }
            return postfix.PostfixToPrefix();
        }
    }
}
