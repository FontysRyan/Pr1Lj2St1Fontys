using Microsoft.EntityFrameworkCore;
using Pr1Lj2St1Fontys_webapp.Data; // Used this namespace to have access to the ApplicationDbContext.cs

var builder = WebApplication.CreateBuilder(args);

// Use the connection string from appsettings.json to connect to the database 
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

//  redirect to /overzicht pagina when starting application
app.MapGet("/", async context =>
{
    context.Response.Redirect("/overzicht");
});

// De pagina's binded (useful for the /overzicht page else this wont be main page)
app.MapRazorPages();
app.Run();
