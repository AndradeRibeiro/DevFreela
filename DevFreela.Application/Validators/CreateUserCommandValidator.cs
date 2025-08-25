using DevFreela.Application.Commands.UserCommands.CreateUser;
using FluentValidation;
using System.Text.RegularExpressions;

namespace DevFreela.Application.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("E-mail inválido");

            RuleFor(x => x.Password)
                .Must(ValidPassword)
                .WithMessage("A senha deve ter no mínimo 8 caracteres, contendo ao menos uma letra maiúscula, uma letra minúscula, um número e um caractere especial");

            RuleFor(x => x.FullName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome é obrigatório");
        }

        public bool ValidPassword(string password)
        {
            var regex = new Regex(@"^.*(?=.{8,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=].*$)");
            return regex.IsMatch(password);
        }
    }
}
