using System.ComponentModel.DataAnnotations;

namespace Phonebook.Sample.Maui.Application.Models
{
    public class AppContact
    {
        public Guid? ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public bool Active { get; set; } = false;
    }
}
