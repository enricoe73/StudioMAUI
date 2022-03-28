namespace StudioMAUI;

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
		CounterLabel.Text = $"Current count: {count}";

		SemanticScreenReader.Announce(CounterLabel.Text);
	}


	private void OnNavigazione(object sender, EventArgs e)
	{

		var secondWindow = new Window
		{
			Page = new n_Navigazione()
		};
		Application.Current.OpenWindow(secondWindow);
	}

}


