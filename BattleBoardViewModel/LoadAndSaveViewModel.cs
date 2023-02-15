using BattleBoardModel;
using BattleBoardModel.Model;
using CommunityToolkit.Maui.Storage;
using Newtonsoft.Json;
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

        private async void OnLoadCharacter()
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

            var foobaa = FilePicker.Default.PickAsync(options);
            
            var thing2 = await foobaa;

            var thing =  thing2.OpenReadAsync().Result;
            StreamReader reader = new StreamReader(thing);
            string text = reader.ReadToEnd();

            Character newChar = JsonConvert.DeserializeObject<Character>(text);

            var foo = _character.GetCharacter();
            
            foo = newChar;
        }

        private async void OnSaveCharacter()
        {
            CancellationToken token = new CancellationToken();
            var output = JsonConvert.SerializeObject(_character.GetCharacter(), Formatting.Indented);

            var repo = new MemoryStream(Encoding.UTF8.GetBytes(output));

            string defaultName = _character.GetCharacter().Details.Name;
            var fileLocation = await FileSaver.Default.SaveAsync(defaultName + ".json", repo, token);
        }
    }
}
