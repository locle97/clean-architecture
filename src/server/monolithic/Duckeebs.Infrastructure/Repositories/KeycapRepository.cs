using System.Linq.Expressions;
using Duckeebs.Core.Entities;
using Duckeebs.Core.Interfaces;
using Duckeebs.Core.Exceptions;

namespace Duckeebs.Infrastructure.Repositories
{
    public class KeycapRepository : IKeycapRepository
    {
      private readonly ApplicationDbContext _context;

      public KeycapRepository(ApplicationDbContext context)
      {
        _context = context;
      }

      public async Task AddAsync(Keycap entity)
      {
        await _context.Keycaps.AddAsync(entity);
        await _context.SaveChangesAsync();
      }

      public async Task<Keycap> GetByIdAsync(int id)
      {
        Console.WriteLine("Getting keycap by id");
        Keycap kc = await _context.Keycaps.FindAsync(id);
        if (kc == null)
          throw new KeycapNotFoundException();
                  
        return kc;
      }

      public Task DeleteAsync(int id)
      {
          throw new NotImplementedException();
      }

      public Task<Keycap> FirstOrDefaultAsync(Expression<Func<Keycap, bool>> filter)
      {
          throw new NotImplementedException();
      }

      public Task<IEnumerable<Keycap>> GetAllAsync()
      {
          throw new NotImplementedException();
      }

      public Task<IEnumerable<Keycap>> GetByFilterAsync(Expression<Func<Keycap, bool>> filter)
      {
          throw new NotImplementedException();
      }


      public Task UpdateAsync(Keycap entity)
      {
          throw new NotImplementedException();
      }
    }
}
