using System;

namespace Srp_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Single Responsibility Principle => START ###");
            Console.WriteLine("");

            var mo = new MathOperations {X = 6, Y = 3};

            Console.WriteLine("{0}", mo.MathToString(mo));
            Console.WriteLine();
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

        public class MathOperations
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

            public int Substract()
            {
                return this.X - this.Y;
            }

            public void Print(MathOperations mathOperations)
            {
                // add some printing logic
            }

            public string MathToString(MathOperations mathOperations)
            {
                return $"X: {this.X}, Y: {this.Y}";
            }
        }

        #endregion


    }
}
