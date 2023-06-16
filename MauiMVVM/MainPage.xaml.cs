using MauiMVVM.MVVM.ViewModels;
using Microsoft.Maui.Controls;
using Remotion.Linq.Collections;
using System.Collections.ObjectModel;

namespace MauiMVVM;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        BindingContext = new FruitViewMode();
    }

   
}

