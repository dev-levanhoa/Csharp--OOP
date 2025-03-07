using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Th2_LeVanHoa_Bai5
{
    // Lớp Stack mô tả ngăn xếp số nguyên
    class Stack
    {
        private int top;
        private int Max;
        private int[] stack;

        public Stack(int size)
        {
            Max = size;
            stack = new int[Max];
            top = -1;
        }

        public void Push(int data)
        {
            if (top >= Max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            stack[++top] = data;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            return stack[top--];
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return stack[top];
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            for (int i = top; i >= 0; i--)
            {
                Console.Write(stack[i] + " ");
            }
            Console.WriteLine();
        }
    }

    // Chương trình chính
    class Program
    {
        static void PrimeFactorization(int number)
        {
            Stack stack = new Stack(100);
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    stack.Push(i);
                    number /= i;
                }
            }
            Console.Write("= ");
            while (!stack.IsEmpty())
            {
                Console.Write(stack.Pop());
                if (!stack.IsEmpty())
                    Console.Write(" * ");
            }
            Console.WriteLine();
        }

        static void ConvertToBinary(int number)
        {
            Stack stack = new Stack(100);
            while (number > 0)
            {
                stack.Push(number % 2);
                number /= 2;
            }
            Console.Write("Binary: ");
            while (!stack.IsEmpty())
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }

        static void ConvertToHexadecimal(int number)
        {
            Stack stack = new Stack(100);
            string hexChars = "0123456789ABCDEF";
            while (number > 0)
            {
                stack.Push(number % 16);
                number /= 16;
            }
            Console.Write("Hexadecimal: ");
            while (!stack.IsEmpty())
            {
                Console.Write(hexChars[stack.Pop()]);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.Write("Nhập một số nguyên: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Phân tích thừa số nguyên tố:");
            PrimeFactorization(number);

            Console.WriteLine("Chuyển đổi sang hệ nhị phân:");
            ConvertToBinary(number);

            Console.WriteLine("Chuyển đổi sang hệ thập lục phân:");
            ConvertToHexadecimal(number);
        }
    }
}
