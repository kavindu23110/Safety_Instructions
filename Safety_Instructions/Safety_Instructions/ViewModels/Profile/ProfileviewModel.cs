using Plugin.Media;
using Safety_app.Helpers;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Safety_Instructions.ViewModels.Profile
{
    public class ProfileviewModel : BaseViewModel
    {

        public ICommand TakeImageCommand { get; set; }
        public ICommand NextCommand { get; set; }
        public ProfileviewModel()
        {
            TakeImageCommand = new Command(OnTakeImageAsync);
            NextCommand = new Command(OnNextAsync);
            profile = new Data.Models.Profile();
        }

        private void OnNextAsync(object obj)
        {
            App.Current.MainPage = new AppShell();
        }

        private async void OnTakeImageAsync(object obj)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                StaticFunctions.DisplayAlert_ProvideInformationAsync("Camera", "This device havent camera.");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Profilepic",
                Name = $"{Guid.NewGuid()}.jpg"
            });

            if (file == null)
                return;

            profile = new Data.Models.Profile() { ImagePath = file.AlbumPath, Name = profile.Name };



        }
    }
}
