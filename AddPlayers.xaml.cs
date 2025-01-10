namespace TruthOrDrink;

public partial class AddPlayers : ContentPage
{
	public AddPlayers()
	{
		InitializeComponent();
	}

    private async void OnNextButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new GamePage());
	}
}