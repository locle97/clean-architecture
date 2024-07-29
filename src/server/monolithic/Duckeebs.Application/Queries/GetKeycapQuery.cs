using Duckeebs.Core.Entities;
using Duckeebs.Core.Interfaces;
using MediatR;

namespace Duckeebs.Application.Queries
{
  public class GetKeycapQuery: IRequest<Keycap> {
    public GetKeycapQuery(int id) {
      Id = id;
    }

    public int Id { get; set; }
  }

  public class GetKeycapQueryHandler: IRequestHandler<GetKeycapQuery, Keycap>
  {
    private readonly IKeycapRepository _keycapRepository;

    public GetKeycapQueryHandler(IKeycapRepository keycapRepository)
    {
      Console.WriteLine("Creating GetKeycapQueryHandler");
      _keycapRepository = keycapRepository;
    }

    public async Task<Keycap> Handle(GetKeycapQuery request, CancellationToken cancellationToken)
    {
      Console.WriteLine("Handling GetKeycapQuery");
      var kc = await _keycapRepository.GetByIdAsync(request.Id);
      return kc;
    }
  }
}
