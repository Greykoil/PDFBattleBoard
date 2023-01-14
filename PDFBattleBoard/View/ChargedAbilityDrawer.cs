using PDFBattleBoard.Model;
using PdfSharpCore.Drawing;

namespace PDFBattleBoard.View
{
    internal class ChargedAbilityDrawer
    {

        public static double CalculateAbilityHeight(List<ChargedAbility> abilities)
        {
            var currentPoint = new XPoint(0, 0);
            int count = 0;
            foreach (var type in (Source[])Enum.GetValues(typeof(Source)))
            {
                var relevantTypeAbilies = abilities.Where(x => x.Source == type);
                if (!relevantTypeAbilies.Any())
                {
                    continue;
                }
                count += 10;

                foreach (var fre in (Frequency[])Enum.GetValues(typeof(Frequency)))
                {
                    var relevantFreAbilies = relevantTypeAbilies.Where(x => x.Frequent == fre);
                    if (!relevantFreAbilies.Any())
                    {
                        continue;
                    }
                    count += 10;

                    var singleLines = relevantFreAbilies.Where(x => x.Frequent == Frequency.Sectional || x.Charges > 5);

                    foreach (var thing in singleLines)
                    {
                        count += 10;
                    }

                    var doubledLines = relevantFreAbilies.Where(x => !singleLines.Contains(x));
                    bool halfOffset = false;
                    foreach (var current in doubledLines)
                    {
                        if (!halfOffset)
                        {
                            halfOffset = true;
                        }
                        else
                        {
                            count += 10;
                            halfOffset = false;
                        }
                    }

                    if (halfOffset)
                    {
                        count += 10;
                    }
                }
            }

            return count;
        }

        public static void DrawChargedSkills(List<ChargedAbility> abilities, XGraphics graphics, XRect xRect)
        {
            var currentPoint = xRect.TopLeft;
            double width = xRect.Width;
            XFont headerFont = new XFont("Verdana", 10, XFontStyle.Bold);
            XFont midFont = new XFont("Verdana", 10);
            XPen linePen = new XPen(XBrushes.Black);
            graphics.DrawRectangle(linePen, xRect);

            foreach (var type in (Source[]) Enum.GetValues(typeof(Source)))
            {
                var relevantTypeAbilies = abilities.Where(x => x.Source == type);
                if (!relevantTypeAbilies.Any())
                {
                    continue;
                }
                var headerRect = new XRect() { Width = width, Height = 10, Location = currentPoint };
                graphics.DrawRectangle(linePen, headerRect);
                graphics.DrawString(type.ToString(), headerFont, XBrushes.Black, headerRect, XStringFormats.Center);
                currentPoint.Offset(0, 10);

                foreach (var fre in (Frequency[]) Enum.GetValues(typeof(Frequency)))
                {
                    var relevantFreAbilies = relevantTypeAbilies.Where(x => x.Frequent == fre);
                    if (!relevantFreAbilies.Any())
                    {
                        continue;
                    }
                    var freRect = new XRect() { Width = width, Height = 10, Location = currentPoint };
                    graphics.DrawRectangle(linePen, freRect);
                    graphics.DrawString(fre.ToString(), midFont, XBrushes.Black, freRect, XStringFormats.Center);
                    currentPoint.Offset(0, 10);

                    DrawAbilites(relevantFreAbilies, graphics, ref currentPoint, xRect.Width);
                }
            }
        }

        private static void DrawAbilites(IEnumerable<ChargedAbility> relevantFreAbilies, XGraphics graphics, ref XPoint currentPoint, double width)
        {
            var singleLines = relevantFreAbilies.Where(x => x.Frequent == Frequency.Sectional || x.Charges > 5);

            foreach (var fre in singleLines)
            {
                XRect rect = new XRect() { Width = width, Height = 10, Location = currentPoint };
                DrawChargedAbility(fre, graphics, rect);
                currentPoint.Offset(0, 10);
            }

            var doubledLines = relevantFreAbilies.Where(x => !singleLines.Contains(x));
            bool halfOffset = false;

            foreach (var current in doubledLines)
            {
                XRect rect = new XRect() { Width = width / 2, Height = 10, Location = currentPoint };
                DrawChargedAbility(current, graphics, rect);
                if (!halfOffset)
                {
                    currentPoint.Offset(width / 2, 0);
                    halfOffset = true;
                }
                else
                {
                    currentPoint.Offset(-width / 2, 10);
                    halfOffset = false;
                }
            }

            if (halfOffset)
            {
                currentPoint.Offset(-width / 2, 10); 
            }
        }

        public static void DrawChargedAbility(ChargedAbility ability, XGraphics graphics, XRect containingRectangle)
        {
            XPen linePen = new XPen(XBrushes.Black);

            XFont font = new XFont("Verdana", 8);

            graphics.DrawRectangle(linePen, containingRectangle);
            var currentPoint = containingRectangle.TopLeft;
            
            // Name
            var nameRect = new XRect() { Width = containingRectangle.Width / 2.5, Height = containingRectangle.Height, Location = currentPoint};
            graphics.DrawRectangle(linePen, nameRect);

            graphics.DrawString(ability.Name, font, XBrushes.Black, nameRect, XStringFormats.Center);

            currentPoint.X += (containingRectangle.Width / 2.5);

            for (int i = 0; i < ability.Charges; ++i)
            {
                XPoint start = new XPoint(currentPoint.X + 2, currentPoint.Y + 2);
                XPoint end = new XPoint(start.X + 6, start.Y + 6);
                XRect containingBox = new XRect(start, end);
                graphics.DrawEllipse(linePen, containingBox);
                currentPoint.X += 10;
            }

            if (ability.Frequent == Frequency.Sectional)
            {
                for (int i = 0; i < 2; ++i)
                {
                    XPoint from = new XPoint() { X = currentPoint.X, Y = currentPoint.Y + 10 };
                    XPoint to = new XPoint() { X = currentPoint.X + 5, Y = currentPoint.Y };
                    graphics.DrawLine(linePen, from, to);
                    currentPoint.X += 5;
                    for (int j = 0; j < ability.Charges; ++j)
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
    }
}
