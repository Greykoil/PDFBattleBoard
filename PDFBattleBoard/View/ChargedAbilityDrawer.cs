using BattleBoardModel.Model;
using PdfSharpCore.Drawing;

namespace PDFBattleBoard.View
{
    struct ChargedAbilitySplit
    {
        public IEnumerable<ChargedAbility> SingleLineAbilites { get; set; }
        public IEnumerable<ChargedAbility> DoubledUpAbilies { get; set; }
        public IEnumerable<ChargedAbility> TripledUpAbilities { get; set; }
    }

    internal class ChargedAbilityDrawer
    {

        public UtilDrawer DrawingUtils { get; }

        public ChargedAbilityDrawer(UtilDrawer utils)
        {
            DrawingUtils = utils;
        }

        public double CalculateAbilityHeight(IEnumerable<ChargedAbility> abilities)
        {
            var abilitySplit = CreateAbilityDistributions(abilities);

            return
                DrawingUtils.RegionBuffer * 2 + // The buffer above and below the box
                DrawingUtils.DefaultLineHeight + // The header line
                (abilitySplit.SingleLineAbilites.Count() * DrawingUtils.DefaultLineHeight) + // One line per single line ability
                Math.Ceiling((double)abilitySplit.DoubledUpAbilies.Count() / 2) * DrawingUtils.DefaultLineHeight + // One line for every 2 doubled up abilites
                Math.Ceiling((double)abilitySplit.TripledUpAbilities.Count() / 3) * DrawingUtils.DefaultLineHeight  // One line for every 3 trippled up abilites
                ;
        }

        public void DrawChargedSkills(IEnumerable<ChargedAbility> abilities, XRect xRect)
        {
            var innerRegion = DrawingUtils.CreateRegion(xRect, abilities.First().Source.ToString());

            var splitAbilites = CreateAbilityDistributions(abilities);

            var totalWidth = innerRegion.Width;
            var currentPoint = innerRegion.TopLeft;
            foreach (var item in splitAbilites.SingleLineAbilites)
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
                else if (item.Frequent == Frequency.Daily)
                {
                    DrawingUtils.CheckCircleRectangle(item.Charges, chargesWidth, currentPoint);
                }
                else
                {
                    DrawingUtils.CheckBoxRectangle(item.Charges, chargesWidth, currentPoint);
                }

                currentPoint.X = innerRegion.Left;
                currentPoint.Offset(0, DrawingUtils.DefaultLineHeight);
            }

            var halfWidth = totalWidth / 2;
            bool halfOffset = false;
            foreach (var item in splitAbilites.DoubledUpAbilies)
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
                else if (item.Frequent == Frequency.Daily)
                {
                    DrawingUtils.CheckCircleRectangle(item.Charges, chargesWidth, currentPoint);
                }
                else
                {
                    DrawingUtils.CheckBoxRectangle(item.Charges, chargesWidth, currentPoint);
                }

                if (halfOffset)
                {
                    halfOffset = false;
                    currentPoint.X = innerRegion.Left;
                    currentPoint.Offset(0, DrawingUtils.DefaultLineHeight);
                }
                else
                {
                    halfOffset = true;
                    currentPoint.X = innerRegion.Left + halfWidth;
                }
            }

            if (halfOffset)
            {
                currentPoint.X = innerRegion.Left;
                currentPoint.Offset(0, DrawingUtils.DefaultLineHeight);
            }

            var thirdWidth = totalWidth / 3;
            int indendationLevel = 0;

            foreach (var item in splitAbilites.TripledUpAbilities)
            {
                var nameWidth = totalWidth / 4;
                DrawingUtils.TextRectangle(item.Name, nameWidth, currentPoint);
                currentPoint.Offset(nameWidth, 0);
                var chargesWidth = thirdWidth - nameWidth;

                if (item.Frequent == Frequency.Daily)
                {
                    DrawingUtils.CheckCircleRectangle(item.Charges, chargesWidth, currentPoint);
                }
                else
                {
                    DrawingUtils.CheckBoxRectangle(item.Charges, chargesWidth, currentPoint);
                }

                if (indendationLevel == 2)
                {
                    indendationLevel = 0;
                    currentPoint.X = innerRegion.Left;
                    currentPoint.Offset(0, DrawingUtils.DefaultLineHeight);
                }
                else
                {
                    indendationLevel += 1;
                    currentPoint.X = innerRegion.Left + (thirdWidth * indendationLevel);
                }
            }
        }


        public ChargedAbilitySplit CreateAbilityDistributions(IEnumerable<ChargedAbility> abilities)
        {
            var singleLineAbilites = new List<ChargedAbility>();
            var doubledUpAbilies = new List<ChargedAbility>();
            var tripledUpAbilities = new List<ChargedAbility>();

            foreach (var ability in abilities)
            {
                if (ability.Charges == 1 && ability.Frequent != Frequency.Sectional)
                {
                    tripledUpAbilities.Add(ability);
                }
                else if (ability.Charges > 7 || (ability.Frequent == Frequency.Sectional && ability.Charges > 2))
                {
                    singleLineAbilites.Add(ability);
                }
                else
                {
                    doubledUpAbilies.Add(ability);
                }
            }

            // Move triple to double where it doesn't cost a line
            while (tripledUpAbilities.Count() % 3 != 0)
            {
                doubledUpAbilies.Add(tripledUpAbilities.First());
                tripledUpAbilities.RemoveAt(0);
            }

            return new ChargedAbilitySplit()
            {
                SingleLineAbilites = singleLineAbilites,
                DoubledUpAbilies = doubledUpAbilies,
                TripledUpAbilities = tripledUpAbilities
            };
        }
    }
}
