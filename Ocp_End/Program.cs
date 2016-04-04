using System;

namespace Ocp_End
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
            Console.WriteLine("{0} + {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a + b));
            Console.WriteLine("{0} * {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a * b));
            Console.WriteLine("{0} / {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a / b));
            Console.WriteLine("{0} - {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a - b));

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
        /// </summary>
        class MathOperations
        {
            public int X { get; set; }
            public int Y { get; set; }

            // class is open for extensions but closed for modifications!!!
            public decimal Calculate(Func<int, int, decimal> mathFunction)
            {
                return mathFunction(this.X, this.Y);
            }
        }

        #endregion
    }
}
