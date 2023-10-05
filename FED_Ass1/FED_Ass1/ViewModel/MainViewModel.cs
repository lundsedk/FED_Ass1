using FED_Ass1.Data;
using FED_Ass1.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FED_Ass1.ViewModel
{
	[ObservableObject]
    public partial class MainViewModel
    //hvorfor ikke " : INotifyPropertyChanged" - er det "inkluderet" i ObservableObject?
    {
        public MainViewModel()
		{
			_database = new Database();
			// Tilføj mere her
		}

		public ObservableCollection<DebtBook> DebtBook { get; set; } = new();

		private readonly Database _database;

		//Kristian's test-hejs
        [ObservableProperty]
        public uint _globalTest = 18;
        //GlobalTest is the name of the "generated property" (https://learn.microsoft.com/en-us/dotnet/communitytoolkit/mvvm/generators/observableproperty)


        [RelayCommand]
        void TestBtnClick()
        {
            GlobalTest++;
            //TestBtn.Text = $"{GlobalTest}"; 
        }
    }
}
