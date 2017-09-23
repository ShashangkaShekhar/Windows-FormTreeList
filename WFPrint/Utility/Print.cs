using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFPrint.Models;

namespace WFPrint.Utility
{
    public class Print
    {
        private PrintDocument pdoc = null;
        private PrintTemplate objPrintTemp = null;
        private static List<vmItems> cartData = null;

        public Print()
        {
        }

        public Print(List<vmItems> data) : this()
        {
            cartData = data;
        }

        public void PrintDoc()
        {
            try
            {
                objPrintTemp = new PrintTemplate();
                using (pdoc = new PrintDocument())
                {
                    PrintDialog pd = new PrintDialog();
                    PrinterSettings ps = new PrinterSettings();
                    PaperSize psize = new PaperSize("Custom", 280, 900);
                    pd.Document = pdoc;
                    pd.Document.PrintController = new StandardPrintController();
                    pd.Document.PrinterSettings.PrinterName = Printer.GetDefaultPrinter();
                    pd.Document.PrinterSettings.Copies = 1;
                    pd.Document.DefaultPageSettings.PaperSize = psize;
                    pdoc.DefaultPageSettings.PaperSize.Height = 900;
                    pdoc.DefaultPageSettings.PaperSize.Width = 280;

                    new PrintTemplate(cartData);
                    pdoc.PrintPage += new PrintPageEventHandler(objPrintTemp.Default_Receipt);

                    //Print to Printer
                    PrintPreviewDialog pp = new PrintPreviewDialog();
                    pp.Document = pdoc;
                    pdoc.Print();
                    pdoc.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
