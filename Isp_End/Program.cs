using System;

namespace Isp_End
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        #region ICalculate implementations


        class CalculateAddAndSubstract : ICalculateAddSubstract
        {
            public int Add(int x, int y)
            {
                return x + y;
            }

            public int Substract(int x, int y)
            {
                return x - y;
            }
        }

        class CalculateMultiply : ICalculateMultiply
        {
            public int Multiply(int x, int y)
            {
                return x * y;
            }
        }
        #endregion

        #region Interface
        interface ICalculateAddSubstract
        {
            int Add(int x, int y);
            int Substract(int x, int y);
        }
        interface ICalculateMultiply
        {
            int Multiply(int x, int y);
        }

        #endregion
    }
}
