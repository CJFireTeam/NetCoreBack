using Mapster;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Netcore.Web.Api.Startup;
using System.Text.Json.Serialization;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);

string? env = builder.Configuration.GetValue<string>("env");

string? connectionStrings = builder.Configuration.GetConnectionString("Netcore");

string? secret = builder.Configuration.GetValue<string>("Secret");

builder.Configuration.AddJsonFile("appsettings.json");
builder.Configuration.AddJsonFile($"appsettings.{env}.json");

Netcore.Abstraction.StaticParams.StaticParams.Secret = secret;

builder.Services.RegisterServices(builder.Configuration);

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddMvc().AddJsonOptions(o =>
{
    o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    o.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("corsLocalHost", //corsLocalHost
    builder =>
    {
        builder.WithOrigins(
            "http://localhost:3000"
            )
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod()

        .WithExposedHeaders("content-disposition");
    });
});

builder.Services.AddDbContext<Netcore.ActivoFijo.Model.Context>(x => x.UseSqlServer(connectionStrings, x => x.EnableRetryOnFailure()));

(Action<AuthenticationOptions> authenticationOptions, Action<JwtBearerOptions> jwtBearerOptions) = Netcore.Abstraction.Security.Security.AddAuthentication(secret);

builder.Services.AddAuthorization()
                .AddAuthentication(authenticationOptions)
                .AddJwtBearer(jwtBearerOptions);

IHostEnvironment environment = builder.Environment;

Netcore.Abstraction.StaticParams.StaticParams.Environment = environment.EnvironmentName;

switch (environment.EnvironmentName)
{
    case "Development":
        {
            builder.Configuration.AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

            break;
        }
    case "Production":
        {
            builder.Configuration.AddJsonFile("appsettings.Production.json", optional: true, reloadOnChange: true);

            break;
        }
    case "Local":
        {
            builder.Configuration.AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true);

            break;
        }
    case "QA":
        {
            builder.Configuration.AddJsonFile("appsettings.QA.json", optional: true, reloadOnChange: true);

            break;
        }
}

WebApplication app = builder.Build();

app.UseCors("corsLocalHost");

app.ConfigureSwagger();

app.UseAuthentication();

app.UseAuthorization();

app.UseHttpsRedirection();

app.MapEndpoints();

app.Run();