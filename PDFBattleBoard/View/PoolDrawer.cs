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
            XFont font = new XFont("Verdana", 10, XFontStyle.Bold);

            #region BoxOutline

            XPen linePen = new XPen(XBrushes.Black);

            graphics.DrawRectangle(linePen, containingRectangle);

            #endregion

            #region Header
            XPoint currentPoint = containingRectangle.TopLeft;
            // Header outline
            var headerRectangle = new XRect() { Width = totalPoolWidth, Height = 10, Location = currentPoint };
            graphics.DrawRectangle(linePen, headerRectangle);

            // Name
            var nameRect = new XRect() { Width = containingRectangle.Width / 6, Height = 10 , Location = currentPoint};
            graphics.DrawRectangle(linePen, nameRect);
            
            graphics.DrawString(ability.Name, font, XBrushes.Black, nameRect, XStringFormats.Center);

            // Total
            currentPoint.X += containingRectangle.Width / 6;
            var totalRect = new XRect() { Width = containingRectangle.Width / 6, Height = 10, Location = currentPoint};
            graphics.DrawRectangle(linePen, nameRect);
            graphics.DrawString(ability.Total.ToString(), font, XBrushes.Black, totalRect, XStringFormats.Center);

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
            currentPoint.Y = containingRectangle.Y + 10;
            var outRect = new XRect() { Width = containingRectangle.Width / 6, Height = 10, Location = currentPoint };
            graphics.DrawRectangle(linePen, outRect);
            graphics.DrawString("Out", font, XBrushes.Black, outRect, XStringFormats.Center);

            currentPoint.Y += 10;
            var emptyOutRect = new XRect() { Width = containingRectangle.Width / 6, Height = containingRectangle.Height  -20, Location = currentPoint };
            graphics.DrawRectangle(linePen, emptyOutRect);
            graphics.DrawString("75", font, XBrushes.Black, emptyOutRect, XStringFormats.TopCenter);

            #endregion

            #region Lines
            currentPoint.X += containingRectangle.Width / 6;
            currentPoint.Y -= 10;
            var lineRectangle = new XRect
            {
                Width = containingRectangle.Width - containingRectangle.Width / 6,
                Height = containingRectangle.Height - 10,
                Location = currentPoint
            };
            linePen.Width = linePen.Width / 2;
            graphics.DrawRectangle(linePen, lineRectangle);

            for (int i = 0; i < lineRectangle.Height; i += 10)
            {
                XPoint from = new XPoint() { X = lineRectangle.TopLeft.X, Y = lineRectangle.TopLeft.Y + i };
                XPoint to = new XPoint() { X = lineRectangle.TopRight.X, Y = lineRectangle.TopLeft.Y + i };
                graphics.DrawLine(linePen, from, to);
            }

            #endregion

        }
    }
}
