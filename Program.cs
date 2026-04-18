using Microsoft.EntityFrameworkCore;
using razor.Core.UseCases.schedules;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

DbBuilder dbBuilder = new();
builder.Services.AddRazorPages();
dbBuilder.AddDatabase(builder);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
dbBuilder.AddDatabase(builder);

builder.Services.AddScoped<SchedulesUseCase>();

WebApplication app = builder.Build();

using IServiceScope scope = app.Services.CreateScope();
AppDbContext db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
db.Database.Migrate();

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pages}/{action=Index}/{id?}"
);
app.MapRazorPages().WithStaticAssets();

app.Run();