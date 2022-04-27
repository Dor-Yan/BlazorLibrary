using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace BlazorLibrary.Shared.Users.Commands
{
    public class AddUserVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        [PhoneAttribute]
        [MaxLength(12, ErrorMessage ="Phone number is to long")]
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
    }

    public class AddUserValidator : AbstractValidator<AddUserVM>
    {
        public AddUserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(15).WithMessage("Name must be max 15 characters length");
            RuleFor(x => x.EmailAdress).NotEmpty().EmailAddress();
        }
    }
}
