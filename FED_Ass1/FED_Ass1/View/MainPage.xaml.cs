using FED_Ass1.ViewModel;

namespace FED_Ass1.View
{
    public partial class MainPage : ContentPage
    {
	    MainViewModel vm = new MainViewModel();
		public MainPage()
		{
			InitializeComponent();
			BindingContext = vm;
		}
    }
}