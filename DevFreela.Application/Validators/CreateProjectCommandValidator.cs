using DevFreela.Application.Commands.ProjectCommands.CreateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(x => x.Description)
                .MaximumLength(255)
                .WithMessage("A descrição deve ter no máximo 255 caracteres");

            RuleFor(x => x.Title)
                .MaximumLength(30)
                .WithMessage("O título deve ter no máximo 30 caracteres");
        }
    }
}
