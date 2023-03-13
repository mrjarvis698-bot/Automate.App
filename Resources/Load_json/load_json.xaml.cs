using System.Net;

namespace Automate.Resources.Load_json;

public partial class load_json : ContentPage
{
	public load_json()
	{
		InitializeComponent();
	}
    async void FetchJsonButton_Clicked(object sender, EventArgs e)
    {
        // Get the URL entered by the user from the Entry control
        string url = json_url.Text;

        // Create a new HttpClient instance
        var httpClient = new HttpClient();

        // Download the file and save it to a local file
        string localFilePath = "C:/Users/mrjarvis698/Desktop/New Text Document (89).txt";
        using (var response = await httpClient.GetAsync(url))
        using (var fileStream = new FileStream(localFilePath, FileMode.Create))
        {
            await response.Content.CopyToAsync(fileStream);
        }

        Console.WriteLine("File downloaded successfully to " + localFilePath);
    }
    async void FetchJsonButton_Clicked2(object sender, EventArgs e)
    {
        try
        {
            string url = json_url.Text;
            string fileName = Path.GetFileName(url);
            await DownloadFileAsync(url, "C:/Users/mrjarvis698/Desktop/New Text Document (89).txt");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }

    private async Task DownloadFileAsync(string url, string saveLocation)
    {
        try
        {
#pragma warning disable SYSLIB0014 // Type or member is obsolete
            using (var client = new WebClient())
            {
                await client.DownloadFileTaskAsync(url, "C:/Users/mrjarvis698/Desktop/New Text Document (89).txt");
                await DisplayAlert("Done","Configuration File is Downloaded." , "OK");
            }
#pragma warning restore SYSLIB0014 // Type or member is obsolete


        }
        catch (WebException ex)
        {
            if (ex.Status == WebExceptionStatus.ProtocolError)
            {
                var response = ex.Response as HttpWebResponse;
                await DisplayAlert("Download Error", $"HTTP error {response.StatusCode}: {response.StatusDescription}", "OK");
            }
            else  
            {
                await DisplayAlert("Download Error", $"Failed to download file: {ex.Message}", "OK");
            }
        }
        catch (Exception)
        {
            await DisplayAlert("Download Error", $"Failed to download file: Invalid URL", "OK");
        }
    }
}