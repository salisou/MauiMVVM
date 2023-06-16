using MauiMVVM.MVVM.ViewModels;

namespace MauiMVVM.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		BindingContext = new PersonVIewModel();
	}
}