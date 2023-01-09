using PDFBattleBoard.Model;
using PdfSharpCore.Drawing;

namespace PDFBattleBoard.View
{
    internal class CharacterDrawer
    {
        public static void DrawCharacter(Character character, XGraphics graphics, XRect containingRectangle)
        {
            // The hard part here is going to be the division of the page, but for now lets do 
            // Character details across the top.
            // Pool Details down the left
            // Charged details down the right

            double totalPageHeight = containingRectangle.Height;
            double totalPageWidth = containingRectangle.Width;

            XRect characterDetailsRect = new XRect() { Width = totalPageWidth, Height = 100 };


            XRect chargedAbilitesRect = new XRect()
            {
                Width = totalPageWidth / 2,
                Height = totalPageHeight - characterDetailsRect.Height,
                Location = new XPoint() { X = totalPageWidth / 2, Y = characterDetailsRect.Height }
            };
            
            XRect poolAbilitesRect = new XRect() 
            { 
                Width = totalPageWidth / 2, 
                Height = totalPageHeight - characterDetailsRect.Height,
                Location = new XPoint() { X = 0, Y = characterDetailsRect.Height }
            };

            DetailsDrawer.DrawCharacterDetails(character.Details, graphics, characterDetailsRect);


            DrawChargedAbilites(character.ChargedAbilities, chargedAbilitesRect, graphics);
            DrawPoolAbilities(character.PoolAbilites, poolAbilitesRect, graphics);
        }

        private static void DrawPoolAbilities(List<PoolAbility> poolAbilites, XRect poolAbilitesRect, XGraphics gfx)
        {
            double height = poolAbilitesRect.Height / poolAbilites.Count;

            for (int i = 0; i < poolAbilites.Count; ++i)
            {
                XPoint location = poolAbilitesRect.TopLeft;
                location.Y += height * i;
                XRect rect = new XRect()
                {
                    Width = poolAbilitesRect.Width,
                    Height = height,
                    Location = location
                };

                PoolDrawer.DrawPool(poolAbilites[i], gfx, rect);
            }
        }

        private static void DrawChargedAbilites(List<ChargedAbility> chargedAbilities, XRect chargedAbilitesRect, XGraphics gfx)
        {
            for (int i = 0; i < chargedAbilities.Count; ++i)
            {
                XPoint location = chargedAbilitesRect.TopLeft;
                location.Y += i * 10;
                XRect rect = new XRect() { Width = chargedAbilitesRect.Width, Height = 10, Location = location };
                ChargedAbilityDrawer.DrawChargedAbility(chargedAbilities[i], gfx, rect);
            }
        }
    }
}
