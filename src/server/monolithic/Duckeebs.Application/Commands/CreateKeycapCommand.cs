using Duckeebs.Core.Entities;
using Duckeebs.Core.Interfaces;
using MediatR;

namespace Duckeebs.Application.Commands
{
  public class CreateKeycapCommand: IRequest
  {
    public CreateKeycapCommand(string name)
    {
      Name = name;
    }
    public string? Name { get; set; }
  }

  public class CreateKeycapCommandHandler : IRequestHandler<CreateKeycapCommand>
  {
    private readonly IKeycapRepository _keycapRepository;
    public CreateKeycapCommandHandler(IKeycapRepository keycapRepository)
    {
      _keycapRepository = keycapRepository;
    }

    async Task IRequestHandler<CreateKeycapCommand>.Handle(CreateKeycapCommand request, CancellationToken cancellationToken)
    {
      Keycap kc = new Keycap(){
        Name = request.Name
      };
      await _keycapRepository.AddAsync(kc);
    }
  }
}
