using Onion.Application.DependencyResolvers;
using Onion.Persistence.DependencyResolvers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    // Ayni isimdeki siniflarin (CQRS ve Mediator) cakismasini onlemek icin
    c.CustomSchemaIds(type => type.ToString());
});


builder.Services.AddDbContextServices();
builder.Services.AddRepositoryServices();
builder.Services.AddMapperService();
builder.Services.AddHandlerService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
