using System;

namespace HwTwoDotThree
{
    public class ArrayStack : IStack
    {
        private double[] stack;

        public ArrayStack() { stack = new double[0]; }

        public bool IsEmpty() => stack.Length == 0;

        public void Push(double data)
        {
            Array.Resize(ref stack, stack.Length + 1);
            stack[stack.Length - 1] = data;
        }

        public double Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("stack does not exist now");
            }

            var data = stack[stack.Length - 1];
            Array.Resize(ref stack, stack.Length - 1);
            return data;
        }
    }
}