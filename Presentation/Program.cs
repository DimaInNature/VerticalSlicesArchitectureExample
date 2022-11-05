var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDatabaseConfiguration(configuration: builder.Configuration);
builder.Services.AddCQRS();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

await app.RunAsync();