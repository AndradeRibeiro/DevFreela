using MediatR;

namespace DevFreela.Application.Commands.ProjectCommands.FinishProject
{
    public class FinishProjectCommand : IRequest<Unit>
    {
        public int Id { get; private set; }

        public FinishProjectCommand(int id)
        {
            Id = id;
        }
    }
}
