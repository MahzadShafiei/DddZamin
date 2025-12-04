using FluentValidation;
using MiniBlog.Core.RequestResponse.People.Commands.Create;
using Zamin.Extensions.Translations.Abstractions;

namespace MiniBlog.Core.RequestResponse.Blogs.Commands.Create
{
    public class CreatePersonCommandValidator : AbstractValidator<CreatePerson>
    {
        public CreatePersonCommandValidator(ITranslator translator)
        {
            RuleFor(c => c.FirstName)
                .NotNull().WithMessage(translator["Required", "FirstName"])
                .MinimumLength(2).WithMessage(translator["MinimumLength", "FirstName", "2"])
                .MaximumLength(50).WithMessage(translator["MaximumLength", "FirstName", "50"]);

            RuleFor(c => c.LastName)
                .NotNull().WithMessage(translator["Required", "LastName"]).WithErrorCode("1")
                .MinimumLength(2).WithMessage(translator["MinimumLength", "LastName", "2"]).WithErrorCode("2")
                .MaximumLength(50).WithMessage(translator["MaximumLength", "LastName", "50"]).WithErrorCode("3");
        }
    }
}
