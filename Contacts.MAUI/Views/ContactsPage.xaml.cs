using Contacts.MAUI.Models;
using Contact = Contacts.MAUI.Models.Contact;

namespace Contacts.MAUI.Views;


public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
        List<Contact> contacts = ContactRepo.GetContacts();

        contactsList.ItemsSource = contacts;

    }




    private void contactsList_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
         contactsList.SelectedItem = null; 
    }

    private async void contactsList_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        if (contactsList.SelectedItem !=null)
        {
            await Shell.Current.GoToAsync($"{nameof(SingleContact)}?Id={((Contact)contactsList.SelectedItem).ContactId}");
        }
    }



}