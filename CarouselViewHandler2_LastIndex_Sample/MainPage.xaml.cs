using System.Collections.ObjectModel;

namespace CarouselViewHandler2_LastIndex_Sample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public ObservableCollection<string> ImagesToDisplay { get; } = new();

	public MainPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		ImagesToDisplay.Clear();
		ImagesToDisplay.Add("dotnet_bot.png");
		ImagesToDisplay.Add("dotnet_bot.png");
		ImagesToDisplay.Add("dotnet_bot.png");
	}
}

