using FED_Ass1.ViewModel;

namespace FED_Ass1.View
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

		private MainViewModel vm = new MainViewModel();
		//Next, we assign the BindingContext to that instance in the constructor:
		public MainPage()
		{
			InitializeComponent();
			BindingContext = vm;
        }
    }
}