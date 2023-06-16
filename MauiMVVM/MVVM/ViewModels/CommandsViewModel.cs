using MauiMVVM.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiMVVM.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public ICommand displayAlert { get; }
        public ICommand SearchCommand { get; }
        public string SearchTerm { get; set; }

        public CommandsViewModel()
        {
            displayAlert = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Title", "message", "Ok");
            });

            SearchCommand = new Command((s) =>
            {
                var data = s;
            });
        }
        private void Alert()
        {
            App.Current.MainPage.DisplayAlert("Title", "message", "Ok");
        }

        public ICommand ClickCommand =>
            new Command(() => App.Current.MainPage.Navigation.PushModalAsync(new PersonView()));
    }
}
