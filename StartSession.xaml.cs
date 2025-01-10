namespace TruthOrDrink;

public partial class StartSession : ContentPage
{
	public StartSession()
	{
		InitializeComponent();
	}

	public static int CurrentRating { get; private set; } = 0;  //public zodat deze overal gebruikt kan worden
	

    private void OnStarClicked(object sender, EventArgs e)  //onderstaande functies aanroepen als er op een ster geklikt wordt
    {
		if (sender is ImageButton clickedStar)
		{
			int clickedIndex = GetStarIndex(clickedStar);

			UpdateStars(clickedIndex);
		}
    }

	private int GetStarIndex(ImageButton star)  //index bepalen van moeilijkheid
	{
		return star == Star1 ? 1 :
			   star == Star2 ? 2 :
			   star == Star3 ? 3 :
			   star == Star4 ? 4 :
			   star == Star5 ? 5 : 0;
	}

	private void UpdateStars(int rating)  //Sterren updaten, van vol naar leeg of terug
	{
		CurrentRating = rating;

		Star1.Source = CurrentRating >= 1 ? "star_full.png" : "star_empty.png";
        Star2.Source = CurrentRating >= 2 ? "star_full.png" : "star_empty.png";
        Star3.Source = CurrentRating >= 3 ? "star_full.png" : "star_empty.png";
        Star4.Source = CurrentRating >= 4 ? "star_full.png" : "star_empty.png";
        Star5.Source = CurrentRating >= 5 ? "star_full.png" : "star_empty.png";
    }

    private async void OnNextButtonClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new Categorys());
    }
}