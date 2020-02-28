using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ThroatHurts.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Accesos rápidos";
            OpenWebCommand = new Command(async () => await SpeakNowDefaultSettings( ));
            OpenWebCommand2 = new Command(async () => await SpeakNowDefaultSettings2( ));
            OpenWebCommand3 = new Command(async () => await SpeakNowDefaultSettings3( ));
            OpenWebCommand4 = new Command(async () => await SpeakNowDefaultSettings4( )); 
        }
        public async Task SpeakNowDefaultSettings( )
        {
            var locales = await TextToSpeech.GetLocalesAsync(); 
            var locale = locales.FirstOrDefault(x => x.Language == "es");

            var settings = new SpeechOptions()
            { 
                Locale = locale
            }; 
            await TextToSpeech.SpeakAsync("Hola"); 
        }

        public async Task SpeakNowDefaultSettings2()
        {
            var locales = await TextToSpeech.GetLocalesAsync();
            var locale = locales.FirstOrDefault(x => x.Language == "es");

            var settings = new SpeechOptions()
            {
                Locale = locale
            };
            await TextToSpeech.SpeakAsync("Te amo");
        }
        public async Task SpeakNowDefaultSettings3()
        {
            var locales = await TextToSpeech.GetLocalesAsync();
            var locale = locales.FirstOrDefault(x => x.Language == "es");

            var settings = new SpeechOptions()
            {
                Locale = locale
            };
            await TextToSpeech.SpeakAsync("si");
        }
        public async Task SpeakNowDefaultSettings4()
        {
            var locales = await TextToSpeech.GetLocalesAsync();
            var locale = locales.FirstOrDefault(x => x.Language == "es");

            var settings = new SpeechOptions()
            {
                Locale = locale
            };
            await TextToSpeech.SpeakAsync("no");
        }

        public ICommand OpenWebCommand { get; }
        public ICommand OpenWebCommand2 { get; }
        public ICommand OpenWebCommand3 { get; }
        public ICommand OpenWebCommand4 { get; } 
    }
}