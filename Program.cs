using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using DockerAPI.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// MS SQL Server connection 

var connectionString = builder.Configuration.GetConnectionString("sqlserver");
 //builder.Services.AddDbContext<CustomerContext>(options=> 
    //                 options.UseSqlServer(connectionString));
           
        builder.Services.AddDbContext<CustomerContext>(options=> 
        options.UseSqlServer(
                connectionString)
                );
              //  options.
               // dbOptionsBuilder => dbOptionsBuilder.UseModel(MainDbContextModel.Instance),
              //  svc => svc.AddRepository(typeof(Repository<>)));


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
CustomerPrepDB.Prepopulation(app);