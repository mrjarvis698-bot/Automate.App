using System.Xml.Linq;

namespace Automate.Resources.GetStarted;

public partial class UID : ContentPage
{
	public UID()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }

    private void UID_Submit_Clicked(object sender, EventArgs e)
    {
        var UID = UID_entry.Text;
    }
    private async void Buy_UID_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Buy_UID");
    }
}