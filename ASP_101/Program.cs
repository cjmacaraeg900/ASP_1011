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

//Add to make a static files in your project
app.UseStaticFiles();

app.Run();
