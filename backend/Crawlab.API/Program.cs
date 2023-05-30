using Crawlab.DB;
using Crawlab.RPC;

// Create the builder with which we will build the app
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add database context
builder.Services.AddDbContext<CrawlabDbContext>();

// Add SignalR
builder.Services.AddSignalR();
// .AddJsonProtocol(options => { options.PayloadSerializerOptions.PropertyNamingPolicy = null; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// HTTPS
app.UseHttpsRedirection();

// Authentication
app.UseAuthorization();

// Controllers
app.MapControllers();

// SignalR
app.MapHub<RpcServer>("/rpc");

// Run
app.Run();