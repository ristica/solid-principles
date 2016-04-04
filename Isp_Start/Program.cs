using System;

namespace Isp_Start
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        #region ICalculate implementations
        class CalculateAddAndSubstract : ICalculate
        {
            public int Add(int x, int y)
            {
                return x + y;
            }

            public int Substract(int x, int y)
            {
                return x - y;
            }

            /// <summary>
            /// Violation of the Interface Segregation Pronciple
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

        class CalculateMultiply : ICalculate
        {
            /// <summary>
            /// Violation of the Interface Segregation Pronciple
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
            /// Violation of the Interface Segregation Pronciple
            /// this function / implementation is not needed bei 
            /// this concrete class
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public int Substract(int x, int y)
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Interface
        interface ICalculate
        {
            int Add(int x, int y);
            int Substract(int x, int y);
            int Multiply(int x, int y);
        }
        #endregion
    }
}
