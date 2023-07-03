using Contacts.MAUI.Models;

namespace Contacts.MAUI.Views;

[QueryProperty(nameof(curr_contactId), "current_contactID")]

public partial class EditContactPage : ContentPage
{
    private Models.Contact currentContact;
    public EditContactPage()
	{
		InitializeComponent();
    }

    private void btnCancel_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(SingleContact)}?Id={currentContact.ContactId}");
    }


    public string curr_contactId
    {
        set
        {
            currentContact = ContactRepo.GetContactById(int.Parse(value));
            if (currentContact != null)
            {
                contactCtrl.FirstName = currentContact.FirstName;
                contactCtrl.LastName = currentContact.LastName;
                contactCtrl.Email = currentContact.Email;
                contactCtrl.Mobile = currentContact.Mobile.ToString();
            }
        }
    }

    void btnUpdate_Clicked(System.Object sender, System.EventArgs e)
    {

        currentContact.FirstName = contactCtrl.FirstName;
        currentContact.LastName = contactCtrl.LastName;
        currentContact.Email = contactCtrl.Email;
        currentContact.Mobile = int.Parse(contactCtrl.Mobile);

        ContactRepo.UpdateContact(currentContact.ContactId, currentContact);
        Shell.Current.GoToAsync($"{nameof(SingleContact)}?Id={currentContact.ContactId}");
    }

    void contactCtrl_OnError(System.Object sender, System.String e)
    {
        DisplayAlert("Error!", e, "OK");
    }
}
