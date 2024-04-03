using BookStore.Core.Validators;

namespace BookStore.Core.Models
{
    public class Book
    {
        private Book(Guid id, string title, string description, decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }

        public Guid Id { get; }

        public string Title { get; }

        public string Description { get; }

        public decimal Price { get; }

        public static (Book book, string Error) Create(Guid id, string title, string description, decimal price)
        {
            var validator = new BookValidator();
            var validationResult = validator.Validate(new Book(id, title, description, price));

            if (validationResult.IsValid)
            {
                return (new Book(id, title, description, price), null)!;
            }
            return (null, string.Join(", ", validationResult.Errors.Select(x => x.ErrorMessage)))!;
        }
    }
}
