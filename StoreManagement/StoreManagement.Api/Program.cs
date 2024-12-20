using Microsoft.AspNetCore.Mvc.Infrastructure;
using StoreManagement.Api.Errors;
using StoreManagement.Api.Filters;
using StoreManagement.Api.Middleware;
using StoreManagement.Application;
using StoreManagement.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    /*------------------------------------------
    //FILTER IMPLEMENTATION
    builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
    --------------------------------------------*/

    builder.Services.AddControllers();

    //------------------------------------------
    //ERROR ENDPOINT IMPLEMENTATION
    builder.Services.AddSingleton<ProblemDetailsFactory, StoreManagementProblemDetailsFactory>();
    //------------------------------------------

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

    /*------------------------------------------
    //MIDDLEWARE IMPLEMENTATION
    app.UseMiddleware<ErrorHandlingMiddleware>();
    --------------------------------------------*/

    //------------------------------------------
    //ERROR ENDPOINT IMPLEMENTATION
    app.UseExceptionHandler("/error");
    //------------------------------------------

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
