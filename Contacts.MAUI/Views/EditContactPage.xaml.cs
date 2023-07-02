using Contacts.MAUI.Models;

namespace Contacts.MAUI.Views;

[QueryProperty(nameof(curr_contactId), "current_contactID")]

public partial class EditContactPage : ContentPage
{
    private Models.Contact currentContact;
    public EditContactPage()
	{
		InitializeComponent();
        btnCancel.Clicked += btnCancel_Clicked;
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
                entry_firstName.Text = currentContact.FirstName;
                entry_lastName.Text = currentContact.LastName;
                entry_email.Text = currentContact.Email;
                entry_mobile.Text = currentContact.Mobile.ToString();
            }
        }
    }

    void btnUpdate_Clicked(System.Object sender, System.EventArgs e)
    {
        currentContact.FirstName = entry_firstName.Text;
        currentContact.LastName = entry_lastName.Text;
        currentContact.Email = entry_email.Text;
        currentContact.Mobile = int.Parse(entry_mobile.Text);

        ContactRepo.UpdateContact(currentContact.ContactId, currentContact);
        Shell.Current.GoToAsync($"{nameof(SingleContact)}?Id={currentContact.ContactId}");
    }

}
