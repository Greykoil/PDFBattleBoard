using BattleBoardModel.Utils;

namespace BattleboardUI;

public partial class LoadAndSavePage : ContentPage
{
	public LoadAndSavePage()
	{
		InitializeComponent();
        BindingContext = ServiceHelper.GetService<LoadAndSavePage>();
    }
}