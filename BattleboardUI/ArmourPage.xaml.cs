using BattleBoardModel.Utils;
using BattleBoardViewModel;

namespace BattleboardUI;

public partial class ArmourPage : ContentPage
{
	public ArmourPage()
	{
		InitializeComponent();
		BindingContext = ServiceHelper.GetService<ArmourViewModel>();
    }
}