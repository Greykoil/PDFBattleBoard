using BattleBoardModel.Utils;
using BattleBoardViewModel;

namespace BattleboardUI;

public partial class PoolAbilityPage : ContentPage
{
	public PoolAbilityPage()
	{
		InitializeComponent();
        BindingContext = ServiceHelper.GetService<PoolAbilityViewModel>();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        (BindingContext as PoolAbilityViewModel).OnAppearing();
    }
}