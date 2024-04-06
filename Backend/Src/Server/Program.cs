var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddDatabase(configuration);
builder.Services.AddRepositories();
builder.Services.AddServices();

builder.Services.AddCors();

builder.WebHost.ConfigureKestrel(serverOptions => {
        serverOptions.ListenAnyIP(5004);
    }).UseKestrel();

var app = builder.Build();

#if DEBUG
app.UseSwagger();
app.UseSwaggerUI();
#endif

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) 
    .AllowCredentials()); 

app.MapControllers();
app.UseHttpsRedirection();

app.Run();