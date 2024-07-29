using Duckeebs.Core.Commons;

namespace Duckeebs.Core.Entities
{
  public class Keycap: BaseEntity {
    public Keycap(int id, string name, string imageUrl) : base(id)
    {
      Name = name;
      ImageUrl = imageUrl;
    }

    public Keycap() { }

    public string? Name { get; set; }

    public string? ImageUrl { get; set; }

    public int? KeycapSetId { get; set; }
    public KeycapSet? KeycapSet { get; set; }
  }
}
