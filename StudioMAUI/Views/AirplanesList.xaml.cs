using System.Collections.ObjectModel;
using System.Diagnostics;
using Newtonsoft.Json;
using StudioMAUI.Models;
namespace StudioMAUI.Views;

public partial class AirplanesList : ContentPage
{

 //   public ObservableCollection<Airplane> Airplanes { get; set; } = new ObservableCollection<Airplane>();
	//public Command GetAirplanesCommand { get; set; }

	public AirplanesList()
	{
		InitializeComponent();
	
		//GetAirplanesCommand = new Command(async () => await GetAirplanesAsync());
    //    BindingContext = this;
      
    }

    //private async void  OnCounterClicked(object sender, EventArgs e)
    //{
    //    await GetAirplanesAsync();
    //}

    //async Task GetAirplanesAsync()
    //{
    //    // Check if Busy and return early...
    //    if (IsBusy)
    //        return;

    //    try
    //    {
    //        // Set an IsBusy so that we can display an Activity Indicator while the data loads...
    //        IsBusy = true;

    //        // Grab the data from the web with a bog standard HTTPClient call...
    //        var client = new HttpClient();
    //        var json = await client.GetStringAsync("https://www.cliffordagius.co.uk/data/Airplanes.json");
    //        var airplanes = JsonConvert.DeserializeObject<List<Airplane>>(json);

    //        //  Clear the Collection to make sure we are not adding to a full list...
    //        Airplanes.Clear();

    //        //  Add them all to the ObserableCollection.
    //        foreach (var airplane in airplanes)
    //        {
    //            Airplanes.Add(airplane);
    //        }

            
    //    }
    //    catch (Exception ex)
    //    {
    //        // A Bit of debug info and display an alert for the user...
    //        Debug.WriteLine($"Unable to get Airplanes data: {ex.Message}");
    //        await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "OK");
    //    }
    //    finally
    //    {
    //        // Set it to false to hide the Activity Indicator...
    //        IsBusy = false;
    //    }
    //}

}