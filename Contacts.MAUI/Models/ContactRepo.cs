using System;
namespace Contacts.MAUI.Models
{
	public static class ContactRepo
	{
		public static List<Contact> _contacts = new List<Contact>()
        {
        new Contact { ContactId=1, FirstName ="Mikel", LastName="Jordan", Mobile= 09111, Email="mj@gmail.com"},
        new Contact { ContactId=2, FirstName="Brad", LastName="Pitt", Mobile= 09222, Email="mr@gmail.com"},
        new Contact { ContactId=3, FirstName="Pino", LastName="Kio", Mobile= 09333, Email="pn@gmail.com"},
        new Contact { ContactId=4, FirstName="Dua", LastName="Lipa", Mobile= 09444, Email="dl@gmail.com"}
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int contactId)
        {
            var contact=_contacts.FirstOrDefault(x => x.ContactId == contactId);
            if(contact != null)
            {
                return new Contact
                {
                    ContactId = contactId, 
                    FirstName = contact.FirstName,
                    LastName = contact.LastName,
                    Mobile = contact.Mobile,
                    Email = contact.Email
                };
            }
            return null;
        }

        public static void UpdateContact(int contactId, Contact contact)
        {
            if (contactId != contact.ContactId) return;

            var contactToUpdate = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contactToUpdate != null)
            {

                contactToUpdate.FirstName = contact.FirstName;
                contactToUpdate.LastName = contact.LastName;
                contactToUpdate.Mobile = contact.Mobile;
                contactToUpdate.Email = contact.Email;

            }
        }
    }

}

