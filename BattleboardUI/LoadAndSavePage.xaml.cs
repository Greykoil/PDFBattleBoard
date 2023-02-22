using BattleBoardModel.Utils;
using BattleBoardViewModel;

namespace BattleboardUI;

public partial class LoadAndSavePage : ContentPage
{
	public LoadAndSavePage()
	{
		InitializeComponent();
        BindingContext = ServiceHelper.GetService<LoadAndSaveViewModel>();
    }
}