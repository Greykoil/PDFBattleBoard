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
            //   Armour  Notes?
            //   Life    Pools
            //   Magic   Abilities
            double totalPageHeight = containingRectangle.Height;
            double totalPageWidth = containingRectangle.Width;

            var utils = new UtilDrawer(graphics);
            var detailsDrawer = new DetailsDrawer(utils);
            detailsDrawer.DrawNameHeader(character.Details, totalPageWidth, containingRectangle.TopLeft);

            double headerHeight = 3 * utils.DefaultLineHeight;

            #region LeftSide
            double leftSideSpace = totalPageHeight - 3 * utils.DefaultLineHeight;

            var armourDrawer = new ArmourDrawer(utils);
            double armourHeight = armourDrawer.CalculateArmourHeight();
            var armourRect = new XRect() {
                Height = armourHeight, 
                Width = totalPageWidth / 2, 
                Location = new XPoint() { X = containingRectangle.Left, Y = containingRectangle.Top + headerHeight }
                }; 
            armourDrawer.DrawArmour(character.Details.CharacterArmour, armourRect);

            double magicAbilityHeight = 0;

            if (character.CharacterMagic != null)
            {
                var UtilDrawer = new UtilDrawer(graphics);
                var magic = new MagicDrawer(UtilDrawer);
                magicAbilityHeight = magic.CalculateMagicHeight();
            }

            double lifeHeight = leftSideSpace - magicAbilityHeight - armourHeight;

            XRect lifeRect = new XRect()
            {
                Width = totalPageWidth / 2,
                Height = lifeHeight,
                Location = new XPoint() { X = containingRectangle.Left, Y = containingRectangle.Top + headerHeight + armourHeight }
            };
            DrawPoolAbilities(character.PoolAbilites.Where(x => x.Name == "Life").ToList(), lifeRect, graphics);

            XRect magicRect = new XRect()
            {
                Height = magicAbilityHeight,
                Width = totalPageWidth / 2,
                Location = new XPoint()
                {
                    X = containingRectangle.Left,
                    Y = containingRectangle.Top + headerHeight + lifeRect.Height + armourHeight,
                }
            };

            if (character.CharacterMagic != null)
            {
                DrawMagicAbilities(character.CharacterMagic, magicRect, graphics);
            }
            #endregion

            #region RightSide
            var drawer = new UtilDrawer(graphics);
            var foo = new ChargedAbilityDrawer(drawer);
            
            var abilityHeight = foo.CalculateAbilityHeight(character.ChargedAbilities.Where(x => x.Source == Source.Ability));

            var itemHeight = foo.CalculateAbilityHeight(character.ChargedAbilities.Where(x => x.Source == Source.Item));

            var storeHeight = foo.CalculateAbilityHeight(character.ChargedAbilities.Where(x => x.Source == Source.Store));

            double rightSidePoolSpace = totalPageHeight - abilityHeight - itemHeight - storeHeight - headerHeight;

            XRect poolRect = new XRect()
            {
                Height = rightSidePoolSpace,
                Width = totalPageWidth / 2,
                Location = new XPoint() { X = containingRectangle.Left + totalPageWidth / 2, Y = containingRectangle.Top + headerHeight}
            };
            DrawPoolAbilities(character.PoolAbilites.Where(x => x.Name != "Life").ToList(), poolRect, graphics);

            XRect chargedAbilitesRect = new XRect()
            {
                Width = totalPageWidth / 2,
                Height = abilityHeight,
                Location = poolRect.BottomLeft
            };
            DrawChargedAbilites(character.ChargedAbilities.Where(x => x.Source == Source.Ability), chargedAbilitesRect, graphics);

            XRect ItemAbilitesRect = new XRect()
            {
                Width = totalPageWidth / 2,
                Height = itemHeight,
                Location = chargedAbilitesRect.BottomLeft
            };
            DrawChargedAbilites(character.ChargedAbilities.Where(x => x.Source == Source.Item), ItemAbilitesRect, graphics);

            XRect storesAbilityRect = new XRect()
            {
                Width = totalPageWidth / 2,
                Height = storeHeight,
                Location = ItemAbilitesRect.BottomLeft
            };

            DrawChargedAbilites(character.ChargedAbilities.Where(x => x.Source == Source.Store), storesAbilityRect, graphics);


            #endregion
        }

        private static void DrawMagicAbilities(MagicDetails characterMagic, XRect magicAbilitesRect, XGraphics graphics)
        {
            var UtilDrawer = new UtilDrawer(graphics);
            var magic = new MagicDrawer(UtilDrawer);
            magic.DrawMagic(characterMagic, magicAbilitesRect);
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

                var UtilDrawer = new UtilDrawer(gfx);
                var PoolDrawer = new PoolDrawer(UtilDrawer);
                PoolDrawer.DrawPool(poolAbilites[i], rect);
            }
        }

        private static void DrawChargedAbilites(IEnumerable<ChargedAbility> chargedAbilities, XRect chargedAbilitesRect, XGraphics gfx)
        {
            var drawer = new UtilDrawer(gfx);
            var foo = new ChargedAbilityDrawer(drawer);
            foo.DrawChargedSkills(chargedAbilities, chargedAbilitesRect);
        }
    }
}
