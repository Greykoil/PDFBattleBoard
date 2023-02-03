using BattleBoardModel.Utils;
using BattleBoardViewModel;

namespace BattleboardUI;

public partial class ArmourPage : ContentPage
{
	public ArmourPage()
	{
		InitializeComponent();
		BindingContext = new ArmourViewModel(CharacterBuilder.BuildCharacter().Details.CharacterArmour);
    }
}