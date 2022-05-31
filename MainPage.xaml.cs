using System.Text.RegularExpressions;
using BeehiveNews.BL;
using SkyScraper;
using SkyScraper.Observers.ConsoleWriter;
using SkyScraper.Observers.ImageScraper;

namespace BeehiveNews;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void onTextChanged(object obj, EventArgs e) {
		Console.WriteLine(obj);
    }

	private void onTextCompleted(object obj, EventArgs e)
    {
		Console.WriteLine(obj);
    }

	private async void onSubmit(object obj, EventArgs e)
    {
		Console.WriteLine(editor.Text);
		Console.WriteLine("start the exception");
		try
		{
			var httpClient = new SkyScraper.HttpClient { UserAgentName = "tb.giaidb" }; //optional UserAgentName
			var scraper = new Scraper(httpClient, new ScrapedUrisDictionary()); //use built in IHttpClient and IScrapedUris implementations
			var io = new ImageScraperObserver(httpClient, new FileWriter(new DirectoryInfo("users:\\temp")));
			scraper.Subscribe(io); //use built in image scraper
			scraper.Subscribe(new ConsoleWriterObserver()); //use built in console writer
			scraper.Subscribe(x => Console.WriteLine(x.Uri)); //implement your own subscriber
			scraper.MaxDepth = 2; //optional
			scraper.TimeOut = TimeSpan.FromMinutes(5); //optional
			scraper.IgnoreLinks = new Regex("spam"); //optional - ignore links in page
			scraper.IncludeLinks = new Regex("stuff"); //optional - scrape links in page
			scraper.ObserverLinkFilter = new Regex("things"); //optional - trigger observers when link matches
			scraper.DisableRobotsProtocol = true; //optional
			scraper.Scrape(new Uri("https://www.minhngoc.com.vn/")).Wait();
		} catch(Exception err)
        {
			Console.WriteLine(err.Message);
        } finally
        {
			Console.WriteLine("end of exception");
			await DisplayAlert("Submit your name", "Do you want to submit your information", "Yes");
		}
		
    }

}


