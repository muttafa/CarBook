using CarBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CarBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CarBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarDescriptionHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarFeatureHandlers;
using CarBook.Application.Features.CQRS.Handlers.CarHandlers;
using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Interfaces;
using CarBook.Persistence.Context;
using CarBook.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<GetAboutByIDQueryHandler>();
builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();
//------------------------------------------------------------
builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIDQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
//------------------------------------------------------------
builder.Services.AddScoped<CreateBrandCommandHandler>();
builder.Services.AddScoped<GetBrandByIDQueryHandler>();
builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();
//------------------------------------------------------------
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<GetCarByIDQueryHandler>();
builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<UpdateCarCommandHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
//------------------------------------------------------------
builder.Services.AddScoped<CreateCarFeatureCommandHandler>();
builder.Services.AddScoped<GetCarFeatureByIDQueryHandler>();
builder.Services.AddScoped<GetCarFeatureQueryHandler>();
builder.Services.AddScoped<UpdateCarFeatureCommandHandler>();
builder.Services.AddScoped<RemoveCarFeatureCommandHandler>();
//------------------------------------------------------------
builder.Services.AddScoped<CreateCarDescriptionCommandHandler>();
builder.Services.AddScoped<GetCarDescriptionByIDQueryHandler>();
builder.Services.AddScoped<GetCarDescriptionQueryHandler>();
builder.Services.AddScoped<UpdateCarDescriptionCommandHandler>();
builder.Services.AddScoped<RemoveCarDescriptionCommandHandler>();
//------------------------------------------------------------
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
