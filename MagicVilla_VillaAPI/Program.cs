//using Serilog;
using MagicVilla_VillaAPI.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//customize logger and save it in log file
// Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
//                 .WriteTo.File("log/villalogs.txt", rollingInterval: RollingInterval.Day).CreateLogger();
// builder.Host.UseSerilog();
builder.Services
    .AddControllers(
    //add condition on type of body here is json 
    option =>
    {
        option.ReturnHttpNotAcceptable = true;
    }
    )
    //to accept xml type
    // .AddXmlDataContractSerializerFormatters()      
    .AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ILogging,LoggingV2>();
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
