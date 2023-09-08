using Autofac.Extensions.DependencyInjection;
using Autofac;
using AutoMapper;
using DapperOrnekBTK.Web;
using DapperOrnekBTK.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<TodoItemAutoMapperProfile>();
});
builder.Services.AddSingleton(config.CreateMapper());
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(builder => builder.RegisterModule(new DapperTodoDemoApplicationModule()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();