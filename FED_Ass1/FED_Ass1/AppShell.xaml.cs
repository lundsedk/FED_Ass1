using FED_Ass1.View;

namespace FED_Ass1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(AddDebitor), typeof(AddDebitor));
		Routing.RegisterRoute(nameof(ListDebitors), typeof(ListDebitors));
	}
}