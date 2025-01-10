using System.Net.Http;  //zodat http links gebruikt kunnen worden
using Newtonsoft.Json.Linq;  //voor parsen
using System;

namespace TruthOrDrink;

public partial class GamePage : ContentPage
{
    private static readonly HttpClient client = new HttpClient();  //maakt een readonly naar een http link

    private LocalDBService _localDBService;

    public GamePage()
    {
        InitializeComponent();

        _localDBService = new LocalDBService(); //haalt database service binnen

        string ChosenCategory = (Application.Current as App).chosenCategory; //deze pakt vanuit app.xaml.cs de waarde van de gekozen categorie, zodat die ook hier weer gebruikt kan worden.

    }

    private void VibratePhone() //geeft trilling functie
    {
        int secondsToVibrate = Random.Shared.Next(1, 1);
        TimeSpan vibrationLength = TimeSpan.FromSeconds(secondsToVibrate);

        Vibration.Default.Vibrate(vibrationLength);
    }

    private async void OnDrinkClicked(object sender, EventArgs e)
    {
        string ChosenCategory = (Application.Current as App).chosenCategory;

        string randomPlayerName = await _localDBService.GetRandomPlayerNameAsync();  //haal random naam binnen
        RandomPlayerName.Text = randomPlayerName ?? "Geen speler gevonden.";  //wijst random naam toe
        VibratePhone();


        string currentRating = Convert.ToString(StartSession.CurrentRating);  //Haalt de sterren rating uit StartSession en zet om naar string ivm Display Alart functie

        if (ChosenCategory == "Truth")
        {
            DisplayAlert("Aantal slokken:", currentRating, "OK");

            try
            {
                string apiUrl = "https://api.truthordarebot.xyz/v1/truth";

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // maakt een exception als de statuscode geen succes is

                string jsonResult = await response.Content.ReadAsStringAsync();

                //resultaat parsen van json naar string
                var jsonObject = JObject.Parse(jsonResult);
                string question = jsonObject["question"]?.ToString();

                QuestionLabel.Text = question ?? "Geen vraag gevonden.";  //update het questionlabel
            }
            catch (Exception ex)
            { QuestionLabel.Text = ex.Message; }


        }
        else if (ChosenCategory == "Dare")
        {
            DisplayAlert("Aantal slokken:", currentRating, "OK");

            try
            {
                string apiUrl = "https://api.truthordarebot.xyz/api/dare";

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // maakt een exception als de statuscode geen succes is

                string jsonResult = await response.Content.ReadAsStringAsync();

                //resultaat parsen van json naar string
                var jsonObject = JObject.Parse(jsonResult);
                string question = jsonObject["question"]?.ToString();

                QuestionLabel.Text = question ?? "Geen vraag gevonden.";  //update het questionlabel
            }
            catch (Exception ex)
            { QuestionLabel.Text = ex.Message; }


        }
        else if (ChosenCategory == "WouldYouRather")
        {
            DisplayAlert("Aantal slokken:", currentRating, "OK");

            try
            {
                string apiUrl = "https://api.truthordarebot.xyz/api/wyr";

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // maakt een exception als de statuscode geen succes is

                string jsonResult = await response.Content.ReadAsStringAsync();

                //resultaat parsen van json naar string
                var jsonObject = JObject.Parse(jsonResult);
                string question = jsonObject["question"]?.ToString();

                QuestionLabel.Text = question ?? "Geen vraag gevonden.";  //update het questionlabel
            }
            catch (Exception ex)
            { QuestionLabel.Text = ex.Message; }
        }


        else if (ChosenCategory == "Mixed")
        {
            DisplayAlert("Aantal slokken:", currentRating, "ok");
        }
    }

    // hier onder is beantwoorden

    private async void OnAnwserClicked(object sender, EventArgs e)
	{
        string ChosenCategory = (Application.Current as App).chosenCategory;

        string randomPlayerName = await _localDBService.GetRandomPlayerNameAsync();  //haal random naam binnen
        RandomPlayerName.Text = randomPlayerName ?? "Geen speler gevonden.";  //wijs random naam toe

        if (ChosenCategory == "Truth")
        {

            try
            {
                string apiUrl = "https://api.truthordarebot.xyz/v1/truth";

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // maakt een exception als de statuscode geen succes is

                string jsonResult = await response.Content.ReadAsStringAsync();

                //resultaat parsen van json naar string
                var jsonObject = JObject.Parse(jsonResult);
                string question = jsonObject["question"]?.ToString();

                QuestionLabel.Text = question ?? "Geen vraag gevonden.";  //update het questionlabel

            }
            catch (Exception ex)
            { QuestionLabel.Text = ex.Message; }


        }
        else if (ChosenCategory == "Dare")
        {

            try
            {
                string apiUrl = "https://api.truthordarebot.xyz/api/dare";

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // maakt een exception als de statuscode geen succes is

                string jsonResult = await response.Content.ReadAsStringAsync();

                //resultaat parsen van json naar string
                var jsonObject = JObject.Parse(jsonResult);
                string question = jsonObject["question"]?.ToString();

                QuestionLabel.Text = question ?? "Geen vraag gevonden.";  //update het questionlabel

            }
            catch (Exception ex)
            { QuestionLabel.Text = ex.Message; }


        }
        else if (ChosenCategory == "WouldYouRather")
        {

            try
            {
                string apiUrl = "https://api.truthordarebot.xyz/api/wyr";

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode(); // maakt een exception als de statuscode geen succes is

                string jsonResult = await response.Content.ReadAsStringAsync();

                //resultaat parsen van json naar string
                var jsonObject = JObject.Parse(jsonResult);
                string question = jsonObject["question"]?.ToString();

                QuestionLabel.Text = question ?? "Geen vraag gevonden.";  //update het questionlabel

            }
            catch (Exception ex)
            { QuestionLabel.Text = ex.Message; }
        }


        else if (ChosenCategory == "Mixed")
        {

        }
    }
}
