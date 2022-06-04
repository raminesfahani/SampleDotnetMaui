using Phonebook.Sample.Maui.Application.Models;
using Phonebook.Sample.Maui.Application.Services;

namespace Phonebook.Sample.Maui;
public partial class ContactListPage : ContentPage
{
    public ContactListPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        ContactService service = ContactService.Instance;

        listView.ItemsSource = service.GetItems();
    }

    async void OnItemAdded(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ContactPage()
        {
            BindingContext = new AppContact()
        });
    }

    async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ContactPage()
            {
                BindingContext = e.SelectedItem as AppContact
            });
        }
    }
}