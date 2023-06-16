using MauiMVVM.MVVM.Views;

namespace MauiMVVM;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage( new CommandCalculVIew());
	}
}
