using Contacts.MAUI.Models;

namespace Contacts.MAUI.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    void contactCtrl_OnSave(System.Object sender, System.EventArgs e)
    {
        ContactRepo.AddContact(new Models.Contact
        {
            FirstName = contactCtrl.FirstName,
            LastName = contactCtrl.LastName,
            Mobile = int.Parse(contactCtrl.Mobile),
            Email = contactCtrl.Email
        });
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");

    } 

    void contactCtrl_OnCancel(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }   

    void contactCtrl_OnError(System.Object sender, System.String e)
    {
        DisplayAlert("Error!", e, "OK");
    }


    //void btnCancel_Clicked(System.Object sender, System.EventArgs e)
    //{
    //    Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    //}
}
