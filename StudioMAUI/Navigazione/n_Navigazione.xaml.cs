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

}