using FED_Ass1.ViewModel;

namespace FED_Ass1.View
{
	public partial class AddDebitor : ContentPage
	{
		AddViewModel vm = new AddViewModel();
		public AddDebitor()
		{
			InitializeComponent();
			BindingContext = vm;
		}
	}
}

