namespace Phonebook.Sample.Maui;

public partial class App : Microsoft.Maui.Controls.Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new ContactListPage())

        {
            BarTextColor = Color.FromArgb("#FFFFFF"),

            BarBackgroundColor = Color.FromArgb("#E1E1E1")
        };
    }
}
