using PDFBattleBoard.Model;
using PdfSharpCore.Drawing;

namespace PDFBattleBoard.View
{
    internal class PoolDrawer
    {
        public static void DrawPool(PoolAbility ability, XGraphics graphics, XRect containingRectangle)
        {
            // Do something if the rectangle is too small. Otherwise we won't have space to work with

            double totalPoolWidth = containingRectangle.Width;
            XFont headerFont = new XFont("Verdana", 10, XFontStyle.Bold);
            XFont font = new XFont("Verdana", 10);

            #region BoxOutline

            XPen linePen = new XPen(XBrushes.Black);

            graphics.DrawRectangle(linePen, containingRectangle);

            #endregion

            #region Header
            XPoint currentPoint = containingRectangle.TopLeft;
            // Header outline
            var headerRectangle = new XRect() { Width = totalPoolWidth, Height = 10, Location = currentPoint };
            graphics.DrawRectangle(linePen, headerRectangle);
            graphics.DrawString(ability.Name, headerFont, XBrushes.Black, headerRectangle, XStringFormats.Center);
            currentPoint.Offset(0, 10);


            // Name
            var totalRect = new XRect() { Width = containingRectangle.Width / 6, Height = 10 , Location = currentPoint};
            graphics.DrawRectangle(linePen, totalRect);
            graphics.DrawString("Total", font, XBrushes.Black, totalRect, XStringFormats.Center);
            currentPoint.Offset(totalRect.Width, 0);

            // Total
            var totalValueRect = new XRect() { Width = containingRectangle.Width / 6, Height = 10, Location = currentPoint};
            graphics.DrawRectangle(linePen, totalValueRect);
            graphics.DrawString(ability.Total.ToString(), font, XBrushes.Black, totalValueRect, XStringFormats.Center);

            // Self/Talisman
            currentPoint.X += containingRectangle.Width / 6;
            var SelfTaliRect = new XRect() { Width = containingRectangle.Width / 6, Height = 10, Location = currentPoint };
            graphics.DrawRectangle(linePen, SelfTaliRect);
            graphics.DrawString("Self/Tali", font, XBrushes.Black, SelfTaliRect, XStringFormats.Center);

            currentPoint.X += containingRectangle.Width / 6;
            var fooRect = new XRect() { Width = containingRectangle.Width / 6, Height = 10, Location = currentPoint };
            graphics.DrawRectangle(linePen, fooRect);
            graphics.DrawString("10/190", font, XBrushes.Black, fooRect, XStringFormats.Center);

            // Meds
            currentPoint.X += containingRectangle.Width / 6;
            var medsRect = new XRect() { Width = containingRectangle.Width / 6, Height = 10, Location = currentPoint };
            graphics.DrawRectangle(linePen, medsRect);
            graphics.DrawString("Meditate", font, XBrushes.Black, medsRect, XStringFormats.Center);


            currentPoint.X += containingRectangle.Width / 6;
            var medCountRect = new XRect() { Width = containingRectangle.Width / 6, Height = 10, Location = currentPoint };
            for (int i = 0; i < ability.MedCharges; ++i)
            {
                XPoint start = new XPoint(currentPoint.X + 2, currentPoint.Y + 2);
                XPoint end = new XPoint(start.X + 6, start.Y + 6);
                XRect containingBox = new XRect(start, end);
                graphics.DrawEllipse(linePen, containingBox);
                currentPoint.X += 10;
            }

            graphics.DrawRectangle(linePen, medCountRect);

            // Out
            currentPoint.X = containingRectangle.X;
            currentPoint.Y = containingRectangle.Y + 20;
            var outRect = new XRect() { Width = containingRectangle.Width / 6, Height = 10, Location = currentPoint };
            graphics.DrawRectangle(linePen, outRect);
            graphics.DrawString("Out", font, XBrushes.Black, outRect, XStringFormats.Center);

            currentPoint.Y += 10;
            var emptyOutRect = new XRect() { Width = containingRectangle.Width / 6, Height = 50, Location = currentPoint };
            graphics.DrawRectangle(linePen, emptyOutRect);
            graphics.DrawString(ability.Out.ToString(), font, XBrushes.Black, emptyOutRect, XStringFormats.TopCenter);

            #endregion

            #region Lines
            currentPoint.X += containingRectangle.Width / 6;
            currentPoint.Y -= 10;
            var lineRectangle = new XRect
            {
                Width = containingRectangle.Width - containingRectangle.Width / 6,
                Height = containingRectangle.Height - 20,
                Location = currentPoint
            };
            linePen.Width = linePen.Width / 2;
            //graphics.DrawRectangle(linePen, lineRectangle);

            for (int i = 0; i < lineRectangle.Height; i += 10)
            {
                XPoint from = new XPoint() { X = lineRectangle.TopLeft.X, Y = lineRectangle.TopLeft.Y + i };
                XPoint to = new XPoint() { X = lineRectangle.TopRight.X, Y = lineRectangle.TopLeft.Y + i };

                if (i >= 60)
                {
                    from.X -= outRect.Width;
                }
                graphics.DrawLine(linePen, from, to);
            }

            #endregion

        }
    }
}
