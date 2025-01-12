namespace TruthOrDrink;

public partial class Categorys : ContentPage
{
	public Categorys()
	{
		InitializeComponent();
	}

    //controleer werking van deze regel in alle functies hier onder
    private async void OnTruthClicked(object sender, EventArgs e)
	{
        (Application.Current as App).chosenCategory = "Truth";
        var dbService = (Application.Current as App).DbService;
        await Navigation.PushAsync(new AddPlayers(dbService));
	}

    private async void OnDareClicked(object sender, EventArgs e)
    {
        (Application.Current as App).chosenCategory = "Dare";
        var dbService = (Application.Current as App).DbService;
        await Navigation.PushAsync(new AddPlayers(dbService));
    }

    private async void OnWouldYouRatherClicked(object sender, EventArgs e)
    {
        (Application.Current as App).chosenCategory = "WouldYouRather";
        var dbService = (Application.Current as App).DbService;
        await Navigation.PushAsync(new AddPlayers(dbService));
    }

    private async void OnMixedClicked(object sender, EventArgs e)
    {
        (Application.Current as App).chosenCategory = "Mixed";
        var dbService = (Application.Current as App).DbService;
        await Navigation.PushAsync(new AddPlayers(dbService));
    }
}