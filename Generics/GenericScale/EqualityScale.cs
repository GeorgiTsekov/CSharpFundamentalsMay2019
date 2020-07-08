using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T> where T : IComparable
    {
        private T Left;
        private T Right;
        public EqualityScale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }

        public bool AreEqual()
        {
            bool result = this.Left.Equals(this.Right);
            return result;
        }

        public void WhichIsHeavier()
        {
            int result = Left.CompareTo(Right);

            if (result == 0)
            {
                Console.WriteLine("Right and left are equal");
            }
            else if (result > 0)
            {
                Console.WriteLine("Left is havier");
            }
            else
            {
                Console.WriteLine("Right is havier");
            }
        }

    }
}
