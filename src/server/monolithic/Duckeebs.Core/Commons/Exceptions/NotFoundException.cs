namespace Duckeebs.Core.Commons
{
  public class NotFoundException : Exception
  {
    public NotFoundException(string message) : base(message) { }
  }
}
