using MauiMVVM.MVVM.ViewModels;

namespace MauiMVVM.MVVM.Views;

public partial class CommandCalculVIew : ContentPage
{
	public CommandCalculVIew()
	{
		InitializeComponent();
		BindingContext = new CommandCalculVIewModel();

    }
}