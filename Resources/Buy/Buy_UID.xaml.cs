using System.Management;
namespace Automate.Resources.Buy;

public partial class Buy_UID : ContentPage
{
	public Buy_UID()
	{
		InitializeComponent();
        var CPU_List = new ManagementObjectSearcher("Select ProcessorID From Win32_processor").Get();
        var Motherboard_List = new ManagementObjectSearcher("Select SerialNumber From Win32_BaseBoard").Get();

        foreach (ManagementObject CPU in CPU_List)
        {
            CPU_prop.Text = CPU["ProcessorID"].ToString();
        }
        foreach (ManagementObject MotherBoard in Motherboard_List)
        {
            Board_prop.Text = MotherBoard["SerialNumber"].ToString();
        }
    }

	private void btn_click(object sender, EventArgs e)
	{
        // TODO: Add Website URL Redirect for Registration.
    }
}