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
            DrawArmourRect(ref currentPt, containingRectangle.Width, graphics);
            DrawAcBoxes(ref currentPt, containingRectangle.Width, graphics); ;
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
        }

        private static void DrawArmourRect(ref XPoint currentPt, double width, XGraphics graphics)
        {
            //throw new NotImplementedException();
        }

        private static void DrawAcBoxes(ref XPoint currentPt, double width, XGraphics graphics)
        {
            //throw new NotImplementedException();
        }

    }
}
