namespace TruthOrDrink;

public partial class Categorys : ContentPage
{
	public Categorys()
	{
		InitializeComponent();
	}

	public string chosenCategory = "";

    private async void OnTruthClicked(object sender, EventArgs e)
	{
		chosenCategory = "Truth";
		await Navigation.PushAsync(new ReadyCheck());
	}

    private async void OnDareClicked(object sender, EventArgs e)
    {
        chosenCategory = "Dare";
        await Navigation.PushAsync(new ReadyCheck());
    }

    private async void OnWouldYouRatherClicked(object sender, EventArgs e)
    {
        chosenCategory = "WouldYouRather";
        await Navigation.PushAsync(new ReadyCheck());
    }

    private async void OnMixedClicked(object sender, EventArgs e)
    {
        chosenCategory = "Mixed";
        await Navigation.PushAsync(new ReadyCheck());
    }
}