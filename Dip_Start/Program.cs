using System;

namespace Dip_Start
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("");
            var textPrinter = new InvoiceTextPrinter();
            textPrinter.Print();
            Console.WriteLine("");
            var htmlPrinter = new InvoiceHtmlPrinter();
            htmlPrinter.Print();

            Console.WriteLine("");
            Console.ReadKey();
        }
    }

    #region IInvoicePrinter

    internal interface IInvoicePrinter
    {
        void Print();
    }

    #endregion

    #region IInvoicePrinter concrete

    internal class InvoiceHtmlPrinter : IInvoicePrinter
    {
        public void Print()
        {
            Console.WriteLine("Print as HTML...");
        }
    }

    internal class InvoiceTextPrinter : IInvoicePrinter
    {
        public void Print()
        {
            Console.WriteLine("Print as text...");
        }
    }

    #endregion
}