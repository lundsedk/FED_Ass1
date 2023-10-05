﻿using FED_Ass1.Data;
using FED_Ass1.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FED_Ass1.View;

namespace FED_Ass1.ViewModel
{
	
	public partial class MainViewModel : ObservableObject
    //hvorfor ikke " : INotifyPropertyChanged" - er det "inkluderet" i ObservableObject?
    {
        public MainViewModel()
		{
			_database = new Database();
			// = new Command(async () => await Shell.Current.GoToAsync(nameof(AddDebitor)));
		}

		public ObservableCollection<DebtBook> DebtBook { get; set; } = new();

		private readonly Database _database;

		[RelayCommand]
		private async Task GoToAddDeb()
		{
			await Shell.Current.GoToAsync("//AddDebitor");
		}

	}
}
