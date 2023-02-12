using BattleBoardModel;
using CommunityToolkit.Maui.Storage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;


namespace BattleBoardViewModel
{
    public class LoadAndSaveViewModel : BindableObject
    {
        private ICharacterInterface _character;

        public ICommand LoadCharacter { get; set; }
        public ICommand SaveCharacter { get; set; }

        public LoadAndSaveViewModel(ICharacterInterface character)
        {
            _character = character;
            LoadCharacter = new Command(OnLoadCharacter);
            SaveCharacter = new Command(OnSaveCharacter);
        }

        private void OnLoadCharacter()
        {
            PickOptions options = new PickOptions()
            {
                FileTypes = new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>
                {
                    { DevicePlatform.iOS, new[] { ".json" } },
                    { DevicePlatform.Android, new[] { ".json" } },
                    { DevicePlatform.WinUI, new[] { ".json" } },
                    { DevicePlatform.Tizen, new[] { ".json" } },
                    { DevicePlatform.macOS, new[] { ".json" } }
                })
            };

            var result = FilePicker.Default.PickAsync(options);

        }

        private async void OnSaveCharacter()
        {
            CancellationToken token = new CancellationToken();
            using var stream = new MemoryStream(Encoding.Default.GetBytes("Hello from the Community Toolkit!"));
            var fileLocation = await FileSaver.Default.SaveAsync("test.txt", stream, token);
        }
    }
}
