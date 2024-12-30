using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace CarouselViewHandler2_LastIndex_Sample;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
