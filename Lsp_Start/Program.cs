using System;

namespace Lsp_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Liskov Substitution Principle => START ###");
            Console.WriteLine("");

            // main class
            var mo = new MathOperations { X = 2, Y = 3};

            // main class' operations 
            var validator = new Validator();
            if (!validator.AreParameterGreaterThenZeroValidation(mo))
            {
                Console.WriteLine("Parameter are not greater then 0!");
            }
            else
            {
                Console.WriteLine("{0} + {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a + b));
                Console.WriteLine("{0} * {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a*b));
                Console.WriteLine("{0} - {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a - b));

                if (validator.ValidateDivideOperation(mo))
                {
                    Console.WriteLine("{0} / {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a / b));
                }
                else
                {
                    Console.WriteLine("Divide with rest is not allowed!");
                }
            }
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
            public int Calculate(Func<int, int, int> mathFunction)
            {
                return mathFunction(this.X, this.Y);
            }
        }

        #endregion

        #region Validation class

        /// <summary>
        ///  this class is tightly coupled to the MathOperations class
        /// OCP is broken - if we want to add new validation logic we have to modified
        /// the Validators class
        /// </summary>
        class Validator
        {
            // TELL and not ASK => volated
            public bool AreParameterGreaterThenZeroValidation(MathOperations mo)
            {
                return mo.X > 0 && mo.Y > 0;
            }

            // TELL and not ASK => volated
            public bool ValidateDivideOperation(MathOperations mo)
            {
                return (mo.X % mo.Y) == 0;
            }
        }
        
        #endregion
    }
}
