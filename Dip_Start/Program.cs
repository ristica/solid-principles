using System;

namespace Dip_Start
{
    class Program
    {
        static void Main(string[] args)
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

    interface IInvoicePrinter
    {
        void Print();
    }

    #endregion

    #region IInvoicePrinter concrete

    class InvoiceHtmlPrinter : IInvoicePrinter
    {
        public void Print()
        {
            Console.WriteLine("Print as HTML...");
        }
    }

    class InvoiceTextPrinter : IInvoicePrinter
    {
        public void Print()
        {
            Console.WriteLine("Print as text...");
        }
    }

    #endregion
}
