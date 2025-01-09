using System.Net.Http;
using Newtonsoft.Json.Linq;
using System;

namespace TruthOrDrink;

public partial class GamePage : ContentPage
{
    private static readonly HttpClient client = new HttpClient();
	public GamePage()
	{
		InitializeComponent();

        string ChosenCategory = (Application.Current as App).chosenCategory; //deze pakt vanuit app.xaml.cs de waarde van de gekozen categorie, zodat die ook hier weer gebruikt kan worden.
    }

    private async void OnDrinkClicked(object sender, EventArgs e)
	{
        string ChosenCategory = (Application.Current as App).chosenCategory;

        if (ChosenCategory == "Truth")
        {
            DisplayAlert("Actie", ChosenCategory, "OK");
        }
        else if (ChosenCategory == "Dare")
        {
            DisplayAlert(Title, ChosenCategory, "OK");
        }
        else if (ChosenCategory == "WouldYouRather")
        {
            DisplayAlert(Title, ChosenCategory, "OK");
        }
        else if (ChosenCategory == "Mixed")
        {
            DisplayAlert(Title, ChosenCategory, "ok");
        }
    }

    private async void OnAnwserClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new GamePage());
    }
}