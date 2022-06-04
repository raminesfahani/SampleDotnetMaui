using Phonebook.Sample.Maui.Application.Models;
using Phonebook.Sample.Maui.Application.Services;
using Xunit;
using System;
using Xunit.Sdk;

namespace Phonebook.Sample.Maui.Application.UnitTest
{
    public class ContactServiceTests
    {
        public void DummyDataInitializer()
        {
            ContactService contactService = ContactService.Instance;
            var contact = new AppContact()
            {
                ID = Guid.NewGuid(),
                Name = "Name Family",
                Email = "mail@mail.com",
                PhoneNumber = "09999999999",
                Active = true
            };
            contactService.SaveItem(contact);
        }

        [Fact]
        public void AddContactTest()
        {
            DummyDataInitializer();
            ContactService contactService = ContactService.Instance;

            Assert.True(contactService.GetItems().Count > 0);
        }
    }
}