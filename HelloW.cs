using HelloWorldProject;
using System;
using System.Diagnostics.Metrics;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;

namespace HWNS
{
    public delegate int StringFuncDelDT(string s);
    class employee
    {
        int id;
        string name;
        long phoneNumber;

        public employee(int id, string name, long pn)
        {
            this.id = id;
            this.name = name;
            phoneNumber = pn;
        }

        public long this[int id, string name]
        {
            get
            {
                if (this.id == id && this.name == name)
                    return phoneNumber;
                return -1;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public string this[int id, long pn]
        {
            get
            {
                if (this.id == id && this.phoneNumber == pn)
                    return name;
                return "Not Valid";
            }
            set
            {
                name = value;
            }
        }

        public int this[string name, long pn]
        {
            get
            {
                if (this.name == name && this.phoneNumber == pn)
                    return this.id;
                return -1;
            }
            set
            {
                id = value;
            }
        }


    }

    class stringFunctions
    {
        public char ch;

        public static int CountUpperCase(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
                if (char.IsUpper(s[i])) count++;
            return count;
        }
        public static int getLengh(string s)
        {
            return s.Length;
        }

        public static int FullName(string fName, string lName)
        {
            return fName.Length + lName.Length;
        }

        public int CountChar(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ch) count++;
            }
            return count;
        }

    }



    class Program
    {
        /*
         * public static int prec(char c)
        {
            if (c == '^')
                return 3;
            else if (c == '/' || c == '*')
                return 2;
            else if (c == '+' || c == '-')
                return 1;
            else
                return -1;
        }
        public static string infixToPostfix(string expression)
        {
            Stack<char> st = new Stack<char>();
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
                {
                    sb.Append(c);
                }
                else if (c == '(')
                {
                    st.Push(c);
                }
                else if (c == ')')
                {
                    while (st.Peek() != '(')
                    {
                        sb.Append(st.Peek());
                        st.Pop();
                    }
                    st.Pop();
                }
                else
                {
                    while (st.Count > 0 && prec(c) <= prec(st.Peek()))
                    {
                        sb.Append(st.Peek());
                        st.Pop();
                    }
                    st.Push(c);
                }
            }

            while (st.Count > 0)
            {
                sb.Append(st.Peek());
                st.Pop();
            }
            string res = sb.ToString();
            return res;
        }
         */
        public static void Main()
        {
            BSTree bSTree = new BSTree();
            bSTree.insert(7);
            bSTree.insert(4);
            bSTree.insert(3);
            bSTree.insert(9);
            bSTree.insert(8);
            Console.WriteLine("before deleting 9: ");
            bSTree.printBST();
            Console.WriteLine("-----------------------");
            bSTree.delete(9);
            Console.WriteLine("after deleting 9");
            bSTree.printBST();

        }

    }
}

            

       