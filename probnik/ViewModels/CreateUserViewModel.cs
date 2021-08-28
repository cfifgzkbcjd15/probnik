using System;

namespace probnik.ViewModels
{
    public class CreateUserViewModel
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Year { get; set; }
    }
}