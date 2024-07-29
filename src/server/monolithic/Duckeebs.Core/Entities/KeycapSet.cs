using Duckeebs.Core.Commons;

namespace Duckeebs.Core.Entities
{
    public class KeycapSet: BaseEntity
    {
      public KeycapSet(int id, string name, string imageUrl, string sourceUrl) 
            : base(id)
      {
        Name = name;
        ImageUrl = imageUrl;
        SourceUrl = sourceUrl;
      }
      public string? Name { get; set; }

      public string? ImageUrl { get; set; }

      public string? SourceUrl { get; set; }

      public List<Keycap> Keycaps { get; set; } = new List<Keycap>();
    }
}
