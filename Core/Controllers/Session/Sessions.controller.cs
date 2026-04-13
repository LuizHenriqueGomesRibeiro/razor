using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class SessionController : Controller {
  private readonly DbSet<User> _user;

  public SessionController(AppDbContext context) {
    _user = context.Users;
  }

  public async Task<User> getUsers() {
    User user = await _user.FirstAsync();
    return user;
  }
}