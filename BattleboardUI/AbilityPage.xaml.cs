using BattleBoardModel.Utils;
using BattleBoardViewModel;

namespace BattleboardUI;

public partial class AbilityPage : ContentPage
{
	public AbilityPage()
	{
		InitializeComponent();
		BindingContext = ServiceHelper.GetService<AbilityViewModel>();
    }
}