namespace TruthOrDrink
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnProfileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void OnStartSessionClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StartSession());
        }

        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }

        private async void OnQrClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScanCode());
        }

    }

}
