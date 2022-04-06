using Newtonsoft.Json;

namespace StudioMAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	 

	private void OnNavigazione(object sender, EventArgs e)
	{

		var secondWindow = new Window
		{
			Page = new n_Navigazione()
		};
		Application.Current.OpenWindow(secondWindow);
	}
	private void OnNavigationPage(object sender, EventArgs e)
	{ 
		var rootNavigationPage = new NavigationPage(new n_Navigazione());
		Variables.ap.MainPage = rootNavigationPage;
		Variables.nv = rootNavigationPage; 
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

		var client = new HttpClient();
		var json =  client.GetStringAsync("https://www.cliffordagius.co.uk/data/Airplanes.json").Result ;

		this.DisplayAlert("Messaggio", json.ToString(), "Ok");

	}

	



}


