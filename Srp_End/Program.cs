using System;

namespace Srp_End
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("### Single Responsibility Principle => START ###");
            Console.WriteLine("");

            var mo = new MathOperations(6, 3);

            Console.WriteLine("{0} + {1} = {2}", mo.X, mo.Y, mo.Add());
            Console.WriteLine("{0} * {1} = {2}", mo.X, mo.Y, mo.Multiply());
            Console.WriteLine("{0} / {1} = {2}", mo.X, mo.Y, mo.Divide());
            Console.WriteLine("{0} - {1} = {2}", mo.X, mo.Y, mo.Subtract());
            Console.WriteLine("");

            // main class' outsourced operations
            var printingHelper = new MathOperationsPrinting();
            printingHelper.Print(mo);
            Console.WriteLine("");

            var mathOutput = new MathOutput();
            Console.WriteLine("{0}", mathOutput.MathToString(mo));

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
        private sealed class MathOperations
        {
            public int X { get; }
            public int Y { get; }

            public MathOperations(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int Add()
            {
                return X + Y;
            }

            public int Multiply()
            {
                return X * Y;
            }

            public int Divide()
            {
                return X / Y;
            }

            public int Subtract()
            {
                return X - Y;
            }
        }

        #endregion

        #region Helpers classes

        /// <summary>
        /// this helper class is doing only printing of the 
        /// particular MathOperations class
        /// and nothing else
        /// </summary>
        private class MathOperationsPrinting
        {
            public void Print(MathOperations mathOperations)
            {
                Console.WriteLine("Doing some printing operations...");
            }
        }

        /// <summary>
        /// this class makes an output of the particular
        /// MathOperations class and nothing else
        /// </summary>
        private class MathOutput
        {
            public string MathToString(MathOperations mo)
            {
                return $"X: {mo.X}, Y: {mo.Y}";
            }
        }

        #endregion
    }
}