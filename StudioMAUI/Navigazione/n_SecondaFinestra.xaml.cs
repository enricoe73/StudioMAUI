namespace StudioMAUI;

public partial class n_SecondaFinestra : ContentPage
{
	public n_SecondaFinestra()
	{
		InitializeComponent();
	}


	private void OnIndietroFinestra(object sender, EventArgs e)
	{
		var window = this.GetParentWindow();
		if (window is not null)
			Application.Current.CloseWindow(window); 
	}
}