using ApiQuestion.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Converters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson(jsonOptions =>
{
    jsonOptions.SerializerSettings.Converters.Add(new StringEnumConverter());
    jsonOptions.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});
builder.Services.AddEndpointsApiExplorer();

//Context
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionServer")));

//Scoped Interfaces
builder.Services.AddScoped<ApiQuestion.Domain.Interfaces.IListDomain, ApiQuestion.Domain.Classes.ListDomain>();
builder.Services.AddScoped<ApiQuestion.Repository.IListRepository, ApiQuestion.Repository.ListRepository>();

//Swagger
builder.Services.AddSwaggerDocument(config =>
{
    config.PostProcess = document =>
    {
        document.Info.Version = "v1";
        document.Info.Title = "Titulo API";
        document.Info.Description = "Descripción API";
        document.Info.TermsOfService = "Terms of Service";
        document.Info.Contact = new NSwag.OpenApiContact
        {
            Name = "Username",
            Email = "user@example.com",
            Url = "http://example.com"
        };
        document.Info.License = new NSwag.OpenApiLicense
        {
            Name = "Nombre Licencia",
            Url = "https://example.com/license"
        };
    };
});

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    //The default HSTS value is 30 days.You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
IConfiguration configuration = app.Configuration;
IWebHostEnvironment environment = app.Environment;
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseOpenApi();
app.UseSwaggerUi3();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
