namespace StudioMAUI;

public partial class n_PrimaFinestra : ContentPage
{
	public n_PrimaFinestra()
	{
		InitializeComponent();
	}

	private void OnApriSeconda(object sender, EventArgs e)
	{ 
		var secondaNavigazione = new Window
		{
			Page = new n_SecondaFinestra()
		};
		Application.Current.OpenWindow(secondaNavigazione);
	}
	

	private async void OnNavigaIndietro(object sender, EventArgs e)
	{
		await Variables.nv.PopAsync();	
	}
	private async void OnNavigaSeconda(object sender, EventArgs e)
	{
		await Variables.nv.PushAsync(new n_SecondaFinestra());
	}

	private void OnIndietroFinestra(object sender, EventArgs e)
	{
		var window = this.GetParentWindow();
		if (window is not null)
			Application.Current.CloseWindow(window);
	}

	private void AddOverlay(object sender, EventArgs e)
	{
		var window = GetParentWindow();
		var overlay = new TestWindowOverlay(window);
		window.AddOverlay(overlay);
		
	}

	//void TestAddOverlayWindow(object sender, EventArgs e)
	//{
	//	var window = GetParentWindow();
	//	overlay ??= new n_SecondaFinestra(window);
	//	window.AddOverlay(overlay);
	//}

	//void TestRemoveOverlayWindow(object sender, EventArgs e)
	//{
	//	if (overlay is not null)
	//	{
	//		GetParentWindow().RemoveOverlay(overlay);
	//		overlay = null;
	//	}
	//}

	 
}



public class TestWindowOverlay : WindowOverlay
{
	IWindowOverlayElement _testWindowDrawable;

	public TestWindowOverlay(Window window)
		: base(window)
	{
		_testWindowDrawable = new TestOverlayElement(this);

		AddWindowElement(_testWindowDrawable);

		EnableDrawableTouchHandling = true;
		Tapped += OnTapped;

		var windowt = Application.Current.Windows.FirstOrDefault(w => w.Page is n_PrimaFinestra);
		

	}

	async void OnTapped(object sender, WindowOverlayTappedEventArgs e)
	{
		if (!e.WindowOverlayElements.Contains(_testWindowDrawable))
			return;

		var window = Application.Current.Windows.FirstOrDefault(w => w.Page  is n_PrimaFinestra);

		window.RemoveOverlay(this);

		//System.Diagnostics.Debug.WriteLine($"Tapped the test overlay button.");

		//var result = await window.Page.DisplayActionSheet(
		//	"Greetings from Visual Studio Client Experiences!",
		//	"Goodbye!",
		//	null,
		//	"Do something", "Do something else", "Do something... with feeling.");

		//System.Diagnostics.Debug.WriteLine(result);
	}

	class TestOverlayElement : IWindowOverlayElement
	{
		readonly WindowOverlay _overlay;
		Circle _circle = new Circle(0, 0, 0);
		int _size = 20;

		public TestOverlayElement(WindowOverlay overlay)
		{
			_overlay = overlay;

			Device.StartTimer(TimeSpan.FromMilliseconds(1), () =>
			{
				if (_size > 300) _size = 0;
				_size += 10;
				_overlay.Invalidate();
				return true;
			});
		}

		public void Draw(ICanvas canvas, RectF dirtyRect)
		{
			canvas.FillColor = Color.FromRgba(255, 0, 0, 225);
			canvas.StrokeColor = Color.FromRgba(225, 0, 0, 225);
			canvas.FontColor = Colors.Orange;
			canvas.FontSize = 40f;

			var centerX = dirtyRect.Width / 2 - (_size / 2);
			var centerY = dirtyRect.Height / 2 - (_size / 2);
			_circle = new Circle(centerX, centerY, _size);

			canvas.FillCircle(centerX, centerY, _size);
			canvas.DrawString("🔥", centerX, centerY + 10, HorizontalAlignment.Center);
		}

		public bool Contains(Point point) =>
			_circle.ContainsPoint(new Point(point.X / _overlay.Density, point.Y / _overlay.Density));
 

		struct Circle
		{
			public float Radius;
			public PointF Center;

			public Circle(float x, float y, float r)
			{
				Radius = r;
				Center = new PointF(x, y);
			}

			public bool ContainsPoint(Point p) =>
				p.X <= Center.X + Radius &&
				p.X >= Center.X - Radius &&
				p.Y <= Center.Y + Radius &&
				p.Y >= Center.Y - Radius;
		}
	}
}