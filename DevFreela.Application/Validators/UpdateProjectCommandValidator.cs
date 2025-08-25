using DevFreela.Application.Commands.ProjectCommands.UpdateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
        {
            RuleFor(x => x.Description)
                .MaximumLength(255)
                .WithMessage("A descrição deve ter no máximo 255 caracteres");

            RuleFor(x => x.Title)
                .MaximumLength(30)
                .WithMessage("O título deve ter no máximo 30 caracteres");

            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("Id do projeto é obrigatório");
        }
    }
}
