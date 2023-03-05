using Automate.Resources.Buy;
using Automate.Resources.GetStarted;

namespace Automate;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("fetch_UID", typeof(UID));
        Routing.RegisterRoute("Buy_UID", typeof(Buy_UID));
    }
}
