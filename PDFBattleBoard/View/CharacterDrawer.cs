using PDFBattleBoard.Model;
using PdfSharpCore.Drawing;

namespace PDFBattleBoard.View
{
    internal class CharacterDrawer
    {
        public static void DrawCharacter(Character character, XGraphics graphics, XRect fullRectangle)
        {

            var containingRectangle = new XRect()
            {
                Height = fullRectangle.Height - 20,
                Width = fullRectangle.Width - 20,
                Location = new XPoint() { X = fullRectangle.TopLeft.X + 10, Y = fullRectangle.TopLeft.Y + 10 }
            };

            // The hard part here is going to be the division of the page, but for now lets do 
            // Character details across the top.
            //   Life    Pools
            //   Magic   Abilities
            double totalPageHeight = containingRectangle.Height;
            double totalPageWidth = containingRectangle.Width;

            XRect characterDetailsRect = new XRect() { Width = totalPageWidth, Height = 100, Location = containingRectangle.TopLeft};

            #region LeftSide

            DetailsDrawer.DrawCharacterDetails(character.Details, graphics, characterDetailsRect);
            
            double leftSideSpace = totalPageHeight - characterDetailsRect.Height;

            double magicAbilityHeight = 0;


            if (character.CharacterMagic != null)
            {
                magicAbilityHeight = MagicDrawer.CalculateMagicHeight();
            }

            double lifeHeight = leftSideSpace - magicAbilityHeight;

            XRect lifeRect = new XRect()
            {
                Width = totalPageWidth / 2,
                Height = lifeHeight,
                Location = new XPoint() { X = containingRectangle.Left, Y = containingRectangle.Top + characterDetailsRect.Height }
            };
            DrawPoolAbilities(character.PoolAbilites.Where(x => x.Name == "Life").ToList(), lifeRect, graphics);

            XRect magicRect = new XRect()
            {
                Height = magicAbilityHeight,
                Width = totalPageWidth / 2,
                Location = new XPoint()
                {
                    X = containingRectangle.Left,
                    Y = containingRectangle.Top + characterDetailsRect.Height + lifeRect.Height
                }
            };

            if (character.CharacterMagic != null)
            {
                DrawMagicAbilities(character.CharacterMagic, magicRect, graphics);
            }
            #endregion

            #region RightSide
            double abilityHeight = ChargedAbilityDrawer.CalculateAbilityHeight(character.ChargedAbilities);
            double rightSideSpace = totalPageHeight - (abilityHeight + 30);
            
            XRect poolRect = new XRect()
            {
                Height = rightSideSpace,
                Width = totalPageWidth / 2,
                Location = new XPoint() { X = containingRectangle.Left + totalPageWidth / 2, Y = 40}
            };
            DrawPoolAbilities(character.PoolAbilites.Where(x => x.Name != "Life").ToList(), poolRect, graphics);

            XRect chargedAbilitesRect = new XRect()
            {
                Width = totalPageWidth / 2,
                Height = abilityHeight,
                Location = new XPoint() { X = containingRectangle.Left + totalPageWidth / 2, Y = containingRectangle.Top + poolRect.Height + 30}
            };
            DrawChargedAbilites(character.ChargedAbilities, chargedAbilitesRect, graphics);
            #endregion
        }

        private static void DrawMagicAbilities(MagicDetails characterMagic, XRect magicAbilitesRect, XGraphics graphics)
        {
            MagicDrawer.DrawMagic(characterMagic, graphics, magicAbilitesRect);
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
            ChargedAbilityDrawer.DrawChargedSkills(chargedAbilities, gfx, chargedAbilitesRect);
        }
    }
}
