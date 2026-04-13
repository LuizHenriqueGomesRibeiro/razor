WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

DbBuilder dbBuilder = new();
builder.Services.AddRazorPages();
dbBuilder.AddDatabase(builder);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
dbBuilder.AddDatabase(builder);

WebApplication app = builder.Build();

if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pages}/{action=Index}/{id?}");
app.MapRazorPages().WithStaticAssets();

app.Run();