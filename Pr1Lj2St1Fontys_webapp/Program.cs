using Microsoft.EntityFrameworkCore;
using Pr1Lj2St1Fontys_webapp.Data; // Zorg dat je Data map en ApplicationDbContext bestaat!

var builder = WebApplication.CreateBuilder(args);

// Voeg de database toe met een connectiestring
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

//  redirect to /overzicht pagina 
app.MapGet("/", async context =>
{
    context.Response.Redirect("/overzicht");
});

// De pagina's binded (useful for the /overzicht page else this wont be main page)
app.MapRazorPages();
app.Run();
