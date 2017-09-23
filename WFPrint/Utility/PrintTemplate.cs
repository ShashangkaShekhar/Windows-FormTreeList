using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFPrint.Models;

namespace WFPrint.Utility
{
    public class PrintTemplate
    {
        private static List<vmItems> cartData = null;

        public PrintTemplate()
        {
        }

        public PrintTemplate(List<vmItems> data) : this()
        {
            cartData = data;
        }

        public void Default_Receipt(object sender, PrintPageEventArgs e)
        {
            try
            {
                #region #Decleration
                Font drawFontTiny = new Font("Courier New", 1, GraphicsUnit.Pixel);
                Font drawFontSmall = new Font("Courier New", 13, GraphicsUnit.Pixel);
                Font drawFontSmallIta = new Font("Courier New", 13, FontStyle.Italic, GraphicsUnit.Pixel);

                // Create brush.
                SolidBrush drawBrushBlack = new SolidBrush(Color.Black);
                SolidBrush drawBrushWhite = new SolidBrush(Color.WhiteSmoke);

                // Create rectangle for drawing.
                float startX = 0.0F; //Left
                float startY = 0.0F; //Top
                float width = 275.0F;
                float height = 0.0F;

                RectangleF drawRect = new RectangleF();

                // Draw rectangle to screen.
                Pen blackPen = new Pen(Color.Black);
                Pen whitePen = new Pen(Color.White);
                Pen whitesmokePen = new Pen(Color.WhiteSmoke);
                Pen blackPenThin = new Pen(Color.Black, 1);
                Pen blackPenThik = new Pen(Color.Black, 3);

                // Set format of string.
                StringFormat drawFormat = new StringFormat();

                // Set gap of string.
                float Offset = 0F;
                #endregion

                using (Graphics graphics = e.Graphics)
                {
                    foreach (var item in cartData)
                    {
                        //Next Gap
                        Offset = (startY + Offset + 20.0F);

                        //Left QTY
                        startX = 5.0F;
                        width = 25.0F;
                        height = 20.0F;
                        drawFormat.Alignment = StringAlignment.Near;
                        drawRect = new RectangleF(startX, Offset, width, height);
                        graphics.DrawString(item.ItemQty + "x", drawFontSmall, drawBrushBlack, drawRect, drawFormat);
                        //graphics.DrawRectangle(blackPen, startX, Offset, width, height);

                        //Middle Item Name
                        startX = 30.0F;
                        width = 190.0F;
                        //height = 20.0F;
                        drawFormat.Alignment = StringAlignment.Near;
                        drawRect = new RectangleF(startX, Offset, width, height);
                        drawRect.Size = new Size(190, ((int)e.Graphics.MeasureString(item.ItemName.ToUpper(), drawFontSmall, 190, StringFormat.GenericTypographic).Height));
                        graphics.DrawString(item.ItemName.ToUpper(), drawFontSmall, drawBrushBlack, drawRect);
                        //graphics.DrawRectangle(blackPen, startX, Offset, width, height);

                        Offset = (startY + Offset + drawRect.Size.Height);

                        //Right Price
                        startX = 220.0F;
                        width = 50.0F;
                        //height = 20.0F;
                        drawFormat.Alignment = StringAlignment.Far;
                        Offset = Offset - 13;
                        drawRect = new RectangleF(startX, Offset, width, height);
                        graphics.DrawString(item.ItemTotal.ToString("0.00"), drawFontSmall, drawBrushBlack, drawRect, drawFormat);
                        //graphics.DrawRectangle(blackPen, startX, Offset, width, drawRect.Size.Height);

                        //Child Item
                        foreach (var citem in item.vmChildItems)
                        {
                            //Next Gap
                            Offset = (startY + Offset + 15.0F);

                            //Left QTY
                            startX = 30.0F;
                            width = 40.0F;
                            height = 20.0F;
                            drawFormat.Alignment = StringAlignment.Near;
                            drawRect = new RectangleF(startX, Offset, width, height);
                            graphics.DrawString("-" + citem.ItemQty + "x", drawFontSmallIta, drawBrushBlack, drawRect, drawFormat);
                            //graphics.DrawRectangle(blackPen, startX, Offset, width, height);

                            //Middle Item Name
                            startX = 60.0F;
                            width = 200.0F;
                            //height = 20.0F;
                            drawFormat.Alignment = StringAlignment.Near;
                            drawRect = new RectangleF(startX, Offset, width, height);
                            drawRect.Size = new Size(200, ((int)e.Graphics.MeasureString(citem.ItemName.ToUpper(), drawFontSmallIta, 200, StringFormat.GenericTypographic).Height));
                            graphics.DrawString(citem.ItemName.ToUpper(), drawFontSmallIta, drawBrushBlack, drawRect);
                            //graphics.DrawRectangle(blackPen, startX, Offset, width, height);

                            Offset = (startY + Offset + drawRect.Size.Height);

                            //Right Price
                            startX = 220.0F;
                            width = 50.0F;
                            //height = 20.0F;
                            drawFormat.Alignment = StringAlignment.Far;
                            Offset = Offset - 13;
                            drawRect = new RectangleF(startX, Offset, width, height);
                            graphics.DrawString(citem.ItemTotal.ToString("0.00"), drawFontSmallIta, drawBrushBlack, drawRect, drawFormat);
                            //graphics.DrawRectangle(blackPen, startX, Offset, width, drawRect.Size.Height);

                        }
                    }

                    //Last Gap
                    Offset = (startY + Offset + 50.0F);
                    //======================END=====================
                    startX = 5.0F;
                    startY = 10.0F;
                    width = 275.0F;
                    height = 20.0F;
                    drawFormat.Alignment = StringAlignment.Center;
                    drawRect = new RectangleF(startX, Offset, width, height);
                    graphics.DrawString("_", drawFontTiny, drawBrushWhite, drawRect, drawFormat);
                    //graphics.DrawRectangle(whitePen, startX, Offset, width, height);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
