namespace Automate;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private async void OnGetStartedClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("fetch_UID");
    }

    private async void OnBypassClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("load_json");
    }
}

