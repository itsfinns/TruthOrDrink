namespace TruthOrDrink
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddFriendsClicked(object sender, EventArgs e)
        {

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
