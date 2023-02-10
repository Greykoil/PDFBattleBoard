using BattleBoardModel;
using BattleBoardViewModel;

namespace BattleboardUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<ICharacterInterface>(new CharacterInterface());

            builder.Services.AddSingleton<AbilityViewModel>();
            builder.Services.AddSingleton<ArmourViewModel>();
            builder.Services.AddSingleton<LoadAndSaveViewModel>();
            builder.Services.AddSingleton<PlayerDetailsViewModel>();
            builder.Services.AddSingleton<PoolAbilityViewModel>();
            builder.Services.AddSingleton<MagicViewModel>();

            return builder.Build();
        }
    }
}