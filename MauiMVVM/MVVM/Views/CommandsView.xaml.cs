using MauiMVVM.MVVM.ViewModels;

namespace MauiMVVM.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
		BindingContext = new CommandsViewModel();
	}
}