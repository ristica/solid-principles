using System;

namespace Srp_Start
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("### Single Responsibility Principle => START ###");
            Console.WriteLine("");

            var mo = new MathOperations { X = 6, Y = 3 };

            Console.WriteLine("{0}", mo.MathToString(mo));
            Console.WriteLine();
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

        public class MathOperations
        {
            public int X { get; set; }
            public int Y { get; set; }

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

            public void Print(MathOperations mathOperations)
            {
                // add some printing logic
            }

            public string MathToString(MathOperations mathOperations)
            {
                return $"X: {X}, Y: {Y}";
            }
        }

        #endregion
    }
}