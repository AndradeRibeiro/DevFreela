using DevFreela.Application.Commands.ProjectCommands.CreateProjectComment;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommentCommandValidator : AbstractValidator<CreateProjectCommentCommand>
    {
        public CreateProjectCommentCommandValidator()
        {
            RuleFor(x => x.Content)
                .NotEmpty()
                .NotNull()
                .WithMessage("O comentário não pode ser vazio")
                .MaximumLength(255)
                .WithMessage("O comentário deve ter no máximo 255 caracteres");

            RuleFor(x => x.IdProject)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .WithMessage("O Id do projeto é obrigatório");

            RuleFor(x => x.IdUser)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0)
                .WithMessage("O Id do usuário é obrigatório");
        }
    }
}
