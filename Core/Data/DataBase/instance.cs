namespace razor.Core.Data.DataBase
{
  public class DbInstance
  {
    protected readonly AppDbContext _dbInstance;

    public DbInstance(AppDbContext dbContext, Action<AppDbContext>? configure = null)
    {
      _dbInstance = dbContext;
      configure?.Invoke(_dbInstance);
    }
  }
}