namespace TruthOrDrink;

public partial class ReadyCheck : ContentPage
{
	public ReadyCheck()
	{
		InitializeComponent();
	}

    private async void OnStartClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new StartSession());  //aanpassen naar juiste pagina (deze staat er tijdelijk om functionaliteit te controleren)
    }
}