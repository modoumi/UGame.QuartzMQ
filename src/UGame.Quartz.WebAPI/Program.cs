using Serilog;
using StackExchange.Redis;
using System.Reflection;
using TinyFx;
using TinyFx.Configuration;
using TinyFx.Logging;
using Xxyy.Banks.JOB.ServicesExtensions;
using UGame.Quartz.Service;
using UGame.Quartz.Service.Services.Activity.InviteNewuser;
using UGame.Quartz.Service.Services.LoseCashBack;
using UGame.Quartz.Service.Services.VipWeekReward;
using UGame.Quartz.WebAPI.Controllers;

var builder = AspNetHost.CreateBuilder();

// Add services to the container.
builder.AddAspNetEx();
//builder.Host.UseQuartzServer();
//builder.Services.Configure<ApiAccessFilterOption>(builder.Configuration.GetSection("ApiAccessFilter"));

builder.Services.AddMediatR(svcConfig => {
    svcConfig.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly(), Assembly.Load("UGame.Quartz.Service"));
});

builder.Services.AddScoped<LoseCashBackService>();
builder.Services.AddScoped<VipWeekRewardService>();
builder.Services.AddScoped<InviteNewuserService>();
//������֤���ж�������
builder.Services.AddVerifyOrderService();
var app = builder.Build();
// Configure the HTTP request pipeline.
app.UseAspNetEx();

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();
