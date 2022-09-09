using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using MyMovies.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MyMoviesDbContext>(opts => {
    opts.UseSqlServer(
    builder.Configuration["ConnectionStrings:MyMoviesConnection"]);
});

builder.Services.AddScoped<IMyMoviesRepository, EFMyMoviesRepository>();

var app = builder.Build();

app.UseStaticFiles();
app.MapDefaultControllerRoute();

var context = app.Services.CreateScope().ServiceProvider
 .GetRequiredService<MyMoviesDbContext>();

SeedData.SeedDatabase(context);

app.Run();
