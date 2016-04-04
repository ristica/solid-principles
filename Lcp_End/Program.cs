using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Lcp_End
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Liskow Substitution Principle => START ###");
            Console.WriteLine("");

            // main class
            var mo = new MathOperations { X = 6, Y = 3 };

            // main class' operations 
            var validators = new List<Validator> {new GraterThenZeroValidator(), new NoRestDivideValidator()};
            var isValid = true;
            foreach (var v in validators)
            {
                isValid = v.Validate(mo.X, mo.Y);
            }

            if (!isValid)
            {
                Console.WriteLine("Validation failed!");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("{0} + {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a + b));
                Console.WriteLine("{0} * {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a*b));
                Console.WriteLine("{0} - {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a - b));
                Console.WriteLine("{0} / {1} = {2}", mo.X, mo.Y, mo.Calculate((a, b) => a/b));
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
        /// SRP and OCP are ok because we can create 
        /// as many validators as we want wo
        /// needing to reopen the Calidator class anymore
        /// and we can write as manx validators as want
        /// </summary>
        abstract class Validator
        {
            public abstract bool Validate(int x, int y);
        }

        /// <summary>
        /// SRP is ok
        /// the class is not more tightly coupled to the MarthOperations
        /// TELL and not ASK => satisified
        /// </summary>
        class GraterThenZeroValidator : Validator
        {
            public override bool Validate(int x, int y)
            {
                return x > 0 && y > 0;
            }  
        }

        /// <summary>
        ///  SRP is ok
        /// the class is not more tightly coupled to the MarthOperations
        /// TELL and not ASK => satisified
        /// </summary>
        class NoRestDivideValidator : Validator
        {
            public override bool Validate(int x, int y)
            {
                return (x % y) == 0;
            }
        }

        #endregion
    }
}
