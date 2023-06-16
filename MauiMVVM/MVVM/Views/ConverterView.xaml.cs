using MauiMVVM.MVVM.ViewModels;

namespace MauiMVVM.MVVM.Views;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
		BindingContext = new ConvertersViewModel();
	}
}