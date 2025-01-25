using System;

namespace Dip_End
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine("");

            var printManager = new InvoicePrinterManager(new InvoiceTextPrinter());
            printManager.DoPrint();

            Console.WriteLine("");

            printManager = new InvoicePrinterManager(new InvoiceHtmlPrinter());
            printManager.DoPrint();

            Console.WriteLine("");
            Console.ReadKey();
        }
    }

    #region IInvoicePrinter

    internal interface IInvoicePrinter
    {
        void Print();
    }

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

    #region IInvoiceManager

    internal class InvoicePrinterManager
    {
        private readonly IInvoicePrinter _printer;

        public InvoicePrinterManager(IInvoicePrinter printer)
        {
            _printer = printer;
        }

        public void DoPrint()
        {
            _printer.Print();
        }
    }

    #endregion
}