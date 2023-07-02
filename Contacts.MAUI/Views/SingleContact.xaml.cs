using Contacts.MAUI.Models;

namespace Contacts.MAUI.Views;

[QueryProperty(nameof(ContactId),"Id")]

public partial class SingleContact : ContentPage
{

    private Models.Contact currentContact;
	public SingleContact()
	{
		InitializeComponent();


	}

    void btnCancel_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    public string ContactId
    {
        set
        {
           currentContact=  ContactRepo.GetContactById(int.Parse(value));
            lbl_firstName.Text = currentContact.FirstName;
            lbl_lastName.Text = currentContact.LastName;
            lbl_email.Text = currentContact.Email;
            lbl_mobile.Text = currentContact.Mobile.ToString();
        }
    }
}
