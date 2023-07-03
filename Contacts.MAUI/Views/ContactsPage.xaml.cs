using System.Collections.ObjectModel;
using Contacts.MAUI.Models;
using Contact = Contacts.MAUI.Models.Contact;

namespace Contacts.MAUI.Views;


public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();
        
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        searchBar_element.Text = string.Empty;

        LoadContacts(); 
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

    void btnAdd_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    void DeleteMenuItem_Clicked(System.Object sender, System.EventArgs e)
    {
        var menuItem = sender as MenuItem;
        var contact = menuItem.CommandParameter as Contact;
        ContactRepo.DeleteContact(contact.ContactId);
        LoadContacts(); 
    }

    private void LoadContacts()
    {

        var contacts = new ObservableCollection<Contact>(ContactRepo.GetContacts());

        contactsList.ItemsSource = contacts;
    }

    void SearchBar_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
       var contacts = new ObservableCollection<Contact>(ContactRepo.SearchContacts(((SearchBar)sender).Text));
        contactsList.ItemsSource = contacts;  
    }

    
}