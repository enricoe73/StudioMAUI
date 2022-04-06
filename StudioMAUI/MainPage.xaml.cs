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




}


