namespace BattleboardUI;

using BattleBoardModel.Utils;
using BattleBoardViewModel;

public partial class CharacterPage : ContentPage
{
	public CharacterPage()
	{
		InitializeComponent();
		BindingContext = new PlayerDetailsViewModel(CharacterBuilder.BuildCharacter().Details);
    }
}