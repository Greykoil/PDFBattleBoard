using BattleBoardModel.Utils;
using BattleBoardViewModel;

namespace BattleboardUI;

public partial class PoolAbilityPage : ContentPage
{
	public PoolAbilityPage()
	{
		InitializeComponent();
        BindingContext = new PoolAbilityViewModel(CharacterBuilder.BuildCharacter().PoolAbilites);
    }
}