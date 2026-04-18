using Microsoft.EntityFrameworkCore;
using razor.Core.UseCases.schedules;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

DbBuilder dbBuilder = new();
builder.Services.AddRazorPages();
dbBuilder.AddDatabase(builder);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

WebApplication app = builder.Build();

using IServiceScope scope = app.Services.CreateScope();

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