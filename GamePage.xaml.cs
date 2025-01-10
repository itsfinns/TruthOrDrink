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


        string currentRating = Convert.ToString(StartSession.CurrentRating);  //Haalt de sterren rating uit StartSession en zet om naar string ivm Display Alart functie

        if (ChosenCategory == "Truth")
        {
            DisplayAlert("Aantal slokken:", currentRating , "OK");
        }
        else if (ChosenCategory == "Dare")
        {
            DisplayAlert("Aantal slokken", currentRating, "OK");
        }
        else if (ChosenCategory == "WouldYouRather")
        {
            DisplayAlert("Aantal slokken", currentRating, "OK");
        }
        else if (ChosenCategory == "Mixed")
        {
            DisplayAlert("Aantal slokken", currentRating, "ok");
        }
    }

    private async void OnAnwserClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new GamePage());
    }
}