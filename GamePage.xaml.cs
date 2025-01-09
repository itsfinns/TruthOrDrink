namespace TruthOrDrink;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();
	}

    private async void OnDrinkClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new GamePage());
    }

    private async void OnAnwserClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new GamePage());
    }
}