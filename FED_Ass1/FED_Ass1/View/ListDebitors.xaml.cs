using FED_Ass1.ViewModel;

namespace FED_Ass1.View
{
	public partial class ListDebitors : ContentPage
	{
		ListViewModel vm = new ListViewModel();
		public ListDebitors()
		{
			InitializeComponent();
			BindingContext = vm;
		}
	}
}