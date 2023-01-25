using Clean_RH.Core.Interfaces.Core;
using Clean_RH.Core.Interfaces.Infra;
using Clean_RH.Core.Servicos;
using Clean_RH.Infrastructure.Infra;
using Clean_RH.Infrastructure.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// injeção de dependência
builder.Services.AddScoped<IRetornarCandidatoService, RetornarCandidatoService>();

builder.Services.AddScoped<IConexaoDB, ConexaoDB>();
builder.Services.AddScoped<IConsultarCandidatosPendente, ConsultarCandidatosPendente>();

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
