using Community9Cold_Bot.Middlewares;
using PRTelegramBot.Core;


var bot = new PRBotBuilder("7737618204:AAHbF0DLertLYQi3ul2uiSw_S7NVOIwG_mQ")
    .AddAdmin(16118573458, 5122938690)
    .AddMiddlewares(new TwoMiddlewareOption())
    .Build();

bot.Events.OnCommonLog += Events_OnCommonLog;
_ = bot.Start();

async Task Events_OnCommonLog(PRTelegramBot.Models.EventsArgs.CommonLogEventArgs arg)
{
    Console.WriteLine(arg.Message);
}

while (true)
{

}