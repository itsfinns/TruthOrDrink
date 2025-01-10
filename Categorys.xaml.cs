namespace TruthOrDrink;

public partial class Categorys : ContentPage
{
	public Categorys()
	{
		InitializeComponent();
	}


    private async void OnTruthClicked(object sender, EventArgs e)
	{
        (Application.Current as App).chosenCategory = "Truth";   //controleer werking van deze regel in alle functies hier onder
        await Navigation.PushAsync(new AddPlayers());
	}

    private async void OnDareClicked(object sender, EventArgs e)
    {
        (Application.Current as App).chosenCategory = "Dare";
        await Navigation.PushAsync(new AddPlayers());
    }

    private async void OnWouldYouRatherClicked(object sender, EventArgs e)
    {
        (Application.Current as App).chosenCategory = "WouldYouRather";
        await Navigation.PushAsync(new AddPlayers());
    }

    private async void OnMixedClicked(object sender, EventArgs e)
    {
        (Application.Current as App).chosenCategory = "Mixed";
        await Navigation.PushAsync(new AddPlayers());
    }
}