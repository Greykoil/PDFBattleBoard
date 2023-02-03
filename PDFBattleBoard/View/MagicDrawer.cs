using BattleBoardModel.Model;
using PdfSharpCore.Drawing;

namespace PDFBattleBoard.View
{
    internal class MagicDrawer
    {
        public UtilDrawer DrawingUtils { get; }

        public MagicDrawer(UtilDrawer utils)
        {
            DrawingUtils = utils;
        }

        public double CalculateMagicHeight()
        {
            return 13 * DrawingUtils.DefaultLineHeight + 2 * DrawingUtils.RegionBuffer;
        }

        public void DrawMagic(MagicDetails characterDetails, XRect containingRectangle)
        {
            var innerRegion = DrawingUtils.CreateRegion(containingRectangle, "Magic");

            double magicWidth = innerRegion.Width;

            var currentPoint = innerRegion.TopLeft;

            var columnHeaderWidth = magicWidth / 15;
            DrawingUtils.TextRectangle("Lvl", columnHeaderWidth, currentPoint);
            currentPoint.Offset(columnHeaderWidth, 0);

            DrawingUtils.TextRectangle("Total", columnHeaderWidth, currentPoint);
            currentPoint.Offset(columnHeaderWidth, 0);

            DrawingUtils.TextRectangle("Out", columnHeaderWidth, currentPoint);
            currentPoint.Offset(columnHeaderWidth, 0);

            var remainingWidth = magicWidth - 3 * columnHeaderWidth;

            var infoWidth = remainingWidth / 6;
            DrawingUtils.TextRectangle("Total", infoWidth, currentPoint);
            currentPoint.Offset(infoWidth, 0);

            int totalMana = CalculateTotalMana(characterDetails);
            DrawingUtils.TextRectangle(totalMana.ToString(), infoWidth, currentPoint);
            currentPoint.Offset(infoWidth, 0);

            DrawingUtils.TextRectangle("Mnemonic", infoWidth, currentPoint);
            currentPoint.Offset(infoWidth, 0);

            DrawingUtils.CheckCircleRectangle(characterDetails.Mnemonics, infoWidth, currentPoint);
            currentPoint.Offset(infoWidth, 0);

            DrawingUtils.TextRectangle("Regain", infoWidth, currentPoint);
            currentPoint.Offset(infoWidth, 0);

            DrawingUtils.TextRectangle(characterDetails.Regain.ToString(), infoWidth, currentPoint);

            currentPoint = innerRegion.TopLeft;
            currentPoint.Offset(0, DrawingUtils.DefaultLineHeight);

            for (int i = 1; i <= 5; ++i)
            {
                var currentLevelSlots = characterDetails.SpellSlots[(i - 1)];

                DrawingUtils.TextRectangle(currentLevelSlots.Level.ToString(), columnHeaderWidth, currentPoint);
                currentPoint.Offset(columnHeaderWidth, 0);

                DrawingUtils.TextRectangle(currentLevelSlots.Total.ToString(), columnHeaderWidth, currentPoint);
                currentPoint.Offset(columnHeaderWidth, 0);

                DrawingUtils.TextRectangle(currentLevelSlots.Out.ToString(), columnHeaderWidth, currentPoint);
                currentPoint.Offset(columnHeaderWidth, 0);

                currentPoint.Offset(-3 * columnHeaderWidth, DrawingUtils.DefaultLineHeight);
            }

            var rightLineRegion = new XRect()
            {
                Width = innerRegion.Width - 3 * columnHeaderWidth,
                Height = 5 * DrawingUtils.DefaultLineHeight,
                Location = new XPoint()
                {
                    X = innerRegion.Left + 3 * columnHeaderWidth,
                    Y = innerRegion.Top + DrawingUtils.DefaultLineHeight
                }
            };

            DrawingUtils.FilLRegionWithLines(rightLineRegion);

            var levelFiveLines = new XRect()
            {
                Width = innerRegion.Width,
                Height = 2 * DrawingUtils.DefaultLineHeight,
                Location = new XPoint()
                {
                    X = innerRegion.Left,
                    Y = innerRegion.Top + 6 * DrawingUtils.DefaultLineHeight
                }
            };

            DrawingUtils.FilLRegionWithLines(levelFiveLines);

            currentPoint = levelFiveLines.BottomLeft;

            for (int i = 6; i <= 8; ++i)
            {
                var currentLevelSlots = characterDetails.SpellSlots[(i - 1)];

                DrawingUtils.TextRectangle(currentLevelSlots.Level.ToString(), columnHeaderWidth, currentPoint);
                currentPoint.Offset(columnHeaderWidth, 0);

                DrawingUtils.TextRectangle(currentLevelSlots.Total.ToString(), columnHeaderWidth, currentPoint);
                currentPoint.Offset(columnHeaderWidth, 0);

                DrawingUtils.TextRectangle(currentLevelSlots.Out.ToString(), columnHeaderWidth, currentPoint);
                currentPoint.Offset(columnHeaderWidth, 0);

                currentPoint.Offset(-3 * columnHeaderWidth, DrawingUtils.DefaultLineHeight);
            }

            var secondRightLineRegion = new XRect()
            {
                Width = innerRegion.Width - 3 * columnHeaderWidth,
                Height = 3 * DrawingUtils.DefaultLineHeight,
                Location = new XPoint()
                {
                    X = innerRegion.Left + 3 * columnHeaderWidth,
                    Y = levelFiveLines.Bottom
                }
            };

            DrawingUtils.FilLRegionWithLines(secondRightLineRegion);

            var nineSlots = characterDetails.SpellSlots[8];
            var tenSlots = characterDetails.SpellSlots[9];

            DrawingUtils.TextRectangle(nineSlots.Level.ToString(), columnHeaderWidth, currentPoint);
            currentPoint.Offset(columnHeaderWidth, 0);

            DrawingUtils.TextRectangle(nineSlots.Total.ToString(), columnHeaderWidth, currentPoint);
            currentPoint.Offset(columnHeaderWidth, 0);

            DrawingUtils.TextRectangle(nineSlots.Out.ToString(), columnHeaderWidth, currentPoint);
            currentPoint.Offset(columnHeaderWidth, 0);

            currentPoint.X = innerRegion.Width / 2;

            DrawingUtils.TextRectangle(tenSlots.Level.ToString(), columnHeaderWidth, currentPoint);
            currentPoint.Offset(columnHeaderWidth, 0);

            DrawingUtils.TextRectangle(tenSlots.Total.ToString(), columnHeaderWidth, currentPoint);
            currentPoint.Offset(columnHeaderWidth, 0);

            DrawingUtils.TextRectangle(tenSlots.Out.ToString(), columnHeaderWidth, currentPoint);
            currentPoint.Offset(columnHeaderWidth, 0);
        }

        private static int CalculateTotalMana(MagicDetails magicDetails)
        {
            int value = 0;
            foreach (var item in magicDetails.SpellSlots)
            {
                value += item.Total * item.Level;
            }
            return value;
        }
    }
}