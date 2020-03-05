using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;
using OzzyEntityLibraries.Repository;
using OzzyEntityLibraries.DTO.Models;
using OzzyEntityLibraries.ORM.Models;

namespace OzzyEntityLibraries.Services
{
    public class ContactServices
    {
       ContactRepository contactRepository;
       public ContactServices()
       {
           if (contactRepository==null)
           {
               contactRepository=new ContactRepository();
           }
       }
       
       public IEnumerable<ContactDTO>GetContactsService()
       {
          return contactRepository.GetAll().Select(x=> new ContactDTO
          {
             ContactId=x.ContactId,
             Sender=x.Sender,
             ContactMessage=x.ContactMessage,
             SendingDate=x.SendingDate,
             IsRead=x.IsRead
        
          }).ToList();

       }

       public void AddContactService(ContactDTO entity)
       {
           Contact contact = new Contact
           {
             Sender=entity.Sender,
             ContactMessage=entity.ContactMessage,
             SendingDate=entity.SendingDate,
             IsRead=entity.IsRead
           };

           contactRepository.Add(contact);
        }
        
        public void UpdateContactService(ContactDTO entity)
        {
            var contact = contactRepository.GetAll().Where(r=>r.ContactId==entity.ContactId).FirstOrDefault();
            contact.ContactMessage=entity.ContactMessage;
            contact.Sender=entity.Sender;
            contact.SendingDate=entity.SendingDate;
            contact.IsRead=entity.IsRead;
            contactRepository.Update(contact);

        }
        
        public void DeleteContactService(ContactDTO entity)
        {
             var contact = contactRepository.GetAll().Where(r=>r.ContactId==entity.ContactId).FirstOrDefault();
            contact.ContactMessage=entity.ContactMessage;
            contact.Sender=entity.Sender;
            contact.SendingDate=entity.SendingDate;
            contact.IsRead=entity.IsRead;
            contactRepository.Delete(contact);
        }

        public bool DeleteContactServiceByID(int id)
        {
            return contactRepository.DeletebyEntity(x=>x.ContactId==id); 
        }
        
    }
}
