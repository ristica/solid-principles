using System;

namespace Ocp_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Open Closed Principle => START ###");
            Console.WriteLine("");

            // main class
            var mo = new MathOperations { X = 6, Y = 3 };

            // main class' operations 
            Console.WriteLine("{0} + {1} = {2}", mo.X, mo.Y, mo.Add());
            Console.WriteLine("{0} * {1} = {2}", mo.X, mo.Y, mo.Multiply());
            Console.WriteLine("{0} / {1} = {2}", mo.X, mo.Y, mo.Divide());
            Console.WriteLine("{0} - {1} = {2}", mo.X, mo.Y, mo.Substract());

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
        /// BUT: class is not open for extensions bescause if
        /// there is a need for new calculation's art the class has 
        /// to be modified itself! OCP is broken!!!!!
        /// </summary>
        class MathOperations
        {
            public int X { get; set; }
            public int Y { get; set; }

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

            public decimal Substract()
            {
                return this.X - this.Y;
            }
        }

        #endregion
    }
}
