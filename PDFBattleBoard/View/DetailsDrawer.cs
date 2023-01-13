using PDFBattleBoard.Model;
using PdfSharpCore.Drawing;

namespace PDFBattleBoard.View
{
    internal class DetailsDrawer
    {
        public static void DrawCharacterDetails(CharacterDetails characterDetails, XGraphics graphics, XRect containingRectangle)
        {
            var currentPt = containingRectangle.TopLeft;
            DrawName(characterDetails, graphics, containingRectangle.Width, ref currentPt);
            DrawMiscInfoRect(characterDetails, ref currentPt, containingRectangle.Width, graphics);
            DrawAcInfo(characterDetails, ref currentPt, containingRectangle.Width / 2, containingRectangle.Height, graphics);
            DrawNotes(ref currentPt, containingRectangle.Width / 2, containingRectangle.Height - 30, graphics);
        }

        private static void DrawName(CharacterDetails characterDetails, XGraphics graphics, double width, ref XPoint currentPt)
        {
            var nameRect = new XRect() { Width = width, Height = 20, Location = currentPt };
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            XPen linePen = new XPen(XBrushes.Black);
            graphics.DrawRectangle(linePen, nameRect);
            graphics.DrawString(characterDetails.Name, font, XBrushes.Black, nameRect, XStringFormats.Center);
            currentPt.Offset(0, 20);
        }

        private static void DrawMiscInfoRect(CharacterDetails characterDetails, ref XPoint currentPt, double width, XGraphics graphics)
        {
            XPen linePen = new XPen(XBrushes.Black);
            XFont font = new XFont("Verdana", 10, XFontStyle.Bold);
            var infoRect = new XRect() { Width = width, Height = 10, Location = currentPt };
            graphics.DrawRectangle(linePen, infoRect);

            string detailsString = characterDetails.CharacterRace.ToString() + " " + characterDetails.PlayerClass +
                "  -  Points: " + characterDetails.Points.ToString() +
                "  -  Res Chances: " + characterDetails.ResChances +
                "  -  Deaths on Event: ";

            graphics.DrawString(detailsString, font, XBrushes.Black, infoRect, XStringFormats.Center);
            currentPt.Offset(0, 10);
        }

        private static void DrawAcInfo(CharacterDetails characterDetails, ref XPoint currentPt, double width, double height, XGraphics graphics)
        {
            var startPt = currentPt;
            XPen linePen = new XPen(XBrushes.Black);
            XFont font = new XFont("Verdana", 10, XFontStyle.Bold);
            var infoRect = new XRect() { Width = width, Height = 10, Location = currentPt };
            graphics.DrawRectangle(linePen, infoRect);

            foreach (var acValue in characterDetails.CharacterArmour.Values)
            {
                var acNameRect = new XRect() { Width = width / characterDetails.CharacterArmour.Values.Count, Height = 10, Location = currentPt };
                graphics.DrawRectangle(linePen, acNameRect);
                graphics.DrawString(acValue.Name, font, XBrushes.Black, acNameRect, XStringFormats.Center);
                currentPt.Offset(0, 10);
                var acValueRect = new XRect { Width = width / 8, Height = 10, Location = currentPt };
                graphics.DrawRectangle(linePen, acValueRect);
                graphics.DrawString(acValue.Value.ToString(), font, XBrushes.Black, acValueRect, XStringFormats.Center);
                currentPt.Offset(width / characterDetails.CharacterArmour.Values.Count, -10);
            }
            currentPt = startPt;
            currentPt.Offset(0, 20);
            for (int i = 0; i < 3; ++i)
            {
                var borderRect = new XRect() { Width = width / 3, Height = height - 50, Location = currentPt};
                graphics.DrawRectangle(linePen, borderRect);
                var nameRect = new XRect() { Width = width / 3, Height = 10, Location = currentPt };
                graphics.DrawRectangle(linePen, nameRect);
                switch (i)
                {
                    case 0:
                        graphics.DrawString("Physical", font, XBrushes.Black, nameRect, XStringFormats.Center);
                        break;
                    case 1:
                        graphics.DrawString("Power", font, XBrushes.Black, nameRect, XStringFormats.Center);
                        break;
                    case 2:
                        graphics.DrawString("Magic", font, XBrushes.Black, nameRect, XStringFormats.Center);
                        break;
                    default:
                        break;
                }
                currentPt.Offset(width / 3, 0);
            }

            currentPt.Offset(0, -20);
        }

        private static void DrawNotes(ref XPoint currentPt, double width, double height, XGraphics graphics)
        {
            var notesRect = new XRect() { Width = width, Height = height, Location = currentPt };
            XPen linePen = new XPen(XBrushes.Black);
            graphics.DrawRectangle(linePen, notesRect);
            var notesName = new XRect() { Width = width, Height = 10, Location = currentPt };
            graphics.DrawRectangle(linePen, notesName);
            XFont font = new XFont("Verdana", 10, XFontStyle.Bold);
            graphics.DrawString("Notes", font, XBrushes.Black, notesName, XStringFormats.Center);

            currentPt.Offset(0, 10);
            var lineRectangle = new XRect
            {
                Width = width,
                Height = height- 10,
                Location = currentPt
            };
            linePen.Width = linePen.Width / 2;
            graphics.DrawRectangle(linePen, lineRectangle);

            for (int i = 0; i < lineRectangle.Height; i += 10)
            {
                XPoint from = new XPoint() { X = lineRectangle.TopLeft.X, Y = lineRectangle.TopLeft.Y + i };
                XPoint to = new XPoint() { X = lineRectangle.TopRight.X, Y = lineRectangle.TopLeft.Y + i };
                graphics.DrawLine(linePen, from, to);
            }
        }
    }
}
