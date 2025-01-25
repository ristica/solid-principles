using System;

namespace Ocp_Start
{
    static class Program
    {
        private static void Main()
        {
            Console.WriteLine("### Open Closed Principle => START ###");
            Console.WriteLine("");

            // main class
            var mo = new MathOperations(6, 3);

            // main class' operations 
            Console.WriteLine("{0} + {1} = {2}", mo.X, mo.Y, mo.Add());
            Console.WriteLine("{0} * {1} = {2}", mo.X, mo.Y, mo.Multiply());
            Console.WriteLine("{0} / {1} = {2}", mo.X, mo.Y, mo.Divide());
            Console.WriteLine("{0} - {1} = {2}", mo.X, mo.Y, mo.Subtract());

            Console.WriteLine("");
            Console.WriteLine("### END ###");
            Console.WriteLine("");
            Console.ReadKey();
        }

        #region Main class

        /// <summary>
        /// math class has only one responsibility:
        /// doing some math calculations / operations
        /// and nothing else
        /// BUT: class is not open for extensions because if
        /// there is a need for a new operation the class itself has to be modified!
        /// OCP is broken!!!!!
        /// </summary>
        private sealed class MathOperations
        {
            public int X { get; }
            public int Y { get; }

            public MathOperations(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public int Add()
            {
                return this.X + this.Y;
            }

            public int Multiply()
            {
                return this.X * this.Y;
            }

            public int Divide()
            {
                return this.X / this.Y;
            }

            public decimal Subtract()
            {
                return this.X - this.Y;
            }
        }

        #endregion
    }
}
