using Microsoft.AspNetCore.Mvc;
using MediatR;
using Duckeebs.Application.Queries;
using Duckeebs.Application.Commands;
using Duckeebs.Core.Entities;

namespace Duckeebs.API.Controller
{
  [ApiController]
  [Route("[controller]")]
  public class KeycapController : ControllerBase
  {
      private readonly IMediator _mediator;
      private readonly ILogger<KeycapController> _logger;

      public KeycapController(ILogger<KeycapController> logger, IMediator mediator)
      {
          _logger = logger;
          _mediator = mediator;
      }

      [HttpGet("{id}", Name = "GetKeycapById")]
      public async Task<IActionResult> GetKeycapById(int id)
      {
        Console.WriteLine("Getting keycap by id");
        var keycap = await _mediator.Send(new GetKeycapQuery(id));
        return Ok(keycap);
      }

      [HttpPost(Name = "CreateKeycap")]
      public async Task<IActionResult> CreateKeycap([FromBody] CreateKeycapRequest request)
      {
        CreateKeycapCommand command = new CreateKeycapCommand(request.Name);
        await _mediator.Send(command);
        return Ok();
      }
  }

  public class CreateKeycapRequest {
    public string Name { get; set; }
  }
}
