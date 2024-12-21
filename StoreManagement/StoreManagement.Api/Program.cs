using Microsoft.AspNetCore.Mvc.Infrastructure;
using StoreManagement.Api.Common.Errors;
using StoreManagement.Application;
using StoreManagement.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration)
        .AddControllers();

    builder.Services.AddSingleton<ProblemDetailsFactory, StoreManagementProblemDetailsFactory>();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseExceptionHandler("/error");

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
