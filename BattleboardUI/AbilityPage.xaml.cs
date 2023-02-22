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

    protected override void OnAppearing()
    {
        base.OnAppearing();
        (BindingContext as AbilityViewModel).OnAppearing();
    }
}