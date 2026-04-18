using razor.Core.Repositories.Schedules;
using Microsoft.EntityFrameworkCore;
using razor.Core.UseCases.schedules;

public class DbBuilder
{
    public IServiceCollection AddDatabase(WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
        
        builder.Services.AddScoped<AppDbContext>();
        builder.Services.AddScoped<SchedulesRepository>();
        builder.Services.AddScoped<SchedulesUseCase>();
        return builder.Services;
    }
}