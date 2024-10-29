using Framework_01.Infrastructure;
using MB.Application;
using MB.Application.Abstractions.Article;
using MB.Application.Abstractions.ArticleCategory;
using MB.Application.Abstractions.Comment;
using Microsoft.EntityFrameworkCore;
using Persistance;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg;
using MB.Domain.CommentAgg;
using MB.Persistence;
using MB.Persistence.EFCore.Repositories;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configOption = new ConfigurationBuilder();
var config = configOption.AddJsonFile("appsettings.json").Build();
string connectionString = config.GetConnectionString("DBconnection");

Bootstrapper.Config(builder.Services,connectionString);
builder.Services.AddRazorPages();

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
