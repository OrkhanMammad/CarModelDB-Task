using CarModelProject.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(option =>
{

    option.UseSqlServer(builder.Configuration.GetConnectionString("Default"));


});
var app = builder.Build();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=home}/{action=index}/{id?}"
    
    
    
    );

app.Run();
