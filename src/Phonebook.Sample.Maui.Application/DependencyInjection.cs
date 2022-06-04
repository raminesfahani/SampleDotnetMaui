using Phonebook.Sample.Maui.Application.Services;

namespace Phonebook.Sample.Maui.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<ContactService>();
            return services;
        }
    }
}
