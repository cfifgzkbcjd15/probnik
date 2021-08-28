using Microsoft.AspNetCore.Http;
using System;

namespace probnik.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime Year { get; set; }
        public byte[] Photo { get; set; }
    }
    public class EdUserViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime Year { get; set; }
        public IFormFile Photo { get; set; }
    }
}