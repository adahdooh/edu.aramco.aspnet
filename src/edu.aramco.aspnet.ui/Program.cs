using edu.aramco.aspnet.domainEntities.Context;
using edu.aramco.aspnet.services.IServices;
using edu.aramco.aspnet.services.Services.SMSServices;
using edu.aramco.aspnet.ui.Components;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient("internalClient", client =>
{
    client.BaseAddress = new Uri("https://localhost:7245");
});

builder.Services.AddHttpClient("googleClient", client =>
{
    client.BaseAddress = new Uri("https://www.google.com");
});

// register dbcontext
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<ISMSService, MobilySMSService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
