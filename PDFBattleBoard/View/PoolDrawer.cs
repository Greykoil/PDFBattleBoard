using PDFBattleBoard.Model;
using PdfSharpCore.Drawing;

namespace PDFBattleBoard.View
{
    internal class PoolDrawer
    {
        public UtilDrawer DrawingUtils { get; }

        public PoolDrawer(UtilDrawer utilDrawer)
        {
            DrawingUtils = utilDrawer;
        }


        public void DrawPool(PoolAbility ability, XRect containingRectangle)
        {
            // Do something if the rectangle is too small. Otherwise we won't have space to work with
            var innerRegion = DrawingUtils.CreateRegion(containingRectangle, ability.Name);

            var currentPoint = innerRegion.TopLeft;

            var boxWidth = innerRegion.Width / 6;
            // Name
            DrawingUtils.TextRectangle("Total", boxWidth, currentPoint);
            currentPoint.Offset(boxWidth, 0);

            DrawingUtils.TextRectangle(ability.Total.ToString(), boxWidth, currentPoint);
            currentPoint.Offset(boxWidth, 0);

            DrawingUtils.TextRectangle("Self/Tali", boxWidth, currentPoint);
            currentPoint.Offset(boxWidth, 0);

            DrawingUtils.TextRectangle(ability.Self.ToString() + "/" + ability.Talisman.ToString(), boxWidth, currentPoint);
            currentPoint.Offset(boxWidth, 0);

            DrawingUtils.TextRectangle("Meditate", boxWidth, currentPoint);
            currentPoint.Offset(boxWidth, 0);

            DrawingUtils.CheckCircleRectangle(ability.MedCharges, boxWidth, currentPoint);


            // Reset current point to what is now the top left of the remaining space
            currentPoint = new XPoint()
            {
                X = innerRegion.Left,
                Y = innerRegion.Top + DrawingUtils.DefaultLineHeight
            };

            if (ability.HasOut)
            {
                double outWidth = innerRegion.Width / 6;
                double outHeight = 4 * DrawingUtils.DefaultLineHeight;
                DrawingUtils.TextRectangle("Out", outWidth, currentPoint);
                currentPoint.Offset(0, DrawingUtils.DefaultLineHeight);
                var emptyOutRect = new XRect() { Width = outWidth, Height = outHeight, Location = currentPoint };
                DrawingUtils.TextRectangle(ability.Out.ToString(), emptyOutRect, XStringFormats.TopCenter);

                var rightBox = new XRect()
                {
                    Width = innerRegion.Width - outWidth,
                    Height = outHeight + DrawingUtils.DefaultLineHeight,
                    Location = new XPoint()
                    {
                        X = currentPoint.X + outWidth,
                        Y = currentPoint.Y
                    }
                };
                DrawingUtils.FilLRegionWithLines(rightBox);
                
                var bottomBox = new XRect()
                {
                    Width = innerRegion.Width,
                    Height = innerRegion.Height - (outHeight +  2 * DrawingUtils.DefaultLineHeight),
                    Location = new XPoint()
                    {
                        X = currentPoint.X,
                        Y = currentPoint.Y + outHeight
                    }
                };
                DrawingUtils.FilLRegionWithLines(bottomBox);
            }

            else
            {
                var lineRegion = new XRect() {
                    Width = innerRegion.Width, 
                    Height = innerRegion.Height - DrawingUtils.DefaultLineHeight,
                    Location = currentPoint
                };

                DrawingUtils.FilLRegionWithLines(lineRegion);
            }
        }
    }
}
