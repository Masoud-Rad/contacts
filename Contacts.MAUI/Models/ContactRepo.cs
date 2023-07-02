using System;
namespace Contacts.MAUI.Models
{
	public static class ContactRepo
	{
		public static List<Contact> _contacts = new List<Contact>()
        {
        new Contact { FirstName="Mikel", LastName="Jordan", Mobile= 09111, Email="mj@gmail.com"},
        new Contact { FirstName="Brad", LastName="Pitt", Mobile= 09222, Email="mr@gmail.com"},
        new Contact { FirstName="Pino", LastName="Kio", Mobile= 09333, Email="pn@gmail.com"},
        new Contact { FirstName="Dua", LastName="Lipa", Mobile= 09444, Email="dl@gmail.com"}
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int contactId)
        {
            return _contacts.FirstOrDefault(x => x.ContactId == contactId);
        }

    }

}

