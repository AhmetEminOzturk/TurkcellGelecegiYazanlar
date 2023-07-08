using SurveyApp.API.IoCExtensions;
using SurveyApp.Services.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var connectionString = builder.Configuration.GetConnectionString("db");
builder.Services.AddInjections(connectionString);

//builder.Services.AddCors(opt =>
//{
//    opt.AddPolicy("allow", builder =>
//    {
//        builder.AllowAnyHeader();
//        builder.AllowAnyMethod();
//        builder.AllowAnyOrigin();
//    });
//});

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
