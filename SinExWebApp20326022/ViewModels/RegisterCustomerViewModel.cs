using SinExWebApp20326022.Models;

namespace SinExWebApp20326022.ViewModels
{
    public class RegisterCustomerViewModel
    {
        public PersonalShippingAccount PersonalInformation { get; set; }
        public BusinessShippingAccount BusinessInformation { get; set; }
        public RegisterViewModel LoginInformation { get; set; }
    }
}