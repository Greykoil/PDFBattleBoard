using PdfSharpCore.Drawing;

namespace PDFBattleBoard.View
{
    internal class UtilDrawer
    {

        public double DefaultLineHeight { get; } = 12;

        XFont HeaderFont = new XFont("Verdana", 10, XFontStyle.Bold);
        XFont TextFont = new XFont("Verdana", 10);
        XBrush DefaultBrush = XBrushes.Black;
        XPen DefaultPen = new XPen(XBrushes.Black);
        XPen ThinPen = new XPen(XBrushes.Black, 0.5);

        public XGraphics Graphics { get; }

        public UtilDrawer(XGraphics graphics)
        {
            Graphics = graphics;
        }

        /// <summary>
        /// Draw the outline and header for a region
        /// </summary>
        /// <param name="regionLimit">The initial size that the region has to fit into</param>
        /// <returns>The point top left below the region header, ready for the next draw</returns>
        public XRect CreateRegion(XRect regionLimit, string regionTitle)
        {
            var innerRegion = DrawRegionOutline(regionLimit);

            TextRectangle(regionTitle, innerRegion.Width, innerRegion.TopLeft, HeaderFont);

            XRect lowerRegion = new XRect()
            {
                Width = innerRegion.Width,
                Height = innerRegion.Height - DefaultLineHeight,
                Location = new XPoint() { X = innerRegion.X, Y = innerRegion.Y + DefaultLineHeight }
            };

            return lowerRegion;
        }

        internal void TextRectangle(string text, double width, XPoint currentPoint)
        {
            TextRectangle(text, width, currentPoint, TextFont);
        }

        internal void TextRectangle(string text, double width, XPoint currentPoint, XFont font)
        {
            var totalRect = new XRect() { Width = width, Height = DefaultLineHeight, Location = currentPoint };
            Graphics.DrawRectangle(DefaultPen, totalRect);
            Graphics.DrawString(text, font, XBrushes.Black, totalRect, XStringFormats.Center);
        }

        internal void CheckCircleRectangle(int checkCircles, double width, XPoint currentPoint)
        {
            var totalRect = new XRect() { Width = width, Height = DefaultLineHeight, Location = currentPoint };
            Graphics.DrawRectangle(DefaultPen, totalRect);

            double circleBuffer = 2;
            double circleSize = DefaultLineHeight - (2 * circleBuffer);
            for (int i = 0; i < checkCircles; ++i)
            {
                XPoint start = new XPoint(currentPoint.X + circleBuffer, currentPoint.Y + circleBuffer);
                XPoint end = new XPoint(start.X + circleSize, start.Y + circleSize);
                XRect containingBox = new XRect(start, end);
                Graphics.DrawEllipse(DefaultPen, containingBox);
                currentPoint.X += DefaultLineHeight;
            }
        }

        internal void TextRectangle(string text, XRect emptyOutRect, XStringFormat format)
        {
            Graphics.DrawRectangle(DefaultPen, emptyOutRect);
            Graphics.DrawString(text, TextFont, XBrushes.Black, emptyOutRect, format);
        }

        internal void FilLRegionWithLines(XRect lineRegion)
        {
            for (double i = 0; i < lineRegion.Height; i += DefaultLineHeight)
            {
                XPoint from = new XPoint() { X = lineRegion.TopLeft.X, Y = lineRegion.TopLeft.Y + i };
                XPoint to = new XPoint() { X = lineRegion.TopRight.X, Y = lineRegion.TopLeft.Y + i };

                Graphics.DrawLine(ThinPen, from, to);
            }
        }

        /// <summary>
        /// Adds a slight buffer, then draws a bold rectangle around the region, 
        /// then returns the new smaller inner region for the actual thing to be drawn in.
        /// </summary>
        /// <param name="outerLimit"></param>
        /// <returns></returns>
        public XRect DrawRegionOutline(XRect outerLimit)
        {
            double buffer = 2;

            XRect outlineRect = new XRect()
            {
                Height = outerLimit.Height - (2 * buffer),
                Width = outerLimit.Width - (2 * buffer),
                X = outerLimit.X + buffer,
                Y = outerLimit.Y + buffer
            };

            var line = new XPen(XBrushes.Black, 1);
            Graphics.DrawRectangle(line, outlineRect);

            XRect innerRect = new XRect()
            {
                Height = outlineRect.Height - (buffer),
                Width = outlineRect.Width - (buffer),
                X = outlineRect.X + buffer / 2,
                Y = outlineRect.Y + buffer / 2
            };

            return outlineRect;
        }
    }
}
