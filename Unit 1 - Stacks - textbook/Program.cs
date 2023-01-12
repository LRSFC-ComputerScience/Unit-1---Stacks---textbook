using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Unit_1___Stacks___textbook
{
    internal class Program
    {

        static void showStack(Stack stackToView)
        {
            // show the stack
            Console.WriteLine("Current stack - Number of items: {0}", stackToView.Count);
            foreach (char ch in stackToView)
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine("\n"); // Escape character \n for new line
        }

        static void Main(string[] args)
        {

            char data;                  // single item stack data
            Stack st = new Stack();     // 

            // push onto stack
            st.Push('A');
            st.Push('B');
            st.Push('C');

            // calling PROCEDURE to view stack
            showStack(st);

            // remove from stack top - it should be a "C"
            data = (char)st.Pop();
            Console.WriteLine("The popped value: {0}", data);

            // calling PROCEDURE to view stack
            showStack(st);

            st.Push('D');

            // calling PROCEDURE to view stack
            showStack(st);

            Console.ReadLine();

        }
    }
}
