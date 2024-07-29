using Duckeebs.Core.Entities;

namespace Duckeebs.Core.Exceptions
{
  public class KeycapSetNotFoundException : Exception
  {
    public KeycapSetNotFoundException() : base($"The {nameof(KeycapSet)} you are looking for was not found in the database.") { }
  }
}
