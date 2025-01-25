using System;

namespace Isp_End
{
    internal static class Program
    {
        private static void Main()
        {
        }

        #region ICalculate implementations

        private class CalculateAddAndSubtract : ICalculateAddSubtract
        {
            public int Add(int x, int y)
            {
                return x + y;
            }

            public int Subtract(int x, int y)
            {
                return x - y;
            }
        }

        private class CalculateMultiply : ICalculateMultiply
        {
            public int Multiply(int x, int y)
            {
                return x * y;
            }
        }

        #endregion

        #region Interface

        private interface ICalculateAddSubtract
        {
            int Add(int x, int y);
            int Subtract(int x, int y);
        }

        private interface ICalculateMultiply
        {
            int Multiply(int x, int y);
        }

        #endregion
    }
}