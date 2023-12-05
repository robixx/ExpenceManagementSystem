using ExpenceManagementSystem.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DataBaseConnection>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    endpoints.MapAreaControllerRoute(
        name: "areas",
        areaName: "Admin",
        pattern: "{controller=DashBoard}/{action=DashBoard}/{id?}"
    );
    // other areas configurations goes here 
    endpoints.MapControllerRoute(
       name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
      );
});



app.Run();
