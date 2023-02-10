using BattleBoardModel.Utils;
using BattleBoardViewModel;

namespace BattleboardUI;

public partial class MagicPage : ContentPage
{
	public MagicPage()
	{
		InitializeComponent();
        BindingContext = new MagicViewModel(CharacterBuilder.BuildCharacter().CharacterMagic);
    }
}