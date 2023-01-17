using PDFBattleBoard.Model;
using PdfSharpCore.Drawing;

namespace PDFBattleBoard.View
{
    internal class ChargedAbilityDrawer
    {

        public UtilDrawer DrawingUtils { get; }

        public ChargedAbilityDrawer(UtilDrawer utils)
        {
            DrawingUtils = utils;
        }

        public double CalculateAbilityHeight(IEnumerable<ChargedAbility> abilities)
        {

            var singleLineAbilites = abilities.Where(x => x.Charges > 7 || x.Frequent == Frequency.Sectional && x.Charges > 2);

            var doubledUpAbilites = abilities.Where(x => !singleLineAbilites.Contains(x));


            return
                DrawingUtils.RegionBuffer * 2 + // The buffer above and below the box
                DrawingUtils.DefaultLineHeight + // The header line
                (singleLineAbilites.Count() * DrawingUtils.DefaultLineHeight) + // One line per single line ability
                Math.Ceiling((double)doubledUpAbilites.Count() / 2) * DrawingUtils.DefaultLineHeight; // One line for every 2 doubled up abilites
        }

        public void DrawChargedSkills(IEnumerable<ChargedAbility> abilities, XGraphics graphics, XRect xRect)
        {
            var innerRegion = DrawingUtils.CreateRegion(xRect, abilities.First().Source.ToString());

            var singleLineAbilites = abilities.Where(x => x.Charges > 7 || x.Frequent == Frequency.Sectional && x.Charges > 3);

            var doubledUpAbilites = abilities.Where(x => !singleLineAbilites.Contains(x));

            var totalWidth = innerRegion.Width;
            var currentPoint = innerRegion.TopLeft;
            foreach (var item in singleLineAbilites)
            {
                var nameWidth = totalWidth / 4;
                DrawingUtils.TextRectangle(item.Name, nameWidth, currentPoint);
                currentPoint.Offset(nameWidth, 0);
                var chargesWidth = totalWidth - nameWidth;
                if (item.Frequent == Frequency.Sectional)
                {
                    chargesWidth = chargesWidth / 3;
                    for (int i = 0; i < 3; ++i)
                    {
                        DrawingUtils.CheckCircleRectangle(item.Charges, chargesWidth, currentPoint);
                        currentPoint.Offset(chargesWidth, 0);
                    }
                }
                else
                {
                    DrawingUtils.CheckCircleRectangle(item.Charges, chargesWidth, currentPoint);
                }

                currentPoint.X = innerRegion.Left;
                currentPoint.Offset(0, DrawingUtils.DefaultLineHeight);
            }

            var halfWidth = totalWidth / 2;
            bool halfOffset = false;
            foreach (var item in doubledUpAbilites)
            {
                var nameWidth = totalWidth / 4;
                DrawingUtils.TextRectangle(item.Name, nameWidth, currentPoint);
                currentPoint.Offset(nameWidth, 0);
                var chargesWidth = halfWidth - nameWidth;
                if (item.Frequent == Frequency.Sectional)
                {
                    chargesWidth = chargesWidth / 3;
                    for (int i = 0; i < 3; ++i)
                    {
                        DrawingUtils.CheckCircleRectangle(item.Charges, chargesWidth, currentPoint);
                        currentPoint.Offset(chargesWidth, 0);
                    }
                }
                else
                {
                    DrawingUtils.CheckCircleRectangle(item.Charges, chargesWidth, currentPoint);
                }

                if (halfOffset)
                {
                    halfOffset = false;
                    currentPoint.X = innerRegion.Left;
                    currentPoint.Offset(0, DrawingUtils.DefaultLineHeight);
                }
                else
                {
                    halfOffset=true;
                    currentPoint.X = innerRegion.Left + halfWidth;
                }
            }
        }
    }
}
