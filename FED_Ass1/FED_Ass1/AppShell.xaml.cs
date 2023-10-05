using FED_Ass1.View;

namespace FED_Ass1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("addDebitor", typeof(AddDebitor));
		Routing.RegisterRoute("ListDebitors", typeof(ListDebitors));
	}
}