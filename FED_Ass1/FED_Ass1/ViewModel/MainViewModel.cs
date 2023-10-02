using FED_Ass1.Data;
using FED_Ass1.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace FED_Ass1.ViewModel
{
	[ObservableObject]
	public partial class MainViewModel
	{
		public MainViewModel()
		{
			_database = new Database();
			// Tilføj mere her
		}

		public ObservableCollection<DebtBook> DebtBook { get; set; } = new();

		private readonly Database _database;
	}
}
