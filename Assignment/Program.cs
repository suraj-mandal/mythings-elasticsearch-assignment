using Assignment.Data;
using Assignment.Interfaces;
using Assignment.Jobs;
using Assignment.Repositories;
using Assignment.Services;
using Microsoft.EntityFrameworkCore;
using Nest;
using Newtonsoft.Json;
using Quartz;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"), a => a.CommandTimeout(3600));
});

builder.Services.AddScoped<ISubStoreRepository, SubStoreRepository>();
builder.Services.AddScoped<ISubStoreService, SubStoreService>();
builder.Services.AddScoped<IElasticSearchService, ElasticSearchService>();

builder.Services.AddSingleton<IElasticClient>(sp =>
{
    var settings =
        new ConnectionSettings(new Uri(builder.Configuration["ElasticSearch:Url"] ?? "http://localhost:9200"))
            .DefaultIndex("search-sub-stores");
    return new ElasticClient(settings);
});

builder.Services.AddScoped<SyncDataJob>();

builder.Services.AddQuartz(q =>
{
    var jobKey = new JobKey("SyncDataJob");
    q.AddJob<SyncDataJob>(opts => opts.WithIdentity(jobKey));

    q.AddTrigger(opts => opts
        .ForJob(jobKey)
        .WithIdentity("SyncDataJob-Trigger")
        .WithCronSchedule("0/1 0 * * * ?")
    );
});

builder.Services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.MapControllers();
app.Run();