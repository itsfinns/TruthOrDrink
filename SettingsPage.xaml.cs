namespace TruthOrDrink;

public partial class SettingsPage : ContentPage
{

	private bool isSettings_on = true;

	public SettingsPage()
	{
		InitializeComponent();
	}

	private void OnSettingsClicked(object sender, EventArgs e)
	{
		if (isSettings_on)
		{
			ToggleImageButton1.Source = "settings_off.png";
		}
		else
		{
			ToggleImageButton1.Source = "settings_on.png";
		}
		isSettings_on = !isSettings_on;
	}
}