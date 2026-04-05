var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews()
    .AddRazorRuntimeCompilation();
var app = builder.Build();

app.UseRouting();
app.MapControllers();
app.UseStaticFiles();

app.Run();
