
using System.Windows.Input; 
namespace StudioMAUI;
 

public partial class AppShell : Shell
{

    public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
    public ICommand HelpCommand => new Command(
        () =>
        System.Diagnostics.Process.GetCurrentProcess().Kill()
          //this.DisplayAlert("Uscita", "Sei sicuro di voler chiudere l'applicazione ?", "Ok", "Annulla")
        );

    public AppShell()
	{
		InitializeComponent();
        RegisterRoutes();
        BindingContext = this;
    }


	

    void RegisterRoutes()
    {
        //Routes.Add("monkeydetails", typeof(MonkeyDetailPage));
        //Routes.Add("beardetails", typeof(BearDetailPage));
        //Routes.Add("catdetails", typeof(CatDetailPage));
        //Routes.Add("dogdetails", typeof(DogDetailPage));
        //Routes.Add("elephantdetails", typeof(ElephantDetailPage));

        foreach (var item in Routes)
        {
            Routing.RegisterRoute(item.Key, item.Value);
        }
    }



}