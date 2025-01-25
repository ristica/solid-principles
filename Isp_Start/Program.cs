using System;

namespace Isp_Start
{
    internal static class Program
    {
        private static void Main()
        {
        }

        #region ICalculate implementations

        internal class CalculateAddAndSubtract : ICalculate
        {
            public int Add(int x, int y)
            {
                return x + y;
            }

            public int Subtract(int x, int y)
            {
                return x - y;
            }

            /// <summary>
            /// Violation of the Interface Segregation Principle
            /// this function / implementation is not needed bei 
            /// this concrete class
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public int Multiply(int x, int y)
            {
                throw new NotImplementedException();
            }
        }

        private class CalculateMultiply : ICalculate
        {
            /// <summary>
            /// Violation of the Interface Segregation Principle
            /// this function / implementation is not needed bei 
            /// this concrete class
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public int Add(int x, int y)
            {
                throw new NotImplementedException();
            }

            public int Multiply(int x, int y)
            {
                return x * y;
            }

            /// <summary>
            /// Violation of the Interface Segregation Principle
            /// this function / implementation is not needed bei 
            /// this concrete class
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public int Subtract(int x, int y)
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Interface

        private interface ICalculate
        {
            int Add(int x, int y);
            int Subtract(int x, int y);
            int Multiply(int x, int y);
        }

        #endregion
    }
}