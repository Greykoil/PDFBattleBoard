using PDFBattleBoard.Model;
using PdfSharpCore.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFBattleBoard.View
{
    internal class ChargedAbilityDrawer
    {
        public static void DrawChargedAbility(ChargedAbility ability, XGraphics graphics, XRect containingRectangle)
        {
            XPen linePen = new XPen(XBrushes.Black);

            XFont font = new XFont("Verdana", 10, XFontStyle.Bold);

            graphics.DrawRectangle(linePen, containingRectangle);
            var currentPoint = containingRectangle.TopLeft;
            // Name
            var nameRect = new XRect() { Width = containingRectangle.Width / 3, Height = containingRectangle.Height, Location = currentPoint};
            graphics.DrawRectangle(linePen, nameRect);

            graphics.DrawString(ability.Name, font, XBrushes.Black, nameRect, XStringFormats.Center);

            currentPoint.X += (containingRectangle.Width / 3);

            for (int i = 0; i < ability.Charges; ++i)
            {
                XPoint start = new XPoint(currentPoint.X + 2, currentPoint.Y + 2);
                XPoint end = new XPoint(start.X + 6, start.Y + 6);
                XRect containingBox = new XRect(start, end);
                graphics.DrawEllipse(linePen, containingBox);
                currentPoint.X += 10;
            }
        }
    }
}
