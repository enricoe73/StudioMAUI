namespace StudioMAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();

		Variables.ap = this;

	}

}

public static class Variables {

    public static Application ap { get; set; }
	public static NavigationPage nv { get; set; }

}
