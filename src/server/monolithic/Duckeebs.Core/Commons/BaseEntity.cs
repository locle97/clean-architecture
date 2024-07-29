namespace Duckeebs.Core.Commons
{
  public abstract class BaseEntity {
    public BaseEntity(int id) { 
      Id = id;
    }

    public BaseEntity() { }

    public int Id { get; set; }
  }
}
