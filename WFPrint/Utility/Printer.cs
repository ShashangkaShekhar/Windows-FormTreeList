using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPrint.Utility
{
    public class Printer
    {
        public static string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            try
            {
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    settings.PrinterName = printer;
                    if (settings.IsDefaultPrinter)
                        return printer;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return string.Empty;
        }
    }
}
