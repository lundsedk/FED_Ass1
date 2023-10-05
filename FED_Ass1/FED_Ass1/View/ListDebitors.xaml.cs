using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FED_Ass1.ViewModel;

namespace FED_Ass1.View;

public partial class ListDebitors : ContentPage
{
	private ListViewModel vm1 = new ListViewModel();
	public ListDebitors()
	{
		InitializeComponent();
		BindingContext = vm1;
	}
}