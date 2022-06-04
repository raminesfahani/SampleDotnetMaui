using Phonebook.Sample.Maui.Application.Models;

namespace Phonebook.Sample.Maui.Application.Services
{
    public class ContactService
    {
        private ContactService() { }

        private static ContactService instance = null;

        public static ContactService Instance

        {

            get

            {

                if (instance == null)

                {

                    instance = new ContactService();

                }

                return instance;

            }

        }

        private List<AppContact> _appContacts = new List<AppContact>() { new AppContact { ID = Guid.NewGuid(), Name = "Name Family", PhoneNumber = "09999999999", Email = "mail@mail.com", Active = true } };
        public List<AppContact> GetItems()
        {
            return _appContacts.ToList();
        }

        public AppContact GetItem(Guid id)
        {
            return _appContacts.Where(i => i.ID == id).FirstOrDefault();
        }

        public Guid SaveItem(AppContact item)
        {
            if (item.ID != Guid.Empty)
            {
                _appContacts.Remove(item);
                _appContacts.Add(item);
                return item.ID ?? Guid.Empty;
            }
            else
            {
                item.ID = Guid.NewGuid();
                _appContacts.Add(item);
                return item.ID ?? Guid.Empty;
            }
        }

        public void DeleteItem(AppContact item)
        {
            _appContacts.Remove(item);
        }
    }
}
