using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Challenge___Reverse_A_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var list1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var list2 = new int[] { 2, 4, 6, 8, 10 };
            var list3 = new int[] { 1, 5, 10, 80, 100 };

            var originalStack = new Stack();
            foreach (var i in list1)
            {
                originalStack.Push(i);
            }

            Console.WriteLine("Contents of Stack (Initial)");
            foreach (var s in originalStack)
            {
                Console.WriteLine(s);
            }


            var tempStack = new Stack();


            var index = 0;


            //initial content
            tempStack.Push(originalStack.Pop());

            while (originalStack.Count != 0)
            {
                var content = (int)originalStack.Pop();
                InsertBottom(tempStack, originalStack, content, index);

                index++;
            }
            
            while (tempStack.Count != 0)
            {
                var content = (int)tempStack.Pop();
                originalStack.Push(content);
            }

            Console.WriteLine("Contents of Stack (final)");
            foreach (var s in originalStack)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }

        private static void InsertBottom(Stack target, Stack temp, int content, int attempts)
        {
            var tempStackIndex = 0;
            do
            {
                var tempContent = (int)target.Pop();
                temp.Push(tempContent);
                tempStackIndex++;

            } while (tempStackIndex <= attempts);

            target.Push(content);

            tempStackIndex = 0;
            do
            {
                target.Push((int)temp.Pop());
                tempStackIndex++;

            } while (tempStackIndex <= attempts);
        }
    }
}
