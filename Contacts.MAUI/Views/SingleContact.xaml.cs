namespace Contacts.MAUI.Views;

public partial class SingleContact : ContentPage
{
	public SingleContact()
	{
		InitializeComponent();


	}

    void btnCancel_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

}
