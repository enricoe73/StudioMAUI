namespace StudioMAUI;

public partial class n_Navigazione : ContentPage
{
	public n_Navigazione()
	{
		InitializeComponent();
	}


	private void OnApriPrima(object sender, EventArgs e)
	{
		var primaNavigazione = new Window
		{
			Page = new n_PrimaFinestra()
		};
		Application.Current.OpenWindow(primaNavigazione);
	}

	private async void OnNavigaPrima(object sender, EventArgs e)
	{
		await Variables.nv.PushAsync(new n_PrimaFinestra());
	}
	 
	private void OnNavigaShell(object sender, EventArgs e)
	{
		// Funziona qui solo se si passa dalla navigation 
		Variables.ap.MainPage = new AppShell();

	}




}