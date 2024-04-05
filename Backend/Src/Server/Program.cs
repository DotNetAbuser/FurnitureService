var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDatabase(configuration);
builder.Services.AddRepositories();
builder.Services.AddServices();

builder.WebHost.ConfigureKestrel(serverOptions => {
        serverOptions.ListenAnyIP(5004);
    }).UseKestrel();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();
app.UseHttpsRedirection();

app.Run();