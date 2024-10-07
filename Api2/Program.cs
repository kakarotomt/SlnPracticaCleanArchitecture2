using Application2;
using Infraestructure2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication();
builder.Services.AddInfraestructure(builder.Configuration);


//builder.Services.AddCors(opt =>
//{
//    opt.AddPolicy(name: "angular", build =>
//    {
//        build.AllowAnyOrigin();//"https://localhost:4200");
//        build.AllowAnyMethod();//"PUT", "POST", "GET", "DELETE");
//        build.AllowAnyHeader();
//    }
//                );
//}
//);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
//app.UseCors();
app.MapControllers();

app.Run();
