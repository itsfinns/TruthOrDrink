namespace TruthOrDrink;

// op deze pagina een lokale db maken voor tijdelijke spelers op te slaan die je handmatig aan een spel toevoegd. alleen een automatisch ID en naam opslaan.

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