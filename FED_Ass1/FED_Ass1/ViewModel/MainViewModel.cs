using FED_Ass1.Data;
using FED_Ass1.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FED_Ass1.View;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using Windows.ApplicationModel;

namespace FED_Ass1.ViewModel
{
	
	public partial class MainViewModel : ObservableObject
    //hvorfor ikke " : INotifyPropertyChanged" - er det "inkluderet" i ObservableObject?
    {
		public MainViewModel()
		{
			_database = new Database();
		}

		public ObservableCollection<DebtBook> Debtors { get; set; } = new();
        public ObservableCollection<Transaction> Transactions { get; set; } = new();

		[RelayCommand]
		private async Task GoToAddDeb()
		{
			await Shell.Current.GoToAsync(nameof(AddDebitor));
			//await Shell.Current.GoToAsync($"{nameof(AddDebitor)}?Data={database}");
		}

		[RelayCommand]
		private async Task GoToListDeb()
		{
			await Shell.Current.GoToAsync(nameof(ListDebitors));
		}

		private readonly Database _database;
	}
}
