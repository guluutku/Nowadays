using System.Reflection;
using Nowadays.Services;
using Microsoft.OpenApi.Models;
using Nowadays.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Custom Added
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDB"));
builder.Services.AddSingleton<MongoDBService>();
// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Nowadays",
        Version = "v1",
        Description = "An issue tracker API",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Gün Uluutku",
            Email = "example@email.com",
            Url = new Uri("https://example.com/terms")
        },
        License = new OpenApiLicense
        {
            Name = "Nowadays License Example",
            Url = new Uri("https://example.com/license")
        }
    });
});

builder.Services.AddHttpContextAccessor();
// End

var app = builder.Build();

// Custom Added
if (app.Environment.IsDevelopment())
{
    // Swagger
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nowadays V1");
    });
}
// End

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
