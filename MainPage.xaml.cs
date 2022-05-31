using BeehiveNews.BL;

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

	private void onSubmit(object obj, EventArgs e)
    {
		Console.WriteLine(editor.Text);
		var scraper = new WebParse();
		 scraper.Start();
		//await DisplayAlert("Submit your name", "Do you want to submit your information", "Yes");
    }

}


