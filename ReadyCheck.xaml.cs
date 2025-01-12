namespace TruthOrDrink;

public partial class ReadyCheck : ContentPage
{
	public ReadyCheck()
	{
		InitializeComponent();
        SelectedCategoryLabel.Text = (Application.Current as App).chosenCategory;  //line 22 controleren op werking in ReadyCheck.xaml
    }

    private async void OnStartClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GamePage());  
    }
}