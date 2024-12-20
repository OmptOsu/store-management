using StoreManagement.Api.Filters;
using StoreManagement.Api.Middleware;
using StoreManagement.Application;
using StoreManagement.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure(builder.Configuration);

    builder.Services.AddControllers(options => options.Filters.Add<ErrorHandlingFilterAttribute>());
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

    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
