using BookStore.Core.Models;
using FluentValidation;

namespace BookStore.Core.Validators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(book => book.Title)
                .NotEmpty().WithMessage("Title cannot be empty")
                .MaximumLength(250).WithMessage($"Title cannot be longer than 250 characters");

            RuleFor(book => book.Price).GreaterThan(0).WithMessage("Price must be greater than 0");
        }
    }
}
