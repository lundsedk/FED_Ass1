using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace FED_Ass1.ViewModel
{
    public partial class AddViewModel : ObservableObject
    {
        public AddViewModel()
        {
            // Cstor
        }

        [ObservableProperty]
        private string _newName;

        [RelayCommand]
        void NewDebtorEntryCompleted()
        {
            Console.WriteLine("Complete method");
        }

    }
}