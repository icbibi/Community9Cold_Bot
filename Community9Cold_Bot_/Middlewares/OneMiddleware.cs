using PRTelegramBot.Core.Middlewares;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Community9Cold_Bot.Middlewares
{
    internal class OneMiddleware : MiddlewareBase
    {
        public override async Task InvokeOnPreUpdateAsync(ITelegramBotClient botClient, Update update, Func<Task> next)
        {
            var msg = update.Message;
            Console.WriteLine("Начало обработки сообщений");
            await base.InvokeOnPreUpdateAsync(botClient, update, next);
            Console.WriteLine($"Имя пользователя: {msg?.Chat.FirstName}  |  Текст сообщения: {msg?.Text}");

        }
        public override async Task InvokeOnPostUpdateAsync(ITelegramBotClient botClient, Update update)
        {
            Console.WriteLine("Конец обработки сообщений");
            await base.InvokeOnPostUpdateAsync(botClient, update);
        }
    }
}
