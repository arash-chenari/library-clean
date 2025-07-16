using Library.Application.Categories;
using Library.Application.Categories.Contracts;
using Library.Entities.Abstraction;
using Library.Persistence.EF;
using Library.Persistence.EF.Categories;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("ConnectionString");

builder.Services.AddDbContext<EfDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddScoped<ICategoryRepository, EfCategoryRepository>()
    .AddScoped<ICategoriesService, CategoriesService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    app.UseExceptionHandler(async ex =>
    {
        ex.Run(async context =>
        {
            var exeption = context.Features.Get<IExceptionHandlerPathFeature>();

            if (exeption.Error is BusinessException)
            {
                var exTitle = exeption.Error.GetType().Name
                .ToString().Replace("Exception", "");
                await context.Response.WriteAsync(exTitle);
            }else
            {
                await context.Response.WriteAsync("Something went wrong!!!!!!");
                //log
            }
        });
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
