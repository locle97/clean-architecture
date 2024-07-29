using Duckeebs.Core.Entities;

namespace Duckeebs.Core.Exceptions
{
  public class KeycapNotFoundException : Exception
  {
    public KeycapNotFoundException() : base($"The {nameof(Keycap)} you are looking for was not found in the database.") { }
  }
}
