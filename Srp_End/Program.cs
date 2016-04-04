using System;

namespace Srp_End
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Single Responsibility Principle => START ###");
            Console.WriteLine("");

            var mo = new MathOperations { X = 6, Y = 3 };

            Console.WriteLine("{0} + {1} = {2}", mo.X, mo.Y, mo.Add());
            Console.WriteLine("{0} * {1} = {2}", mo.X, mo.Y, mo.Multiply());
            Console.WriteLine("{0} / {1} = {2}", mo.X, mo.Y, mo.Divide());
            Console.WriteLine("{0} - {1} = {2}", mo.X, mo.Y, mo.Substract());
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
        class MathOperations
        {
            #region Properties
            public int X { get; set; }
            public int Y { get; set; }
            #endregion

            #region Methods
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
            #endregion  
        }

        #endregion

        #region Helpers classes

        /// <summary>
        ///  this helper class is doing only printing of the 
        /// particular MathOperations class
        /// and nothing else
        /// </summary>
        class MathOperationsPrinting
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
        class MathOutput
        {
            public string MathToString(MathOperations mo)
            {
                return $"X: {mo.X}, Y: {mo.Y}";
            }
        }

        #endregion
    }
}
