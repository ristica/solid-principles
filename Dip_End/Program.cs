using System;

namespace Dip_End
{
    class Program
    {
        static void Main(string[] args)
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

    interface IInvoicePrinter
    {
        void Print();
    }

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

    #region IInvoiceManager

    class InvoicePrinterManager
    {
        private readonly IInvoicePrinter _printer;

        public InvoicePrinterManager(IInvoicePrinter printer)
        {
            this._printer = printer;
        }

        public void DoPrint()
        {
            this._printer.Print();
        }
    }

    #endregion
}
