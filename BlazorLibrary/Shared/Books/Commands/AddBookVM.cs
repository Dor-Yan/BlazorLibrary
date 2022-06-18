using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorLibrary.Shared.Books.Commands
{
    public class AddBookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public WriterVm Writers { get; set; }
        public TypeVm Types { get; set; }
        public string Publisher { get; set; }
        public DateTime DateOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public string ISBN { get; set; }
        public bool Available { get; set; }
    }
    public class AddBookValidator : AbstractValidator<AddBookVM>
    {
        public AddBookValidator()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(15).WithMessage("Title must be max 15 characters length");
            RuleFor(x => x.Description).NotEmpty().MaximumLength(30).WithMessage("Description must be max 30 characters length");
            RuleFor(x => x.Publisher).NotEmpty().MaximumLength(20).WithMessage("Publisher must be max 20 characters length");
            
        }
    }

    public class TypeVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class WriterVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    
}
