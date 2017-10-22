using System;
using Xamarin.Forms;
using System.Windows.Input;


namespace App5
{
    class MainPageViewModel
    {
        public ICommand ButtonClickedCommand { get; set; }

        public MainPageViewModel()
        {
            ButtonClickedCommand = new Command(HandleButtonClick);
        }

        private void HandleButtonClick()
        {
            MessagingCenter.Send<MainPageViewModel>(this, "ButtonClicked");

        }
    }
}
