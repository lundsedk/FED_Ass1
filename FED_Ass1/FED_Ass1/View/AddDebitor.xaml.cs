using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FED_Ass1.ViewModel;

namespace FED_Ass1.View;

public partial class AddDebitor : ContentPage
{
	private AddViewModel vm2 = new AddViewModel();
	public AddDebitor()
	{
		InitializeComponent();
		BindingContext = vm2;
	}
}