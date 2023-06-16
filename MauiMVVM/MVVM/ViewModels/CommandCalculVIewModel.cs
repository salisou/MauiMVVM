using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiMVVM.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CommandCalculVIewModel 
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get; set; }

        public ICommand AddCommand => 
            new Command(() => Result = Number1 + Number2);

    }
}
