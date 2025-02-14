var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Replaces AddMvc()

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.UseStaticFiles();

app.Run();
