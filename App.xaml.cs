namespace TruthOrDrink
{
    public partial class App : Application

    {
        public string chosenCategory { get; set; }

        public LocalDBService DbService { get; private set; } //Deze is nodig om navigatie vanaf Categorys naar AddPlayers mogelijk te maken

        //public int currentRating { get; set; }

        public App()
        {
            InitializeComponent();

            DbService = new LocalDBService();
            MainPage = new NavigationPage(new MainPage());
            
        }
    }
}
