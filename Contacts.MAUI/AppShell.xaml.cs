using Contacts.MAUI.Views;

namespace Contacts.MAUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(SingleContact), typeof(SingleContact));
        Routing.RegisterRoute(nameof(EditContactPage), typeof(EditContactPage));
        Routing.RegisterRoute(nameof(AddContactPage), typeof(AddContactPage));
		Routing.RegisterRoute(nameof(EditContactPage), typeof(EditContactPage));

	}
}

