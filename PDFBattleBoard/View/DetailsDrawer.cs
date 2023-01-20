using PDFBattleBoard.Model;
using PdfSharpCore.Drawing;

namespace PDFBattleBoard.View
{
    internal class DetailsDrawer
    {
        public UtilDrawer Utils { get; }

        public DetailsDrawer(UtilDrawer utils)
        {
            Utils = utils;
        }

        public void DrawNameHeader(CharacterDetails characterDetails, double width, XPoint startingPoint)
        {
            Utils.HeaderTextRectangle(characterDetails.Name, width, startingPoint);

            string detailsString = characterDetails.CharacterRace.ToString() + " " + characterDetails.PlayerClass +
              "  -  Points: " + characterDetails.Points.ToString() +
              "  -  Res Chances: " + characterDetails.ResChances +
              "  -  Deaths on Event: ";

            startingPoint.Offset(0, 2 * Utils.DefaultLineHeight);

            Utils.TextRectangle(detailsString, width, startingPoint);
        }
    }
}
