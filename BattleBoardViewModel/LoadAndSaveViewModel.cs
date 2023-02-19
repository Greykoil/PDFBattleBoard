using BattleBoardModel;
using BattleBoardModel.Model;
using CommunityToolkit.Maui.Storage;
using Newtonsoft.Json;
using System.Text;
using System.Windows.Input;
using PDFBattleBoard;

namespace BattleBoardViewModel
{
    public class LoadAndSaveViewModel : BindableObject
    {
        private ICharacterInterface _character;

        public ICommand LoadCharacter { get; set; }
        public ICommand SaveCharacter { get; set; }
        public ICommand CreatePDF { get; set; }

        public LoadAndSaveViewModel(ICharacterInterface character)
        {
            _character = character;
            LoadCharacter = new Command(OnLoadCharacter);
            SaveCharacter = new Command(OnSaveCharacter);
            CreatePDF = new Command(OnCreatePDF);
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

            var pickerTask = FilePicker.Default.PickAsync(options);
            
            FileResult pickerResult = await pickerTask;

            if (pickerResult == null)
            {
                return;
            }

            var fileStream = pickerResult.OpenReadAsync().Result;
            StreamReader reader = new StreamReader(fileStream);
            string text = reader.ReadToEnd();

            Character newChar = JsonConvert.DeserializeObject<Character>(text);

            _character.UpdateCharacter(newChar);
        }

        private async void OnSaveCharacter()
        {
            CancellationToken token = new CancellationToken();
            var output = JsonConvert.SerializeObject(_character.GetCharacter(), Formatting.Indented);

            var memStream = new MemoryStream(Encoding.UTF8.GetBytes(output));

            string defaultName = _character.GetCharacter().Details.Name;
            var fileLocation = await FileSaver.Default.SaveAsync(defaultName + ".json", memStream, token);
        }

        private async void OnCreatePDF()
        {
            CancellationToken token = new CancellationToken();
            string defaultName = _character.GetCharacter().Details.Name;
            var memStream = new MemoryStream(Encoding.UTF8.GetBytes(""));
            var fileLocation = await FileSaver.Default.SaveAsync(defaultName + ".pdf", memStream, token);

            PDFWriter.CreatePdf(_character.GetCharacter(), fileLocation);
        }
    }
}
