namespace TruthOrDrink;

public partial class StartSession : ContentPage
{
	public StartSession()
	{
		InitializeComponent();
	}

	private int currentRating = 0;     //Deze int is voor binnen de StartSession

	public int CurrentRating          //Deze int neemt de waarde mee naar een public, waardoor hij later te benaderen is in andere paginas / functies
	{
		get { return currentRating; }
	}

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
		currentRating = rating;

		Star1.Source = currentRating >= 1 ? "star_full.png" : "star_empty.png";
        Star2.Source = currentRating >= 2 ? "star_full.png" : "star_empty.png";
        Star3.Source = currentRating >= 3 ? "star_full.png" : "star_empty.png";
        Star4.Source = currentRating >= 4 ? "star_full.png" : "star_empty.png";
        Star5.Source = currentRating >= 5 ? "star_full.png" : "star_empty.png";
    }

    private async void OnNextButtonClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new Categorys());
    }
}