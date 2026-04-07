using Microsoft.EntityFrameworkCore;

public class DbBuilder
{
    public IServiceCollection AddDatabase(WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
        return builder.Services;
    }
}