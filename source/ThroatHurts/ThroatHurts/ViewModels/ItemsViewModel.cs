using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using ThroatHurts.Models;
using ThroatHurts.Views;
using System.Windows.Input;
using Xamarin.Essentials;
using System.Linq;

namespace ThroatHurts.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
 

        public ItemsViewModel()
        {
            Title = "Escribir"; 
            OpenWebCommand = new Command(async () => await SpeakNowDefaultSettings()); 
        }
   
        public string Message { get; set; }

        public async Task SpeakNowDefaultSettings()
        {
            string message = this.Message;
            var locales = await TextToSpeech.GetLocalesAsync();

            // Grab the first locale
            var locale = locales.FirstOrDefault(x => x.Language == "es");

            var settings = new SpeechOptions()
            {
                Locale = locale
            };

            await TextToSpeech.SpeakAsync(message);
        }

        public ICommand OpenWebCommand { get; }

    }
}