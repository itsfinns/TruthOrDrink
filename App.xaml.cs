namespace TruthOrDrink
{
    public partial class App : Application

    {
        public string chosenCategory { get; set; }

        //public int currentRating { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
