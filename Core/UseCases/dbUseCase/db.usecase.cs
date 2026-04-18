using Microsoft.EntityFrameworkCore;

namespace razor.Core.UseCases.dbUseCase {
  public class DbUseCase {
    public readonly AppDbContext _dbContext;
    
    public DbUseCase(AppDbContext dbContext)
    {
      _dbContext = dbContext;
    }
  }
}