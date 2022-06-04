using Phonebook.Sample.Maui.Application.Models;
using Phonebook.Sample.Maui.Application.Services;

namespace Phonebook.Sample.Maui;
public partial class ContactPage : ContentPage
{
    public ContactPage()
    {
        InitializeComponent();
    }

    async void OnSaveClicked(object sender, EventArgs e)
    {
        var contactItem = (AppContact)BindingContext;

        ContactService service = ContactService.Instance;
        service.SaveItem(contactItem);

        await Navigation.PopAsync();
    }
    async void OnDeleteClicked(object sender, EventArgs e)
    {
        var contactItem = (AppContact)BindingContext;

        ContactService service = ContactService.Instance;
        service.DeleteItem(contactItem);

        await Navigation.PopAsync();
    }
    async void OnCancelClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}