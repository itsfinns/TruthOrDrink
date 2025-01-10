namespace TruthOrDrink;

// op deze pagina een lokale db maken voor tijdelijke spelers op te slaan die je handmatig aan een spel toevoegd. alleen een automatisch ID en naam opslaan.

public partial class AddPlayers : ContentPage
{

	private readonly LocalDBService _dbService;
	private int _editPlayerId;
	public AddPlayers(LocalDBService dbService)
    {
		InitializeComponent();
		_dbService = dbService;
		Task.Run(async () => listView.ItemsSource = await _dbService.GetPlayers());
	}



    private async void onAddClicked(object sender, EventArgs e)
	{
		if (_editPlayerId == 0)
		{
			await _dbService.Create(new Player
			{
				Name = NameEntry.Text
			});
		}
		else
		{
			await _dbService.Update(new Player
			{
				Id = _editPlayerId,
				Name = NameEntry.Text
			});

			_editPlayerId = 0;
		}

		NameEntry.Text = string.Empty;  //Maakt placeholder weer leeg voor betere ervaring

		listView.ItemsSource = await _dbService.GetPlayers();
	}

	private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
	{
		var player = (Player)e.Item;
		var action = await DisplayActionSheet("Action", "Terug", null, "Bewerken", "Verwijderen");

		switch (action)
		{
			case "Edit":
				_editPlayerId = player.Id;
				NameEntry.Text = player.Name;

				break;

			case "Delete":
				await _dbService.Delete(player);
				listView.ItemsSource = await _dbService.GetPlayers();

				break;
		}
	}

    private async void OnNextButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new GamePage());
	}
}