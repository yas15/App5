using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;

        public MainPage()
        {
            InitializeComponent();

            vm = new MainPageViewModel();

            // set the BindingContext Property of the view MainPage to a new instance of the MainPage ViewModel.
            // i.e. set the default datasource for all the objects in the MainPage View to the objects in the MainPageViewModel.
            BindingContext = vm;

            // Xamarin.Forms.MessagingCenter allows a developer to send and process events easily in code.
            // MessagingCenter methods include: -
            // Send: Send will raise an event. It publishes a message on which a listener can act.
            // Subscribe: Subscribe will listen for messages that have a certain signature. 
            // Multiple listeners can subscribe to the same message signature.
            // Unsubscribe: Unsubscribe will stop a listener from responding to messages with the defined signature.
            MessagingCenter.Subscribe<MainPageViewModel>(vm, "ButtonClicked", (sender) =>
            {
                DisplayAlert("Message", "Button Clicked!", "OK");
            });

        }
    }
}
