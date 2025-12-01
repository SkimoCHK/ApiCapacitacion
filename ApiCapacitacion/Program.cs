
using ApiCapacitacion.Interfaces;
using ApiCapacitacion.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ApiCapacitacion
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var builder = WebApplication.CreateBuilder(args);

      // Add services to the container.

      //Obtenemos la cadena de conexion
      var connectionString = builder.Configuration.GetConnectionString("sqlConnection");
      //Creamos una instancia de PostgreSqlConfiguration y le pasamos la cadena de conexion
      //porque luego usaremos esta clase para obtener la cadena de conexion!!
      PostgreSqlConfiguration sqlConfiguration = new PostgreSqlConfiguration(connectionString);

      //Damos de alta sqlConfiguration en el inyector de dependencias para que cualquier servicio o repository
      //que ocupe un PostgreSqlConfiguration el framework le pase uno
      builder.Services.AddSingleton(sqlConfiguration);


      builder.Services.AddScoped<ICursoRepository, CursoRepository>();




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
    }
  }
}
