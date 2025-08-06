using Community9Cold_Bot.Headers;
using PRTelegramBot.Attributes;
using PRTelegramBot.Core.Middlewares;
using PRTelegramBot.Extensions;
using PRTelegramBot.Interfaces;
using PRTelegramBot.Models;
using PRTelegramBot.Models.InlineButtons;
using PRTelegramBot.Utils;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Community9Cold_Bot.Middlewares
{
    internal class TwoMiddlewareOption : MiddlewareBase
    {
        static bool PlzImme = false;
        static bool PlzInfo = false;
        static bool PlzRegistersTime = false;
        static bool PlzLowPlace = false;
        static bool NewsProverca = false;
        static bool TelegramNameProverca = false;
        public static string? TelegramNameAdd;
        static bool StandoffNameProverca = false;
        public static string? StandoffNameAdd;
        static bool StandoffIDProverca = false;
        public static string? StandoffIDAdd;
        static bool TelegramIDProverca = false;
        public static string? TelegramIDAdd;
        static bool TelegramUserNameProverca = false;
        public static string? TelegramUserNameAdd;
        static bool BlackSpisoc = false;
        public static string? BlackSpisocAdd;
        static bool WhiteSpisoc = false;
        public static string? WhiteSpisocAdd;
        static bool EsportSpisoc = false;
        public static string? EsportSpisocAdd;
        static bool ProfilPlzP = false;
        public static string? ProfilPlzPAdd;
        static bool ProfilAva = false;
        public static string? ProfilAvaAdd;
        static bool DelProfil = false;
        public static string? DelProfilAdd;

        static bool ProfilPlzPPl = false;
        public static string? ProfilPlzPPlAdd;
        public static string? NameSimProfilPlzPl;

        public static int Plz = 0;
        public static int Mess;
        public static short RegProfil = 0;
        public static long IDProverca;
        static string? Statys;
        public static string? wordS;
        public static int index = 0;
        public static int indexDell;
        public static string? MessSim;
        public static string? NameAll;
        public static string? NameSimProfilPlz;
        public static string? AddS;
        public static string? UserNameAdd;
        public static string? News;

        #region Case
        #region Fable
        public static int Fable1 = 0;
        public static int Fable2 = 0;
        public static int Fable3 = 0;
        public static int Fable4 = 0;
        public static int Fable5 = 0;
        public static int Fable6 = 0;
        public static int Fable7 = 0;
        public static int Fable8 = 0;
        public static int Fable9 = 0;
        public static int Fable10 = 0;
        public static int Fable11 = 0;
        public static int Fable12 = 0;
        public static int Fable13 = 0;
        public static int Fable14 = 0;
        public static int Fable15 = 0;
        public static int Fable16 = 0;
        public static int Fable17 = 0;
        public static int Fable18 = 0;
        public static int Fable19 = 0;
        public static int Fable20 = 0;
        public static int Fable21 = 0;
        public static int Fable22 = 0;
        public static int Fable23 = 0;
        public static int Fable24 = 0;
        public static int Fable25 = 0;
        public static int Fable26 = 0;
        public static int Fable27 = 0;
        public static int Fable28 = 0;
        public static int Fable29 = 0;
        public static int Fable30 = 0;
        public static int Fable31 = 0;
        public static int Fable32 = 0;
        public static int Fable33 = 0;
        public static int Fable34 = 0;
        public static int Fable35 = 0;
        public static int Fable36 = 0;
        public static int Fable37 = 0;
        public static int Fable38 = 0;
        public static int Fable39 = 0;
        public static int Fable40 = 0;
        public static int Fable41 = 0;
        public static int Fable42 = 0;
        public static int Fable43 = 0;
        public static int Fable44 = 0;
        public static int Fable45 = 0;
        public static int Fable46 = 0;
        public static int Fable47 = 0;
        public static int Fable48 = 0;
        public static int Fable49 = 0;
        public static int Fable50 = 0;
        #endregion
        #endregion

        #region Balanc
        public static int Balanc1 = 404;
        public static int Balanc2 = 404;
        public static int Balanc3 = 404;
        public static int Balanc4 = 404;
        public static int Balanc5 = 404;
        public static int Balanc6 = 404;
        public static int Balanc7 = 404;
        public static int Balanc8 = 404;
        public static int Balanc9 = 404;
        public static int Balanc10 = 404;
        public static int Balanc11 = 404;
        public static int Balanc12 = 404;
        public static int Balanc13 = 404;
        public static int Balanc14 = 404;
        public static int Balanc15 = 404;
        public static int Balanc16 = 404;
        public static int Balanc17 = 404;
        public static int Balanc18 = 404;
        public static int Balanc19 = 404;
        public static int Balanc20 = 404;
        public static int Balanc21 = 404;
        public static int Balanc22 = 404;
        public static int Balanc23 = 404;
        public static int Balanc24 = 404;
        public static int Balanc25 = 404;
        public static int Balanc26 = 404;
        public static int Balanc27 = 404;
        public static int Balanc28 = 404;
        public static int Balanc29 = 404;
        public static int Balanc30 = 404;
        public static int Balanc31 = 404;
        public static int Balanc32 = 404;
        public static int Balanc33 = 404;
        public static int Balanc34 = 404;
        public static int Balanc35 = 404;
        public static int Balanc36 = 404;
        public static int Balanc37 = 404;
        public static int Balanc38 = 404;
        public static int Balanc39 = 404;
        public static int Balanc40 = 404;
        public static int Balanc41 = 404;
        public static int Balanc42 = 404;
        public static int Balanc43 = 404;
        public static int Balanc44 = 404;
        public static int Balanc45 = 404;
        public static int Balanc46 = 404;
        public static int Balanc47 = 404;
        public static int Balanc48 = 404;
        public static int Balanc49 = 404;
        public static int Balanc50 = 404;
        #endregion

        #region Spisci
        public static string? AllPlz;
        public static string? AllPlzBlack;
        public static string? AllPlzWhite;
        public static string? AllPlzEsport;
        #endregion

        #region TelegramIDconvert
        public static string? IDConverts;
        public static string? IDConverts2;
        public static string? IDConverts3;
        public static string? IDConverts4;
        #endregion


        #region ProfilUserName
        public static string? UserNameTelegram1 = "@Slavaicebibi";
        public static string? UserNameTelegram2 = "@МИША";
        public static string? UserNameTelegram3 = "@GavTG01";
        public static string? UserNameTelegram4;
        public static string? UserNameTelegram5;
        public static string? UserNameTelegram6;
        public static string? UserNameTelegram7;
        public static string? UserNameTelegram8;
        public static string? UserNameTelegram9;
        public static string? UserNameTelegram10;
        public static string? UserNameTelegram11;
        public static string? UserNameTelegram12;
        public static string? UserNameTelegram13;
        public static string? UserNameTelegram14;
        public static string? UserNameTelegram15;
        public static string? UserNameTelegram16;
        public static string? UserNameTelegram17;
        public static string? UserNameTelegram18;
        public static string? UserNameTelegram19;
        public static string? UserNameTelegram20;
        public static string? UserNameTelegram21;
        public static string? UserNameTelegram22;
        public static string? UserNameTelegram23;
        public static string? UserNameTelegram24;
        public static string? UserNameTelegram25;
        public static string? UserNameTelegram26;
        public static string? UserNameTelegram27;
        public static string? UserNameTelegram28;
        public static string? UserNameTelegram29;
        public static string? UserNameTelegram30;
        public static string? UserNameTelegram31;
        public static string? UserNameTelegram32;
        public static string? UserNameTelegram33;
        public static string? UserNameTelegram34;
        public static string? UserNameTelegram35;
        public static string? UserNameTelegram36;
        public static string? UserNameTelegram37;
        public static string? UserNameTelegram38;
        public static string? UserNameTelegram39;
        public static string? UserNameTelegram40;
        public static string? UserNameTelegram41;
        public static string? UserNameTelegram42;
        public static string? UserNameTelegram43;
        public static string? UserNameTelegram44;
        public static string? UserNameTelegram45;
        public static string? UserNameTelegram46;
        public static string? UserNameTelegram47;
        public static string? UserNameTelegram48;
        public static string? UserNameTelegram49;
        public static string? UserNameTelegram50;
        #endregion

        #region ProfilName
        public static string? NameTelegram1 = "Savaa";
        public static string? NameTelegram2 = "МИША";
        public static string? NameTelegram3 = "Гав";
        public static string? NameTelegram4;
        public static string? NameTelegram5;
        public static string? NameTelegram6;
        public static string? NameTelegram7;
        public static string? NameTelegram8;
        public static string? NameTelegram9;
        public static string? NameTelegram10;
        public static string? NameTelegram11;
        public static string? NameTelegram12;
        public static string? NameTelegram13;
        public static string? NameTelegram14;
        public static string? NameTelegram15;
        public static string? NameTelegram16;
        public static string? NameTelegram17;
        public static string? NameTelegram18;
        public static string? NameTelegram19;
        public static string? NameTelegram20;
        public static string? NameTelegram21;
        public static string? NameTelegram22;
        public static string? NameTelegram23;
        public static string? NameTelegram24;
        public static string? NameTelegram25;
        public static string? NameTelegram26;
        public static string? NameTelegram27;
        public static string? NameTelegram28;
        public static string? NameTelegram29;
        public static string? NameTelegram30;
        public static string? NameTelegram31;
        public static string? NameTelegram32;
        public static string? NameTelegram33;
        public static string? NameTelegram34;
        public static string? NameTelegram35;
        public static string? NameTelegram36;
        public static string? NameTelegram37;
        public static string? NameTelegram38;
        public static string? NameTelegram39;
        public static string? NameTelegram40;
        public static string? NameTelegram41;
        public static string? NameTelegram42;
        public static string? NameTelegram43;
        public static string? NameTelegram44;
        public static string? NameTelegram45;
        public static string? NameTelegram46;
        public static string? NameTelegram47;
        public static string? NameTelegram48;
        public static string? NameTelegram49;
        public static string? NameTelegram50;
        #endregion

        #region ProfilID
        public static string? IDTelegram1 = "5122938690";
        public static string? IDTelegram2 = "1618573458";
        public static string? IDTelegram3 = "7302403156";
        public static string? IDTelegram4;
        public static string? IDTelegram5;
        public static string? IDTelegram6;
        public static string? IDTelegram7;
        public static string? IDTelegram8;
        public static string? IDTelegram9;
        public static string? IDTelegram10;
        public static string? IDTelegram11;
        public static string? IDTelegram12;
        public static string? IDTelegram13;
        public static string? IDTelegram14;
        public static string? IDTelegram15;
        public static string? IDTelegram16;
        public static string? IDTelegram17;
        public static string? IDTelegram18;
        public static string? IDTelegram19;
        public static string? IDTelegram20;
        public static string? IDTelegram21;
        public static string? IDTelegram22;
        public static string? IDTelegram23;
        public static string? IDTelegram24;
        public static string? IDTelegram25;
        public static string? IDTelegram26;
        public static string? IDTelegram27;
        public static string? IDTelegram28;
        public static string? IDTelegram29;
        public static string? IDTelegram30;
        public static string? IDTelegram31;
        public static string? IDTelegram32;
        public static string? IDTelegram33;
        public static string? IDTelegram34;
        public static string? IDTelegram35;
        public static string? IDTelegram36;
        public static string? IDTelegram37;
        public static string? IDTelegram38;
        public static string? IDTelegram39;
        public static string? IDTelegram40;
        public static string? IDTelegram41;
        public static string? IDTelegram42;
        public static string? IDTelegram43;
        public static string? IDTelegram44;
        public static string? IDTelegram45;
        public static string? IDTelegram46;
        public static string? IDTelegram47;
        public static string? IDTelegram48;
        public static string? IDTelegram49;
        public static string? IDTelegram50;
        #endregion

        #region ProfilStandoffName
        public static string? NameStandoff1 = "ice bibi";
        public static string? NameStandoff2 = "Todash_Raketa";
        public static string? NameStandoff3 = "апреле джек";
        public static string? NameStandoff4;
        public static string? NameStandoff5;
        public static string? NameStandoff6;
        public static string? NameStandoff7;
        public static string? NameStandoff8;
        public static string? NameStandoff9;
        public static string? NameStandoff10;
        public static string? NameStandoff11;
        public static string? NameStandoff12;
        public static string? NameStandoff13;
        public static string? NameStandoff14;
        public static string? NameStandoff15;
        public static string? NameStandoff16;
        public static string? NameStandoff17;
        public static string? NameStandoff18;
        public static string? NameStandoff19;
        public static string? NameStandoff20;
        public static string? NameStandoff21;
        public static string? NameStandoff22;
        public static string? NameStandoff23;
        public static string? NameStandoff24;
        public static string? NameStandoff25;
        public static string? NameStandoff26;
        public static string? NameStandoff27;
        public static string? NameStandoff28;
        public static string? NameStandoff29;
        public static string? NameStandoff30;
        public static string? NameStandoff31;
        public static string? NameStandoff32;
        public static string? NameStandoff33;
        public static string? NameStandoff34;
        public static string? NameStandoff35;
        public static string? NameStandoff36;
        public static string? NameStandoff37;
        public static string? NameStandoff38;
        public static string? NameStandoff39;
        public static string? NameStandoff40;
        public static string? NameStandoff41;
        public static string? NameStandoff42;
        public static string? NameStandoff43;
        public static string? NameStandoff44;
        public static string? NameStandoff45;
        public static string? NameStandoff46;
        public static string? NameStandoff47;
        public static string? NameStandoff48;
        public static string? NameStandoff49;
        public static string? NameStandoff50;
        #endregion

        #region ProfilStandoffID
        public static string? IDStandoff1 = "57613305";
        public static string? IDStandoff2 = "33535323";
        public static string? IDStandoff3 = "20533162";
        public static string? IDStandoff4;
        public static string? IDStandoff5;
        public static string? IDStandoff6;
        public static string? IDStandoff7;
        public static string? IDStandoff8;
        public static string? IDStandoff9;
        public static string? IDStandoff10;
        public static string? IDStandoff11;
        public static string? IDStandoff12;
        public static string? IDStandoff13;
        public static string? IDStandoff14;
        public static string? IDStandoff15;
        public static string? IDStandoff16;
        public static string? IDStandoff17;
        public static string? IDStandoff18;
        public static string? IDStandoff19;
        public static string? IDStandoff20;
        public static string? IDStandoff21;
        public static string? IDStandoff22;
        public static string? IDStandoff23;
        public static string? IDStandoff24;
        public static string? IDStandoff25;
        public static string? IDStandoff26;
        public static string? IDStandoff27;
        public static string? IDStandoff28;
        public static string? IDStandoff29;
        public static string? IDStandoff30;
        public static string? IDStandoff31;
        public static string? IDStandoff32;
        public static string? IDStandoff33;
        public static string? IDStandoff34;
        public static string? IDStandoff35;
        public static string? IDStandoff36;
        public static string? IDStandoff37;
        public static string? IDStandoff38;
        public static string? IDStandoff39;
        public static string? IDStandoff40;
        public static string? IDStandoff41;
        public static string? IDStandoff42;
        public static string? IDStandoff43;
        public static string? IDStandoff44;
        public static string? IDStandoff45;
        public static string? IDStandoff46;
        public static string? IDStandoff47;
        public static string? IDStandoff48;
        public static string? IDStandoff49;
        public static string? IDStandoff50;
        #endregion

        #region ProfilAva
        public static string? ProfilAva1 = "Берёзовая";
        public static string? ProfilAva2 = "Чёрная";
        public static string? ProfilAva3 = "Именная";
        public static string? ProfilAva4 = "Member";
        public static string? ProfilAva5 = "Member";
        public static string? ProfilAva6 = "Member";
        public static string? ProfilAva7 = "Member";
        public static string? ProfilAva8 = "Member";
        public static string? ProfilAva9 = "Member";
        public static string? ProfilAva10 = "Member";
        public static string? ProfilAva11 = "Member";
        public static string? ProfilAva12 = "Member";
        public static string? ProfilAva13 = "Member";
        public static string? ProfilAva14 = "Member";
        public static string? ProfilAva15 = "Member";
        public static string? ProfilAva16 = "Member";
        public static string? ProfilAva17 = "Member";
        public static string? ProfilAva18 = "Member";
        public static string? ProfilAva19 = "Member";
        public static string? ProfilAva20 = "Member";
        public static string? ProfilAva21 = "Member";
        public static string? ProfilAva22 = "Member";
        public static string? ProfilAva23 = "Member";
        public static string? ProfilAva24 = "Member";
        public static string? ProfilAva25 = "Member";
        public static string? ProfilAva26 = "Member";
        public static string? ProfilAva27 = "Member";
        public static string? ProfilAva28 = "Member";
        public static string? ProfilAva29 = "Member";
        public static string? ProfilAva30 = "Member";
        public static string? ProfilAva31 = "Member";
        public static string? ProfilAva32 = "Member";
        public static string? ProfilAva33 = "Member";
        public static string? ProfilAva34 = "Member";
        public static string? ProfilAva35 = "Member";
        public static string? ProfilAva36 = "Member";
        public static string? ProfilAva37 = "Member";
        public static string? ProfilAva38 = "Member";
        public static string? ProfilAva39 = "Member";
        public static string? ProfilAva40 = "Member";
        public static string? ProfilAva41 = "Member";
        public static string? ProfilAva42 = "Member";
        public static string? ProfilAva43 = "Member";
        public static string? ProfilAva44 = "Member";
        public static string? ProfilAva45 = "Member";
        public static string? ProfilAva46 = "Member";
        public static string? ProfilAva47 = "Member";
        public static string? ProfilAva48 = "Member";
        public static string? ProfilAva49 = "Member";
        public static string? ProfilAva50 = "Member";
        #endregion

        public override async Task InvokeOnPreUpdateAsync(ITelegramBotClient botClient, Update update, Func<Task> next)
        {
            var msg = update.Message;
            Console.WriteLine("Начало обработки сообщений");
            await base.InvokeOnPreUpdateAsync(botClient, update, next);

            Mess++;
            index += 1;
            #region MessAll
            if (msg?.Text != null)
            {
                wordS += msg?.Text + $" 00{index},\n\r";
            }
            #endregion
            #region LastMess
            if (msg?.Text != null)
            {
                MessSim = msg?.Text;
            }
            #endregion
            #region ProvercaProfil
            if (msg?.Text != null && TelegramNameProverca == true)
            {
                TelegramNameAdd = msg?.Text;
            }
            if (msg?.Text != null && StandoffNameProverca == true)
            {
                StandoffNameAdd = msg?.Text;
            }
            if (msg?.Text != null && StandoffIDProverca == true)
            {
                StandoffIDAdd = msg?.Text;
            }
            if (msg?.Text != null && TelegramIDProverca == true)
            {
                TelegramIDAdd = msg?.Text;
            }
            if (msg?.Text != null && TelegramUserNameProverca == true)
            {
                TelegramUserNameAdd = msg?.Text;
            }
            #endregion
            #region LastNews
            if (msg?.Text != null && NewsProverca == true)
            {
                News = msg?.Text;
            }
            #endregion
            #region List
            if (msg?.Text != null && BlackSpisoc == true)
            {
                BlackSpisocAdd = msg?.Text;
            }
            if (msg?.Text != null && WhiteSpisoc == true)
            {
                WhiteSpisocAdd = msg?.Text;
            }
            if (msg?.Text != null && EsportSpisoc == true)
            {
                EsportSpisocAdd = msg?.Text;
            }
            #endregion
            #region ProfilPlzProverca
            if (msg?.Text != null && ProfilPlzP == true)
            {
                ProfilPlzPAdd = msg?.Text;
            }
            if (msg?.Text != null && ProfilPlzPPl == true)
            {
                ProfilPlzPPlAdd = msg?.Text;
            }
            #endregion
            #region AvaPlzProverca
            if (msg?.Text != null && ProfilAva == true)
            {
                ProfilAvaAdd = msg?.Text;
            }
            #endregion
            #region LastDellProfil
            if (msg?.Text != null && DelProfil == true)
            {
                DelProfilAdd = msg?.Text;
            }
            #endregion

            Console.WriteLine($"Name: {msg?.Chat.FirstName}  |  Message: {msg?.Text}");

            Console.WriteLine("Колличество сообщений: " + Mess + "\n\r");

            #region Statys

            if (PlzInfo == false)
            {
                var isAdmin = await botClient.IsAdmin(update);
                isAdmin = await botClient.GetBotDataOrNull().Options.AdminManager.HasUser(update.GetChatId());
                if (isAdmin)
                {
                    Statys = "Admin";
                }
                else
                {
                    Statys = "User";
                }
            }

            if (Statys == "Admin")
            {
                Statys = "Owner";
            }

            #endregion

            if (PlzInfo == false)
            {
                Console.WriteLine($"Добавлена информация об пользователе\n\r\nИмя: \n\r\nПользовательское имя: @\n\r\nId: \n\r\nStatys:\n\r\n");
                PlzInfo = true;
            }
            if (PlzImme == false)
            {
                Plz++;
                PlzImme = true;
                Console.WriteLine("Колличество пользователей: " + Plz);
                Console.WriteLine("Значение проверки: " + PlzImme);
            }
            if (msg?.Text != null)
            {
                IDConverts4 = Convert.ToString(msg?.Chat.Id);
            }
        }
        public override async Task InvokeOnPostUpdateAsync(ITelegramBotClient botClient, Update update)
        {
            Console.WriteLine("Конец обработки сообщений");
            await base.InvokeOnPostUpdateAsync(botClient, update);
        }

        #region reply

        //Код для ответа на простые вопросы, а также для вывод меню.

        [ReplyMenuHandler("На чём написан этот бот", "В какой программе был разработан этот бот", "Среда разработки")]
        public static async Task OtvetNaChemBilNapisanBot(ITelegramBotClient botclient, Update update)
        {
            string msg = "Этот бот был написан на языке <b>C#</b> в среде разработки <b>Visual Studio</b>";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        #region V

        [ReplyMenuHandler("Версия", "Версия бота", "Какая версия бота")]
        public static async Task OtvetWhyVbot(ITelegramBotClient botclient, Update update)
        {
            string msg = "<b>v0.5 Beta</b>";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("Версии", "Версии бота", "Какие версии бота", "Все версии бота")]
        public static async Task OtvetWhyFullVbot(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.1 - <b>Создан бот</b> (4 Февраля).\r\nv0.1.1 - <b>Добавленны правила</b> (4 Февраля).\r\nv0.1.2 - <b>Добавлены роли</b> (4 Февраля)\r\nv0.1.3 - <b>Добавлена основная форма по которой принимать игроков</b> (5 Февраля).\r\nv0.1.4 - <b>Добавлены расшифровки команд</b> (6 Февраля).\r\nv0.1.5 - <b>Добавлены ответы на вопросы</b> (7 Февраля).\r\nv0.1.6 - <b>Создан корпу бота</b> (8 Февраля).\r\n" +
                "v0.2 - <b>Добавлен корпус профиля</b> (9 Февраля).\r\nv0.2.1 - <b>Добавлено добавление  Standoff-Ника в профиль</b> (12 Февраля).\r\nv0.2.2 - <b>Добавлено добавление Standoff-ID в профиль</b> (13 Февраля).\r\nv0.2.3 - <b>Добавлено добавление Telegram-Name в профиль</b> (14 Февраля).\r\nv0.2.4 - <b>Добавлено добавление Telegram-ID в профиль</b> (16 Февраля).\r\n" +
                "v0.2.5 - <b>Добавлено добавление Telegram-Username в профиль</b> (16 Февраля).\r\nv0.3 - <b>Создан корпус бота профиля</b> (17 Февраля).\r\nv0.3.1 - <b>Добавлена проверка на наличие профиля</b> (17 Февраля).\r\nv0.3.2 - <b>Добавлены Slash-команды</b> (18 Февраля).\r\nv0.3.3 - <b>Добавлены 9 аватарок</b> (6 Марта).\r\nv0.3.4 - <b>Добавлено привязка аватарок к аккаунту</b> (7 Марта).\r\n" +
                "v0.4 - <b>Оптимизирован бот</b> (29 Марта).\r\nv0.4.1 - <b>Удалено 5 тысяч строк</b> (2 Апреля).\r\nv0.4.2 - <b>Улучшена структура бота</b> (5 Апреля).\r\nv0.5 Beta - <b>Первый запуск бота</b> ().";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.1", "v0.1", "Создан бот")]
        public static async Task V01(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.1 - <b>Создан бот</b> (4 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.1.1", "v0.1.1", "Добавлены правила")]
        public static async Task V011(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.1.1 - <b>Добавленны правила</b> (4 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.1.2", "v0.1.2", "Добавлены роли")]
        public static async Task V012(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.1.2 - <b>Добавлены роли</b> (4 Февраля)";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.1.3", "v0.1.3", "Добавлена форма", "По которой принимать игроков")]
        public static async Task V013(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.1.3 - <b>Добавлена основная форма по которой принимать игроков</b> (5 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.1.4", "v0.1.4", "Добавлены расшифровки команд", "Добавлены команды")]
        public static async Task V014(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.1.4 - <b>Добавлены расшифровки команд</b> (6 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.1.5", "v0.1.5", "Добавлены ответы на вопросы")]
        public static async Task V015(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.1.5 - <b>Добавлены ответы на вопросы</b> (7 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.1.6", "v0.1.6", "0.1.7", "v0.1.7", "0.1.8", "v0.1.8", "0.1.9", "v0.1.9", "Создан корпус бота", "Корпус")]
        public static async Task V016(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.1.6 - <b>Создан корпус бота</b> (8 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.2", "v0.2", "Корпус профиля")]
        public static async Task V02(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.2 - <b>Добавлен корпус профиля</b> (9 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.2.1", "v0.2.1", "Добавление Standoff Ника в профиль", "Добавление Стандофф Ника в профиль", "Добавление Standoff-Ника в профиль")]
        public static async Task V021(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.2.1 - <b>Добавлено добавление  Standoff-Ника в профиль</b> (12 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.2.2", "v0.2.2", "Добавление Standoff ID в профиль", "Добавление Стандофф айди в профиль", "Добавление Standoff-ID в профиль")]
        public static async Task V022(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.2.2 - <b>Добавлено добавление Standoff-ID в профиль</b> (13 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.2.3", "v0.2.3", "Добавление TelegramНика в профиль", "Добавление Телеграм Ника в профиль", "Добавление Telegram-Name в профиль")]
        public static async Task V023(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.2.3 - <b>Добавлено добавление Telegram-Name в профиль</b> (14 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.2.4", "v0.2.4", "Добавление Telegram ID в профиль", "Добавление Телеграм айди в профиль", "Добавление Telegram-ID в профиль")]
        public static async Task V024(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.2.4 - <b>Добавлено добавление Telegram-ID в профиль</b> (16 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.2.5", "v0.2.5", "Добавление Telegram Username в профиль", "Добавление Телеграм юзернейм в профиль", "Добавление Telegram-Username в профиль")]
        public static async Task V025(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.2.5 - <b>Добавлено добавление Telegram-Username в профиль</b> (16 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.3", "v0.3", "Создан профиль")]
        public static async Task V03(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.3 - <b>Создан профиль</b> (17 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.3.1", "v0.3.1", "Проверка на наличие профиля")]
        public static async Task V031(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.3.1 - <b>Добавлена проверка на наличие профиля</b> (17 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.3.2", "v0.3.2", "Добавлены Slash-команды")]
        public static async Task V032(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.3.2 - <b>Добавлены Slash-команды</b> (18 Февраля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.3.3", "v0.3.3", "9 аватарок")]
        public static async Task V033(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.3.3 - <b>Добавлены 9 аватарок</b> (6 Марта).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.3.4", "v0.3.4", "Привязка аватарок к аккаунту")]
        public static async Task V034(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.3.4 - <b>Добавлено привязка аватарок к аккаунту</b> (7 Марта).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.4", "v0.4", "Оптимизорован бот")]
        public static async Task V04(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.4 - <b>Оптимизирован бот</b> (29 Марта).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.4.1", "v0.4.1", "Удалено 5 тысяч строк")]
        public static async Task V041(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.4.1 - <b>Удалено 5 тысяч строк</b> (2 Апреля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.4.2", "v0.4.2", "Улучшена структура бота")]
        public static async Task V042(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.4.2 - <b>Улучшена структура бота</b> (5 Апреля).";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        [ReplyMenuHandler("0.5", "v0.5", "Первый запуск")]
        public static async Task V05(ITelegramBotClient botclient, Update update)
        {
            string msg = "v0.5 Beta - <b>Первый запуск бота</b> ().";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        #endregion

        [ReplyMenuHandler(PRTelegramBot.Models.Enums.CommandComparison.Contains, "Какого звания принимать игроков", "Какого звания принимать игроков", "Скольки часов принимать игроков", "Каким профилем принимать", "Какой профиль подходит для 9Cold", "Принимают в 9Cold", "Принимать в 9Cold", "Принимать игроков", "Принимают игроков")]
        public static async Task OtvetOtCacogoZvaniaPrinimat(ITelegramBotClient botclient, Update update)
        {
            string msg = "Принимаем игроков по этим характеристиками: \\r\\n\\rЧасов: <b>700ч</b>. \\r\\n\\rЗвание MM: <b>Gold4</b>. \\r\\n\\rЗвание Союзники: <b>Gold3</b>. \\r\\n\\rЗвание Дуэль: -- \\r\\n\\rАИМ: <b>Средний</b> \\r\\n\\rЕсли ваш профиль совпадает или же выше этих характеристик, то можете смело принимать его в клан.";
            await PRTelegramBot.Helpers.Message.Send(botclient, update, msg);
        }

        #endregion

        #region Slash Owner

        [ReplyMenuHandler("/wordS")]
        public static async Task words(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            if (msg?.Chat.Id == 5122938690)
            {
                await botClient.SendTextMessageAsync(update.GetChatIdClass(), "Word: " + wordS);
            }
        }

        [ReplyMenuHandler("/Dellword")]
        public static async Task Delword(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            if (msg?.Chat.Id == 5122938690)
            {
                await botClient.SendTextMessageAsync(update.GetChatIdClass(), "Введите индекс сообщения");
            }
        }

        [ReplyMenuHandler("/AllName")]
        public static async Task AllName(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            if (msg?.Chat.Id == 5122938690)
            {
                await botClient.SendTextMessageAsync(update.GetChatIdClass(), "AllMess: " + NameAll);
            }
        }

        [ReplyMenuHandler("/ProfilPlz")]
        public static async Task ProfilPlzSlash(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            ProfilPlzP = true;
            if (msg?.Chat.Id == 5122938690)
            {
                var ProfilPlz = new InlineCallback("Подтвердить", PRHeadlers.ProfilPlz);

                var list = new List<IInlineContent>();
                list.Add(ProfilPlz);

                var menu = MenuGenerator.InlineKeyboard(1, list);

                var option = new OptionMessage();
                option.MenuInlineKeyboardMarkup = menu;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Введите данные пользователя.", option);
            }
        }

        [ReplyMenuHandler("/CleanEsport")]
        public static async Task CleanEsport(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            if (msg?.Chat.Id == 5122938690)
            {
                AllPlzEsport = null;
            }
        }

        [ReplyMenuHandler("/CleanBlackList")]
        public static async Task CleanBlackList(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            if (msg?.Chat.Id == 5122938690)
            {
                AllPlzBlack = null;
            }
        }

        [ReplyMenuHandler("/CleanWhiteList")]
        public static async Task CleanWhiteList(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            if (msg?.Chat.Id == 5122938690)
            {
                AllPlzWhite = null;
            }
        }

        [ReplyMenuHandler("/CleanWordS")]
        public static async Task CleanWordS(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            if (msg?.Chat.Id == 5122938690)
            {
                wordS = null;
            }
        }

        [ReplyMenuHandler("/CleanMessSim")]
        public static async Task CleanMessSim(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            if (msg?.Chat.Id == 5122938690)
            {
                MessSim = null;
            }
        }

        [ReplyMenuHandler("/UpdateListBlack")]
        public static async Task UpdateListBlackSlash(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            BlackSpisoc = true;
            if (msg?.Chat.Id == 5122938690)
            {
                var UpdateListBlack = new InlineCallback("Подтвердить", PRHeadlers.UpdateListBlack);
                var example3 = new InlineCallback("Меню", PRHeadlers.Example3);

                var list = new List<IInlineContent>();
                list.Add(UpdateListBlack);
                list.Add(example3);

                var menuPrav = MenuGenerator.InlineKeyboard(1, list);

                var option1 = new OptionMessage();
                option1.MenuInlineKeyboardMarkup = menuPrav;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Укажите новый черный список.", option1);
            }
        }

        [ReplyMenuHandler("/UpdateListWhite")]
        public static async Task UpdateListWhiteSlash(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            WhiteSpisoc = true;
            if (msg?.Chat.Id == 5122938690)
            {
                var UpdateListWhite = new InlineCallback("Подтвердить", PRHeadlers.UpdateListWhite);
                var example3 = new InlineCallback("Меню", PRHeadlers.Example3);

                var list = new List<IInlineContent>();
                list.Add(UpdateListWhite);
                list.Add(example3);

                var menuPrav = MenuGenerator.InlineKeyboard(1, list);

                var option1 = new OptionMessage();
                option1.MenuInlineKeyboardMarkup = menuPrav;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Укажите новый белый список.", option1);
            }
        }

        [ReplyMenuHandler("/UpdateListEsport")]
        public static async Task UpdateListEsportSlash(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            EsportSpisoc = true;
            if (msg?.Chat.Id == 5122938690)
            {
                var UpdateListEsport = new InlineCallback("Подтвердить", PRHeadlers.UpdateListEsport);
                var example3 = new InlineCallback("Меню", PRHeadlers.Example3);

                var list = new List<IInlineContent>();
                list.Add(UpdateListEsport);
                list.Add(example3);

                var menuPrav = MenuGenerator.InlineKeyboard(1, list);

                var option1 = new OptionMessage();
                option1.MenuInlineKeyboardMarkup = menuPrav;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Укажите новый список основного состава.", option1);
            }
        }

        [ReplyMenuHandler("/Test")]
        public static async Task Test(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            if (msg?.Chat.Id == 5122938690)
            {
                await botClient.SendTextMessageAsync(update.GetChatIdClass(), "ffffffffff");
            }
        }

        [ReplyMenuHandler("/Debugging")]
        public static async Task Debugging(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            if (msg?.Chat.Id == 5122938690)
            {
                await botClient.SendTextMessageAsync(update.GetChatIdClass(), $"Last enter TGN: {TelegramNameAdd}\n\rLast enter SON: {StandoffNameAdd}\n\rLast enter SID: {StandoffIDAdd}\n\rLast enter TID: {TelegramIDAdd}\n\r" +
                    $"Last enter TUN: {TelegramUserNameAdd}\n\r\nExamination TGN: {TelegramNameProverca}\n\rExamination SON: {StandoffNameProverca}\n\rExamination SID: {StandoffIDProverca}\n\rExamination TID: {TelegramIDProverca}\n\r" +
                    $"Examination TUN: {TelegramUserNameProverca}\n\r\nLast enter AYio: \n\rLast enter AYil: \n\rLast enter ABlu: \n\rLast enter AOra: \n\rLast enter ARed: \n\r" +
                    $"Last enter ALG: \n\rLast enter ABG: \n\rLast enter APi: \n\rLast enter AWh: \n\rLast enter ABl: \n\r\nrExamination AYio: \n\r" +
                    $"Examination AYil: \n\rExamination ABlu: \n\rExamination AOra: \n\rExamination ARed: \n\r Examination ALG: \n\r" +
                    $"Examination ABG: \n\rExamination APi: \n\rExamination AWh: \n\rExamination ABl: \n\r\nLast enter Mess: {MessSim}\n\r\nLast News: {News}");
            }
        }
        #endregion
        #region Slash Admincommands
        [ReplyMenuHandler("/AllPlzCol")]
        public static async Task AdminCommands2(ITelegramBotClient botClient, Update update)
        {
            var isAdmin = await botClient.IsAdmin(update);
            isAdmin = await botClient.GetBotDataOrNull().Options.AdminManager.HasUser(update.GetChatId());
            if (isAdmin)
            {
                await botClient.SendTextMessageAsync(update.GetChatIdClass(), $"Колличество всех пользователей: {Plz}");
            }
        }
        [ReplyMenuHandler("/AllMess")]
        public static async Task AdminCommands3(ITelegramBotClient botClient, Update update)
        {
            var isAdmin = await botClient.IsAdmin(update);
            isAdmin = await botClient.GetBotDataOrNull().Options.AdminManager.HasUser(update.GetChatId());
            if (isAdmin)
            {
                await botClient.SendTextMessageAsync(update.GetChatIdClass(), $"Колличество сообщений: {Mess} (+1)");
            }
        }

        [ReplyMenuHandler("/AllPlz")]
        public static async Task AllPlzSlash(ITelegramBotClient botClient, Update update)
        {
            var isAdmin = await botClient.IsAdmin(update);
            isAdmin = await botClient.GetBotDataOrNull().Options.AdminManager.HasUser(update.GetChatId());
            if (isAdmin)
            {
                await botClient.SendTextMessageAsync(update.GetChatIdClass(), $"Все пользователи:\n\r\n{AllPlz}");
            }
        }

        [ReplyMenuHandler("/NewsAdd")]
        public static async Task NewsAddSlash(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            var isAdmin = await botClient.IsAdmin(update);
            isAdmin = await botClient.GetBotDataOrNull().Options.AdminManager.HasUser(update.GetChatId());
            if (isAdmin)
            {
                var AddNews = new InlineCallback("Продолжить", PRHeadlers.AddNews);

                var list = new List<IInlineContent>();
                list.Add(AddNews);

                var menu = MenuGenerator.InlineKeyboard(1, list);

                var option = new OptionMessage();
                option.MenuInlineKeyboardMarkup = menu;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Нажмите продолжить, чтобы установить новости. Недавние новости: {News}", option);
            }
        }

        [ReplyMenuHandler("/NewsDell")]
        public static async Task NewsDellSlash(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            var isAdmin = await botClient.IsAdmin(update);
            isAdmin = await botClient.GetBotDataOrNull().Options.AdminManager.HasUser(update.GetChatId());
            if (isAdmin)
            {
                News = null;

                await botClient.SendTextMessageAsync(update.GetChatIdClass(), "Новости удалены.");
            }
        }

        #endregion
        #region Slash

        //Код для ответа на слеш команды
        [ReplyMenuHandler("/Commands")]
        public static async Task CommandsSlash(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            var isAdmin = await botClient.IsAdmin(update);
            isAdmin = await botClient.GetBotDataOrNull().Options.AdminManager.HasUser(update.GetChatId());
            if (!isAdmin)
            {
                await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Все Slash команды:\n\r\n/Balance - <b>показывает</b> какой у вас <b>баланс</b>.\n\r/TelegramName - <b>показывает</b> ваш <b>telegram ник</b>.\n\r/TelegramID - <b>показывает</b> ваше <b>telegram id</b>.\n\r/P - <b>показывает</b> ваш <b>профиль</b>.\n\r/BlackList или /BL - <b>показывает чёрный список</b>.\n\r/WhiteList или /WL - <b>показывает белый список</b>.\n\r/Esport - <b>показывает основной состав</b>.\n\r/reg или /log - <b>регистрация</b>.\n\r/Commands - <b>показывает все команды</b>.\n\r/News - <b>Показывает новости</b>.");
            }
            else if (isAdmin && msg?.Chat.Id == 5122938690)
            {
                await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Все Slash команды:\n\r\n/Balance - <b>показывает</b> какой у вас <b>баланс</b>.\n\r/TelegramName - <b>показывает</b> ваш <b>telegram ник</b>.\n\r/TelegramID - <b>показывает</b> ваше <b>telegram id</b>.\n\r/P - <b>показывает</b> ваш <b>профиль</b>.\n\r/BlackList или /BL - <b>показывает чёрный список</b>.\n\r/WhiteList или /WL - <b>показывает белый список</b>.\n\r/Esport - <b>показывает основной состав</b>.\n\r/reg или /log - <b>регистрация</b>.\n\r/Commands - <b>показывает все команды</b>.\n\r/News - <b>Показывает новости</b>.\n\r\nКоманды админа:\n\r\n/AllPlzCol - <b>показывает колличество сообщений</b>.\n\r/AllPlz - <b>показывает всех пользователей</b>.\n\r/AllMess - <b>показывает колличество сообщений</b>.\n\r\nКоманды владельца: \n\r\n/WordS - <b>показывает все сообщения</b>.\n\r/ProfilPlz - <b>просмотр профиля</b> и его редакция.\n\r/CleanEsport - <b>очистить</b> весь <b>основной состав</b>.\n\r/CleanMessSim - <b>очистить последние сообщение</b>.\n\r/CleanWordS - <b>очистить все сообщения</b>.\n\r/CleanWhiteList - <b>очистить</b> весь <b>белый список</b>.\n\r/CleanBlackList - <b>очистить</b> весь <b>чёрный список</b>.\n\r/UpdateListEsport - <b>обновляет список основного состава</b>.\n\r/UpdateListWhite - <b>обновляет белый список</b>.\n\r/UpdateListBlack - <b>обновляет чёрный список</b>.\n\r/Debugging - <b>отладка</b>.\n\r/NewsAdd - <b>добавляет новости</b>.\n\r/NewsDell - <b>удаляет новости</b>.");
            }
            else if (isAdmin)
            {
                await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Все Slash команды:\n\r\n/Balance - <b>показывает</b> какой у вас <b>баланс</b>.\n\r/TelegramName - <b>показывает</b> ваш <b>telegram ник</b>.\n\r/TelegramID - <b>показывает</b> ваше <b>telegram id</b>.\n\r/P - <b>показывает</b> ваш <b>профиль</b>.\n\r/BlackList или /BL - <b>показывает чёрный список</b>.\n\r/WhiteList или /WL - <b>показывает белый список</b>.\n\r/Esport - <b>показывает основной состав</b>.\n\r/reg или /log - <b>регистрация</b>.\n\r/Commands - <b>показывает все команды</b>.\n\r/News - <b>Показывает новости</b>.\n\r\nКоманды админа:\n\r\n/AllPlzCol - <b>показывает колличество сообщений</b>.\n\r/AllPlz - <b>показывает всех пользователей</b>.\n\r/AllMess - <b>показывает колличество сообщений</b>.\n\r/NewsAdd - <b>добавляет новости</b>.\n\r/NewsDell - <b>удаляет новости</b>.");
            }
            else
            {
                await botClient.SendTextMessageAsync(update.GetChatIdClass(), "Error 400");
            }
        }

        [ReplyMenuHandler("/Balance")]
        public static async Task BalanceCommand(ITelegramBotClient botClient, Update update)
        {
            await botClient.SendTextMessageAsync(update.GetChatIdClass(), "Баланс: 404");
        }

        [ReplyMenuHandler("/News")]
        public static async Task NewsSlashPlz(ITelegramBotClient botClient, Update update)
        {
            await botClient.SendTextMessageAsync(update.GetChatIdClass(), $"{News}");
        }

        [ReplyMenuHandler("/TelegramName")]
        public static async Task TelegramName(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            await botClient.SendTextMessageAsync(update.GetChatIdClass(), $"Ваш TelegramName: {msg?.Chat.FirstName}");
        }

        [ReplyMenuHandler("/TelegramUserName")]
        public static async Task TelegramUserName(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            await botClient.SendTextMessageAsync(update.GetChatIdClass(), $"Ваш TelegramUserName: {msg?.Chat.Username}");
        }

        [ReplyMenuHandler("/TelegramID")]
        public static async Task TelegramID(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            await botClient.SendTextMessageAsync(update.GetChatIdClass(), $"Ваш TelegramID: {msg?.Chat.Id}");
        }

        [ReplyMenuHandler("/P", "Профиль", "Мой профиль", "профиль", "мой профиль", "/Profile", "/Plz")]
        public static async Task Profil(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;

            IDConverts2 = Convert.ToString(msg?.Chat.Id);

            var AvaMember = new InlineCallback("Получить аватарку", PRHeadlers.AvaMember);
            var RedactProfil = new InlineCallback("Редактировать", PRHeadlers.RedactProfil);
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var listMemberAva = new List<IInlineContent>();
            listMemberAva.Add(AvaMember);
            listMemberAva.Add(RedactProfil);
            listMemberAva.Add(example3);
            var menuMember = MenuGenerator.InlineKeyboard(1, listMemberAva);
            var optionMember = new OptionMessage();
            optionMember.MenuInlineKeyboardMarkup = menuMember;

            var AvaElder = new InlineCallback("Получить аватарку", PRHeadlers.AvaElder);
            var listElderAva = new List<IInlineContent>();
            listElderAva.Add(AvaElder);
            listElderAva.Add(RedactProfil);
            listElderAva.Add(example3);
            var menuElder = MenuGenerator.InlineKeyboard(1, listElderAva);
            var optionElder = new OptionMessage();
            optionElder.MenuInlineKeyboardMarkup = menuElder;

            var AvaCoLeader = new InlineCallback("Получить аватарку", PRHeadlers.AvaCoLeader);
            var listCoLeader = new List<IInlineContent>();
            listCoLeader.Add(AvaCoLeader);
            listCoLeader.Add(RedactProfil);
            listCoLeader.Add(example3);
            var menuCoLeader = MenuGenerator.InlineKeyboard(1, listCoLeader);
            var optionCoLeader = new OptionMessage();
            optionCoLeader.MenuInlineKeyboardMarkup = menuCoLeader;

            var AvaRed = new InlineCallback("Получить аватарку", PRHeadlers.AvaRed);
            var listRedAva = new List<IInlineContent>();
            listRedAva.Add(AvaRed);
            listRedAva.Add(RedactProfil);
            listRedAva.Add(example3);
            var menuRed = MenuGenerator.InlineKeyboard(1, listRedAva);
            var optionRed = new OptionMessage();
            optionRed.MenuInlineKeyboardMarkup = menuRed;

            var AvaGreen = new InlineCallback("Получить аватарку", PRHeadlers.AvaGreen);
            var listGreenAva = new List<IInlineContent>();
            listGreenAva.Add(AvaGreen);
            listGreenAva.Add(RedactProfil);
            listGreenAva.Add(example3);
            var menuGreen = MenuGenerator.InlineKeyboard(1, listGreenAva);
            var optionGreen = new OptionMessage();
            optionGreen.MenuInlineKeyboardMarkup = menuGreen;

            var AvaOrange = new InlineCallback("Получить аватарку", PRHeadlers.AvaOrange);
            var listOrangeAva = new List<IInlineContent>();
            listOrangeAva.Add(AvaOrange);
            listOrangeAva.Add(RedactProfil);
            listOrangeAva.Add(example3);
            var menuOrange = MenuGenerator.InlineKeyboard(1, listOrangeAva);
            var optionOrange = new OptionMessage();
            optionOrange.MenuInlineKeyboardMarkup = menuOrange;

            var AvaPink = new InlineCallback("Получить аватарку", PRHeadlers.AvaPink);
            var listPinkAva = new List<IInlineContent>();
            listPinkAva.Add(AvaPink);
            listPinkAva.Add(RedactProfil);
            listPinkAva.Add(example3);
            var menuPink = MenuGenerator.InlineKeyboard(1, listPinkAva);
            var optionPink = new OptionMessage();
            optionPink.MenuInlineKeyboardMarkup = menuPink;

            var AvaBlue = new InlineCallback("Получить аватарку", PRHeadlers.AvaBlue);
            var listBlueAva = new List<IInlineContent>();
            listBlueAva.Add(AvaBlue);
            listBlueAva.Add(RedactProfil);
            listBlueAva.Add(example3);
            var menuBlue = MenuGenerator.InlineKeyboard(1, listBlueAva);
            var optionBlue = new OptionMessage();
            optionBlue.MenuInlineKeyboardMarkup = menuBlue;

            var AvaBirch = new InlineCallback("Получить аватарку", PRHeadlers.AvaBirch);
            var listBirchAva = new List<IInlineContent>();
            listBirchAva.Add(AvaBirch);
            listBirchAva.Add(RedactProfil);
            listBirchAva.Add(example3);
            var menuBirch = MenuGenerator.InlineKeyboard(1, listBirchAva);
            var optionBirch = new OptionMessage();
            optionBirch.MenuInlineKeyboardMarkup = menuBirch;

            var AvaBlack = new InlineCallback("Получить аватарку", PRHeadlers.AvaBlack);
            var listBlackAva = new List<IInlineContent>();
            listBlackAva.Add(AvaBlack);
            listBlackAva.Add(RedactProfil);
            listBlackAva.Add(example3);
            var menuBlack = MenuGenerator.InlineKeyboard(1, listBlackAva);
            var optionBlack = new OptionMessage();
            optionBlack.MenuInlineKeyboardMarkup = menuBlack;

            var AvaPersonalize = new InlineCallback("Получить аватарку", PRHeadlers.AvaPersonalize);
            var listPersonalizedAva = new List<IInlineContent>();
            listPersonalizedAva.Add(AvaPersonalize);
            listPersonalizedAva.Add(RedactProfil);
            listPersonalizedAva.Add(example3);
            var menuPersonalized = MenuGenerator.InlineKeyboard(1, listPersonalizedAva);
            var optionPersonalized = new OptionMessage();
            optionPersonalized.MenuInlineKeyboardMarkup = menuPersonalized;

            if (IDConverts2 == IDTelegram1)
            {
                IDConverts2 = null;
                await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram1}" +
                $"\n\r TelegramUserName: {UserNameTelegram1}\n\r TelegramID: {IDTelegram1}\n\r\n " +
                $"StandoffName: {NameStandoff1}\n\r StandoffID: {IDStandoff1}\n\r\n Баланс: {Balanc1}\n\r\n Аватарка: {ProfilAva1}", "https://radikal.host/i/MDVPjK", optionBirch);
            }
            else if (IDConverts2 == IDTelegram2)
            {
                IDConverts2 = null;
                await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram2}" +
                $"\n\r TelegramUserName: {UserNameTelegram2}\n\r TelegramID: {IDTelegram2}\n\r\n " +
                $"StandoffName: {NameStandoff2}\n\r StandoffID: {IDStandoff2}\n\r\n Баланс: {Balanc2}\n\r\n Аватарка: {ProfilAva2}", "https://radikal.host/i/M7MbXA", optionBlack);
            }
            else if (IDConverts2 == IDTelegram3)
            {
                IDConverts2 = null;
                await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram3}" +
                $"\n\r TelegramUserName: {UserNameTelegram3}\n\r TelegramID: {IDTelegram3}\n\r\n " +
                $"StandoffName: {NameStandoff3}\n\r StandoffID: {IDStandoff3}\n\r\n Баланс: {Balanc3}\n\r\n Аватарка: {ProfilAva3}", "https://radikal.host/i/M7MIQE", optionPersonalized);
            }
            else if (IDConverts2 == IDTelegram4)
            {
                IDConverts2 = null;
                if (ProfilAva4 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva4 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva4 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva4 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva4 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva4 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva4 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva4 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram5)
            {
                IDConverts2 = null;
                if (ProfilAva5 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva5 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva5 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva5 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva5 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva5 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva5 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva5 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram6)
            {
                IDConverts2 = null;
                if (ProfilAva6 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva6 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva6 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva6 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva6 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva6 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva6 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva6 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram7)
            {
                IDConverts2 = null;
                if (ProfilAva7 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva7 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva7 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva7 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff1}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva7 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva7 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva7 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram1}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva7 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram8)
            {
                IDConverts2 = null;
                if (ProfilAva8 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva8 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva8 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva8 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva8 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva8 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva8 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva8 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram9)
            {
                IDConverts2 = null;
                if (ProfilAva9 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva9 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva9 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva9 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva9 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva9 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva9 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram1}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva9 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram10)
            {
                IDConverts2 = null;
                if (ProfilAva10 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva10 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva10 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva10 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva10 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva10 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva10 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva10 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram11)
            {
                IDConverts2 = null;
                if (ProfilAva11 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva11 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva11 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc1}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva11 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva11 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva11 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva11 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva11 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram12)
            {
                IDConverts2 = null;
                if (ProfilAva12 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva12 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva12 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva12 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva12 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva12 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva12 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva12 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram13)
            {
                IDConverts2 = null;
                if (ProfilAva13 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva13 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva13 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva13 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva13 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva13 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva13 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva13 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram14)
            {
                IDConverts2 = null;
                if (ProfilAva14 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva14 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva14 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva14 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva14 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva14 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva14 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva14 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram15)
            {
                IDConverts2 = null;
                if (ProfilAva15 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva15 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva15 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva15 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva15 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva15 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva15 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva15 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram16)
            {
                IDConverts2 = null;
                if (ProfilAva16 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva16 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva16 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva16 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva16 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva16 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva16 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva16 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram17)
            {
                IDConverts2 = null;
                if (ProfilAva17 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva17 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva17 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva17 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva17 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva17 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva17 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva17 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram18)
            {
                IDConverts2 = null;
                if (ProfilAva18 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva18 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva18 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva18 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva18 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva18 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva18 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva18 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram19)
            {
                IDConverts2 = null;
                if (ProfilAva19 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva19 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva19 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva19 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva19 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva19 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva19 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva19 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram20)
            {
                IDConverts2 = null;
                if (ProfilAva20 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva20 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva20 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva20 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva20 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva20 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva20 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff1}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva20 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram21)
            {
                IDConverts2 = null;
                if (ProfilAva21 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva21 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva21 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva21 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva21 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva21 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva21 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva21 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram22)
            {
                IDConverts2 = null;
                if (ProfilAva22 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva22 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva22 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva22 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva22 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva22 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva22 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva22 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram23)
            {
                IDConverts2 = null;
                if (ProfilAva23 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva23 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva23 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva23 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva23 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva23 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva23 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva23 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram24)
            {
                IDConverts2 = null;
                if (ProfilAva24 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva24 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva24 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva24 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva24 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva24 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva24 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva24 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram25)
            {
                IDConverts2 = null;
                if (ProfilAva25 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva25 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva25 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva25 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva25 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva25 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva25 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva25 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram26)
            {
                IDConverts2 = null;
                if (ProfilAva26 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva26 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva26 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva26 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva26 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva26 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva26 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva26 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram27)
            {
                IDConverts2 = null;
                if (ProfilAva27 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva27 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva27 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva27 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva27 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva27 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff2}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva27 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva27 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram28)
            {
                IDConverts2 = null;
                if (ProfilAva28 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva28 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva28 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva28 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva28 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva28 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva28 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva28 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram29)
            {
                IDConverts2 = null;
                if (ProfilAva29 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva29 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva29 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva29 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva29 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff2}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva29 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva29 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva29 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram30)
            {
                IDConverts2 = null;
                if (ProfilAva30 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva30 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva30 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva30 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva30 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva30 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva30 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva30 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram31)
            {
                IDConverts2 = null;
                if (ProfilAva31 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva31 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva31 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva31 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva31 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva31 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva31 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva31 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram32)
            {
                IDConverts2 = null;
                if (ProfilAva32 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva32 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva32 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva32 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva32 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva32 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva32 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva32 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram33)
            {
                IDConverts2 = null;
                if (ProfilAva33 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva33 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva33 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva33 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva33 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva33 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva3}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva33 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva33 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram34)
            {
                IDConverts2 = null;
                if (ProfilAva34 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva34 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva34 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva34 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva34 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva34 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva34 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva34 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram35)
            {
                IDConverts2 = null;
                if (ProfilAva35 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva35 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva35 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva35 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva35 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva35 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva35 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva35 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram36)
            {
                IDConverts2 = null;
                if (ProfilAva36 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva36 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva36 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva36 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva36 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva36 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva36 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva36 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram37)
            {
                IDConverts2 = null;
                if (ProfilAva37 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva37 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva37 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva37 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva37 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva37 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva37 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva37 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram38)
            {
                IDConverts2 = null;
                if (ProfilAva38 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva38 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva38 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva38 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva38 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva38 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva38 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva38 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram39)
            {
                IDConverts2 = null;
                if (ProfilAva39 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva39 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva39 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva39 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva39 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva39 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva39 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva39 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram40)
            {
                IDConverts2 = null;
                if (ProfilAva40 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva40 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva40 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva40 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva40 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva40 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva40 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva40 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram41)
            {
                IDConverts2 = null;
                if (ProfilAva41 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva41 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva41 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva41 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva41 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva41 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva41 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva41 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram42)
            {
                IDConverts2 = null;
                if (ProfilAva42 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva42 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva42 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva42 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva42 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva42 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva42 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva42 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram43)
            {
                IDConverts2 = null;
                if (ProfilAva43 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva43 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva43 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva43 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva43 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva43 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva43 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva43 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram44)
            {
                IDConverts2 = null;
                if (ProfilAva44 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva44 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva44 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva44 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva44 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva44 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva44 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva44 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram45)
            {
                IDConverts2 = null;
                if (ProfilAva45 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva45 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva45 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva45 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva45 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva45 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva45 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva45 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram46)
            {
                IDConverts2 = null;
                if (ProfilAva46 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva46 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva46 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva46 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva46 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva46 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva46 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva46 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram47)
            {
                IDConverts2 = null;
                if (ProfilAva47 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva47 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva47 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva47 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva47 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva47 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva47 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva47 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram48)
            {
                IDConverts2 = null;
                if (ProfilAva48 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva48 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva48 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva48 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva48 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva48 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva48 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva48 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram49)
            {
                IDConverts2 = null;
                if (ProfilAva49 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva49 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva49 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva49 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva49 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva49 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva49 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva49 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else if (IDConverts2 == IDTelegram50)
            {
                IDConverts2 = null;
                if (ProfilAva50 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx5rdh", optionMember);
                }
                else if (ProfilAva50 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8Z5C ", optionElder);
                }
                else if (ProfilAva50 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8DeE ", optionCoLeader);
                }
                else if (ProfilAva50 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8EXD ", optionRed);
                }
                else if (ProfilAva50 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8rZK ", optionGreen);
                }
                else if (ProfilAva50 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8Ghz ", optionOrange);
                }
                else if (ProfilAva50 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8Rld ", optionPink);
                }
                else if (ProfilAva50 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx80p8 ", optionBlue);
                }
            }
            else
            {
                IDConverts2 = null;

                var listMain = new List<IInlineContent>();
                listMain.Add(example3);
                var menuPravMain = MenuGenerator.InlineKeyboard(1, listMain);
                var optionMain = new OptionMessage();
                optionMain.MenuInlineKeyboardMarkup = menuPravMain;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Вы еще не зарегистрированы.", optionMain);
            }
        }

        [ReplyMenuHandler("/Reg", "/Регистрация", "/Log", "Регистрация", "Зарегистрироваться", "Рег", "Логин", "/R", "/L")]
        public static async Task Register(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            if (IDConverts == null)
                IDConverts = Convert.ToString(msg?.Chat.Id);
            else
            {
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Error 402");
                //402 - одновременное использование команды регистрация.
            }

            if (IDConverts != IDTelegram1 || IDConverts != IDTelegram2 || IDConverts != IDTelegram3 || IDConverts != IDTelegram4 || IDConverts != IDTelegram5 || IDConverts != IDTelegram6 || IDConverts != IDTelegram7 || IDConverts != IDTelegram8 || IDConverts != IDTelegram9 || IDConverts != IDTelegram10 || IDConverts != IDTelegram11 || IDConverts != IDTelegram12 || IDConverts != IDTelegram13 ||
                IDConverts != IDTelegram14 || IDConverts != IDTelegram15 || IDConverts != IDTelegram16 || IDConverts != IDTelegram17 || IDConverts != IDTelegram18 || IDConverts != IDTelegram19 || IDConverts != IDTelegram20 || IDConverts != IDTelegram21 || IDConverts != IDTelegram22 || IDConverts != IDTelegram23 || IDConverts != IDTelegram24 || IDConverts != IDTelegram25 || IDConverts != IDTelegram26 ||
                IDConverts != IDTelegram27 || IDConverts != IDTelegram28 || IDConverts != IDTelegram29 || IDConverts != IDTelegram30 || IDConverts != IDTelegram31 || IDConverts != IDTelegram32 || IDConverts != IDTelegram33 || IDConverts != IDTelegram34 || IDConverts != IDTelegram35 || IDConverts != IDTelegram36 || IDConverts != IDTelegram37 || IDConverts != IDTelegram38 || IDConverts != IDTelegram39 ||
                IDConverts != IDTelegram40 || IDConverts != IDTelegram41 || IDConverts != IDTelegram42 || IDConverts != IDTelegram43 || IDConverts != IDTelegram44 || IDConverts != IDTelegram45 || IDConverts != IDTelegram46 || IDConverts != IDTelegram47 || IDConverts != IDTelegram48 || IDConverts != IDTelegram49 || IDConverts != IDTelegram50)
            {
                if (PlzRegistersTime == false)
                {
                    var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
                    var ProfilRegSlash = new InlineCallback("Зарегистрироваться", PRHeadlers.ProfilRegSlash);

                    var list = new List<IInlineContent>();
                    list.Add(ProfilRegSlash);
                    list.Add(example3);

                    var menu = MenuGenerator.InlineKeyboard(1, list);

                    var option = new OptionMessage();
                    option.MenuInlineKeyboardMarkup = menu;
                    await PRTelegramBot.Helpers.Message.Send(botClient, update, "Нажмите на кнопку для начала регистрации.", option);
                }
                else
                {
                    var example3 = new InlineCallback("Меню", PRHeadlers.Example3);

                    var list = new List<IInlineContent>();
                    list.Add(example3);

                    var menuPrav = MenuGenerator.InlineKeyboard(1, list);

                    var option1 = new OptionMessage();
                    option1.MenuInlineKeyboardMarkup = menuPrav;
                    await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Регистрация отклонина</b>. В данный момент времени другой пользователь регистрируется. Вы сможете пройти регистрацию после него, обычно регистрация занимает (1-2 Минуты).", option1);
                }

            }
            else
            {
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Вы не можете зарегестрироватся</b>, у вас уже существует профиль.");
            }
            IDConverts = null;
        }

        [ReplyMenuHandler("/ProfilPlz")]
        public static async Task ProfilPlzSlashPl(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            ProfilPlzPPl = true;
            var ProfilPlz = new InlineCallback("Подтвердить", PRHeadlers.ProfilPlzPl);

            var list = new List<IInlineContent>();
            list.Add(ProfilPlz);

            var menu = MenuGenerator.InlineKeyboard(1, list);

            var option = new OptionMessage();
            option.MenuInlineKeyboardMarkup = menu;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Введите данные профиля, которого хотите посмотреть. (<b>Number, StandoffID, StandoffName, TelegramName, TelegramUserName</b>)", option);
        }

        [ReplyMenuHandler("/Esport", "Основной состав", "Основа", "Основа клана", "Основной состав клана", "/EsportList")]
        public static async Task Esport(ITelegramBotClient botClient, Update update)
        {
            await botClient.SendTextMessageAsync(update.GetChatIdClass(), "Основной состав: \n\r\n" + AllPlzEsport);
        }

        [ReplyMenuHandler("/BlackList", "Чёрный список", "BL", "чёрный список", "ЧС", "чс", "черный список", "чёрный список")]
        public static async Task Black(ITelegramBotClient botClient, Update update)
        {
            await botClient.SendTextMessageAsync(update.GetChatIdClass(), "Чёрный список: \n\r\n" + AllPlzBlack);
        }

        [ReplyMenuHandler("/WhiteList", "Белый список", "WL", "белый список", "БС")]
        public static async Task White(ITelegramBotClient botClient, Update update)
        {
            await botClient.SendTextMessageAsync(update.GetChatIdClass(), "Белый список: \n\r\n" + AllPlzWhite);
        }

        #endregion

        #region Inline

        [ReplyMenuHandler(PRTelegramBot.Models.Enums.CommandComparison.Contains, "Меню", "Main", "Старта", "/start", "Главное меню")]
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.Example3)]
        public static async Task InLine(ITelegramBotClient botClient, Update update)
        {
            var example = new InlineCallback("Правила 📃", PRHeadlers.Example);
            var example2 = new InlineCallback("Роли", PRHeadlers.Example2);
            var exampleAddPlyaer = new InlineCallback("С какого звания принимать?", PRHeadlers.ExampleAddPlyaer);
            var Roule = new InlineCallback("Игровые команды", PRHeadlers.Roule);
            var Profil = new InlineCallback("Профиль", PRHeadlers.Profil);
            var Commands = new InlineCallback("Slash Команды", PRHeadlers.Commands);
            //varCaseMain =new InlineCallback("Case 📦",PRHeadlers.CaseMain);
            var Maps = new InlineCallback("Играемые карты", PRHeadlers.Maps);

            var list = new List<IInlineContent>();
            list.Add(example);
            list.Add(example2);
            list.Add(exampleAddPlyaer);
            list.Add(Roule);
            list.Add(Profil);
            list.Add(Commands);
            //listAddCaseMain);
            list.Add(Maps);

            var menu = MenuGenerator.InlineKeyboard(3, list);

            var option = new OptionMessage();
            option.MenuInlineKeyboardMarkup = menu;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Меню успешно открыто. {News}", option);
        }

        #region Rulse

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.Example)]
        public static async Task HandlerExample(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Правила 9Cold</b> 📃\n\r\n1.0 (<b>Запрещено оскорблять со-кланов</b>, также как и рандомов в игре и в чате).\n\r\n" +
                "1.2 (<b>Запрещено отправлять</b> в чат любые <b>ссылки</b>).\n\r\n1.3 (<b>Запрещено выходить из чата</b> без особой причины (выход из него это тоже самое, что и выход из клана)).\n\r\n1.4 (<b>Запрещено выходить из БК/Турнира</b> без весомой причины)." +
                "\n\r\n1.6 (<b>Запрещено исключать со-кланов</b> с <b>1 февраля</b> по <b>1 января</b> (если этот игрок больше месяца в клане) <b>исключение из правил: оскорбления, обман и тп</b>.).\n\r\n1.7 (<b>Запрещено массовое упоминание</b> с <b>23.30</b> по <b>8.00</b>)." +
                "\n\r\n1.9 (<b>Запрещено исключать игроков</b> из <b>ММ/БК</b> без согласия 60% участников).");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Правила основного состава</b> 📃\n\r\n1.5 (Запрещено <b>убирать аватарку клана</b>, это тоже самое, что и выход из основного состава. Разрешено <b>снимать аватарку основного состава</b>, с 15-го декабря по 1-е января. (<b>Правило для основного состава</b>)).", option1);
        }

        #endregion
        //Правила.

        #region Role
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.Example2)]
        public static async Task HandlerExample2(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var exampleEntry = new InlineCallback("Entry", PRHeadlers.ExampleEntry);
            var exampleLurk = new InlineCallback("Lurk", PRHeadlers.ExampleLurk);
            var exampleSniper = new InlineCallback("Sniper", PRHeadlers.ExampleSniper);
            var exampleIGL = new InlineCallback("IGL", PRHeadlers.ExampleIGL);
            var exampleSupport = new InlineCallback("Support", PRHeadlers.ExampleSupport);

            var list = new List<IInlineContent>();
            list.Add(exampleEntry);
            list.Add(exampleLurk);
            list.Add(exampleSniper);
            list.Add(exampleSupport);
            list.Add(exampleIGL);
            list.Add(example3);

            var menuRole = MenuGenerator.InlineKeyboard(1, list);
            var optionRole = new OptionMessage();
            optionRole.MenuInlineKeyboardMarkup = menuRole;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выбирите ролль, которая вас интересует.", optionRole);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.ExampleEntry)]
        public static async Task HandlerExampleEntry(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>ENTRY</b> - <b>Танк</b>\r\n\r\nЦель: <b>сбор информации на точках, контроль передвижения команды противника</b>, а так же опен-фраги. <b>Всегда выходит первым</b>, вне зависимости от количества хелс-поинтов (Игроков), армора или девайса. Должен иметь <b>высокий уровень стрельбы</b>, <b>знание позиций</b> и <b>отменную реакцию</b>.");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var exampleLurk = new InlineCallback("Lurk", PRHeadlers.ExampleLurk);
            var exampleSniper = new InlineCallback("Sniper", PRHeadlers.ExampleSniper);
            var exampleIGL = new InlineCallback("IGL", PRHeadlers.ExampleIGL);
            var exampleSupport = new InlineCallback("Support", PRHeadlers.ExampleSupport);

            var list = new List<IInlineContent>();
            list.Add(exampleLurk);
            list.Add(exampleSniper);
            list.Add(exampleSupport);
            list.Add(exampleIGL);
            list.Add(example3);

            var menuRole = MenuGenerator.InlineKeyboard(1, list);
            var optionRole = new OptionMessage();
            optionRole.MenuInlineKeyboardMarkup = menuRole;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выбирите ролль, которая вас интересует.", optionRole);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.ExampleLurk)]
        public static async Task HandlerExampleLurk(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>LURK</b> - <b>Кемпер</b> или тихий игрок\r\n\r\nЦель: <b>сбор информации</b> для отхода команды, <b>должен находиться в неожиданных местах, чтобы перехватывать противников</b>, перетягивающихся на другой плент. Зачастую <b>убивает противников в спину</b>. Роль <b>подойдет для пассивных игроков, у которых средние аим и реакция</b>. Быть LURK не значит быть самым слабым звеном команды, именно этот класс часто меняет ход раунда. Этот человек <b>должен знать карту посекундно</b>.");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var exampleSniper = new InlineCallback("Sniper", PRHeadlers.ExampleSniper);
            var exampleIGL = new InlineCallback("IGL", PRHeadlers.ExampleIGL);
            var exampleSupport = new InlineCallback("Support", PRHeadlers.ExampleSupport);
            var exampleEntry = new InlineCallback("Entry", PRHeadlers.ExampleEntry);

            var list = new List<IInlineContent>();
            list.Add(exampleEntry);
            list.Add(exampleSniper);
            list.Add(exampleSupport);
            list.Add(exampleIGL);
            list.Add(example3);

            var menuRole = MenuGenerator.InlineKeyboard(1, list);
            var optionRole = new OptionMessage();
            optionRole.MenuInlineKeyboardMarkup = menuRole;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выбирите ролль, которая вас интересует.", optionRole);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.ExampleSniper)]
        public static async Task HandlerExamplSnupper(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>SNIPER</b> - <b>Снайпер</b>\r\n\r\nЦель: <b>опен-фраги, контроль необходимых зон, прикрытие тиммейтов</b>. <b>Должен перемещаться вместе с командой</b> и быть там, где необходимо прикрытие его команде.");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var exampleEntry = new InlineCallback("Entry", PRHeadlers.ExampleEntry);
            var exampleLurk = new InlineCallback("Lurk", PRHeadlers.ExampleLurk);
            var exampleIGL = new InlineCallback("IGL", PRHeadlers.ExampleIGL);
            var exampleSupport = new InlineCallback("Support", PRHeadlers.ExampleSupport);

            var list = new List<IInlineContent>();
            list.Add(exampleEntry);
            list.Add(exampleLurk);
            list.Add(exampleSupport);
            list.Add(exampleIGL);
            list.Add(example3);

            var menuRole = MenuGenerator.InlineKeyboard(1, list);
            var optionRole = new OptionMessage();
            optionRole.MenuInlineKeyboardMarkup = menuRole;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выбирите ролль, которая вас интересует.", optionRole);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.ExampleSupport)]
        public static async Task HandlerExampleSupport(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Support</b> - <b>Прикрывающий</b>\r\n\r\nЦель: выполнение \"черной\" работы, <b>раскидки</b>, клатч моменты. <b>Обязан всегда иметь при себе моменталки, двигается вместе с ENTRY</b>, обязан <b>прикрывать его</b>, в случае его гибели разменять по возможности соперника. На роль подойдет игрок <b>со средним скилом, но знающим все раскидки</b>.");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var exampleEntry = new InlineCallback("Entry", PRHeadlers.ExampleEntry);
            var exampleLurk = new InlineCallback("Lurk", PRHeadlers.ExampleLurk);
            var exampleSniper = new InlineCallback("Sniper", PRHeadlers.ExampleSniper);
            var exampleIGL = new InlineCallback("IGL", PRHeadlers.ExampleIGL);

            var list = new List<IInlineContent>();
            list.Add(exampleEntry);
            list.Add(exampleLurk);
            list.Add(exampleSniper);
            list.Add(exampleIGL);
            list.Add(example3);

            var menuRole = MenuGenerator.InlineKeyboard(1, list);
            var optionRole = new OptionMessage();
            optionRole.MenuInlineKeyboardMarkup = menuRole;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выбирите ролль, которая вас интересует.", optionRole);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.ExampleIGL)]
        public static async Task HandlerExampleIGL(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>IGL</b> - <b>Капитан</b>\r\n\r\nЦель: <b>координация действий команды, анализ игры противника, подбор нужной тактической основы</b>. Играет важную роль в моральном состоянии команды. Большую часть игры <b>находится позади, концентрируясь на карте, внося изменения в тактике</b>.");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var exampleEntry = new InlineCallback("Entry", PRHeadlers.ExampleEntry);
            var exampleLurk = new InlineCallback("Lurk", PRHeadlers.ExampleLurk);
            var exampleSniper = new InlineCallback("Sniper", PRHeadlers.ExampleSniper);
            var exampleSupport = new InlineCallback("Support", PRHeadlers.ExampleSupport);

            var list = new List<IInlineContent>();
            list.Add(exampleEntry);
            list.Add(exampleLurk);
            list.Add(exampleSniper);
            list.Add(exampleSupport);
            list.Add(example3);

            var menuRole = MenuGenerator.InlineKeyboard(1, list);
            var optionRole = new OptionMessage();
            optionRole.MenuInlineKeyboardMarkup = menuRole;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выбирите ролль, которая вас интересует.", optionRole);
        }

        #endregion 
        //Расшифровка ролей.

        #region PlCommand

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.Roule)]
        public static async Task HandlerRoule(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var RouleMM = new InlineCallback("ММ", PRHeadlers.RouleMM);
            var RouleBK = new InlineCallback("БК", PRHeadlers.RouleBK);
            var RouleSplit = new InlineCallback("Сплит", PRHeadlers.RouleSplit);
            var RouleRash = new InlineCallback("Раш", PRHeadlers.RouleRash);
            var RouleFullZ = new InlineCallback("Фулл закуп", PRHeadlers.RouleFullZ);
            var RouleEco = new InlineCallback("Эко", PRHeadlers.RouleEco);
            var RouleFors = new InlineCallback("Форс", PRHeadlers.RouleFors);
            var RouleSaves = new InlineCallback("Сейв", PRHeadlers.RouleSaves);

            var list = new List<IInlineContent>();
            list.Add(RouleMM);
            list.Add(RouleBK);
            list.Add(RouleSplit);
            list.Add(RouleRash);
            list.Add(RouleFullZ);
            list.Add(RouleEco);
            list.Add(RouleFors);
            list.Add(RouleSaves);
            list.Add(example3);

            var menuPrav = MenuGenerator.InlineKeyboard(3, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выберите команду, которая должна быть расшифрована", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RouleMM)]
        public static async Task HandlerRouleMM(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>ММ</b> - это <b>соревновательная игра.</b>");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var RouleBK = new InlineCallback("БК", PRHeadlers.RouleBK);
            var RouleSplit = new InlineCallback("Сплит", PRHeadlers.RouleSplit);
            var RouleRash = new InlineCallback("Раш", PRHeadlers.RouleRash);
            var RouleFullZ = new InlineCallback("Фулл закуп", PRHeadlers.RouleFullZ);
            var RouleEco = new InlineCallback("Эко", PRHeadlers.RouleEco);
            var RouleFors = new InlineCallback("Форс", PRHeadlers.RouleFors);
            var RouleSaves = new InlineCallback("Сейв", PRHeadlers.RouleSaves);

            var list = new List<IInlineContent>();
            list.Add(RouleBK);
            list.Add(RouleSplit);
            list.Add(RouleRash);
            list.Add(RouleFullZ);
            list.Add(RouleEco);
            list.Add(RouleFors);
            list.Add(RouleSaves);
            list.Add(example3);

            var menuPrav = MenuGenerator.InlineKeyboard(3, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выберите команду, которая должна быть расшифрова", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RouleBK)]
        public static async Task HandlerRouleBK(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>БК</b> - это <b>битва кланов</b>, некоторые называют КВ, то есть клановые войны.");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var RouleMM = new InlineCallback("ММ", PRHeadlers.RouleMM);
            var RouleSplit = new InlineCallback("Сплит", PRHeadlers.RouleSplit);
            var RouleRash = new InlineCallback("Раш", PRHeadlers.RouleRash);
            var RouleFullZ = new InlineCallback("Фулл закуп", PRHeadlers.RouleFullZ);
            var RouleEco = new InlineCallback("Эко", PRHeadlers.RouleEco);
            var RouleFors = new InlineCallback("Форс", PRHeadlers.RouleFors);
            var RouleSaves = new InlineCallback("Сейв", PRHeadlers.RouleSaves);

            var list = new List<IInlineContent>();
            list.Add(RouleMM);
            list.Add(RouleSplit);
            list.Add(RouleRash);
            list.Add(RouleFullZ);
            list.Add(RouleEco);
            list.Add(RouleFors);
            list.Add(RouleSaves);
            list.Add(example3);

            var menuPrav = MenuGenerator.InlineKeyboard(3, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выберите команду, которая должна быть расшифрована", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RouleSplit)]
        public static async Task HandlerRouleSplit(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Сплит</b> - это <b>заход в плент со всех сторон</b>, также за кт это может называть (кольцо, треугольник) только за кт мы берём не плент в кольцо, а врагов.");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var RouleMM = new InlineCallback("ММ", PRHeadlers.RouleMM);
            var RouleBK = new InlineCallback("БК", PRHeadlers.RouleBK);
            var RouleRash = new InlineCallback("Раш", PRHeadlers.RouleRash);
            var RouleFullZ = new InlineCallback("Фулл закуп", PRHeadlers.RouleFullZ);
            var RouleEco = new InlineCallback("Эко", PRHeadlers.RouleEco);
            var RouleFors = new InlineCallback("Форс", PRHeadlers.RouleFors);
            var RouleSaves = new InlineCallback("Сейв", PRHeadlers.RouleSaves);

            var list = new List<IInlineContent>();
            list.Add(RouleMM);
            list.Add(RouleBK);
            list.Add(RouleRash);
            list.Add(RouleFullZ);
            list.Add(RouleEco);
            list.Add(RouleFors);
            list.Add(RouleSaves);
            list.Add(example3);

            var menuPrav = MenuGenerator.InlineKeyboard(3, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выберите команду, которая должна быть расшифрована", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RouleRash)]
        public static async Task HandlerRouleRash(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Раш</b> - это <b>открывание плента на ранних таймингах</b>, чтобы враг не успел перетянутся на тот плент который открывают.");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var RouleMM = new InlineCallback("ММ", PRHeadlers.RouleMM);
            var RouleBK = new InlineCallback("БК", PRHeadlers.RouleBK);
            var RouleSplit = new InlineCallback("Сплит", PRHeadlers.RouleSplit);
            var RouleFullZ = new InlineCallback("Фулл закуп", PRHeadlers.RouleFullZ);
            var RouleEco = new InlineCallback("Эко", PRHeadlers.RouleEco);
            var RouleFors = new InlineCallback("Форс", PRHeadlers.RouleFors);
            var RouleSaves = new InlineCallback("Сейв", PRHeadlers.RouleSaves);

            var list = new List<IInlineContent>();
            list.Add(RouleMM);
            list.Add(RouleBK);
            list.Add(RouleSplit);
            list.Add(RouleFullZ);
            list.Add(RouleEco);
            list.Add(RouleFors);
            list.Add(RouleSaves);
            list.Add(example3);

            var menuPrav = MenuGenerator.InlineKeyboard(3, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выберите команду, которая должна быть расшифрована", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RouleFullZ)]
        public static async Task HandlerRouleFullZ(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Фулл закуп</b> - это <b>закуп на все деньги</b>, покупать надо в первую очередь основное оружее и броню, а уже на остаток закупать гранаты, обычно такой закуп стоит не больше 8400$");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var RouleMM = new InlineCallback("ММ", PRHeadlers.RouleMM);
            var RouleBK = new InlineCallback("БК", PRHeadlers.RouleBK);
            var RouleSplit = new InlineCallback("Сплит", PRHeadlers.RouleSplit);
            var RouleRash = new InlineCallback("Раш", PRHeadlers.RouleRash);
            var RouleEco = new InlineCallback("Эко", PRHeadlers.RouleEco);
            var RouleFors = new InlineCallback("Форс", PRHeadlers.RouleFors);
            var RouleSaves = new InlineCallback("Сейв", PRHeadlers.RouleSaves);

            var list = new List<IInlineContent>();
            list.Add(RouleMM);
            list.Add(RouleBK);
            list.Add(RouleSplit);
            list.Add(RouleRash);
            list.Add(RouleEco);
            list.Add(RouleFors);
            list.Add(RouleSaves);
            list.Add(example3);

            var menuPrav = MenuGenerator.InlineKeyboard(3, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выберите команду, которая должна быть расшифрована", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RouleEco)]
        public static async Task HandlerRouleEco(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Эко</b> - это <b>закуп пистолетов/гранат</b>, броню брать нельзя и оружее выше пистолетов, обычно такой закуп стоит не выше 1200$");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var RouleMM = new InlineCallback("ММ", PRHeadlers.RouleMM);
            var RouleBK = new InlineCallback("БК", PRHeadlers.RouleBK);
            var RouleSplit = new InlineCallback("Сплит", PRHeadlers.RouleSplit);
            var RouleRash = new InlineCallback("Раш", PRHeadlers.RouleRash);
            var RouleFullZ = new InlineCallback("Фулл закуп", PRHeadlers.RouleFullZ);
            var RouleFors = new InlineCallback("Форс", PRHeadlers.RouleFors);
            var RouleSaves = new InlineCallback("Сейв", PRHeadlers.RouleSaves);

            var list = new List<IInlineContent>();
            list.Add(RouleMM);
            list.Add(RouleBK);
            list.Add(RouleSplit);
            list.Add(RouleRash);
            list.Add(RouleFullZ);
            list.Add(RouleFors);
            list.Add(RouleSaves);
            list.Add(example3);

            var menuPrav = MenuGenerator.InlineKeyboard(3, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выберите команду, которая должна быть расшифрована", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RouleFors)]
        public static async Task HandlerRouleFors(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Форс</b> - это <b>закуп оружея не выше чем пистолеты-пулемёты</b>, а также к ним можно купить броню/гранаты, обычно такой закуп стоит не больше 4200$");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var RouleMM = new InlineCallback("ММ", PRHeadlers.RouleMM);
            var RouleBK = new InlineCallback("БК", PRHeadlers.RouleBK);
            var RouleSplit = new InlineCallback("Сплит", PRHeadlers.RouleSplit);
            var RouleRash = new InlineCallback("Раш", PRHeadlers.RouleRash);
            var RouleFullZ = new InlineCallback("Фулл закуп", PRHeadlers.RouleFullZ);
            var RouleEco = new InlineCallback("Эко", PRHeadlers.RouleEco);
            var RouleSaves = new InlineCallback("Сейв", PRHeadlers.RouleSaves);

            var list = new List<IInlineContent>();
            list.Add(RouleMM);
            list.Add(RouleBK);
            list.Add(RouleSplit);
            list.Add(RouleRash);
            list.Add(RouleFullZ);
            list.Add(RouleEco);
            list.Add(RouleSaves);
            list.Add(example3);

            var menuPrav = MenuGenerator.InlineKeyboard(3, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выберите команду, которая должна быть расшифрована", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RouleSaves)]
        public static async Task HandlerRouleSavess(ITelegramBotClient botClient, Update update)
        {
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Сейв</bb> - это <b>сохранение оружее</b>, в качестве выгоды.");

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var RouleMM = new InlineCallback("ММ", PRHeadlers.RouleMM);
            var RouleBK = new InlineCallback("БК", PRHeadlers.RouleBK);
            var RouleSplit = new InlineCallback("Сплит", PRHeadlers.RouleSplit);
            var RouleRash = new InlineCallback("Раш", PRHeadlers.RouleRash);
            var RouleFullZ = new InlineCallback("Фулл закуп", PRHeadlers.RouleFullZ);
            var RouleEco = new InlineCallback("Эко", PRHeadlers.RouleEco);

            var list = new List<IInlineContent>();
            list.Add(RouleMM);
            list.Add(RouleBK);
            list.Add(RouleSplit);
            list.Add(RouleRash);
            list.Add(RouleFullZ);
            list.Add(RouleEco);
            list.Add(example3);

            var menuPrav = MenuGenerator.InlineKeyboard(3, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выберите команду, которая должна быть расшифрована", option1);
        }

        #endregion
        //Расшифровка игровых команд.

        #region AddPlyaer

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.ExampleAddPlyaer)]
        public static async Task HandlerExampleAddPlyaer(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Принимаем игроков по этим характеристиками: \r\n\rЧасов: <b>700ч</b>. \r\n\rЗвание MM: <b>Gold4</b>. \r\n\rЗвание Союзники: <b>Gold3</b>. \r\n\rЗвание Дуэль: -- \r\n\rАИМ: <b>Средний</b>", option1);
        }

        #endregion
        //Показ по каким характиристикам принимать.

        #region Commands

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.Commands)]
        public static async Task Commands(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            var isAdmin = await botClient.IsAdmin(update);
            isAdmin = await botClient.GetBotDataOrNull().Options.AdminManager.HasUser(update.GetChatId());
            if (!isAdmin)
            {
                var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
                var list = new List<IInlineContent>();
                list.Add(example3);
                var menuPrav = MenuGenerator.InlineKeyboard(1, list);
                var option1 = new OptionMessage();
                option1.MenuInlineKeyboardMarkup = menuPrav;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Все Slash команды:\n\r\n/Balance - <b>показывает</b> какой у вас <b>баланс</b>.\n\r/TelegramName - <b>показывает</b> ваш <b>telegram ник</b>.\n\r/TelegramID - <b>показывает</b> ваше <b>telegram id</b>.\n\r/P - <b>показывает</b> ваш <b>профиль</b>.\n\r/BlackList или /BL - <b>показывает чёрный список</b>.\n\r/WhiteList или /WL - <b>показывает белый список</b>.\n\r/Esport - <b>показывает основной состав</b>.\n\r/reg или /log - <b>регистрация</b>.\n\r/Commands - <b>показывает все команды</b>.\n\r/News - <b>Показывает новости</b>.", option1);
            }
            else if (isAdmin)
            {
                var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
                var list = new List<IInlineContent>();
                list.Add(example3);
                var menuPrav = MenuGenerator.InlineKeyboard(1, list);
                var option1 = new OptionMessage();
                option1.MenuInlineKeyboardMarkup = menuPrav;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Все Slash команды:\n\r\n/Balance - <b>показывает</b> какой у вас <b>баланс</b>.\n\r/TelegramName - <b>показывает</b> ваш <b>telegram ник</b>.\n\r/TelegramID - <b>показывает</b> ваше <b>telegram id</b>.\n\r/P - <b>показывает</b> ваш <b>профиль</b>.\n\r/BlackList или /BL - <b>показывает чёрный список</b>.\n\r/WhiteList или /WL - <b>показывает белый список</b>.\n\r/Esport - <b>показывает основной состав</b>.\n\r/reg или /log - <b>регистрация</b>.\n\r/Commands - <b>показывает все команды</b>.\n\r/News - <b>Показывает новости</b>.\n\r\nКоманды админа:\n\r\n/AllPlzCol - <b>показывает колличество сообщений</b>.\n\r/AllPlz - <b>показывает всех пользователей</b>.\n\r/AllMess - <b>показывает колличество сообщений</b>.\n\r/NewsAdd - <b>добавляет новости</b>.\n\r/NewsDell - <b>удаляет новости</b>.", option1);
            }
        }

        #endregion
        //Показ всех пользовательских команд.

        #region ProfilInfo

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.Profil)]
        public static async Task Profilinfo(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Свой профиль можно посмотреть через <b>Slash команду /P</b>. Это сделано для проверки на наличие пользователя.", option1);
        }

        #endregion
        //Информация как просмотреть профиль.

        #region ProfilRegSlash

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.ProfilRegSlash)]
        public static async Task ProfilRegSlash(ITelegramBotClient botClient, Update update)
        {
            PlzRegistersTime = true;
            TelegramNameProverca = true;
            var msg = update.Message;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Регистрация начата</b>.");
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>При регистрации убедительная просьба следовать всем инструкциям</b>.");
            var TELEGRAMNAME = new InlineCallback("Продолжить", PRHeadlers.TELEGRAMNAME);
            var list = new List<IInlineContent>();
            list.Add(TELEGRAMNAME);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Введите свой <b>TelegramName</b>. Можете узнать свой ник Slash-командой: /TelegramName. <b>После нажмите продолжить</b>.", option1);
        }

        // Добавление имени пользователю.

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.TELEGRAMNAME)]
        public static async Task TELEGRAMNAME(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            TelegramNameProverca = false;
            if (NameTelegram1 == null)
                NameTelegram1 += TelegramNameAdd;
            else if (NameTelegram2 == null)
                NameTelegram2 += TelegramNameAdd;
            else if (NameTelegram3 == null)
                NameTelegram3 += TelegramNameAdd;
            else if (NameTelegram4 == null)
                NameTelegram4 += TelegramNameAdd;
            else if (NameTelegram5 == null)
                NameTelegram5 += TelegramNameAdd;
            else if (NameTelegram6 == null)
                NameTelegram6 += TelegramNameAdd;
            else if (NameTelegram7 == null)
                NameTelegram7 += TelegramNameAdd;
            else if (NameTelegram8 == null)
                NameTelegram8 += TelegramNameAdd;
            else if (NameTelegram9 == null)
                NameTelegram9 += TelegramNameAdd;
            else if (NameTelegram10 == null)
                NameTelegram10 += TelegramNameAdd;

            //----------------------------------------------------------Первые 10----------------------------------------------------------

            else if (NameTelegram11 == null)
                NameTelegram11 += TelegramNameAdd;
            else if (NameTelegram12 == null)
                NameTelegram12 += TelegramNameAdd;
            else if (NameTelegram13 == null)
                NameTelegram13 += TelegramNameAdd;
            else if (NameTelegram14 == null)
                NameTelegram14 += TelegramNameAdd;
            else if (NameTelegram15 == null)
                NameTelegram15 += TelegramNameAdd;
            else if (NameTelegram16 == null)
                NameTelegram16 += TelegramNameAdd;
            else if (NameTelegram17 == null)
                NameTelegram17 += TelegramNameAdd;
            else if (NameTelegram18 == null)
                NameTelegram18 += TelegramNameAdd;
            else if (NameTelegram19 == null)
                NameTelegram19 += TelegramNameAdd;
            else if (NameTelegram20 == null)
                NameTelegram20 += TelegramNameAdd;

            //----------------------------------------------------------Первые 20----------------------------------------------------------

            else if (NameTelegram21 == null)
                NameTelegram21 += TelegramNameAdd;
            else if (NameTelegram22 == null)
                NameTelegram22 += TelegramNameAdd;
            else if (NameTelegram23 == null)
                NameTelegram23 += TelegramNameAdd;
            else if (NameTelegram24 == null)
                NameTelegram24 += TelegramNameAdd;
            else if (NameTelegram25 == null)
                NameTelegram25 += TelegramNameAdd;
            else if (NameTelegram26 == null)
                NameTelegram26 += TelegramNameAdd;
            else if (NameTelegram27 == null)
                NameTelegram27 += TelegramNameAdd;
            else if (NameTelegram28 == null)
                NameTelegram28 += TelegramNameAdd;
            else if (NameTelegram29 == null)
                NameTelegram29 += TelegramNameAdd;
            else if (NameTelegram30 == null)
                NameTelegram30 += TelegramNameAdd;

            //----------------------------------------------------------Первые 30----------------------------------------------------------

            else if (NameTelegram31 == null)
                NameTelegram31 += TelegramNameAdd;
            else if (NameTelegram32 == null)
                NameTelegram32 += TelegramNameAdd;
            else if (NameTelegram33 == null)
                NameTelegram33 += TelegramNameAdd;
            else if (NameTelegram34 == null)
                NameTelegram34 += TelegramNameAdd;
            else if (NameTelegram35 == null)
                NameTelegram35 += TelegramNameAdd;
            else if (NameTelegram36 == null)
                NameTelegram36 += TelegramNameAdd;
            else if (NameTelegram37 == null)
                NameTelegram37 += TelegramNameAdd;
            else if (NameTelegram38 == null)
                NameTelegram38 += TelegramNameAdd;
            else if (NameTelegram39 == null)
                NameTelegram39 += TelegramNameAdd;
            else if (NameTelegram40 == null)
                NameTelegram40 += TelegramNameAdd;

            //----------------------------------------------------------Первые 40----------------------------------------------------------

            else if (NameTelegram41 == null)
                NameTelegram41 += TelegramNameAdd;
            else if (NameTelegram42 == null)
                NameTelegram42 += TelegramNameAdd;
            else if (NameTelegram43 == null)
                NameTelegram43 += TelegramNameAdd;
            else if (NameTelegram44 == null)
                NameTelegram44 += TelegramNameAdd;
            else if (NameTelegram45 == null)
                NameTelegram45 += TelegramNameAdd;
            else if (NameTelegram46 == null)
                NameTelegram46 += TelegramNameAdd;
            else if (NameTelegram47 == null)
                NameTelegram47 += TelegramNameAdd;
            else if (NameTelegram48 == null)
                NameTelegram48 += TelegramNameAdd;
            else if (NameTelegram49 == null)
                NameTelegram49 += TelegramNameAdd;
            else if (NameTelegram50 == null)
                NameTelegram50 += TelegramNameAdd;

            //----------------------------------------------------------Первые 50----------------------------------------------------------

            else
            {
                PlzLowPlace = true;
            }
            if (PlzLowPlace == false)
            {
                var STANDOFFNAME = new InlineCallback("Продолжить", PRHeadlers.STANDOFFNAME);
                var list = new List<IInlineContent>();
                list.Add(STANDOFFNAME);
                var menuPrav = MenuGenerator.InlineKeyboard(1, list);
                var option1 = new OptionMessage();
                option1.MenuInlineKeyboardMarkup = menuPrav;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Укажите свой <b>StandoffName</b>. <b>После нажмите продолжить.</b>", option1);
            }
            else
            {
                var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
                var list = new List<IInlineContent>();
                list.Add(example3);
                var menuPrav = MenuGenerator.InlineKeyboard(1, list);
                var option1 = new OptionMessage();
                option1.MenuInlineKeyboardMarkup = menuPrav;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "<b>Регистрация невозможна</b>, в боте недостаточно места для регистрациии. <b>Напишите администратору 9Cold_bot</b>.", option1);
            }
            StandoffNameProverca = true;
        }

        // Добавление Standoff ника пользователю.

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.STANDOFFNAME)]
        public static async Task STANDOFFNAME(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            StandoffNameProverca = false;

            if (NameStandoff1 == null)
                NameStandoff1 += StandoffNameAdd;
            else if (NameStandoff2 == null)
                NameStandoff2 += StandoffNameAdd;
            else if (NameStandoff3 == null)
                NameStandoff3 += StandoffNameAdd;
            else if (NameStandoff4 == null)
                NameStandoff4 += StandoffNameAdd;
            else if (NameStandoff5 == null)
                NameStandoff5 += StandoffNameAdd;
            else if (NameStandoff6 == null)
                NameStandoff6 += StandoffNameAdd;
            else if (NameStandoff7 == null)
                NameStandoff7 += StandoffNameAdd;
            else if (NameStandoff8 == null)
                NameStandoff8 += StandoffNameAdd;
            else if (NameStandoff9 == null)
                NameStandoff9 += StandoffNameAdd;
            else if (NameStandoff10 == null)
                NameStandoff10 += StandoffNameAdd;

            //----------------------------------------------------------Первые 10----------------------------------------------------------

            else if (NameStandoff11 == null)
                NameStandoff11 += StandoffNameAdd;
            else if (NameStandoff12 == null)
                NameStandoff12 += StandoffNameAdd;
            else if (NameStandoff13 == null)
                NameStandoff13 += StandoffNameAdd;
            else if (NameStandoff14 == null)
                NameStandoff14 += StandoffNameAdd;
            else if (NameStandoff15 == null)
                NameStandoff15 += StandoffNameAdd;
            else if (NameStandoff16 == null)
                NameStandoff16 += StandoffNameAdd;
            else if (NameStandoff17 == null)
                NameStandoff17 += StandoffNameAdd;
            else if (NameStandoff18 == null)
                NameStandoff18 += StandoffNameAdd;
            else if (NameStandoff19 == null)
                NameStandoff19 += StandoffNameAdd;
            else if (NameStandoff20 == null)
                NameStandoff20 += StandoffNameAdd;

            //----------------------------------------------------------Первые 20----------------------------------------------------------

            else if (NameStandoff21 == null)
                NameStandoff21 += StandoffNameAdd;
            else if (NameStandoff22 == null)
                NameStandoff22 += StandoffNameAdd;
            else if (NameStandoff23 == null)
                NameStandoff23 += StandoffNameAdd;
            else if (NameStandoff24 == null)
                NameStandoff24 += StandoffNameAdd;
            else if (NameStandoff25 == null)
                NameStandoff25 += StandoffNameAdd;
            else if (NameStandoff26 == null)
                NameStandoff26 += StandoffNameAdd;
            else if (NameStandoff27 == null)
                NameStandoff27 += StandoffNameAdd;
            else if (NameStandoff28 == null)
                NameStandoff28 += StandoffNameAdd;
            else if (NameStandoff29 == null)
                NameStandoff29 += StandoffNameAdd;
            else if (NameStandoff30 == null)
                NameStandoff30 += StandoffNameAdd;

            //----------------------------------------------------------Первые 30----------------------------------------------------------

            else if (NameStandoff31 == null)
                NameStandoff31 += StandoffNameAdd;
            else if (NameStandoff32 == null)
                NameStandoff32 += StandoffNameAdd;
            else if (NameStandoff33 == null)
                NameStandoff33 += StandoffNameAdd;
            else if (NameStandoff34 == null)
                NameStandoff34 += StandoffNameAdd;
            else if (NameStandoff35 == null)
                NameStandoff35 += StandoffNameAdd;
            else if (NameStandoff36 == null)
                NameStandoff36 += StandoffNameAdd;
            else if (NameStandoff37 == null)
                NameStandoff37 += StandoffNameAdd;
            else if (NameStandoff38 == null)
                NameStandoff38 += StandoffNameAdd;
            else if (NameStandoff39 == null)
                NameStandoff39 += StandoffNameAdd;
            else if (NameStandoff40 == null)
                NameStandoff40 += StandoffNameAdd;

            //----------------------------------------------------------Первые 40----------------------------------------------------------

            else if (NameStandoff41 == null)
                NameStandoff41 += StandoffNameAdd;
            else if (NameStandoff42 == null)
                NameStandoff42 += StandoffNameAdd;
            else if (NameStandoff43 == null)
                NameStandoff43 += StandoffNameAdd;
            else if (NameStandoff44 == null)
                NameStandoff44 += StandoffNameAdd;
            else if (NameStandoff45 == null)
                NameStandoff45 += StandoffNameAdd;
            else if (NameStandoff46 == null)
                NameStandoff46 += StandoffNameAdd;
            else if (NameStandoff47 == null)
                NameStandoff47 += StandoffNameAdd;
            else if (NameStandoff48 == null)
                NameStandoff48 += StandoffNameAdd;
            else if (NameStandoff49 == null)
                NameStandoff49 += StandoffNameAdd;
            else if (NameStandoff50 == null)
                NameStandoff50 += StandoffNameAdd;

            //----------------------------------------------------------Первые 50----------------------------------------------------------

            var STANDOFFID = new InlineCallback("Продолжить", PRHeadlers.STANDOFFID);
            var list = new List<IInlineContent>();
            list.Add(STANDOFFID);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Укажите свой <b>StandoffID</b>. <b>После нажмите продолжить</b>.", option1);
            StandoffIDProverca = true;
        }
        // Добавление Standoff id пользователю.

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.STANDOFFID)]
        public static async Task STANDOFFID(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            StandoffIDProverca = false;
            if (IDStandoff1 == null)
                IDStandoff1 += StandoffIDAdd;
            else if (IDStandoff2 == null)
                IDStandoff2 += StandoffIDAdd;
            else if (IDStandoff3 == null)
                IDStandoff3 += StandoffIDAdd;
            else if (IDStandoff4 == null)
                IDStandoff4 += StandoffIDAdd;
            else if (IDStandoff5 == null)
                IDStandoff5 += StandoffIDAdd;
            else if (IDStandoff6 == null)
                IDStandoff6 += StandoffIDAdd;
            else if (IDStandoff7 == null)
                IDStandoff7 += StandoffIDAdd;
            else if (IDStandoff8 == null)
                IDStandoff8 += StandoffIDAdd;
            else if (IDStandoff9 == null)
                IDStandoff9 += StandoffIDAdd;
            else if (IDStandoff10 == null)
                IDStandoff10 += StandoffIDAdd;

            //----------------------------------------------------------Первые 10----------------------------------------------------------

            else if (IDStandoff11 == null)
                IDStandoff11 += StandoffIDAdd;
            else if (IDStandoff12 == null)
                IDStandoff12 += StandoffIDAdd;
            else if (IDStandoff13 == null)
                IDStandoff13 += StandoffIDAdd;
            else if (IDStandoff14 == null)
                IDStandoff14 += StandoffIDAdd;
            else if (IDStandoff15 == null)
                IDStandoff15 += StandoffIDAdd;
            else if (IDStandoff16 == null)
                IDStandoff16 += StandoffIDAdd;
            else if (IDStandoff17 == null)
                IDStandoff17 += StandoffIDAdd;
            else if (IDStandoff18 == null)
                IDStandoff18 += StandoffIDAdd;
            else if (IDStandoff19 == null)
                IDStandoff19 += StandoffIDAdd;
            else if (IDStandoff20 == null)
                IDStandoff20 += StandoffIDAdd;

            //----------------------------------------------------------Первые 20----------------------------------------------------------

            else if (IDStandoff21 == null)
                IDStandoff21 += StandoffIDAdd;
            else if (IDStandoff22 == null)
                IDStandoff22 += StandoffIDAdd;
            else if (IDStandoff23 == null)
                IDStandoff23 += StandoffIDAdd;
            else if (IDStandoff24 == null)
                IDStandoff24 += StandoffIDAdd;
            else if (IDStandoff25 == null)
                IDStandoff25 += StandoffIDAdd;
            else if (IDStandoff26 == null)
                IDStandoff26 += StandoffIDAdd;
            else if (IDStandoff27 == null)
                IDStandoff27 += StandoffIDAdd;
            else if (IDStandoff28 == null)
                IDStandoff28 += StandoffIDAdd;
            else if (IDStandoff29 == null)
                IDStandoff29 += StandoffIDAdd;
            else if (IDStandoff30 == null)
                IDStandoff30 += StandoffIDAdd;

            //----------------------------------------------------------Первые 30----------------------------------------------------------

            else if (IDStandoff31 == null)
                IDStandoff31 += StandoffIDAdd;
            else if (IDStandoff32 == null)
                IDStandoff32 += StandoffIDAdd;
            else if (IDStandoff33 == null)
                IDStandoff33 += StandoffIDAdd;
            else if (IDStandoff34 == null)
                IDStandoff34 += StandoffIDAdd;
            else if (IDStandoff35 == null)
                IDStandoff35 += StandoffIDAdd;
            else if (IDStandoff36 == null)
                IDStandoff36 += StandoffIDAdd;
            else if (IDStandoff37 == null)
                IDStandoff37 += StandoffIDAdd;
            else if (IDStandoff38 == null)
                IDStandoff38 += StandoffIDAdd;
            else if (IDStandoff39 == null)
                IDStandoff39 += StandoffIDAdd;
            else if (IDStandoff40 == null)
                IDStandoff40 += StandoffIDAdd;

            //----------------------------------------------------------Первые 40----------------------------------------------------------

            else if (IDStandoff41 == null)
                IDStandoff41 += StandoffIDAdd;
            else if (IDStandoff42 == null)
                IDStandoff42 += StandoffIDAdd;
            else if (IDStandoff43 == null)
                IDStandoff43 += StandoffIDAdd;
            else if (IDStandoff44 == null)
                IDStandoff44 += StandoffIDAdd;
            else if (IDStandoff45 == null)
                IDStandoff45 += StandoffIDAdd;
            else if (IDStandoff46 == null)
                IDStandoff46 += StandoffIDAdd;
            else if (IDStandoff47 == null)
                IDStandoff47 += StandoffIDAdd;
            else if (IDStandoff48 == null)
                IDStandoff48 += StandoffIDAdd;
            else if (IDStandoff49 == null)
                IDStandoff49 += StandoffIDAdd;
            else if (IDStandoff50 == null)
                IDStandoff50 += StandoffIDAdd;

            //----------------------------------------------------------Первые 50----------------------------------------------------------    

            var TELEGRAMID = new InlineCallback("Продолжить", PRHeadlers.TELEGRAMID);
            var list = new List<IInlineContent>();
            list.Add(TELEGRAMID);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Укажите свой <b>TelegramID</b>. Узнать свое TelegramID можно Slash-командой: /TelegramID. <b>После нажмите продолжить</b>.", option1);
            TelegramIDProverca = true;
        }
        // Добавление Telegram id пользователю.

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.TELEGRAMID)]
        public static async Task TELEGRAMID(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            TelegramIDProverca = false;
            if (IDTelegram1 == null)
                IDTelegram1 += TelegramIDAdd;
            else if (IDTelegram2 == null)
                IDTelegram2 += TelegramIDAdd;
            else if (IDTelegram3 == null)
                IDTelegram3 += TelegramIDAdd;
            else if (IDTelegram4 == null)
                IDTelegram4 += TelegramIDAdd;
            else if (IDTelegram5 == null)
                IDTelegram5 += TelegramIDAdd;
            else if (IDTelegram6 == null)
                IDTelegram6 += TelegramIDAdd;
            else if (IDTelegram7 == null)
                IDTelegram7 += TelegramIDAdd;
            else if (IDTelegram8 == null)
                IDTelegram8 += TelegramIDAdd;
            else if (IDTelegram9 == null)
                IDTelegram9 += TelegramIDAdd;
            else if (IDTelegram10 == null)
                IDTelegram10 += TelegramIDAdd;

            //----------------------------------------------------------Первые 10----------------------------------------------------------

            else if (IDTelegram11 == null)
                IDTelegram11 += TelegramIDAdd;
            else if (IDTelegram12 == null)
                IDTelegram12 += TelegramIDAdd;
            else if (IDTelegram13 == null)
                IDTelegram13 += TelegramIDAdd;
            else if (IDTelegram14 == null)
                IDTelegram14 += TelegramIDAdd;
            else if (IDTelegram15 == null)
                IDTelegram15 += TelegramIDAdd;
            else if (IDTelegram16 == null)
                IDTelegram16 += TelegramIDAdd;
            else if (IDTelegram17 == null)
                IDTelegram17 += TelegramIDAdd;
            else if (IDTelegram18 == null)
                IDTelegram18 += TelegramIDAdd;
            else if (IDTelegram19 == null)
                IDTelegram19 += TelegramIDAdd;
            else if (IDTelegram20 == null)
                IDTelegram20 += TelegramIDAdd;

            //----------------------------------------------------------Первые 20----------------------------------------------------------

            else if (IDTelegram21 == null)
                IDTelegram21 += TelegramIDAdd;
            else if (IDTelegram22 == null)
                IDTelegram22 += TelegramIDAdd;
            else if (IDTelegram23 == null)
                IDTelegram23 += TelegramIDAdd;
            else if (IDTelegram24 == null)
                IDTelegram24 += TelegramIDAdd;
            else if (IDTelegram25 == null)
                IDTelegram25 += TelegramIDAdd;
            else if (IDTelegram26 == null)
                IDTelegram26 += TelegramIDAdd;
            else if (IDTelegram27 == null)
                IDTelegram27 += TelegramIDAdd;
            else if (IDTelegram28 == null)
                IDTelegram28 += TelegramIDAdd;
            else if (IDTelegram29 == null)
                IDTelegram29 += TelegramIDAdd;
            else if (IDTelegram30 == null)
                IDTelegram30 += TelegramIDAdd;

            //----------------------------------------------------------Первые 30----------------------------------------------------------

            else if (IDTelegram31 == null)
                IDTelegram31 += TelegramIDAdd;
            else if (IDTelegram32 == null)
                IDTelegram32 += TelegramIDAdd;
            else if (IDTelegram33 == null)
                IDTelegram33 += TelegramIDAdd;
            else if (IDTelegram34 == null)
                IDTelegram34 += TelegramIDAdd;
            else if (IDTelegram35 == null)
                IDTelegram35 += TelegramIDAdd;
            else if (IDTelegram36 == null)
                IDTelegram36 += TelegramIDAdd;
            else if (IDTelegram37 == null)
                IDTelegram37 += TelegramIDAdd;
            else if (IDTelegram38 == null)
                IDTelegram38 += TelegramIDAdd;
            else if (IDTelegram39 == null)
                IDTelegram39 += TelegramIDAdd;
            else if (IDTelegram40 == null)
                IDTelegram40 += TelegramIDAdd;

            //----------------------------------------------------------Первые 40----------------------------------------------------------

            else if (IDTelegram41 == null)
                IDTelegram41 += TelegramIDAdd;
            else if (IDTelegram42 == null)
                IDTelegram42 += TelegramIDAdd;
            else if (IDTelegram43 == null)
                IDTelegram43 += TelegramIDAdd;
            else if (IDTelegram44 == null)
                IDTelegram44 += TelegramIDAdd;
            else if (IDTelegram45 == null)
                IDTelegram45 += TelegramIDAdd;
            else if (IDTelegram46 == null)
                IDTelegram46 += TelegramIDAdd;
            else if (IDTelegram47 == null)
                IDTelegram47 += TelegramIDAdd;
            else if (IDTelegram48 == null)
                IDTelegram48 += TelegramIDAdd;
            else if (IDTelegram49 == null)
                IDTelegram49 += TelegramIDAdd;
            else if (IDTelegram50 == null)
                IDTelegram50 += TelegramIDAdd;

            //----------------------------------------------------------Первые 50----------------------------------------------------------
            var TELEGRAMUSERNAME = new InlineCallback("Продолжить", PRHeadlers.TELEGRAMUSERNAME);
            var list = new List<IInlineContent>();
            list.Add(TELEGRAMUSERNAME);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Укажите свой <b>TelegramUserName</b>. Узнать свой Username можно Slash-командой: /TelegramUserName. <b>После нажмите продолжить.</b>(Если он отсутствует напишите 'нет')", option1);
            TelegramUserNameProverca = true;
        }

        // Добавление Telegram Username пользователю.

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.TELEGRAMUSERNAME)]
        public static async Task TELEGRAMUSERNAME(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            TelegramUserNameProverca = false;
            if (UserNameTelegram1 == null)
            {
                UserNameTelegram1 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff1}\n\r\n TGN: {NameTelegram1}\n\r TGID: {IDTelegram1}\n\r TGUN: {UserNameTelegram1}\n\r SON: {NameStandoff1}\n\r SOID: {IDStandoff1}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram2 == null)
            {
                UserNameTelegram2 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff2}\n\r\n TGN: {NameTelegram2}\n\r TGID: {IDTelegram2}\n\r TGUN: {UserNameTelegram2}\n\r SON: {NameStandoff2}\n\r SOID: {IDStandoff2}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram3 == null)
            {
                UserNameTelegram3 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff3}\n\r\n TGN: {NameTelegram3}\n\r TGID: {IDTelegram3}\n\r TGUN: {UserNameTelegram3}\n\r SON: {NameStandoff3}\n\r SOID: {IDStandoff3}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram4 == null)
            {
                UserNameTelegram4 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff4}\n\r\n TGN: {NameTelegram4}\n\r TGID: {IDTelegram4}\n\r TGUN: {UserNameTelegram4}\n\r SON: {NameStandoff4}\n\r SOID: {IDStandoff4}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram5 == null)
            {
                UserNameTelegram5 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff5}\n\r\n TGN: {NameTelegram5}\n\r TGID: {IDTelegram5}\n\r TGUN: {UserNameTelegram5}\n\r SON: {NameStandoff5}\n\r SOID: {IDStandoff5}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram6 == null)
            {
                UserNameTelegram6 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff6}\n\r\n TGN: {NameTelegram6}\n\r TGID: {IDTelegram6}\n\r TGUN: {UserNameTelegram6}\n\r SON: {NameStandoff6}\n\r SOID: {IDStandoff6}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram7 == null)
            {
                UserNameTelegram7 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff7}\n\r\n TGN: {NameTelegram7}\n\r TGID: {IDTelegram7}\n\r TGUN: {UserNameTelegram7}\n\r SON: {NameStandoff7}\n\r SOID: {IDStandoff7}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram8 == null)
            {
                UserNameTelegram8 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff8}\n\r\n TGN: {NameTelegram8}\n\r TGID: {IDTelegram8}\n\r TGUN: {UserNameTelegram8}\n\r SON: {NameStandoff8}\n\r SOID: {IDStandoff8}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram9 == null)
            {
                UserNameTelegram9 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff9}\n\r\n TGN: {NameTelegram9}\n\r TGID: {IDTelegram9}\n\r TGUN: {UserNameTelegram9}\n\r SON: {NameStandoff9}\n\r SOID: {IDStandoff9}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram10 == null)
            {
                UserNameTelegram10 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff10}\n\r\n TGN: {NameTelegram10}\n\r TGID: {IDTelegram10}\n\r TGUN: {UserNameTelegram10}\n\r SON: {NameStandoff10}\n\r SOID: {IDStandoff10}.\n\r\n----------------------------------------------------\n\r\n";
            }

            //----------------------------------------------------------Первые 10----------------------------------------------------------

            else if (UserNameTelegram11 == null)
            {
                UserNameTelegram11 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff11}\n\r\n TGN: {NameTelegram11}\n\r TGID: {IDTelegram11}\n\r TGUN: {UserNameTelegram11}\n\r SON: {NameStandoff11}\n\r SOID: {IDStandoff11}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram12 == null)
            {
                UserNameTelegram12 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff12}\n\r\n TGN: {NameTelegram12}\n\r TGID: {IDTelegram12}\n\r TGUN: {UserNameTelegram12}\n\r SON: {NameStandoff12}\n\r SOID: {IDStandoff12}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram13 == null)
            {
                UserNameTelegram13 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff13}\n\r\n TGN: {NameTelegram13}\n\r TGID: {IDTelegram13}\n\r TGUN: {UserNameTelegram13}\n\r SON: {NameStandoff13}\n\r SOID: {IDStandoff13}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram14 == null)
            {
                UserNameTelegram14 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff14}\n\r\n TGN: {NameTelegram14}\n\r TGID: {IDTelegram14}\n\r TGUN: {UserNameTelegram14}\n\r SON: {NameStandoff14}\n\r SOID: {IDStandoff14}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram15 == null)
            {
                UserNameTelegram15 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff15}\n\r\n TGN: {NameTelegram15}\n\r TGID: {IDTelegram15}\n\r TGUN: {UserNameTelegram15}\n\r SON: {NameStandoff15}\n\r SOID: {IDStandoff15}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram16 == null)
            {
                UserNameTelegram16 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff16}\n\r\n TGN: {NameTelegram16}\n\r TGID: {IDTelegram16}\n\r TGUN: {UserNameTelegram16}\n\r SON: {NameStandoff16}\n\r SOID: {IDStandoff16}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram17 == null)
            {
                UserNameTelegram17 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff17}\n\r\n TGN: {NameTelegram17}\n\r TGID: {IDTelegram17}\n\r TGUN: {UserNameTelegram17}\n\r SON: {NameStandoff17}\n\r SOID: {IDStandoff17}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram18 == null)
            {
                UserNameTelegram18 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff18}\n\r\n TGN: {NameTelegram18}\n\r TGID: {IDTelegram18}\n\r TGUN: {UserNameTelegram18}\n\r SON: {NameStandoff18}\n\r SOID: {IDStandoff18}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram19 == null)
            {
                UserNameTelegram19 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff19}\n\r\n TGN: {NameTelegram19}\n\r TGID: {IDTelegram19}\n\r TGUN: {UserNameTelegram19}\n\r SON: {NameStandoff19}\n\r SOID: {IDStandoff19}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram20 == null)
            {
                UserNameTelegram20 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff20}\n\r\n TGN: {NameTelegram20}\n\r TGID: {IDTelegram20}\n\r TGUN: {UserNameTelegram20}\n\r SON: {NameStandoff20}\n\r SOID: {IDStandoff20}.\n\r\n----------------------------------------------------\n\r\n";
            }

            //----------------------------------------------------------Первые 20----------------------------------------------------------

            else if (UserNameTelegram21 == null)
            {
                UserNameTelegram21 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff21}\n\r\n TGN: {NameTelegram21}\n\r TGID: {IDTelegram21}\n\r TGUN: {UserNameTelegram21}\n\r SON: {NameStandoff21}\n\r SOID: {IDStandoff21}.\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (UserNameTelegram22 == null)
            {
                UserNameTelegram22 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff22}\n\r\n TGN: {NameTelegram22}\n\r TGID: {IDTelegram22}\n\r TGUN: {UserNameTelegram22}\n\r SON: {NameStandoff22}\n\r SOID: {IDStandoff22}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram23 == null)
            {
                UserNameTelegram23 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff23}\n\r\n TGN: {NameTelegram23}\n\r TGID: {IDTelegram23}\n\r TGUN: {UserNameTelegram23}\n\r SON: {NameStandoff23}\n\r SOID: {IDStandoff23}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram24 == null)
            {
                UserNameTelegram24 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff24}\n\r\n TGN: {NameTelegram24}\n\r TGID: {IDTelegram24}\n\r TGUN: {UserNameTelegram24}\n\r SON: {NameStandoff24}\n\r SOID: {IDStandoff24}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram25 == null)
            {
                UserNameTelegram25 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff25}\n\r\n TGN: {NameTelegram25}\n\r TGID: {IDTelegram25}\n\r TGUN: {UserNameTelegram25}\n\r SON: {NameStandoff25}\n\r SOID: {IDStandoff25}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram26 == null)
            {
                UserNameTelegram26 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff27}\n\r\n TGN: {NameTelegram26}\n\r TGID: {IDTelegram26}\n\r TGUN: {UserNameTelegram26}\n\r SON: {NameStandoff26}\n\r SOID: {IDStandoff26}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram27 == null)
            {
                UserNameTelegram27 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff27}\n\r\n TGN: {NameTelegram27}\n\r TGID: {IDTelegram27}\n\r TGUN: {UserNameTelegram27}\n\r SON: {NameStandoff27}\n\r SOID: {IDStandoff27}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram28 == null)
            {
                UserNameTelegram28 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff28}\n\r\n TGN: {NameTelegram28}\n\r TGID: {IDTelegram28}\n\r TGUN: {UserNameTelegram28}\n\r SON: {NameStandoff28}\n\r SOID: {IDStandoff28}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram29 == null)
            {
                UserNameTelegram29 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff29}\n\r\n TGN: {NameTelegram29}\n\r TGID: {IDTelegram29}\n\r TGUN: {UserNameTelegram29}\n\r SON: {NameStandoff29}\n\r SOID: {IDStandoff29}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram30 == null)
            {
                UserNameTelegram30 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff30}\n\r\n TGN: {NameTelegram30}\n\r TGID: {IDTelegram30}\n\r TGUN: {UserNameTelegram30}\n\r SON: {NameStandoff30}\n\r SOID: {IDStandoff30}.\n\r\n----------------------------------------------------\n\r\n";
            }

            //----------------------------------------------------------Первые 30----------------------------------------------------------

            else if (UserNameTelegram31 == null)
            {
                UserNameTelegram31 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff31}\n\r\n TGN: {NameTelegram31}\n\r TGID: {IDTelegram31}\n\r TGUN: {UserNameTelegram31}\n\r SON: {NameStandoff31}\n\r SOID: {IDStandoff31}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram32 == null)
            {
                UserNameTelegram32 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff32}\n\r\n TGN: {NameTelegram32}\n\r TGID: {IDTelegram32}\n\r TGUN: {UserNameTelegram32}\n\r SON: {NameStandoff32}\n\r SOID: {IDStandoff32}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram33 == null)
            {
                UserNameTelegram33 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff33}\n\r\n TGN: {NameTelegram33}\n\r TGID: {IDTelegram33}\n\r TGUN: {UserNameTelegram33}\n\r SON: {NameStandoff33}\n\r SOID: {IDStandoff33}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram34 == null)
            {
                UserNameTelegram34 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff34}\n\r\n TGN: {NameTelegram34}\n\r TGID: {IDTelegram34}\n\r TGUN: {UserNameTelegram34}\n\r SON: {NameStandoff34}\n\r SOID: {IDStandoff34}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram35 == null)
            {
                UserNameTelegram35 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff35}\n\r\n TGN: {NameTelegram35}\n\r TGID: {IDTelegram35}\n\r TGUN: {UserNameTelegram35}\n\r SON: {NameStandoff35}\n\r SOID: {IDStandoff35}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram36 == null)
            {
                UserNameTelegram36 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff36}\n\r\n TGN: {NameTelegram36}\n\r TGID: {IDTelegram36}\n\r TGUN: {UserNameTelegram36}\n\r SON: {NameStandoff36}\n\r SOID: {IDStandoff36}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram37 == null)
            {
                UserNameTelegram37 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff37}\n\r\n TGN: {NameTelegram37}\n\r TGID: {IDTelegram37}\n\r TGUN: {UserNameTelegram37}\n\r SON: {NameStandoff37}\n\r SOID: {IDStandoff37}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram38 == null)
            {
                UserNameTelegram38 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff38}\n\r\n TGN: {NameTelegram38}\n\r TGID: {IDTelegram38}\n\r TGUN: {UserNameTelegram38}\n\r SON: {NameStandoff38}\n\r SOID: {IDStandoff38}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram39 == null)
            {
                UserNameTelegram39 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff39}\n\r\n TGN: {NameTelegram39}\n\r TGID: {IDTelegram39}\n\r TGUN: {UserNameTelegram39}\n\r SON: {NameStandoff39}\n\r SOID: {IDStandoff39}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram40 == null)
            {
                UserNameTelegram40 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff40}\n\r\n TGN: {NameTelegram40}\n\r TGID: {IDTelegram40}\n\r TGUN: {UserNameTelegram40}\n\r SON: {NameStandoff40}\n\r SOID: {IDStandoff40}.\n\r\n----------------------------------------------------\n\r\n";
            }
            //----------------------------------------------------------Первые 40----------------------------------------------------------

            else if (UserNameTelegram41 == null)
            {
                UserNameTelegram41 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff41}\n\r\n TGN: {NameTelegram41}\n\r TGID: {IDTelegram41}\n\r TGUN: {UserNameTelegram41}\n\r SON: {NameStandoff41}\n\r SOID: {IDStandoff41}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram42 == null)
            {
                UserNameTelegram42 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff42}\n\r\n TGN: {NameTelegram42}\n\r TGID: {IDTelegram42}\n\r TGUN: {UserNameTelegram42}\n\r SON: {NameStandoff42}\n\r SOID: {IDStandoff42}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram43 == null)
            {
                UserNameTelegram43 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff43}\n\r\n TGN: {NameTelegram43}\n\r TGID: {IDTelegram43}\n\r TGUN: {UserNameTelegram43}\n\r SON: {NameStandoff43}\n\r SOID: {IDStandoff43}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram44 == null)
            {
                UserNameTelegram44 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff44}\n\r\n TGN: {NameTelegram44}\n\r TGID: {IDTelegram44}\n\r TGUN: {UserNameTelegram44}\n\r SON: {NameStandoff44}\n\r SOID: {IDStandoff44}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram45 == null)
            {
                UserNameTelegram45 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff45}\n\r\n TGN: {NameTelegram45}\n\r TGID: {IDTelegram45}\n\r TGUN: {UserNameTelegram45}\n\r SON: {NameStandoff45}\n\r SOID: {IDStandoff45}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram46 == null)
            {
                UserNameTelegram46 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff46}\n\r\n TGN: {NameTelegram46}\n\r TGID: {IDTelegram46}\n\r TGUN: {UserNameTelegram46}\n\r SON: {NameStandoff46}\n\r SOID: {IDStandoff46}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram47 == null)
            {
                UserNameTelegram47 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff47}\n\r\n TGN: {NameTelegram47}\n\r TGID: {IDTelegram47}\n\r TGUN: {UserNameTelegram47}\n\r SON: {NameStandoff47}\n\r SOID: {IDStandoff47}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram48 == null)
            {
                UserNameTelegram48 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff48}\n\r\n TGN: {NameTelegram48}\n\r TGID: {IDTelegram48}\n\r TGUN: {UserNameTelegram48}\n\r SON: {NameStandoff48}\n\r SOID: {IDStandoff48}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram49 == null)
            {
                UserNameTelegram49 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff49}\n\r\n TGN: {NameTelegram49}\n\r TGID: {IDTelegram49}\n\r TGUN: {UserNameTelegram49}\n\r SON: {NameStandoff49}\n\r SOID: {IDStandoff49}.\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (UserNameTelegram50 == null)
            {
                UserNameTelegram50 += TelegramUserNameAdd;
                AllPlz += $"Пользователь: {NameStandoff50}\n\r\n TGN: {NameTelegram50}\n\r TGID: {IDTelegram50}\n\r TGUN: {UserNameTelegram50}\n\r SON: {NameStandoff50}\n\r SOID: {IDStandoff50}.\n\r\n----------------------------------------------------\n\r\n";
            }

            //----------------------------------------------------------Первые 50----------------------------------------------------------

            RegProfil++;
            PlzRegistersTime = false;
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Вы зарегистрированы. Свой профиль можно посмотреть по конмаде /P", option1);
        }

        #endregion
        //Регистрация нового пользователя.

        #region ProfilPlz
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.ProfilPlz)]
        public static async Task ProfilPlz(ITelegramBotClient botClient, Update update)
        {
            ProfilPlzP = false;
            NameSimProfilPlz = ProfilPlzPAdd;
            if (NameSimProfilPlz != null)
            {
                var AddAvaO = new InlineCallback("Выдать аватарку", PRHeadlers.AddAvaO);
                var AddElder = new InlineCallback("Повысить", PRHeadlers.AddElder);
                var DellProfil = new InlineCallback("Исключить", PRHeadlers.DellProfil);
                var AddProfilEsport = new InlineCallback("addesport", PRHeadlers.AddProfilEsport);
                var listMember = new List<IInlineContent>();
                listMember.Add(AddAvaO);
                listMember.Add(AddElder);
                listMember.Add(DellProfil);
                listMember.Add(AddProfilEsport);
                var menuMember = MenuGenerator.InlineKeyboard(1, listMember);
                var optionMember = new OptionMessage();
                optionMember.MenuInlineKeyboardMarkup = menuMember;

                var AddCoLeader = new InlineCallback("Повысить", PRHeadlers.AddCoLeader);
                var AddMember = new InlineCallback("Понизить", PRHeadlers.AddMember);
                var listElder = new List<IInlineContent>();
                listElder.Add(AddAvaO);
                listElder.Add(AddCoLeader);
                listElder.Add(AddMember);
                listElder.Add(AddProfilEsport);
                var menuElder = MenuGenerator.InlineKeyboard(1, listElder);
                var optionElder = new OptionMessage();
                optionElder.MenuInlineKeyboardMarkup = menuElder;

                var AddEl = new InlineCallback("Повысить", PRHeadlers.AddElder);
                var listCoLeader = new List<IInlineContent>();
                listCoLeader.Add(AddAvaO);
                listCoLeader.Add(AddEl);
                listCoLeader.Add(AddProfilEsport);
                var menuCoLeader = MenuGenerator.InlineKeyboard(1, listCoLeader);
                var optionCoLeader = new OptionMessage();
                optionCoLeader.MenuInlineKeyboardMarkup = menuCoLeader;

                var listO = new List<IInlineContent>();
                var DellAvaO = new InlineCallback("Удалить аватарку", PRHeadlers.DellAvaO);
                listO.Add(DellAvaO);
                listO.Add(AddProfilEsport);
                var menuO = MenuGenerator.InlineKeyboard(1, listO);
                var optionO = new OptionMessage();
                optionO.MenuInlineKeyboardMarkup = menuO;

                if (NameSimProfilPlz == "1" || NameSimProfilPlz == IDTelegram1 || NameSimProfilPlz == NameStandoff1 || NameSimProfilPlz == IDStandoff1 || NameSimProfilPlz == NameTelegram1)
                {
                    if (ProfilAva1 == "Берёзовый")
                    {
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff1}\n\r\n TGN: {NameTelegram1}\n\r TGID: {IDTelegram1}\n\r TGUN: {UserNameTelegram1}\n\r SON: {NameStandoff1}\n\r SOID: {IDStandoff1}\n\rБаланс: {Balanc1}\n\rАватарка: {ProfilAva1}", optionO);
                    }
                }
                else if (NameSimProfilPlz == "2" || NameSimProfilPlz == IDTelegram2 || NameSimProfilPlz == NameStandoff2 || NameSimProfilPlz == IDStandoff2 || NameSimProfilPlz == NameTelegram2)
                {
                    if (ProfilAva2 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff2}\n\r\n TGN: {NameTelegram2}\n\r TGID: {IDTelegram2}\n\r TGUN: {UserNameTelegram2}\n\r SON: {NameStandoff2}\n\r SOID: {IDStandoff2}\n\rБаланс: {Balanc2}\n\rАватарка: {ProfilAva2}", optionMember);
                    else if (ProfilAva2 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff2}\n\r\n TGN: {NameTelegram2}\n\r TGID: {IDTelegram2}\n\r TGUN: {UserNameTelegram2}\n\r SON: {NameStandoff2}\n\r SOID: {IDStandoff2}\n\rБаланс: {Balanc2}\n\rАватарка: {ProfilAva2}", optionElder);
                    else if (ProfilAva2 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff2}\n\r\n TGN: {NameTelegram2}\n\r TGID: {IDTelegram2}\n\r TGUN: {UserNameTelegram2}\n\r SON: {NameStandoff2}\n\r SOID: {IDStandoff2}\n\rБаланс: {Balanc2}\n\rАватарка: {ProfilAva2}", optionCoLeader);
                    else if (ProfilAva2 == "Красная" || ProfilAva2 == "Зелёная" || ProfilAva2 == "Оранжевая" || ProfilAva2 == "Синяя" || ProfilAva2 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff2}\n\r\n TGN: {NameTelegram2}\n\r TGID: {IDTelegram2}\n\r TGUN: {UserNameTelegram2}\n\r SON: {NameStandoff2}\n\r SOID: {IDStandoff2}\n\rБаланс: {Balanc2}\n\rАватарка: {ProfilAva2}", optionO);
                }
                else if (NameSimProfilPlz == "3" || NameSimProfilPlz == IDTelegram3 || NameSimProfilPlz == NameStandoff3 || NameSimProfilPlz == IDStandoff3 || NameSimProfilPlz == NameTelegram3)
                {
                    if (ProfilAva3 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff3}\n\r\n TGN: {NameTelegram3}\n\r TGID: {IDTelegram3}\n\r TGUN: {UserNameTelegram3}\n\r SON: {NameStandoff3}\n\r SOID: {IDStandoff3}\n\rБаланс: {Balanc3}\n\rАватарка: {ProfilAva3}", optionMember);
                    else if (ProfilAva3 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff3}\n\r\n TGN: {NameTelegram3}\n\r TGID: {IDTelegram3}\n\r TGUN: {UserNameTelegram3}\n\r SON: {NameStandoff3}\n\r SOID: {IDStandoff3}\n\rБаланс: {Balanc3}\n\rАватарка: {ProfilAva3}", optionElder);
                    else if (ProfilAva3 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff3}\n\r\n TGN: {NameTelegram3}\n\r TGID: {IDTelegram3}\n\r TGUN: {UserNameTelegram3}\n\r SON: {NameStandoff3}\n\r SOID: {IDStandoff3}\n\rБаланс: {Balanc3}\n\rАватарка: {ProfilAva3}", optionCoLeader);
                    else if (ProfilAva3 == "Красная" || ProfilAva3 == "Зелёная" || ProfilAva3 == "Оранжевая" || ProfilAva3 == "Синяя" || ProfilAva3 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff3}\n\r\n TGN: {NameTelegram3}\n\r TGID: {IDTelegram3}\n\r TGUN: {UserNameTelegram3}\n\r SON: {NameStandoff3}\n\r SOID: {IDStandoff3}\n\rБаланс: {Balanc3}\n\rАватарка: {ProfilAva3}", optionO);
                }
                else if (NameSimProfilPlz == "4" || NameSimProfilPlz == IDTelegram4 || NameSimProfilPlz == NameStandoff4 || NameSimProfilPlz == IDStandoff4 || NameSimProfilPlz == NameTelegram4)
                {
                    if (ProfilAva4 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff4}\n\r\n TGN: {NameTelegram4}\n\r TGID: {IDTelegram4}\n\r TGUN: {UserNameTelegram4}\n\r SON: {NameStandoff4}\n\r SOID: {IDStandoff4}\n\rБаланс: {Balanc4}\n\rАватарка: {ProfilAva4}", optionMember);
                    else if (ProfilAva4 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff4}\n\r\n TGN: {NameTelegram4}\n\r TGID: {IDTelegram4}\n\r TGUN: {UserNameTelegram4}\n\r SON: {NameStandoff4}\n\r SOID: {IDStandoff4}\n\rБаланс: {Balanc4}\n\rАватарка: {ProfilAva4}", optionElder);
                    else if (ProfilAva4 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff4}\n\r\n TGN: {NameTelegram4}\n\r TGID: {IDTelegram4}\n\r TGUN: {UserNameTelegram4}\n\r SON: {NameStandoff4}\n\r SOID: {IDStandoff4}\n\rБаланс: {Balanc4}\n\rАватарка: {ProfilAva4}", optionCoLeader);
                    else if (ProfilAva4 == "Красная" || ProfilAva4 == "Зелёная" || ProfilAva4 == "Оранжевая" || ProfilAva4 == "Синяя" || ProfilAva4 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff4}\n\r\n TGN: {NameTelegram4}\n\r TGID: {IDTelegram4}\n\r TGUN: {UserNameTelegram4}\n\r SON: {NameStandoff4}\n\r SOID: {IDStandoff4}\n\rБаланс: {Balanc4}\n\rАватарка: {ProfilAva4}", optionO);
                }
                else if (NameSimProfilPlz == "5" || NameSimProfilPlz == IDTelegram5 || NameSimProfilPlz == NameStandoff5 || NameSimProfilPlz == IDStandoff5 || NameSimProfilPlz == NameTelegram5)
                {
                    if (ProfilAva5 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff5}\n\r\n TGN: {NameTelegram5}\n\r TGID: {IDTelegram5}\n\r TGUN: {UserNameTelegram5}\n\r SON: {NameStandoff5}\n\r SOID: {IDStandoff5}\n\rБаланс: {Balanc5}\n\rАватарка: {ProfilAva5}", optionMember);
                    else if (ProfilAva5 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff5}\n\r\n TGN: {NameTelegram5}\n\r TGID: {IDTelegram5}\n\r TGUN: {UserNameTelegram5}\n\r SON: {NameStandoff5}\n\r SOID: {IDStandoff5}\n\rБаланс: {Balanc5}\n\rАватарка: {ProfilAva5}", optionElder);
                    else if (ProfilAva5 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff5}\n\r\n TGN: {NameTelegram5}\n\r TGID: {IDTelegram5}\n\r TGUN: {UserNameTelegram5}\n\r SON: {NameStandoff5}\n\r SOID: {IDStandoff5}\n\rБаланс: {Balanc5}\n\rАватарка: {ProfilAva5}", optionCoLeader);
                    else if (ProfilAva5 == "Красная" || ProfilAva5 == "Зелёная" || ProfilAva5 == "Оранжевая" || ProfilAva5 == "Синяя" || ProfilAva5 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff5}\n\r\n TGN: {NameTelegram5}\n\r TGID: {IDTelegram5}\n\r TGUN: {UserNameTelegram5}\n\r SON: {NameStandoff5}\n\r SOID: {IDStandoff5}\n\rБаланс: {Balanc5}\n\rАватарка: {ProfilAva5}", optionO);
                }
                else if (NameSimProfilPlz == "6" || NameSimProfilPlz == IDTelegram6 || NameSimProfilPlz == NameStandoff6 || NameSimProfilPlz == IDStandoff6 || NameSimProfilPlz == NameTelegram6)
                {
                    if (ProfilAva6 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff6}\n\r\n TGN: {NameTelegram6}\n\r TGID: {IDTelegram6}\n\r TGUN: {UserNameTelegram6}\n\r SON: {NameStandoff6}\n\r SOID: {IDStandoff6}\n\rБаланс: {Balanc6}\n\rАватарка: {ProfilAva6}", optionMember);
                    else if (ProfilAva6 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff6}\n\r\n TGN: {NameTelegram6}\n\r TGID: {IDTelegram6}\n\r TGUN: {UserNameTelegram6}\n\r SON: {NameStandoff6}\n\r SOID: {IDStandoff6}\n\rБаланс: {Balanc6}\n\rАватарка: {ProfilAva6}", optionElder);
                    else if (ProfilAva6 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff6}\n\r\n TGN: {NameTelegram6}\n\r TGID: {IDTelegram6}\n\r TGUN: {UserNameTelegram6}\n\r SON: {NameStandoff6}\n\r SOID: {IDStandoff6}\n\rБаланс: {Balanc6}\n\rАватарка: {ProfilAva6}", optionCoLeader);
                    else if (ProfilAva6 == "Красная" || ProfilAva6 == "Зелёная" || ProfilAva6 == "Оранжевая" || ProfilAva6 == "Синяя" || ProfilAva6 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff6}\n\r\n TGN: {NameTelegram6}\n\r TGID: {IDTelegram6}\n\r TGUN: {UserNameTelegram6}\n\r SON: {NameStandoff6}\n\r SOID: {IDStandoff6}\n\rБаланс: {Balanc6}\n\rАватарка: {ProfilAva6}", optionO);
                }
                else if (NameSimProfilPlz == "7" || NameSimProfilPlz == IDTelegram7 || NameSimProfilPlz == NameStandoff7 || NameSimProfilPlz == IDStandoff7 || NameSimProfilPlz == NameTelegram7)
                {
                    if (ProfilAva7 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff7}\n\r\n TGN: {NameTelegram7}\n\r TGID: {IDTelegram7}\n\r TGUN: {UserNameTelegram7}\n\r SON: {NameStandoff7}\n\r SOID: {IDStandoff7}\n\rБаланс: {Balanc7}\n\rАватарка: {ProfilAva7}", optionMember);
                    else if (ProfilAva7 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff7}\n\r\n TGN: {NameTelegram7}\n\r TGID: {IDTelegram7}\n\r TGUN: {UserNameTelegram7}\n\r SON: {NameStandoff7}\n\r SOID: {IDStandoff7}\n\rБаланс: {Balanc7}\n\rАватарка: {ProfilAva7}", optionElder);
                    else if (ProfilAva7 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff7}\n\r\n TGN: {NameTelegram7}\n\r TGID: {IDTelegram7}\n\r TGUN: {UserNameTelegram7}\n\r SON: {NameStandoff7}\n\r SOID: {IDStandoff7}\n\rБаланс: {Balanc7}\n\rАватарка: {ProfilAva7}", optionCoLeader);
                    else if (ProfilAva7 == "Красная" || ProfilAva7 == "Зелёная" || ProfilAva7 == "Оранжевая" || ProfilAva7 == "Синяя" || ProfilAva7 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff7}\n\r\n TGN: {NameTelegram7}\n\r TGID: {IDTelegram7}\n\r TGUN: {UserNameTelegram7}\n\r SON: {NameStandoff7}\n\r SOID: {IDStandoff7}\n\rБаланс: {Balanc7}\n\rАватарка: {ProfilAva7}", optionO);
                }
                else if (NameSimProfilPlz == "8" || NameSimProfilPlz == IDTelegram8 || NameSimProfilPlz == NameStandoff8 || NameSimProfilPlz == IDStandoff8 || NameSimProfilPlz == NameTelegram8)
                {
                    if (ProfilAva8 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff8}\n\r\n TGN: {NameTelegram8}\n\r TGID: {IDTelegram8}\n\r TGUN: {UserNameTelegram8}\n\r SON: {NameStandoff8}\n\r SOID: {IDStandoff8}\n\rБаланс: {Balanc8}\n\rАватарка: {ProfilAva8}", optionMember);
                    else if (ProfilAva8 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff8}\n\r\n TGN: {NameTelegram8}\n\r TGID: {IDTelegram8}\n\r TGUN: {UserNameTelegram8}\n\r SON: {NameStandoff8}\n\r SOID: {IDStandoff8}\n\rБаланс: {Balanc8}\n\rАватарка: {ProfilAva8}", optionElder);
                    else if (ProfilAva8 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff8}\n\r\n TGN: {NameTelegram8}\n\r TGID: {IDTelegram8}\n\r TGUN: {UserNameTelegram8}\n\r SON: {NameStandoff8}\n\r SOID: {IDStandoff8}\n\rБаланс: {Balanc8}\n\rАватарка: {ProfilAva8}", optionCoLeader);
                    else if (ProfilAva8 == "Красная" || ProfilAva8 == "Зелёная" || ProfilAva8 == "Оранжевая" || ProfilAva8 == "Синяя" || ProfilAva8 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff8}\n\r\n TGN: {NameTelegram8}\n\r TGID: {IDTelegram8}\n\r TGUN: {UserNameTelegram8}\n\r SON: {NameStandoff8}\n\r SOID: {IDStandoff8}\n\rБаланс: {Balanc8}\n\rАватарка: {ProfilAva8}", optionO);
                }
                else if (NameSimProfilPlz == "9" || NameSimProfilPlz == IDTelegram9 || NameSimProfilPlz == NameStandoff9 || NameSimProfilPlz == IDStandoff9 || NameSimProfilPlz == NameTelegram9)
                {
                    if (ProfilAva9 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff9}\n\r\n TGN: {NameTelegram9}\n\r TGID: {IDTelegram9}\n\r TGUN: {UserNameTelegram9}\n\r SON: {NameStandoff9}\n\r SOID: {IDStandoff9}\n\rБаланс: {Balanc9}\n\rАватарка: {ProfilAva9}", optionMember);
                    else if (ProfilAva9 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff9}\n\r\n TGN: {NameTelegram9}\n\r TGID: {IDTelegram9}\n\r TGUN: {UserNameTelegram9}\n\r SON: {NameStandoff9}\n\r SOID: {IDStandoff9}\n\rБаланс: {Balanc9}\n\rАватарка: {ProfilAva9}", optionElder);
                    else if (ProfilAva9 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff9}\n\r\n TGN: {NameTelegram9}\n\r TGID: {IDTelegram9}\n\r TGUN: {UserNameTelegram9}\n\r SON: {NameStandoff9}\n\r SOID: {IDStandoff9}\n\rБаланс: {Balanc9}\n\rАватарка: {ProfilAva9}", optionCoLeader);
                    else if (ProfilAva9 == "Красная" || ProfilAva9 == "Зелёная" || ProfilAva9 == "Оранжевая" || ProfilAva9 == "Синяя" || ProfilAva9 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff9}\n\r\n TGN: {NameTelegram9}\n\r TGID: {IDTelegram9}\n\r TGUN: {UserNameTelegram9}\n\r SON: {NameStandoff9}\n\r SOID: {IDStandoff9}\n\rБаланс: {Balanc9}\n\rАватарка: {ProfilAva9}", optionO);
                }
                else if (NameSimProfilPlz == "10" || NameSimProfilPlz == IDTelegram10 || NameSimProfilPlz == NameStandoff10 || NameSimProfilPlz == IDStandoff10 || NameSimProfilPlz == NameTelegram10)
                {
                    if (ProfilAva1 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff10}\n\r\n TGN: {NameTelegram10}\n\r TGID: {IDTelegram10}\n\r TGUN: {UserNameTelegram10}\n\r SON: {NameStandoff10}\n\r SOID: {IDStandoff10}\n\rБаланс: {Balanc10}\n\rАватарка: {ProfilAva10}", optionMember);
                    else if (ProfilAva10 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff10}\n\r\n TGN: {NameTelegram10}\n\r TGID: {IDTelegram10}\n\r TGUN: {UserNameTelegram10}\n\r SON: {NameStandoff10}\n\r SOID: {IDStandoff10}\n\rБаланс: {Balanc10}\n\rАватарка: {ProfilAva10}", optionElder);
                    else if (ProfilAva10 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff10}\n\r\n TGN: {NameTelegram10}\n\r TGID: {IDTelegram10}\n\r TGUN: {UserNameTelegram10}\n\r SON: {NameStandoff10}\n\r SOID: {IDStandoff10}\n\rБаланс: {Balanc10}\n\rАватарка: {ProfilAva10}", optionCoLeader);
                    else if (ProfilAva10 == "Красная" || ProfilAva10 == "Зелёная" || ProfilAva10 == "Оранжевая" || ProfilAva10 == "Синяя" || ProfilAva10 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff10}\n\r\n TGN: {NameTelegram10}\n\r TGID: {IDTelegram10}\n\r TGUN: {UserNameTelegram10}\n\r SON: {NameStandoff10}\n\r SOID: {IDStandoff10}\n\rБаланс: {Balanc10}\n\rАватарка: {ProfilAva10}", optionO);
                }
                else if (NameSimProfilPlz == "11" || NameSimProfilPlz == IDTelegram11 || NameSimProfilPlz == NameStandoff11 || NameSimProfilPlz == IDStandoff11 || NameSimProfilPlz == NameTelegram11)
                {
                    if (ProfilAva1 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff11}\n\r\n TGN: {NameTelegram11}\n\r TGID: {IDTelegram11}\n\r TGUN: {UserNameTelegram11}\n\r SON: {NameStandoff11}\n\r SOID: {IDStandoff11}\n\rБаланс: {Balanc11}\n\rАватарка: {ProfilAva11}", optionMember);
                    else if (ProfilAva11 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff11}\n\r\n TGN: {NameTelegram11}\n\r TGID: {IDTelegram11}\n\r TGUN: {UserNameTelegram11}\n\r SON: {NameStandoff11}\n\r SOID: {IDStandoff11}\n\rБаланс: {Balanc11}\n\rАватарка: {ProfilAva11}", optionElder);
                    else if (ProfilAva11 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff11}\n\r\n TGN: {NameTelegram11}\n\r TGID: {IDTelegram11}\n\r TGUN: {UserNameTelegram11}\n\r SON: {NameStandoff11}\n\r SOID: {IDStandoff11}\n\rБаланс: {Balanc11}\n\rАватарка: {ProfilAva11}", optionCoLeader);
                    else if (ProfilAva11 == "Красная" || ProfilAva11 == "Зелёная" || ProfilAva11 == "Оранжевая" || ProfilAva11 == "Синяя" || ProfilAva11 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff11}\n\r\n TGN: {NameTelegram11}\n\r TGID: {IDTelegram11}\n\r TGUN: {UserNameTelegram11}\n\r SON: {NameStandoff11}\n\r SOID: {IDStandoff11}\n\rБаланс: {Balanc11}\n\rАватарка: {ProfilAva11}", optionO);
                }
                else if (NameSimProfilPlz == "12" || NameSimProfilPlz == IDTelegram12 || NameSimProfilPlz == NameStandoff12 || NameSimProfilPlz == IDStandoff12 || NameSimProfilPlz == NameTelegram12)
                {
                    if (ProfilAva1 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff12}\n\r\n TGN: {NameTelegram12}\n\r TGID: {IDTelegram12}\n\r TGUN: {UserNameTelegram12}\n\r SON: {NameStandoff12}\n\r SOID: {IDStandoff12}\n\rБаланс: {Balanc12}\n\rАватарка: {ProfilAva12}", optionMember);
                    else if (ProfilAva12 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff12}\n\r\n TGN: {NameTelegram12}\n\r TGID: {IDTelegram12}\n\r TGUN: {UserNameTelegram12}\n\r SON: {NameStandoff12}\n\r SOID: {IDStandoff12}\n\rБаланс: {Balanc12}\n\rАватарка: {ProfilAva12}", optionElder);
                    else if (ProfilAva12 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff12}\n\r\n TGN: {NameTelegram12}\n\r TGID: {IDTelegram12}\n\r TGUN: {UserNameTelegram12}\n\r SON: {NameStandoff12}\n\r SOID: {IDStandoff12}\n\rБаланс: {Balanc12}\n\rАватарка: {ProfilAva12}", optionCoLeader);
                    else if (ProfilAva12 == "Красная" || ProfilAva12 == "Зелёная" || ProfilAva12 == "Оранжевая" || ProfilAva12 == "Синяя" || ProfilAva12 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff12}\n\r\n TGN: {NameTelegram12}\n\r TGID: {IDTelegram12}\n\r TGUN: {UserNameTelegram12}\n\r SON: {NameStandoff12}\n\r SOID: {IDStandoff12}\n\rБаланс: {Balanc12}\n\rАватарка: {ProfilAva12}", optionO);
                }
                else if (NameSimProfilPlz == "13" || NameSimProfilPlz == IDTelegram13 || NameSimProfilPlz == NameStandoff13 || NameSimProfilPlz == IDStandoff13 || NameSimProfilPlz == NameTelegram13)
                {
                    if (ProfilAva13 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff13}\n\r\n TGN: {NameTelegram13}\n\r TGID: {IDTelegram13}\n\r TGUN: {UserNameTelegram13}\n\r SON: {NameStandoff13}\n\r SOID: {IDStandoff13}\n\rБаланс: {Balanc13}\n\rАватарка: {ProfilAva13}", optionMember);
                    else if (ProfilAva13 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff13}\n\r\n TGN: {NameTelegram13}\n\r TGID: {IDTelegram13}\n\r TGUN: {UserNameTelegram13}\n\r SON: {NameStandoff13}\n\r SOID: {IDStandoff13}\n\rБаланс: {Balanc13}\n\rАватарка: {ProfilAva13}", optionElder);
                    else if (ProfilAva13 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff13}\n\r\n TGN: {NameTelegram13}\n\r TGID: {IDTelegram13}\n\r TGUN: {UserNameTelegram13}\n\r SON: {NameStandoff13}\n\r SOID: {IDStandoff13}\n\rБаланс: {Balanc13}\n\rАватарка: {ProfilAva13}", optionCoLeader);
                    else if (ProfilAva13 == "Красная" || ProfilAva13 == "Зелёная" || ProfilAva13 == "Оранжевая" || ProfilAva13 == "Синяя" || ProfilAva13 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff13}\n\r\n TGN: {NameTelegram13}\n\r TGID: {IDTelegram13}\n\r TGUN: {UserNameTelegram13}\n\r SON: {NameStandoff13}\n\r SOID: {IDStandoff13}\n\rБаланс: {Balanc13}\n\rАватарка: {ProfilAva13}", optionO);
                }
                else if (NameSimProfilPlz == "14" || NameSimProfilPlz == IDTelegram14 || NameSimProfilPlz == NameStandoff14 || NameSimProfilPlz == IDStandoff14 || NameSimProfilPlz == NameTelegram14)
                {
                    if (ProfilAva14 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff14}\n\r\n TGN: {NameTelegram14}\n\r TGID: {IDTelegram14}\n\r TGUN: {UserNameTelegram14}\n\r SON: {NameStandoff14}\n\r SOID: {IDStandoff14}\n\rБаланс: {Balanc14}\n\rАватарка: {ProfilAva14}", optionMember);
                    else if (ProfilAva14 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff14}\n\r\n TGN: {NameTelegram14}\n\r TGID: {IDTelegram14}\n\r TGUN: {UserNameTelegram14}\n\r SON: {NameStandoff14}\n\r SOID: {IDStandoff14}\n\rБаланс: {Balanc14}\n\rАватарка: {ProfilAva14}", optionElder);
                    else if (ProfilAva14 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff14}\n\r\n TGN: {NameTelegram14}\n\r TGID: {IDTelegram14}\n\r TGUN: {UserNameTelegram14}\n\r SON: {NameStandoff14}\n\r SOID: {IDStandoff14}\n\rБаланс: {Balanc14}\n\rАватарка: {ProfilAva14}", optionCoLeader);
                    else if (ProfilAva14 == "Красная" || ProfilAva14 == "Зелёная" || ProfilAva14 == "Оранжевая" || ProfilAva14 == "Синяя" || ProfilAva14 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff14}\n\r\n TGN: {NameTelegram14}\n\r TGID: {IDTelegram14}\n\r TGUN: {UserNameTelegram14}\n\r SON: {NameStandoff14}\n\r SOID: {IDStandoff14}\n\rБаланс: {Balanc14}\n\rАватарка: {ProfilAva14}", optionO);
                }
                else if (NameSimProfilPlz == "15" || NameSimProfilPlz == IDTelegram15 || NameSimProfilPlz == NameStandoff15 || NameSimProfilPlz == IDStandoff15 || NameSimProfilPlz == NameTelegram15)
                {
                    if (ProfilAva15 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff15}\n\r\n TGN: {NameTelegram15}\n\r TGID: {IDTelegram15}\n\r TGUN: {UserNameTelegram15}\n\r SON: {NameStandoff15}\n\r SOID: {IDStandoff15}\n\rБаланс: {Balanc15}\n\rАватарка: {ProfilAva15}", optionMember);
                    else if (ProfilAva15 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff15}\n\r\n TGN: {NameTelegram15}\n\r TGID: {IDTelegram15}\n\r TGUN: {UserNameTelegram15}\n\r SON: {NameStandoff15}\n\r SOID: {IDStandoff15}\n\rБаланс: {Balanc15}\n\rАватарка: {ProfilAva15}", optionElder);
                    else if (ProfilAva15 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff15}\n\r\n TGN: {NameTelegram15}\n\r TGID: {IDTelegram15}\n\r TGUN: {UserNameTelegram15}\n\r SON: {NameStandoff15}\n\r SOID: {IDStandoff15}\n\rБаланс: {Balanc15}\n\rАватарка: {ProfilAva15}", optionCoLeader);
                    else if (ProfilAva15 == "Красная" || ProfilAva15 == "Зелёная" || ProfilAva15 == "Оранжевая" || ProfilAva15 == "Синяя" || ProfilAva15 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff15}\n\r\n TGN: {NameTelegram15}\n\r TGID: {IDTelegram15}\n\r TGUN: {UserNameTelegram15}\n\r SON: {NameStandoff15}\n\r SOID: {IDStandoff15}\n\rБаланс: {Balanc15}\n\rАватарка: {ProfilAva15}", optionO);
                }
                else if (NameSimProfilPlz == "16" || NameSimProfilPlz == IDTelegram16 || NameSimProfilPlz == NameStandoff16 || NameSimProfilPlz == IDStandoff16 || NameSimProfilPlz == NameTelegram16)
                {
                    if (ProfilAva16 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff16}\n\r\n TGN: {NameTelegram16}\n\r TGID: {IDTelegram16}\n\r TGUN: {UserNameTelegram16}\n\r SON: {NameStandoff16}\n\r SOID: {IDStandoff16}\n\rБаланс: {Balanc16}\n\rАватарка: {ProfilAva16}", optionMember);
                    else if (ProfilAva16 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff16}\n\r\n TGN: {NameTelegram16}\n\r TGID: {IDTelegram16}\n\r TGUN: {UserNameTelegram16}\n\r SON: {NameStandoff16}\n\r SOID: {IDStandoff16}\n\rБаланс: {Balanc16}\n\rАватарка: {ProfilAva16}", optionElder);
                    else if (ProfilAva16 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff16}\n\r\n TGN: {NameTelegram16}\n\r TGID: {IDTelegram16}\n\r TGUN: {UserNameTelegram16}\n\r SON: {NameStandoff16}\n\r SOID: {IDStandoff16}\n\rБаланс: {Balanc16}\n\rАватарка: {ProfilAva16}", optionCoLeader);
                    else if (ProfilAva16 == "Красная" || ProfilAva16 == "Зелёная" || ProfilAva16 == "Оранжевая" || ProfilAva16 == "Синяя" || ProfilAva16 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff16}\n\r\n TGN: {NameTelegram16}\n\r TGID: {IDTelegram16}\n\r TGUN: {UserNameTelegram16}\n\r SON: {NameStandoff16}\n\r SOID: {IDStandoff16}\n\rБаланс: {Balanc16}\n\rАватарка: {ProfilAva16}", optionO);
                }
                else if (NameSimProfilPlz == "17" || NameSimProfilPlz == IDTelegram17 || NameSimProfilPlz == NameStandoff17 || NameSimProfilPlz == IDStandoff17 || NameSimProfilPlz == NameTelegram17)
                {
                    if (ProfilAva17 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff17}\n\r\n TGN: {NameTelegram17}\n\r TGID: {IDTelegram17}\n\r TGUN: {UserNameTelegram17}\n\r SON: {NameStandoff17}\n\r SOID: {IDStandoff17}\n\rБаланс: {Balanc17}\n\rАватарка: {ProfilAva17}", optionMember);
                    else if (ProfilAva17 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff17}\n\r\n TGN: {NameTelegram17}\n\r TGID: {IDTelegram17}\n\r TGUN: {UserNameTelegram17}\n\r SON: {NameStandoff17}\n\r SOID: {IDStandoff17}\n\rБаланс: {Balanc17}\n\rАватарка: {ProfilAva17}", optionElder);
                    else if (ProfilAva17 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff17}\n\r\n TGN: {NameTelegram17}\n\r TGID: {IDTelegram17}\n\r TGUN: {UserNameTelegram17}\n\r SON: {NameStandoff17}\n\r SOID: {IDStandoff17}\n\rБаланс: {Balanc17}\n\rАватарка: {ProfilAva17}", optionCoLeader);
                    else if (ProfilAva17 == "Красная" || ProfilAva17 == "Зелёная" || ProfilAva17 == "Оранжевая" || ProfilAva17 == "Синяя" || ProfilAva17 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff17}\n\r\n TGN: {NameTelegram17}\n\r TGID: {IDTelegram17}\n\r TGUN: {UserNameTelegram17}\n\r SON: {NameStandoff17}\n\r SOID: {IDStandoff17}\n\rБаланс: {Balanc17}\n\rАватарка: {ProfilAva17}", optionO);
                }
                else if (NameSimProfilPlz == "18" || NameSimProfilPlz == IDTelegram18 || NameSimProfilPlz == NameStandoff18 || NameSimProfilPlz == IDStandoff18 || NameSimProfilPlz == NameTelegram18)
                {
                    if (ProfilAva18 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff18}\n\r\n TGN: {NameTelegram18}\n\r TGID: {IDTelegram18}\n\r TGUN: {UserNameTelegram18}\n\r SON: {NameStandoff18}\n\r SOID: {IDStandoff18}\n\rБаланс: {Balanc18}\n\rАватарка: {ProfilAva18}", optionMember);
                    else if (ProfilAva18 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff18}\n\r\n TGN: {NameTelegram18}\n\r TGID: {IDTelegram18}\n\r TGUN: {UserNameTelegram18}\n\r SON: {NameStandoff18}\n\r SOID: {IDStandoff18}\n\rБаланс: {Balanc18}\n\rАватарка: {ProfilAva18}", optionElder);
                    else if (ProfilAva18 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff18}\n\r\n TGN: {NameTelegram18}\n\r TGID: {IDTelegram18}\n\r TGUN: {UserNameTelegram18}\n\r SON: {NameStandoff18}\n\r SOID: {IDStandoff18}\n\rБаланс: {Balanc18}\n\rАватарка: {ProfilAva18}", optionCoLeader);
                    else if (ProfilAva18 == "Красная" || ProfilAva18 == "Зелёная" || ProfilAva18 == "Оранжевая" || ProfilAva18 == "Синяя" || ProfilAva18 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff18}\n\r\n TGN: {NameTelegram18}\n\r TGID: {IDTelegram18}\n\r TGUN: {UserNameTelegram18}\n\r SON: {NameStandoff18}\n\r SOID: {IDStandoff18}\n\rБаланс: {Balanc18}\n\rАватарка: {ProfilAva18}", optionO);
                }
                else if (NameSimProfilPlz == "19" || NameSimProfilPlz == IDTelegram19 || NameSimProfilPlz == NameStandoff19 || NameSimProfilPlz == IDStandoff19 || NameSimProfilPlz == NameTelegram19)
                {
                    if (ProfilAva19 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff19}\n\r\n TGN: {NameTelegram19}\n\r TGID: {IDTelegram19}\n\r TGUN: {UserNameTelegram19}\n\r SON: {NameStandoff19}\n\r SOID: {IDStandoff19}\n\rБаланс: {Balanc19}\n\rАватарка: {ProfilAva19}", optionMember);
                    else if (ProfilAva19 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff19}\n\r\n TGN: {NameTelegram19}\n\r TGID: {IDTelegram19}\n\r TGUN: {UserNameTelegram19}\n\r SON: {NameStandoff19}\n\r SOID: {IDStandoff19}\n\rБаланс: {Balanc19}\n\rАватарка: {ProfilAva19}", optionElder);
                    else if (ProfilAva19 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff19}\n\r\n TGN: {NameTelegram19}\n\r TGID: {IDTelegram19}\n\r TGUN: {UserNameTelegram19}\n\r SON: {NameStandoff19}\n\r SOID: {IDStandoff19}\n\rБаланс: {Balanc19}\n\rАватарка: {ProfilAva19}", optionCoLeader);
                    else if (ProfilAva19 == "Красная" || ProfilAva19 == "Зелёная" || ProfilAva19 == "Оранжевая" || ProfilAva19 == "Синяя" || ProfilAva19 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff19}\n\r\n TGN: {NameTelegram19}\n\r TGID: {IDTelegram19}\n\r TGUN: {UserNameTelegram19}\n\r SON: {NameStandoff19}\n\r SOID: {IDStandoff19}\n\rБаланс: {Balanc19}\n\rАватарка: {ProfilAva19}", optionO);
                }
                else if (NameSimProfilPlz == "20" || NameSimProfilPlz == IDTelegram20 || NameSimProfilPlz == NameStandoff20 || NameSimProfilPlz == IDStandoff20 || NameSimProfilPlz == NameTelegram20)
                {
                    if (ProfilAva20 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff20}\n\r\n TGN: {NameTelegram20}\n\r TGID: {IDTelegram20}\n\r TGUN: {UserNameTelegram20}\n\r SON: {NameStandoff20}\n\r SOID: {IDStandoff20}\n\rБаланс: {Balanc20}\n\rАватарка: {ProfilAva20}", optionMember);
                    else if (ProfilAva20 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff20}\n\r\n TGN: {NameTelegram20}\n\r TGID: {IDTelegram20}\n\r TGUN: {UserNameTelegram20}\n\r SON: {NameStandoff20}\n\r SOID: {IDStandoff20}\n\rБаланс: {Balanc20}\n\rАватарка: {ProfilAva20}", optionElder);
                    else if (ProfilAva20 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff20}\n\r\n TGN: {NameTelegram20}\n\r TGID: {IDTelegram20}\n\r TGUN: {UserNameTelegram20}\n\r SON: {NameStandoff20}\n\r SOID: {IDStandoff20}\n\rБаланс: {Balanc20}\n\rАватарка: {ProfilAva20}", optionCoLeader);
                    else if (ProfilAva20 == "Красная" || ProfilAva20 == "Зелёная" || ProfilAva20 == "Оранжевая" || ProfilAva20 == "Синяя" || ProfilAva20 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff20}\n\r\n TGN: {NameTelegram20}\n\r TGID: {IDTelegram20}\n\r TGUN: {UserNameTelegram20}\n\r SON: {NameStandoff20}\n\r SOID: {IDStandoff20}\n\rБаланс: {Balanc20}\n\rАватарка: {ProfilAva20}", optionO);
                }
                else if (NameSimProfilPlz == "21" || NameSimProfilPlz == IDTelegram21 || NameSimProfilPlz == NameStandoff21 || NameSimProfilPlz == IDStandoff21 || NameSimProfilPlz == NameTelegram21)
                {
                    if (ProfilAva1 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff21}\n\r\n TGN: {NameTelegram21}\n\r TGID: {IDTelegram21}\n\r TGUN: {UserNameTelegram21}\n\r SON: {NameStandoff21}\n\r SOID: {IDStandoff21}\n\rБаланс: {Balanc21}\n\rАватарка: {ProfilAva21}", optionMember);
                    else if (ProfilAva21 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff21}\n\r\n TGN: {NameTelegram21}\n\r TGID: {IDTelegram21}\n\r TGUN: {UserNameTelegram21}\n\r SON: {NameStandoff21}\n\r SOID: {IDStandoff21}\n\rБаланс: {Balanc21}\n\rАватарка: {ProfilAva21}", optionElder);
                    else if (ProfilAva21 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff21}\n\r\n TGN: {NameTelegram21}\n\r TGID: {IDTelegram21}\n\r TGUN: {UserNameTelegram21}\n\r SON: {NameStandoff21}\n\r SOID: {IDStandoff21}\n\rБаланс: {Balanc21}\n\rАватарка: {ProfilAva21}", optionCoLeader);
                    else if (ProfilAva21 == "Красная" || ProfilAva21 == "Зелёная" || ProfilAva21 == "Оранжевая" || ProfilAva21 == "Синяя" || ProfilAva21 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff21}\n\r\n TGN: {NameTelegram21}\n\r TGID: {IDTelegram21}\n\r TGUN: {UserNameTelegram21}\n\r SON: {NameStandoff21}\n\r SOID: {IDStandoff21}\n\rБаланс: {Balanc21}\n\rАватарка: {ProfilAva21}", optionO);
                }
                else if (NameSimProfilPlz == "22" || NameSimProfilPlz == IDTelegram22 || NameSimProfilPlz == NameStandoff22 || NameSimProfilPlz == IDStandoff22 || NameSimProfilPlz == NameTelegram22)
                {
                    if (ProfilAva22 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff22}\n\r\n TGN: {NameTelegram22}\n\r TGID: {IDTelegram22}\n\r TGUN: {UserNameTelegram22}\n\r SON: {NameStandoff22}\n\r SOID: {IDStandoff22}\n\rБаланс: {Balanc22}\n\rАватарка: {ProfilAva22}", optionMember);
                    else if (ProfilAva22 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff22}\n\r\n TGN: {NameTelegram22}\n\r TGID: {IDTelegram22}\n\r TGUN: {UserNameTelegram22}\n\r SON: {NameStandoff22}\n\r SOID: {IDStandoff22}\n\rБаланс: {Balanc22}\n\rАватарка: {ProfilAva22}", optionElder);
                    else if (ProfilAva22 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff22}\n\r\n TGN: {NameTelegram22}\n\r TGID: {IDTelegram22}\n\r TGUN: {UserNameTelegram22}\n\r SON: {NameStandoff22}\n\r SOID: {IDStandoff22}\n\rБаланс: {Balanc22}\n\rАватарка: {ProfilAva22}", optionCoLeader);
                    else if (ProfilAva22 == "Красная" || ProfilAva22 == "Зелёная" || ProfilAva22 == "Оранжевая" || ProfilAva22 == "Синяя" || ProfilAva22 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff22}\n\r\n TGN: {NameTelegram22}\n\r TGID: {IDTelegram22}\n\r TGUN: {UserNameTelegram22}\n\r SON: {NameStandoff22}\n\r SOID: {IDStandoff22}\n\rБаланс: {Balanc22}\n\rАватарка: {ProfilAva22}", optionO);
                }
                else if (NameSimProfilPlz == "23" || NameSimProfilPlz == IDTelegram23 || NameSimProfilPlz == NameStandoff23 || NameSimProfilPlz == IDStandoff23 || NameSimProfilPlz == NameTelegram23)
                {
                    if (ProfilAva23 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff23}\n\r\n TGN: {NameTelegram23}\n\r TGID: {IDTelegram23}\n\r TGUN: {UserNameTelegram23}\n\r SON: {NameStandoff23}\n\r SOID: {IDStandoff23}\n\rБаланс: {Balanc23}\n\rАватарка: {ProfilAva23}", optionMember);
                    else if (ProfilAva23 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff23}\n\r\n TGN: {NameTelegram23}\n\r TGID: {IDTelegram23}\n\r TGUN: {UserNameTelegram23}\n\r SON: {NameStandoff23}\n\r SOID: {IDStandoff23}\n\rБаланс: {Balanc23}\n\rАватарка: {ProfilAva23}", optionElder);
                    else if (ProfilAva23 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff23}\n\r\n TGN: {NameTelegram23}\n\r TGID: {IDTelegram23}\n\r TGUN: {UserNameTelegram23}\n\r SON: {NameStandoff23}\n\r SOID: {IDStandoff23}\n\rБаланс: {Balanc23}\n\rАватарка: {ProfilAva23}", optionCoLeader);
                    else if (ProfilAva23 == "Красная" || ProfilAva23 == "Зелёная" || ProfilAva23 == "Оранжевая" || ProfilAva23 == "Синяя" || ProfilAva23 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff23}\n\r\n TGN: {NameTelegram23}\n\r TGID: {IDTelegram23}\n\r TGUN: {UserNameTelegram23}\n\r SON: {NameStandoff23}\n\r SOID: {IDStandoff23}\n\rБаланс: {Balanc23}\n\rАватарка: {ProfilAva23}", optionO);
                }
                else if (NameSimProfilPlz == "24" || NameSimProfilPlz == IDTelegram24 || NameSimProfilPlz == NameStandoff24 || NameSimProfilPlz == IDStandoff24 || NameSimProfilPlz == NameTelegram24)
                {
                    if (ProfilAva24 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff24}\n\r\n TGN: {NameTelegram24}\n\r TGID: {IDTelegram24}\n\r TGUN: {UserNameTelegram24}\n\r SON: {NameStandoff24}\n\r SOID: {IDStandoff24}\n\rБаланс: {Balanc24}\n\rАватарка: {ProfilAva24}", optionMember);
                    else if (ProfilAva24 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff24}\n\r\n TGN: {NameTelegram24}\n\r TGID: {IDTelegram24}\n\r TGUN: {UserNameTelegram24}\n\r SON: {NameStandoff24}\n\r SOID: {IDStandoff24}\n\rБаланс: {Balanc24}\n\rАватарка: {ProfilAva24}", optionElder);
                    else if (ProfilAva24 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff24}\n\r\n TGN: {NameTelegram24}\n\r TGID: {IDTelegram24}\n\r TGUN: {UserNameTelegram24}\n\r SON: {NameStandoff24}\n\r SOID: {IDStandoff24}\n\rБаланс: {Balanc24}\n\rАватарка: {ProfilAva24}", optionCoLeader);
                    else if (ProfilAva24 == "Красная" || ProfilAva24 == "Зелёная" || ProfilAva24 == "Оранжевая" || ProfilAva24 == "Синяя" || ProfilAva24 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff24}\n\r\n TGN: {NameTelegram24}\n\r TGID: {IDTelegram24}\n\r TGUN: {UserNameTelegram24}\n\r SON: {NameStandoff24}\n\r SOID: {IDStandoff24}\n\rБаланс: {Balanc24}\n\rАватарка: {ProfilAva24}", optionO);
                }
                else if (NameSimProfilPlz == "25" || NameSimProfilPlz == IDTelegram25 || NameSimProfilPlz == NameStandoff25 || NameSimProfilPlz == IDStandoff25 || NameSimProfilPlz == NameTelegram25)
                {
                    if (ProfilAva25 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff25}\n\r\n TGN: {NameTelegram25}\n\r TGID: {IDTelegram25}\n\r TGUN: {UserNameTelegram25}\n\r SON: {NameStandoff25}\n\r SOID: {IDStandoff25}\n\rБаланс: {Balanc25}\n\rАватарка: {ProfilAva25}", optionMember);
                    else if (ProfilAva25 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff25}\n\r\n TGN: {NameTelegram25}\n\r TGID: {IDTelegram25}\n\r TGUN: {UserNameTelegram25}\n\r SON: {NameStandoff25}\n\r SOID: {IDStandoff25}\n\rБаланс: {Balanc25}\n\rАватарка: {ProfilAva25}", optionElder);
                    else if (ProfilAva25 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff25}\n\r\n TGN: {NameTelegram25}\n\r TGID: {IDTelegram25}\n\r TGUN: {UserNameTelegram25}\n\r SON: {NameStandoff25}\n\r SOID: {IDStandoff25}\n\rБаланс: {Balanc25}\n\rАватарка: {ProfilAva25}", optionCoLeader);
                    else if (ProfilAva25 == "Красная" || ProfilAva25 == "Зелёная" || ProfilAva25 == "Оранжевая" || ProfilAva25 == "Синяя" || ProfilAva25 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff25}\n\r\n TGN: {NameTelegram25}\n\r TGID: {IDTelegram25}\n\r TGUN: {UserNameTelegram25}\n\r SON: {NameStandoff25}\n\r SOID: {IDStandoff25}\n\rБаланс: {Balanc25}\n\rАватарка: {ProfilAva25}", optionO);
                }
                else if (NameSimProfilPlz == "26" || NameSimProfilPlz == IDTelegram26 || NameSimProfilPlz == NameStandoff26 || NameSimProfilPlz == IDStandoff26 || NameSimProfilPlz == NameTelegram26)
                {
                    if (ProfilAva26 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff26}\n\r\n TGN: {NameTelegram26}\n\r TGID: {IDTelegram26}\n\r TGUN: {UserNameTelegram26}\n\r SON: {NameStandoff26}\n\r SOID: {IDStandoff26}\n\rБаланс: {Balanc26}\n\rАватарка: {ProfilAva26}", optionMember);
                    else if (ProfilAva26 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff26}\n\r\n TGN: {NameTelegram26}\n\r TGID: {IDTelegram26}\n\r TGUN: {UserNameTelegram26}\n\r SON: {NameStandoff26}\n\r SOID: {IDStandoff26}\n\rБаланс: {Balanc26}\n\rАватарка: {ProfilAva26}", optionElder);
                    else if (ProfilAva26 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff26}\n\r\n TGN: {NameTelegram26}\n\r TGID: {IDTelegram26}\n\r TGUN: {UserNameTelegram26}\n\r SON: {NameStandoff26}\n\r SOID: {IDStandoff26}\n\rБаланс: {Balanc26}\n\rАватарка: {ProfilAva26}", optionCoLeader);
                    else if (ProfilAva26 == "Красная" || ProfilAva26 == "Зелёная" || ProfilAva26 == "Оранжевая" || ProfilAva26 == "Синяя" || ProfilAva26 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff26}\n\r\n TGN: {NameTelegram26}\n\r TGID: {IDTelegram26}\n\r TGUN: {UserNameTelegram26}\n\r SON: {NameStandoff26}\n\r SOID: {IDStandoff26}\n\rБаланс: {Balanc26}\n\rАватарка: {ProfilAva26}", optionO);
                }
                else if (NameSimProfilPlz == "27" || NameSimProfilPlz == IDTelegram27 || NameSimProfilPlz == NameStandoff27 || NameSimProfilPlz == IDStandoff27 || NameSimProfilPlz == NameTelegram27)
                {
                    if (ProfilAva27 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff27}\n\r\n TGN: {NameTelegram27}\n\r TGID: {IDTelegram27}\n\r TGUN: {UserNameTelegram27}\n\r SON: {NameStandoff27}\n\r SOID: {IDStandoff27}\n\rБаланс: {Balanc27}\n\rАватарка: {ProfilAva27}", optionMember);
                    else if (ProfilAva27 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff27}\n\r\n TGN: {NameTelegram27}\n\r TGID: {IDTelegram27}\n\r TGUN: {UserNameTelegram27}\n\r SON: {NameStandoff27}\n\r SOID: {IDStandoff27}\n\rБаланс: {Balanc27}\n\rАватарка: {ProfilAva27}", optionElder);
                    else if (ProfilAva27 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff27}\n\r\n TGN: {NameTelegram27}\n\r TGID: {IDTelegram27}\n\r TGUN: {UserNameTelegram27}\n\r SON: {NameStandoff27}\n\r SOID: {IDStandoff27}\n\rБаланс: {Balanc27}\n\rАватарка: {ProfilAva27}", optionCoLeader);
                    else if (ProfilAva27 == "Красная" || ProfilAva27 == "Зелёная" || ProfilAva27 == "Оранжевая" || ProfilAva27 == "Синяя" || ProfilAva27 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff27}\n\r\n TGN: {NameTelegram27}\n\r TGID: {IDTelegram27}\n\r TGUN: {UserNameTelegram27}\n\r SON: {NameStandoff27}\n\r SOID: {IDStandoff27}\n\rБаланс: {Balanc27}\n\rАватарка: {ProfilAva27}", optionO);
                }
                else if (NameSimProfilPlz == "28" || NameSimProfilPlz == IDTelegram28 || NameSimProfilPlz == NameStandoff28 || NameSimProfilPlz == IDStandoff28 || NameSimProfilPlz == NameTelegram28)
                {
                    if (ProfilAva28 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff28}\n\r\n TGN: {NameTelegram28}\n\r TGID: {IDTelegram28}\n\r TGUN: {UserNameTelegram28}\n\r SON: {NameStandoff28}\n\r SOID: {IDStandoff28}\n\rБаланс: {Balanc28}\n\rАватарка: {ProfilAva28}", optionMember);
                    else if (ProfilAva28 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff28}\n\r\n TGN: {NameTelegram28}\n\r TGID: {IDTelegram28}\n\r TGUN: {UserNameTelegram28}\n\r SON: {NameStandoff28}\n\r SOID: {IDStandoff28}\n\rБаланс: {Balanc28}\n\rАватарка: {ProfilAva28}", optionElder);
                    else if (ProfilAva28 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff28}\n\r\n TGN: {NameTelegram28}\n\r TGID: {IDTelegram28}\n\r TGUN: {UserNameTelegram28}\n\r SON: {NameStandoff28}\n\r SOID: {IDStandoff28}\n\rБаланс: {Balanc28}\n\rАватарка: {ProfilAva28}", optionCoLeader);
                    else if (ProfilAva28 == "Красная" || ProfilAva28 == "Зелёная" || ProfilAva28 == "Оранжевая" || ProfilAva28 == "Синяя" || ProfilAva28 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff28}\n\r\n TGN: {NameTelegram28}\n\r TGID: {IDTelegram28}\n\r TGUN: {UserNameTelegram28}\n\r SON: {NameStandoff28}\n\r SOID: {IDStandoff28}\n\rБаланс: {Balanc28}\n\rАватарка: {ProfilAva28}", optionO);
                }
                else if (NameSimProfilPlz == "29" || NameSimProfilPlz == IDTelegram29 || NameSimProfilPlz == NameStandoff29 || NameSimProfilPlz == IDStandoff29 || NameSimProfilPlz == NameTelegram29)
                {
                    if (ProfilAva29 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff29}\n\r\n TGN: {NameTelegram29}\n\r TGID: {IDTelegram29}\n\r TGUN: {UserNameTelegram29}\n\r SON: {NameStandoff29}\n\r SOID: {IDStandoff29}\n\rБаланс: {Balanc29}\n\rАватарка: {ProfilAva29}", optionMember);
                    else if (ProfilAva29 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff29}\n\r\n TGN: {NameTelegram29}\n\r TGID: {IDTelegram29}\n\r TGUN: {UserNameTelegram29}\n\r SON: {NameStandoff29}\n\r SOID: {IDStandoff29}\n\rБаланс: {Balanc29}\n\rАватарка: {ProfilAva29}", optionElder);
                    else if (ProfilAva29 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff29}\n\r\n TGN: {NameTelegram29}\n\r TGID: {IDTelegram29}\n\r TGUN: {UserNameTelegram29}\n\r SON: {NameStandoff29}\n\r SOID: {IDStandoff29}\n\rБаланс: {Balanc29}\n\rАватарка: {ProfilAva29}", optionCoLeader);
                    else if (ProfilAva29 == "Красная" || ProfilAva29 == "Зелёная" || ProfilAva29 == "Оранжевая" || ProfilAva29 == "Синяя" || ProfilAva29 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff29}\n\r\n TGN: {NameTelegram29}\n\r TGID: {IDTelegram29}\n\r TGUN: {UserNameTelegram29}\n\r SON: {NameStandoff29}\n\r SOID: {IDStandoff29}\n\rБаланс: {Balanc29}\n\rАватарка: {ProfilAva29}", optionO);
                }
                else if (NameSimProfilPlz == "30" || NameSimProfilPlz == IDTelegram30 || NameSimProfilPlz == NameStandoff30 || NameSimProfilPlz == IDStandoff30 || NameSimProfilPlz == NameTelegram30)
                {
                    if (ProfilAva30 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff30}\n\r\n TGN: {NameTelegram30}\n\r TGID: {IDTelegram30}\n\r TGUN: {UserNameTelegram30}\n\r SON: {NameStandoff30}\n\r SOID: {IDStandoff30}\n\rБаланс: {Balanc30}\n\rАватарка: {ProfilAva30}", optionMember);
                    else if (ProfilAva30 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff30}\n\r\n TGN: {NameTelegram30}\n\r TGID: {IDTelegram30}\n\r TGUN: {UserNameTelegram30}\n\r SON: {NameStandoff30}\n\r SOID: {IDStandoff30}\n\rБаланс: {Balanc30}\n\rАватарка: {ProfilAva30}", optionElder);
                    else if (ProfilAva30 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff30}\n\r\n TGN: {NameTelegram30}\n\r TGID: {IDTelegram30}\n\r TGUN: {UserNameTelegram30}\n\r SON: {NameStandoff30}\n\r SOID: {IDStandoff30}\n\rБаланс: {Balanc30}\n\rАватарка: {ProfilAva30}", optionCoLeader);
                    else if (ProfilAva30 == "Красная" || ProfilAva30 == "Зелёная" || ProfilAva30 == "Оранжевая" || ProfilAva30 == "Синяя" || ProfilAva30 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff30}\n\r\n TGN: {NameTelegram30}\n\r TGID: {IDTelegram30}\n\r TGUN: {UserNameTelegram30}\n\r SON: {NameStandoff30}\n\r SOID: {IDStandoff30}\n\rБаланс: {Balanc30}\n\rАватарка: {ProfilAva30}", optionO);
                }
                else if (NameSimProfilPlz == "31" || NameSimProfilPlz == IDTelegram31 || NameSimProfilPlz == NameStandoff31 || NameSimProfilPlz == IDStandoff31 || NameSimProfilPlz == NameTelegram31)
                {
                    if (ProfilAva31 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff31}\n\r\n TGN: {NameTelegram31}\n\r TGID: {IDTelegram31}\n\r TGUN: {UserNameTelegram31}\n\r SON: {NameStandoff31}\n\r SOID: {IDStandoff31}\n\rБаланс: {Balanc31}\n\rАватарка: {ProfilAva31}", optionMember);
                    else if (ProfilAva31 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff31}\n\r\n TGN: {NameTelegram31}\n\r TGID: {IDTelegram31}\n\r TGUN: {UserNameTelegram31}\n\r SON: {NameStandoff31}\n\r SOID: {IDStandoff31}\n\rБаланс: {Balanc31}\n\rАватарка: {ProfilAva31}", optionElder);
                    else if (ProfilAva31 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff31}\n\r\n TGN: {NameTelegram31}\n\r TGID: {IDTelegram31}\n\r TGUN: {UserNameTelegram31}\n\r SON: {NameStandoff31}\n\r SOID: {IDStandoff31}\n\rБаланс: {Balanc31}\n\rАватарка: {ProfilAva31}", optionCoLeader);
                    else if (ProfilAva31 == "Красная" || ProfilAva31 == "Зелёная" || ProfilAva31 == "Оранжевая" || ProfilAva31 == "Синяя" || ProfilAva31 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff31}\n\r\n TGN: {NameTelegram31}\n\r TGID: {IDTelegram31}\n\r TGUN: {UserNameTelegram31}\n\r SON: {NameStandoff31}\n\r SOID: {IDStandoff31}\n\rБаланс: {Balanc31}\n\rАватарка: {ProfilAva31}", optionO);
                }
                else if (NameSimProfilPlz == "32" || NameSimProfilPlz == IDTelegram32 || NameSimProfilPlz == NameStandoff32 || NameSimProfilPlz == IDStandoff32 || NameSimProfilPlz == NameTelegram32)
                {
                    if (ProfilAva32 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff32}\n\r\n TGN: {NameTelegram32}\n\r TGID: {IDTelegram32}\n\r TGUN: {UserNameTelegram32}\n\r SON: {NameStandoff32}\n\r SOID: {IDStandoff32}\n\rБаланс: {Balanc32}\n\rАватарка: {ProfilAva32}", optionMember);
                    else if (ProfilAva32 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff32}\n\r\n TGN: {NameTelegram32}\n\r TGID: {IDTelegram32}\n\r TGUN: {UserNameTelegram32}\n\r SON: {NameStandoff32}\n\r SOID: {IDStandoff32}\n\rБаланс: {Balanc32}\n\rАватарка: {ProfilAva32}", optionElder);
                    else if (ProfilAva32 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff32}\n\r\n TGN: {NameTelegram32}\n\r TGID: {IDTelegram32}\n\r TGUN: {UserNameTelegram32}\n\r SON: {NameStandoff32}\n\r SOID: {IDStandoff32}\n\rБаланс: {Balanc32}\n\rАватарка: {ProfilAva32}", optionCoLeader);
                    else if (ProfilAva32 == "Красная" || ProfilAva32 == "Зелёная" || ProfilAva32 == "Оранжевая" || ProfilAva32 == "Синяя" || ProfilAva32 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff32}\n\r\n TGN: {NameTelegram32}\n\r TGID: {IDTelegram32}\n\r TGUN: {UserNameTelegram32}\n\r SON: {NameStandoff32}\n\r SOID: {IDStandoff32}\n\rБаланс: {Balanc32}\n\rАватарка: {ProfilAva32}", optionO);
                }
                else if (NameSimProfilPlz == "33" || NameSimProfilPlz == IDTelegram33 || NameSimProfilPlz == NameStandoff33 || NameSimProfilPlz == IDStandoff33 || NameSimProfilPlz == NameTelegram33)
                {
                    if (ProfilAva33 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff33}\n\r\n TGN: {NameTelegram33}\n\r TGID: {IDTelegram33}\n\r TGUN: {UserNameTelegram33}\n\r SON: {NameStandoff33}\n\r SOID: {IDStandoff33}\n\rБаланс: {Balanc33}\n\rАватарка: {ProfilAva33}", optionMember);
                    else if (ProfilAva33 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff33}\n\r\n TGN: {NameTelegram33}\n\r TGID: {IDTelegram33}\n\r TGUN: {UserNameTelegram33}\n\r SON: {NameStandoff33}\n\r SOID: {IDStandoff33}\n\rБаланс: {Balanc33}\n\rАватарка: {ProfilAva33}", optionElder);
                    else if (ProfilAva33 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff33}\n\r\n TGN: {NameTelegram33}\n\r TGID: {IDTelegram33}\n\r TGUN: {UserNameTelegram33}\n\r SON: {NameStandoff33}\n\r SOID: {IDStandoff33}\n\rБаланс: {Balanc33}\n\rАватарка: {ProfilAva33}", optionCoLeader);
                    else if (ProfilAva33 == "Красная" || ProfilAva33 == "Зелёная" || ProfilAva33 == "Оранжевая" || ProfilAva33 == "Синяя" || ProfilAva33 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff33}\n\r\n TGN: {NameTelegram33}\n\r TGID: {IDTelegram33}\n\r TGUN: {UserNameTelegram33}\n\r SON: {NameStandoff33}\n\r SOID: {IDStandoff33}\n\rБаланс: {Balanc33}\n\rАватарка: {ProfilAva33}", optionO);
                }
                else if (NameSimProfilPlz == "34" || NameSimProfilPlz == IDTelegram34 || NameSimProfilPlz == NameStandoff34 || NameSimProfilPlz == IDStandoff34 || NameSimProfilPlz == NameTelegram34)
                {
                    if (ProfilAva34 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff34}\n\r\n TGN: {NameTelegram34}\n\r TGID: {IDTelegram34}\n\r TGUN: {UserNameTelegram34}\n\r SON: {NameStandoff34}\n\r SOID: {IDStandoff34}\n\rБаланс: {Balanc34}\n\rАватарка: {ProfilAva34}", optionMember);
                    else if (ProfilAva34 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff34}\n\r\n TGN: {NameTelegram34}\n\r TGID: {IDTelegram34}\n\r TGUN: {UserNameTelegram34}\n\r SON: {NameStandoff34}\n\r SOID: {IDStandoff34}\n\rБаланс: {Balanc34}\n\rАватарка: {ProfilAva34}", optionElder);
                    else if (ProfilAva34 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff34}\n\r\n TGN: {NameTelegram34}\n\r TGID: {IDTelegram34}\n\r TGUN: {UserNameTelegram34}\n\r SON: {NameStandoff34}\n\r SOID: {IDStandoff34}\n\rБаланс: {Balanc34}\n\rАватарка: {ProfilAva34}", optionCoLeader);
                    else if (ProfilAva34 == "Красная" || ProfilAva34 == "Зелёная" || ProfilAva34 == "Оранжевая" || ProfilAva34 == "Синяя" || ProfilAva34 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff34}\n\r\n TGN: {NameTelegram34}\n\r TGID: {IDTelegram34}\n\r TGUN: {UserNameTelegram34}\n\r SON: {NameStandoff34}\n\r SOID: {IDStandoff34}\n\rБаланс: {Balanc34}\n\rАватарка: {ProfilAva34}", optionO);
                }
                else if (NameSimProfilPlz == "35" || NameSimProfilPlz == IDTelegram35 || NameSimProfilPlz == NameStandoff35 || NameSimProfilPlz == IDStandoff35 || NameSimProfilPlz == NameTelegram35)
                {
                    if (ProfilAva35 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff35}\n\r\n TGN: {NameTelegram35}\n\r TGID: {IDTelegram35}\n\r TGUN: {UserNameTelegram35}\n\r SON: {NameStandoff35}\n\r SOID: {IDStandoff35}\n\rБаланс: {Balanc35}\n\rАватарка: {ProfilAva35}", optionMember);
                    else if (ProfilAva35 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff35}\n\r\n TGN: {NameTelegram35}\n\r TGID: {IDTelegram35}\n\r TGUN: {UserNameTelegram35}\n\r SON: {NameStandoff35}\n\r SOID: {IDStandoff35}\n\rБаланс: {Balanc35}\n\rАватарка: {ProfilAva35}", optionElder);
                    else if (ProfilAva35 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff35}\n\r\n TGN: {NameTelegram35}\n\r TGID: {IDTelegram35}\n\r TGUN: {UserNameTelegram35}\n\r SON: {NameStandoff35}\n\r SOID: {IDStandoff35}\n\rБаланс: {Balanc35}\n\rАватарка: {ProfilAva35}", optionCoLeader);
                    else if (ProfilAva3 == "Красная" || ProfilAva3 == "Зелёная" || ProfilAva3 == "Оранжевая" || ProfilAva3 == "Синяя" || ProfilAva3 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff35}\n\r\n TGN: {NameTelegram35}\n\r TGID: {IDTelegram35}\n\r TGUN: {UserNameTelegram35}\n\r SON: {NameStandoff35}\n\r SOID: {IDStandoff35}\n\rБаланс: {Balanc35}\n\rАватарка: {ProfilAva35}", optionO);
                }
                else if (NameSimProfilPlz == "36" || NameSimProfilPlz == IDTelegram36 || NameSimProfilPlz == NameStandoff36 || NameSimProfilPlz == IDStandoff36 || NameSimProfilPlz == NameTelegram36)
                {
                    if (ProfilAva36 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff36}\n\r\n TGN: {NameTelegram36}\n\r TGID: {IDTelegram36}\n\r TGUN: {UserNameTelegram36}\n\r SON: {NameStandoff36}\n\r SOID: {IDStandoff36}\n\rБаланс: {Balanc36}\n\rАватарка: {ProfilAva36}", optionMember);
                    else if (ProfilAva36 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff36}\n\r\n TGN: {NameTelegram36}\n\r TGID: {IDTelegram36}\n\r TGUN: {UserNameTelegram36}\n\r SON: {NameStandoff36}\n\r SOID: {IDStandoff36}\n\rБаланс: {Balanc36}\n\rАватарка: {ProfilAva36}", optionElder);
                    else if (ProfilAva36 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff36}\n\r\n TGN: {NameTelegram36}\n\r TGID: {IDTelegram36}\n\r TGUN: {UserNameTelegram36}\n\r SON: {NameStandoff36}\n\r SOID: {IDStandoff36}\n\rБаланс: {Balanc36}\n\rАватарка: {ProfilAva36}", optionCoLeader);
                    else if (ProfilAva36 == "Красная" || ProfilAva36 == "Зелёная" || ProfilAva36 == "Оранжевая" || ProfilAva36 == "Синяя" || ProfilAva36 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff36}\n\r\n TGN: {NameTelegram36}\n\r TGID: {IDTelegram36}\n\r TGUN: {UserNameTelegram36}\n\r SON: {NameStandoff36}\n\r SOID: {IDStandoff36}\n\rБаланс: {Balanc36}\n\rАватарка: {ProfilAva36}", optionO);
                }
                else if (NameSimProfilPlz == "37" || NameSimProfilPlz == IDTelegram37 || NameSimProfilPlz == NameStandoff37 || NameSimProfilPlz == IDStandoff37 || NameSimProfilPlz == NameTelegram37)
                {
                    if (ProfilAva37 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff37}\n\r\n TGN: {NameTelegram37}\n\r TGID: {IDTelegram37}\n\r TGUN: {UserNameTelegram37}\n\r SON: {NameStandoff37}\n\r SOID: {IDStandoff37}\n\rБаланс: {Balanc37}\n\rАватарка: {ProfilAva37}", optionMember);
                    else if (ProfilAva37 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff37}\n\r\n TGN: {NameTelegram37}\n\r TGID: {IDTelegram37}\n\r TGUN: {UserNameTelegram37}\n\r SON: {NameStandoff37}\n\r SOID: {IDStandoff37}\n\rБаланс: {Balanc37}\n\rАватарка: {ProfilAva37}", optionElder);
                    else if (ProfilAva37 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff37}\n\r\n TGN: {NameTelegram37}\n\r TGID: {IDTelegram37}\n\r TGUN: {UserNameTelegram37}\n\r SON: {NameStandoff37}\n\r SOID: {IDStandoff37}\n\rБаланс: {Balanc37}\n\rАватарка: {ProfilAva37}", optionCoLeader);
                    else if (ProfilAva37 == "Красная" || ProfilAva37 == "Зелёная" || ProfilAva37 == "Оранжевая" || ProfilAva37 == "Синяя" || ProfilAva37 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff37}\n\r\n TGN: {NameTelegram37}\n\r TGID: {IDTelegram37}\n\r TGUN: {UserNameTelegram37}\n\r SON: {NameStandoff37}\n\r SOID: {IDStandoff37}\n\rБаланс: {Balanc37}\n\rАватарка: {ProfilAva37}", optionO);
                }
                else if (NameSimProfilPlz == "38" || NameSimProfilPlz == IDTelegram38 || NameSimProfilPlz == NameStandoff38 || NameSimProfilPlz == IDStandoff38 || NameSimProfilPlz == NameTelegram38)
                {
                    if (ProfilAva38 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff38}\n\r\n TGN: {NameTelegram38}\n\r TGID: {IDTelegram38}\n\r TGUN: {UserNameTelegram38}\n\r SON: {NameStandoff38}\n\r SOID: {IDStandoff38}\n\rБаланс: {Balanc38}\n\rАватарка: {ProfilAva38}", optionMember);
                    else if (ProfilAva38 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff38}\n\r\n TGN: {NameTelegram38}\n\r TGID: {IDTelegram38}\n\r TGUN: {UserNameTelegram38}\n\r SON: {NameStandoff38}\n\r SOID: {IDStandoff38}\n\rБаланс: {Balanc38}\n\rАватарка: {ProfilAva38}", optionElder);
                    else if (ProfilAva38 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff38}\n\r\n TGN: {NameTelegram38}\n\r TGID: {IDTelegram38}\n\r TGUN: {UserNameTelegram38}\n\r SON: {NameStandoff38}\n\r SOID: {IDStandoff38}\n\rБаланс: {Balanc38}\n\rАватарка: {ProfilAva38}", optionCoLeader);
                    else if (ProfilAva38 == "Красная" || ProfilAva38 == "Зелёная" || ProfilAva38 == "Оранжевая" || ProfilAva38 == "Синяя" || ProfilAva38 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff38}\n\r\n TGN: {NameTelegram38}\n\r TGID: {IDTelegram38}\n\r TGUN: {UserNameTelegram38}\n\r SON: {NameStandoff38}\n\r SOID: {IDStandoff38}\n\rБаланс: {Balanc38}\n\rАватарка: {ProfilAva38}", optionO);
                }
                else if (NameSimProfilPlz == "39" || NameSimProfilPlz == IDTelegram39 || NameSimProfilPlz == NameStandoff39 || NameSimProfilPlz == IDStandoff39 || NameSimProfilPlz == NameTelegram39)
                {
                    if (ProfilAva39 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff39}\n\r\n TGN: {NameTelegram39}\n\r TGID: {IDTelegram39}\n\r TGUN: {UserNameTelegram39}\n\r SON: {NameStandoff39}\n\r SOID: {IDStandoff39}\n\rБаланс: {Balanc39}\n\rАватарка: {ProfilAva39}", optionMember);
                    else if (ProfilAva39 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff39}\n\r\n TGN: {NameTelegram39}\n\r TGID: {IDTelegram39}\n\r TGUN: {UserNameTelegram39}\n\r SON: {NameStandoff39}\n\r SOID: {IDStandoff39}\n\rБаланс: {Balanc39}\n\rАватарка: {ProfilAva39}", optionElder);
                    else if (ProfilAva39 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff39}\n\r\n TGN: {NameTelegram39}\n\r TGID: {IDTelegram39}\n\r TGUN: {UserNameTelegram39}\n\r SON: {NameStandoff39}\n\r SOID: {IDStandoff39}\n\rБаланс: {Balanc39}\n\rАватарка: {ProfilAva39}", optionCoLeader);
                    else if (ProfilAva39 == "Красная" || ProfilAva39 == "Зелёная" || ProfilAva39 == "Оранжевая" || ProfilAva39 == "Синяя" || ProfilAva39 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff39}\n\r\n TGN: {NameTelegram39}\n\r TGID: {IDTelegram39}\n\r TGUN: {UserNameTelegram39}\n\r SON: {NameStandoff39}\n\r SOID: {IDStandoff39}\n\rБаланс: {Balanc39}\n\rАватарка: {ProfilAva39}", optionO);
                }
                else if (NameSimProfilPlz == "40" || NameSimProfilPlz == IDTelegram40 || NameSimProfilPlz == NameStandoff40 || NameSimProfilPlz == IDStandoff40 || NameSimProfilPlz == NameTelegram40)
                {
                    if (ProfilAva40 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff40}\n\r\n TGN: {NameTelegram40}\n\r TGID: {IDTelegram40}\n\r TGUN: {UserNameTelegram40}\n\r SON: {NameStandoff40}\n\r SOID: {IDStandoff40}\n\rБаланс: {Balanc40}\n\rАватарка: {ProfilAva40}", optionMember);
                    else if (ProfilAva40 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff40}\n\r\n TGN: {NameTelegram40}\n\r TGID: {IDTelegram40}\n\r TGUN: {UserNameTelegram40}\n\r SON: {NameStandoff40}\n\r SOID: {IDStandoff40}\n\rБаланс: {Balanc40}\n\rАватарка: {ProfilAva40}", optionElder);
                    else if (ProfilAva40 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff40}\n\r\n TGN: {NameTelegram40}\n\r TGID: {IDTelegram40}\n\r TGUN: {UserNameTelegram40}\n\r SON: {NameStandoff40}\n\r SOID: {IDStandoff40}\n\rБаланс: {Balanc40}\n\rАватарка: {ProfilAva40}", optionCoLeader);
                    else if (ProfilAva40 == "Красная" || ProfilAva40 == "Зелёная" || ProfilAva40 == "Оранжевая" || ProfilAva40 == "Синяя" || ProfilAva40 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff40}\n\r\n TGN: {NameTelegram40}\n\r TGID: {IDTelegram40}\n\r TGUN: {UserNameTelegram40}\n\r SON: {NameStandoff40}\n\r SOID: {IDStandoff40}\n\rБаланс: {Balanc40}\n\rАватарка: {ProfilAva40}", optionO);
                }
                else if (NameSimProfilPlz == "41" || NameSimProfilPlz == IDTelegram41 || NameSimProfilPlz == NameStandoff41 || NameSimProfilPlz == IDStandoff41 || NameSimProfilPlz == NameTelegram41)
                {
                    if (ProfilAva41 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff41}\n\r\n TGN: {NameTelegram41}\n\r TGID: {IDTelegram41}\n\r TGUN: {UserNameTelegram41}\n\r SON: {NameStandoff41}\n\r SOID: {IDStandoff41}\n\rБаланс: {Balanc41}\n\rАватарка: {ProfilAva41}", optionMember);
                    else if (ProfilAva41 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff41}\n\r\n TGN: {NameTelegram41}\n\r TGID: {IDTelegram41}\n\r TGUN: {UserNameTelegram41}\n\r SON: {NameStandoff41}\n\r SOID: {IDStandoff41}\n\rБаланс: {Balanc41}\n\rАватарка: {ProfilAva41}", optionElder);
                    else if (ProfilAva41 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff41}\n\r\n TGN: {NameTelegram41}\n\r TGID: {IDTelegram41}\n\r TGUN: {UserNameTelegram41}\n\r SON: {NameStandoff41}\n\r SOID: {IDStandoff41}\n\rБаланс: {Balanc41}\n\rАватарка: {ProfilAva41}", optionCoLeader);
                    else if (ProfilAva41 == "Красная" || ProfilAva41 == "Зелёная" || ProfilAva41 == "Оранжевая" || ProfilAva41 == "Синяя" || ProfilAva41 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff41}\n\r\n TGN: {NameTelegram41}\n\r TGID: {IDTelegram41}\n\r TGUN: {UserNameTelegram41}\n\r SON: {NameStandoff41}\n\r SOID: {IDStandoff41}\n\rБаланс: {Balanc41}\n\rАватарка: {ProfilAva41}", optionO);
                }
                else if (NameSimProfilPlz == "42" || NameSimProfilPlz == IDTelegram42 || NameSimProfilPlz == NameStandoff42 || NameSimProfilPlz == IDStandoff42 || NameSimProfilPlz == NameTelegram42)
                {
                    if (ProfilAva42 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff42}\n\r\n TGN: {NameTelegram42}\n\r TGID: {IDTelegram42}\n\r TGUN: {UserNameTelegram42}\n\r SON: {NameStandoff42}\n\r SOID: {IDStandoff42}\n\rБаланс: {Balanc42}\n\rАватарка: {ProfilAva42}", optionMember);
                    else if (ProfilAva42 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff42}\n\r\n TGN: {NameTelegram42}\n\r TGID: {IDTelegram42}\n\r TGUN: {UserNameTelegram42}\n\r SON: {NameStandoff42}\n\r SOID: {IDStandoff42}\n\rБаланс: {Balanc42}\n\rАватарка: {ProfilAva42}", optionElder);
                    else if (ProfilAva42 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff42}\n\r\n TGN: {NameTelegram42}\n\r TGID: {IDTelegram42}\n\r TGUN: {UserNameTelegram42}\n\r SON: {NameStandoff42}\n\r SOID: {IDStandoff42}\n\rБаланс: {Balanc42}\n\rАватарка: {ProfilAva42}", optionCoLeader);
                    else if (ProfilAva42 == "Красная" || ProfilAva42 == "Зелёная" || ProfilAva42 == "Оранжевая" || ProfilAva42 == "Синяя" || ProfilAva42 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff42}\n\r\n TGN: {NameTelegram42}\n\r TGID: {IDTelegram42}\n\r TGUN: {UserNameTelegram42}\n\r SON: {NameStandoff42}\n\r SOID: {IDStandoff42}\n\rБаланс: {Balanc42}\n\rАватарка: {ProfilAva42}", optionO);
                }
                else if (NameSimProfilPlz == "43" || NameSimProfilPlz == IDTelegram43 || NameSimProfilPlz == NameStandoff43 || NameSimProfilPlz == IDStandoff43 || NameSimProfilPlz == NameTelegram43)
                {
                    if (ProfilAva43 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff43}\n\r\n TGN: {NameTelegram43}\n\r TGID: {IDTelegram43}\n\r TGUN: {UserNameTelegram43}\n\r SON: {NameStandoff43}\n\r SOID: {IDStandoff43}\n\rБаланс: {Balanc43}\n\rАватарка: {ProfilAva43}", optionMember);
                    else if (ProfilAva43 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff43}\n\r\n TGN: {NameTelegram43}\n\r TGID: {IDTelegram43}\n\r TGUN: {UserNameTelegram43}\n\r SON: {NameStandoff43}\n\r SOID: {IDStandoff43}\n\rБаланс: {Balanc43}\n\rАватарка: {ProfilAva43}", optionElder);
                    else if (ProfilAva43 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff43}\n\r\n TGN: {NameTelegram43}\n\r TGID: {IDTelegram43}\n\r TGUN: {UserNameTelegram43}\n\r SON: {NameStandoff43}\n\r SOID: {IDStandoff43}\n\rБаланс: {Balanc43}\n\rАватарка: {ProfilAva43}", optionCoLeader);
                    else if (ProfilAva43 == "Красная" || ProfilAva43 == "Зелёная" || ProfilAva43 == "Оранжевая" || ProfilAva43 == "Синяя" || ProfilAva43 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff43}\n\r\n TGN: {NameTelegram43}\n\r TGID: {IDTelegram43}\n\r TGUN: {UserNameTelegram43}\n\r SON: {NameStandoff43}\n\r SOID: {IDStandoff43}\n\rБаланс: {Balanc43}\n\rАватарка: {ProfilAva43}", optionO);
                }
                else if (NameSimProfilPlz == "44" || NameSimProfilPlz == IDTelegram44 || NameSimProfilPlz == NameStandoff44 || NameSimProfilPlz == IDStandoff44 || NameSimProfilPlz == NameTelegram44)
                {
                    if (ProfilAva44 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff44}\n\r\n TGN: {NameTelegram44}\n\r TGID: {IDTelegram44}\n\r TGUN: {UserNameTelegram44}\n\r SON: {NameStandoff44}\n\r SOID: {IDStandoff44}\n\rБаланс: {Balanc44}\n\rАватарка: {ProfilAva44}", optionMember);
                    else if (ProfilAva44 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff44}\n\r\n TGN: {NameTelegram44}\n\r TGID: {IDTelegram44}\n\r TGUN: {UserNameTelegram44}\n\r SON: {NameStandoff44}\n\r SOID: {IDStandoff44}\n\rБаланс: {Balanc44}\n\rАватарка: {ProfilAva44}", optionElder);
                    else if (ProfilAva44 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff44}\n\r\n TGN: {NameTelegram44}\n\r TGID: {IDTelegram44}\n\r TGUN: {UserNameTelegram44}\n\r SON: {NameStandoff44}\n\r SOID: {IDStandoff44}\n\rБаланс: {Balanc44}\n\rАватарка: {ProfilAva44}", optionCoLeader);
                    else if (ProfilAva44 == "Красная" || ProfilAva44 == "Зелёная" || ProfilAva44 == "Оранжевая" || ProfilAva44 == "Синяя" || ProfilAva44 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff44}\n\r\n TGN: {NameTelegram44}\n\r TGID: {IDTelegram44}\n\r TGUN: {UserNameTelegram44}\n\r SON: {NameStandoff44}\n\r SOID: {IDStandoff44}\n\rБаланс: {Balanc44}\n\rАватарка: {ProfilAva44}", optionO);
                }
                else if (NameSimProfilPlz == "45" || NameSimProfilPlz == IDTelegram45 || NameSimProfilPlz == NameStandoff45 || NameSimProfilPlz == IDStandoff45 || NameSimProfilPlz == NameTelegram45)
                {
                    if (ProfilAva45 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff45}\n\r\n TGN: {NameTelegram45}\n\r TGID: {IDTelegram45}\n\r TGUN: {UserNameTelegram45}\n\r SON: {NameStandoff45}\n\r SOID: {IDStandoff45}\n\rБаланс: {Balanc45}\n\rАватарка: {ProfilAva45}", optionMember);
                    else if (ProfilAva45 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff45}\n\r\n TGN: {NameTelegram45}\n\r TGID: {IDTelegram45}\n\r TGUN: {UserNameTelegram45}\n\r SON: {NameStandoff45}\n\r SOID: {IDStandoff45}\n\rБаланс: {Balanc45}\n\rАватарка: {ProfilAva45}", optionElder);
                    else if (ProfilAva45 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff45}\n\r\n TGN: {NameTelegram45}\n\r TGID: {IDTelegram45}\n\r TGUN: {UserNameTelegram45}\n\r SON: {NameStandoff45}\n\r SOID: {IDStandoff45}\n\rБаланс: {Balanc45}\n\rАватарка: {ProfilAva45}", optionCoLeader);
                    else if (ProfilAva45 == "Красная" || ProfilAva45 == "Зелёная" || ProfilAva45 == "Оранжевая" || ProfilAva45 == "Синяя" || ProfilAva45 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff45}\n\r\n TGN: {NameTelegram45}\n\r TGID: {IDTelegram45}\n\r TGUN: {UserNameTelegram45}\n\r SON: {NameStandoff45}\n\r SOID: {IDStandoff45}\n\rБаланс: {Balanc45}\n\rАватарка: {ProfilAva45}", optionO);
                }
                else if (NameSimProfilPlz == "46" || NameSimProfilPlz == IDTelegram46 || NameSimProfilPlz == NameStandoff46 || NameSimProfilPlz == IDStandoff46 || NameSimProfilPlz == NameTelegram46)
                {
                    if (ProfilAva46 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff46}\n\r\n TGN: {NameTelegram46}\n\r TGID: {IDTelegram46}\n\r TGUN: {UserNameTelegram46}\n\r SON: {NameStandoff46}\n\r SOID: {IDStandoff46}\n\rБаланс: {Balanc46}\n\rАватарка: {ProfilAva46}", optionMember);
                    else if (ProfilAva46 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff46}\n\r\n TGN: {NameTelegram46}\n\r TGID: {IDTelegram46}\n\r TGUN: {UserNameTelegram46}\n\r SON: {NameStandoff46}\n\r SOID: {IDStandoff46}\n\rБаланс: {Balanc46}\n\rАватарка: {ProfilAva46}", optionElder);
                    else if (ProfilAva46 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff46}\n\r\n TGN: {NameTelegram46}\n\r TGID: {IDTelegram46}\n\r TGUN: {UserNameTelegram46}\n\r SON: {NameStandoff46}\n\r SOID: {IDStandoff46}\n\rБаланс: {Balanc46}\n\rАватарка: {ProfilAva46}", optionCoLeader);
                    else if (ProfilAva46 == "Красная" || ProfilAva46 == "Зелёная" || ProfilAva46 == "Оранжевая" || ProfilAva46 == "Синяя" || ProfilAva46 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff46}\n\r\n TGN: {NameTelegram46}\n\r TGID: {IDTelegram46}\n\r TGUN: {UserNameTelegram46}\n\r SON: {NameStandoff46}\n\r SOID: {IDStandoff46}\n\rБаланс: {Balanc46}\n\rАватарка: {ProfilAva46}", optionO);
                }
                else if (NameSimProfilPlz == "47" || NameSimProfilPlz == IDTelegram47 || NameSimProfilPlz == NameStandoff47 || NameSimProfilPlz == IDStandoff47 || NameSimProfilPlz == NameTelegram47)
                {
                    if (ProfilAva47 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff47}\n\r\n TGN: {NameTelegram47}\n\r TGID: {IDTelegram47}\n\r TGUN: {UserNameTelegram47}\n\r SON: {NameStandoff47}\n\r SOID: {IDStandoff47}\n\rБаланс: {Balanc47}\n\rАватарка: {ProfilAva47}", optionMember);
                    else if (ProfilAva47 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff47}\n\r\n TGN: {NameTelegram47}\n\r TGID: {IDTelegram47}\n\r TGUN: {UserNameTelegram47}\n\r SON: {NameStandoff47}\n\r SOID: {IDStandoff47}\n\rБаланс: {Balanc47}\n\rАватарка: {ProfilAva47}", optionElder);
                    else if (ProfilAva47 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff47}\n\r\n TGN: {NameTelegram47}\n\r TGID: {IDTelegram47}\n\r TGUN: {UserNameTelegram47}\n\r SON: {NameStandoff47}\n\r SOID: {IDStandoff47}\n\rБаланс: {Balanc47}\n\rАватарка: {ProfilAva47}", optionCoLeader);
                    else if (ProfilAva47 == "Красная" || ProfilAva47 == "Зелёная" || ProfilAva47 == "Оранжевая" || ProfilAva47 == "Синяя" || ProfilAva47 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff47}\n\r\n TGN: {NameTelegram47}\n\r TGID: {IDTelegram47}\n\r TGUN: {UserNameTelegram47}\n\r SON: {NameStandoff47}\n\r SOID: {IDStandoff47}\n\rБаланс: {Balanc47}\n\rАватарка: {ProfilAva47}", optionO);
                }
                else if (NameSimProfilPlz == "48" || NameSimProfilPlz == IDTelegram48 || NameSimProfilPlz == NameStandoff48 || NameSimProfilPlz == IDStandoff48 || NameSimProfilPlz == NameTelegram48)
                {
                    if (ProfilAva48 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff48}\n\r\n TGN: {NameTelegram48}\n\r TGID: {IDTelegram48}\n\r TGUN: {UserNameTelegram48}\n\r SON: {NameStandoff48}\n\r SOID: {IDStandoff48}\n\rБаланс: {Balanc48}\n\rАватарка: {ProfilAva48}", optionMember);
                    else if (ProfilAva48 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff48}\n\r\n TGN: {NameTelegram48}\n\r TGID: {IDTelegram48}\n\r TGUN: {UserNameTelegram48}\n\r SON: {NameStandoff48}\n\r SOID: {IDStandoff48}\n\rБаланс: {Balanc48}\n\rАватарка: {ProfilAva48}", optionElder);
                    else if (ProfilAva48 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff48}\n\r\n TGN: {NameTelegram48}\n\r TGID: {IDTelegram48}\n\r TGUN: {UserNameTelegram48}\n\r SON: {NameStandoff48}\n\r SOID: {IDStandoff48}\n\rБаланс: {Balanc48}\n\rАватарка: {ProfilAva48}", optionCoLeader);
                    else if (ProfilAva48 == "Красная" || ProfilAva48 == "Зелёная" || ProfilAva48 == "Оранжевая" || ProfilAva48 == "Синяя" || ProfilAva48 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff48}\n\r\n TGN: {NameTelegram48}\n\r TGID: {IDTelegram48}\n\r TGUN: {UserNameTelegram48}\n\r SON: {NameStandoff48}\n\r SOID: {IDStandoff48}\n\rБаланс: {Balanc48}\n\rАватарка: {ProfilAva48}", optionO);
                }
                else if (NameSimProfilPlz == "49" || NameSimProfilPlz == IDTelegram49 || NameSimProfilPlz == NameStandoff49 || NameSimProfilPlz == IDStandoff49 || NameSimProfilPlz == NameTelegram49)
                {
                    if (ProfilAva1 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff49}\n\r\n TGN: {NameTelegram49}\n\r TGID: {IDTelegram49}\n\r TGUN: {UserNameTelegram49}\n\r SON: {NameStandoff49}\n\r SOID: {IDStandoff49}\n\rБаланс: {Balanc49}\n\rАватарка: {ProfilAva49}", optionMember);
                    else if (ProfilAva49 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff49}\n\r\n TGN: {NameTelegram49}\n\r TGID: {IDTelegram49}\n\r TGUN: {UserNameTelegram49}\n\r SON: {NameStandoff49}\n\r SOID: {IDStandoff49}\n\rБаланс: {Balanc49}\n\rАватарка: {ProfilAva49}", optionElder);
                    else if (ProfilAva49 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff49}\n\r\n TGN: {NameTelegram49}\n\r TGID: {IDTelegram49}\n\r TGUN: {UserNameTelegram49}\n\r SON: {NameStandoff49}\n\r SOID: {IDStandoff49}\n\rБаланс: {Balanc49}\n\rАватарка: {ProfilAva49}", optionCoLeader);
                    else if (ProfilAva49 == "Красная" || ProfilAva49 == "Зелёная" || ProfilAva49 == "Оранжевая" || ProfilAva49 == "Синяя" || ProfilAva49 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff49}\n\r\n TGN: {NameTelegram49}\n\r TGID: {IDTelegram49}\n\r TGUN: {UserNameTelegram49}\n\r SON: {NameStandoff49}\n\r SOID: {IDStandoff49}\n\rБаланс: {Balanc49}\n\rАватарка: {ProfilAva49}", optionO);
                }
                else if (NameSimProfilPlz == "50" || NameSimProfilPlz == IDTelegram50 || NameSimProfilPlz == NameStandoff50 || NameSimProfilPlz == IDStandoff50 || NameSimProfilPlz == NameTelegram50)
                {
                    if (ProfilAva50 == "Member")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff50}\n\r\n TGN: {NameTelegram50}\n\r TGID: {IDTelegram50}\n\r TGUN: {UserNameTelegram50}\n\r SON: {NameStandoff50}\n\r SOID: {IDStandoff50}\n\rБаланс: {Balanc50}\n\rАватарка: {ProfilAva50}", optionMember);
                    else if (ProfilAva50 == "Elder")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff50}\n\r\n TGN: {NameTelegram50}\n\r TGID: {IDTelegram50}\n\r TGUN: {UserNameTelegram50}\n\r SON: {NameStandoff50}\n\r SOID: {IDStandoff50}\n\rБаланс: {Balanc50}\n\rАватарка: {ProfilAva50}", optionElder);
                    else if (ProfilAva50 == "Co-Leader")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff50}\n\r\n TGN: {NameTelegram50}\n\r TGID: {IDTelegram50}\n\r TGUN: {UserNameTelegram50}\n\r SON: {NameStandoff50}\n\r SOID: {IDStandoff50}\n\rБаланс: {Balanc50}\n\rАватарка: {ProfilAva50}", optionCoLeader);
                    else if (ProfilAva50 == "Красная" || ProfilAva50 == "Зелёная" || ProfilAva50 == "Оранжевая" || ProfilAva50 == "Синяя" || ProfilAva50 == "Розовая")
                        await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Пользователь: {NameStandoff50}\n\r\n TGN: {NameTelegram50}\n\r TGID: {IDTelegram50}\n\r TGUN: {UserNameTelegram50}\n\r SON: {NameStandoff50}\n\r SOID: {IDStandoff50}\n\rБаланс: {Balanc50}\n\rАватарка: {ProfilAva50}", optionO);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.Send(botClient, update, "Данные не найдены.");
                }
            }
        }
        #endregion
        //Просмотр профиля\его удаление||занесение в основной состав.

        #region ProfilPlzPl
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.ProfilPlzPl)]
        public static async Task ProfilPlzPl(ITelegramBotClient botClient, Update update)
        {
            ProfilPlzPPl = false;
            NameSimProfilPlzPl = ProfilPlzPPlAdd;
            var msg = update.Message;

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menu = MenuGenerator.InlineKeyboard(1, list);
            var option = new OptionMessage();
            option.MenuInlineKeyboardMarkup = menu;

            if (NameSimProfilPlzPl == "1" || NameSimProfilPlzPl == IDTelegram1 || NameSimProfilPlzPl == NameStandoff1 || NameSimProfilPlzPl == IDStandoff1 || NameSimProfilPlzPl == NameTelegram1)
            {
                if (ProfilAva1 == "Берёзовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram1}" +
                    $"\n\r TelegramUserName: {UserNameTelegram1}\n\r TelegramID: {IDTelegram1}\n\r\n " +
                    $"StandoffName: {NameStandoff1}\n\r StandoffID: {IDStandoff1}\n\r\n Баланс: {Balanc1}\n\r\n Аватарка: {ProfilAva1}", "https://radikal.host/i/MDVPjK", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram1}" +
                    $"\n\r TelegramUserName: {UserNameTelegram1}\n\r TelegramID: {IDTelegram1}\n\r\n " +
                    $"StandoffName: {NameStandoff1}\n\r StandoffID: {IDStandoff1}\n\r\n Баланс: {Balanc1}\n\r\n Аватарка: {ProfilAva1}", option);
                }
            }
            else if (NameSimProfilPlzPl == "2" || NameSimProfilPlzPl == IDTelegram2 || NameSimProfilPlzPl == NameStandoff2 || NameSimProfilPlzPl == IDStandoff2 || NameSimProfilPlzPl == NameTelegram2)
            {
                if (ProfilAva2 == "Чёрная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram2}" +
                    $"\n\r TelegramUserName: {UserNameTelegram2}\n\r TelegramID: {IDTelegram2}\n\r\n " +
                    $"StandoffName: {NameStandoff2}\n\r StandoffID: {IDStandoff2}\n\r\n Баланс: {Balanc2}\n\r\n Аватарка: {ProfilAva2}", "https://radikal.host/i/M7MbXA", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram2}" +
                    $"\n\r TelegramUserName: {UserNameTelegram2}\n\r TelegramID: {IDTelegram2}\n\r\n " +
                    $"StandoffName: {NameStandoff2}\n\r StandoffID: {IDStandoff2}\n\r\n Баланс: {Balanc2}\n\r\n Аватарка: {ProfilAva2}", option);
                }
            }
            else if (NameSimProfilPlzPl == "3" || NameSimProfilPlzPl == IDTelegram3 || NameSimProfilPlzPl == NameStandoff3 || NameSimProfilPlzPl == IDStandoff3 || NameSimProfilPlzPl == NameTelegram3)
            {
                if (ProfilAva3 == "Именная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram3}" +
                    $"\n\r TelegramUserName: {UserNameTelegram3}\n\r TelegramID: {IDTelegram3}\n\r\n " +
                    $"StandoffName: {NameStandoff3}\n\r StandoffID: {IDStandoff3}\n\r\n Баланс: {Balanc3}\n\r\n Аватарка: {ProfilAva3}", "https://radikal.host/i/M7MIQE", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram3}" +
                    $"\n\r TelegramUserName: {UserNameTelegram3}\n\r TelegramID: {IDTelegram3}\n\r\n " +
                    $"StandoffName: {NameStandoff3}\n\r StandoffID: {IDStandoff3}\n\r\n Баланс: {Balanc3}\n\r\n Аватарка: {ProfilAva3}", option);
                }
            }
            else if (NameSimProfilPlzPl == "4" || NameSimProfilPlzPl == IDTelegram4 || NameSimProfilPlzPl == NameStandoff4 || NameSimProfilPlzPl == IDStandoff4 || NameSimProfilPlzPl == NameTelegram4)
            {

                if (ProfilAva4 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva4 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva4 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva4 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva4 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva4 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva4 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva4 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", option);
                }
            }
            else if (NameSimProfilPlzPl == "5" || NameSimProfilPlzPl == IDTelegram5 || NameSimProfilPlzPl == NameStandoff5 || NameSimProfilPlzPl == IDStandoff5 || NameSimProfilPlzPl == NameTelegram5)
            {

                if (ProfilAva5 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva5 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva5 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva5 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva5 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva5 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva5 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva5 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram5}" +
                    $"\n\r TelegramUserName: {UserNameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r\n " +
                    $"StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n Баланс: {Balanc5}\n\r\n Аватарка: {ProfilAva5}", option);
                }
            }
            else if (NameSimProfilPlzPl == "6" || NameSimProfilPlzPl == IDTelegram6 || NameSimProfilPlzPl == NameStandoff6 || NameSimProfilPlzPl == IDStandoff6 || NameSimProfilPlzPl == NameTelegram6)
            {

                if (ProfilAva6 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva6 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva6 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva6 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva6 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva6 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva6 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva6 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram6}" +
                    $"\n\r TelegramUserName: {UserNameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r\n " +
                    $"StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n Баланс: {Balanc6}\n\r\n Аватарка: {ProfilAva6}", option);
                }
            }
            else if (NameSimProfilPlzPl == "7" || NameSimProfilPlzPl == IDTelegram7 || NameSimProfilPlzPl == NameStandoff7 || NameSimProfilPlzPl == IDStandoff7 || NameSimProfilPlzPl == NameTelegram7)
            {

                if (ProfilAva7 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva7 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva7 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva7 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff1}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva7 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva7 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva7 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram1}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva7 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram7}" +
                    $"\n\r TelegramUserName: {UserNameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r\n " +
                    $"StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n Баланс: {Balanc7}\n\r\n Аватарка: {ProfilAva7}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram4}" +
                    $"\n\r TelegramUserName: {UserNameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n Баланс: {Balanc4}\n\r\n Аватарка: {ProfilAva4}", option);
                }
            }
            else if (NameSimProfilPlzPl == "8" || NameSimProfilPlzPl == IDTelegram8 || NameSimProfilPlzPl == NameStandoff8 || NameSimProfilPlzPl == IDStandoff8 || NameSimProfilPlzPl == NameTelegram8)
            {

                if (ProfilAva8 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva8 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva8 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva8 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva8 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva8 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva8 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva8 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram8}" +
                    $"\n\r TelegramUserName: {UserNameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r\n " +
                    $"StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n Баланс: {Balanc8}\n\r\n Аватарка: {ProfilAva8}", option);
                }
            }
            else if (NameSimProfilPlzPl == "9" || NameSimProfilPlzPl == IDTelegram9 || NameSimProfilPlzPl == NameStandoff9 || NameSimProfilPlzPl == IDStandoff9 || NameSimProfilPlzPl == NameTelegram9)
            {

                if (ProfilAva9 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva9 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva9 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva9 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva9 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva9 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva9 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram1}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva9 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram9}" +
                    $"\n\r TelegramUserName: {UserNameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r\n " +
                    $"StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n Баланс: {Balanc9}\n\r\n Аватарка: {ProfilAva9}", option);
                }
            }
            else if (NameSimProfilPlzPl == "10" || NameSimProfilPlzPl == IDTelegram10 || NameSimProfilPlzPl == NameStandoff10 || NameSimProfilPlzPl == IDStandoff10 || NameSimProfilPlzPl == NameTelegram10)
            {

                if (ProfilAva10 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva10 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva10 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva10 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva10 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva10 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva10 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva10 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram10}" +
                    $"\n\r TelegramUserName: {UserNameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r\n " +
                    $"StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n Баланс: {Balanc10}\n\r\n Аватарка: {ProfilAva10}", option);
                }
            }
            else if (NameSimProfilPlzPl == "11" || NameSimProfilPlzPl == IDTelegram11 || NameSimProfilPlzPl == NameStandoff11 || NameSimProfilPlzPl == IDStandoff11 || NameSimProfilPlzPl == NameTelegram11)
            {

                if (ProfilAva11 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva11 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva11 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc1}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva11 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva11 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva11 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva11 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva11 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram11}" +
                    $"\n\r TelegramUserName: {UserNameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r\n " +
                    $"StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n Баланс: {Balanc11}\n\r\n Аватарка: {ProfilAva11}", option);
                }
            }
            else if (NameSimProfilPlzPl == "12" || NameSimProfilPlzPl == IDTelegram12 || NameSimProfilPlzPl == NameStandoff12 || NameSimProfilPlzPl == IDStandoff12 || NameSimProfilPlzPl == NameTelegram12)
            {

                if (ProfilAva12 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva12 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva12 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva12 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva12 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva12 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva12 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva12 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram12}" +
                    $"\n\r TelegramUserName: {UserNameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r\n " +
                    $"StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n Баланс: {Balanc12}\n\r\n Аватарка: {ProfilAva12}", option);
                }
            }
            else if (NameSimProfilPlzPl == "13" || NameSimProfilPlzPl == IDTelegram13 || NameSimProfilPlzPl == NameStandoff13 || NameSimProfilPlzPl == IDStandoff13 || NameSimProfilPlzPl == NameTelegram13)
            {

                if (ProfilAva13 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva13 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva13 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva13 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva13 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva13 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva13 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva13 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram13}" +
                    $"\n\r TelegramUserName: {UserNameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r\n " +
                    $"StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n Баланс: {Balanc13}\n\r\n Аватарка: {ProfilAva13}", option);
                }
            }
            else if (NameSimProfilPlzPl == "14" || NameSimProfilPlzPl == IDTelegram14 || NameSimProfilPlzPl == NameStandoff14 || NameSimProfilPlzPl == IDStandoff14 || NameSimProfilPlzPl == NameTelegram14)
            {

                if (ProfilAva14 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva14 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva14 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva14 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva14 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva14 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva14 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva14 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram14}" +
                    $"\n\r TelegramUserName: {UserNameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r\n " +
                    $"StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n Баланс: {Balanc14}\n\r\n Аватарка: {ProfilAva14}", option);
                }
            }
            else if (NameSimProfilPlzPl == "15" || NameSimProfilPlzPl == IDTelegram15 || NameSimProfilPlzPl == NameStandoff15 || NameSimProfilPlzPl == IDStandoff15 || NameSimProfilPlzPl == NameTelegram15)
            {

                if (ProfilAva15 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva15 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva15 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva15 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva15 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva15 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva15 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva15 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram15}" +
                    $"\n\r TelegramUserName: {UserNameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r\n " +
                    $"StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n Баланс: {Balanc15}\n\r\n Аватарка: {ProfilAva15}", option);
                }
            }
            else if (NameSimProfilPlzPl == "16" || NameSimProfilPlzPl == IDTelegram16 || NameSimProfilPlzPl == NameStandoff16 || NameSimProfilPlzPl == IDStandoff16 || NameSimProfilPlzPl == NameTelegram16)
            {

                if (ProfilAva16 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva16 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva16 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva16 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva16 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva16 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva16 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva16 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram16}" +
                    $"\n\r TelegramUserName: {UserNameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r\n " +
                    $"StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n Баланс: {Balanc16}\n\r\n Аватарка: {ProfilAva16}", option);
                }
            }
            else if (NameSimProfilPlzPl == "17" || NameSimProfilPlzPl == IDTelegram17 || NameSimProfilPlzPl == NameStandoff17 || NameSimProfilPlzPl == IDStandoff17 || NameSimProfilPlzPl == NameTelegram17)
            {

                if (ProfilAva17 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva17 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva17 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva17 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva17 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva17 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva17 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva17 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram17}" +
                    $"\n\r TelegramUserName: {UserNameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r\n " +
                    $"StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n Баланс: {Balanc17}\n\r\n Аватарка: {ProfilAva17}", option);
                }
            }
            else if (NameSimProfilPlzPl == "18" || NameSimProfilPlzPl == IDTelegram18 || NameSimProfilPlzPl == NameStandoff18 || NameSimProfilPlzPl == IDStandoff18 || NameSimProfilPlzPl == NameTelegram18)
            {

                if (ProfilAva18 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva18 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva18 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva18 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva18 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva18 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva18 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva18 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram18}" +
                    $"\n\r TelegramUserName: {UserNameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r\n " +
                    $"StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n Баланс: {Balanc18}\n\r\n Аватарка: {ProfilAva18}", option);
                }
            }
            else if (NameSimProfilPlzPl == "19" || NameSimProfilPlzPl == IDTelegram19 || NameSimProfilPlzPl == NameStandoff19 || NameSimProfilPlzPl == IDStandoff19 || NameSimProfilPlzPl == NameTelegram19)
            {

                if (ProfilAva19 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva19 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva19 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva19 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva19 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva19 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva19 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva19 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram19}" +
                    $"\n\r TelegramUserName: {UserNameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r\n " +
                    $"StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n Баланс: {Balanc19}\n\r\n Аватарка: {ProfilAva19}", option);
                }
            }
            else if (NameSimProfilPlzPl == "20" || NameSimProfilPlzPl == IDTelegram20 || NameSimProfilPlzPl == NameStandoff20 || NameSimProfilPlzPl == IDStandoff20 || NameSimProfilPlzPl == NameTelegram20)
            {

                if (ProfilAva20 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva20 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva20 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva20 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva20 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva20 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva20 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff1}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva20 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram20}" +
                    $"\n\r TelegramUserName: {UserNameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r\n " +
                    $"StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n Баланс: {Balanc20}\n\r\n Аватарка: {ProfilAva20}", option);
                }
            }
            else if (NameSimProfilPlzPl == "21" || NameSimProfilPlzPl == IDTelegram21 || NameSimProfilPlzPl == NameStandoff21 || NameSimProfilPlzPl == IDStandoff21 || NameSimProfilPlzPl == NameTelegram21)
            {

                if (ProfilAva21 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva21 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva21 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva21 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva21 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva21 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva21 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva21 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram21}" +
                    $"\n\r TelegramUserName: {UserNameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r\n " +
                    $"StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n Баланс: {Balanc21}\n\r\n Аватарка: {ProfilAva21}", option);
                }
            }
            else if (NameSimProfilPlzPl == "22" || NameSimProfilPlzPl == IDTelegram22 || NameSimProfilPlzPl == NameStandoff22 || NameSimProfilPlzPl == IDStandoff22 || NameSimProfilPlzPl == NameTelegram22)
            {

                if (ProfilAva22 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva22 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva22 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva22 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva22 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva22 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva22 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva22 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram22}" +
                    $"\n\r TelegramUserName: {UserNameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r\n " +
                    $"StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n Баланс: {Balanc22}\n\r\n Аватарка: {ProfilAva22}", option);
                }
            }
            else if (NameSimProfilPlzPl == "23" || NameSimProfilPlzPl == IDTelegram23 || NameSimProfilPlzPl == NameStandoff23 || NameSimProfilPlzPl == IDStandoff23 || NameSimProfilPlzPl == NameTelegram23)
            {

                if (ProfilAva23 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva23 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva23 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva23 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva23 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva23 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva23 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva23 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram23}" +
                    $"\n\r TelegramUserName: {UserNameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r\n " +
                    $"StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n Баланс: {Balanc23}\n\r\n Аватарка: {ProfilAva23}", option);
                }
            }
            else if (NameSimProfilPlzPl == "24" || NameSimProfilPlzPl == IDTelegram24 || NameSimProfilPlzPl == NameStandoff24 || NameSimProfilPlzPl == IDStandoff24 || NameSimProfilPlzPl == NameTelegram24)
            {

                if (ProfilAva24 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva24 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva24 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva24 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva24 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva24 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva24 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva24 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram24}" +
                    $"\n\r TelegramUserName: {UserNameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r\n " +
                    $"StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n Баланс: {Balanc24}\n\r\n Аватарка: {ProfilAva24}", option);
                }
            }
            else if (NameSimProfilPlzPl == "25" || NameSimProfilPlzPl == IDTelegram25 || NameSimProfilPlzPl == NameStandoff25 || NameSimProfilPlzPl == IDStandoff25 || NameSimProfilPlzPl == NameTelegram25)
            {

                if (ProfilAva25 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva25 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva25 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva25 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva25 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva25 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva25 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva25 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram25}" +
                    $"\n\r TelegramUserName: {UserNameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r\n " +
                    $"StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\r\n Баланс: {Balanc25}\n\r\n Аватарка: {ProfilAva25}", option);
                }
            }
            else if (NameSimProfilPlzPl == "26" || NameSimProfilPlzPl == IDTelegram26 || NameSimProfilPlzPl == NameStandoff26 || NameSimProfilPlzPl == IDStandoff26 || NameSimProfilPlzPl == NameTelegram26)
            {

                if (ProfilAva26 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva26 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva26 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva26 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva26 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva26 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva26 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva26 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram26}" +
                    $"\n\r TelegramUserName: {UserNameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r\n " +
                    $"StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n Баланс: {Balanc26}\n\r\n Аватарка: {ProfilAva26}", option);
                }
            }
            else if (NameSimProfilPlzPl == "27" || NameSimProfilPlzPl == IDTelegram27 || NameSimProfilPlzPl == NameStandoff27 || NameSimProfilPlzPl == IDStandoff27 || NameSimProfilPlzPl == NameTelegram27)
            {

                if (ProfilAva27 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva27 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva27 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva27 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva27 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva27 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff2}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva27 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva27 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram27}" +
                    $"\n\r TelegramUserName: {UserNameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r\n " +
                    $"StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n Баланс: {Balanc27}\n\r\n Аватарка: {ProfilAva27}", option);
                }
            }
            else if (NameSimProfilPlzPl == "28" || NameSimProfilPlzPl == IDTelegram28 || NameSimProfilPlzPl == NameStandoff28 || NameSimProfilPlzPl == IDStandoff28 || NameSimProfilPlzPl == NameTelegram28)
            {

                if (ProfilAva28 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva28 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva28 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva28 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva28 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva28 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva28 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva28 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram28}" +
                    $"\n\r TelegramUserName: {UserNameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r\n " +
                    $"StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n Баланс: {Balanc28}\n\r\n Аватарка: {ProfilAva28}", option);
                }
            }
            else if (NameSimProfilPlzPl == "29" || NameSimProfilPlzPl == IDTelegram29 || NameSimProfilPlzPl == NameStandoff29 || NameSimProfilPlzPl == IDStandoff29 || NameSimProfilPlzPl == NameTelegram29)
            {

                if (ProfilAva29 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva29 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva29 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva29 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva29 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff2}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva29 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva29 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva29 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram29}" +
                    $"\n\r TelegramUserName: {UserNameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r\n " +
                    $"StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n Баланс: {Balanc29}\n\r\n Аватарка: {ProfilAva29}", option);
                }
            }
            else if (NameSimProfilPlzPl == "30" || NameSimProfilPlzPl == IDTelegram30 || NameSimProfilPlzPl == NameStandoff30 || NameSimProfilPlzPl == IDStandoff30 || NameSimProfilPlzPl == NameTelegram30)
            {

                if (ProfilAva30 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva30 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva30 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva30 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva30 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva30 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva30 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva30 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram30}" +
                    $"\n\r TelegramUserName: {UserNameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r\n " +
                    $"StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n Баланс: {Balanc30}\n\r\n Аватарка: {ProfilAva30}", option);
                }
            }
            else if (NameSimProfilPlzPl == "31" || NameSimProfilPlzPl == IDTelegram31 || NameSimProfilPlzPl == NameStandoff31 || NameSimProfilPlzPl == IDStandoff31 || NameSimProfilPlzPl == NameTelegram31)
            {

                if (ProfilAva31 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva31 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva31 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva31 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva31 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva31 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva31 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva31 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram31}" +
                    $"\n\r TelegramUserName: {UserNameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r\n " +
                    $"StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n Баланс: {Balanc31}\n\r\n Аватарка: {ProfilAva31}", option);
                }
            }
            else if (NameSimProfilPlzPl == "32" || NameSimProfilPlzPl == IDTelegram32 || NameSimProfilPlzPl == NameStandoff32 || NameSimProfilPlzPl == IDStandoff32 || NameSimProfilPlzPl == NameTelegram32)
            {

                if (ProfilAva32 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva32 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva32 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva32 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva32 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva32 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva32 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva32 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram32}" +
                    $"\n\r TelegramUserName: {UserNameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r\n " +
                    $"StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n Баланс: {Balanc32}\n\r\n Аватарка: {ProfilAva32}", option);
                }
            }
            else if (NameSimProfilPlzPl == "33" || NameSimProfilPlzPl == IDTelegram33 || NameSimProfilPlzPl == NameStandoff33 || NameSimProfilPlzPl == IDStandoff33 || NameSimProfilPlzPl == NameTelegram33)
            {

                if (ProfilAva33 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva33 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva33 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva33 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva33 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva33 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva3}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva33 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva33 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram33}" +
                    $"\n\r TelegramUserName: {UserNameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r\n " +
                    $"StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n Баланс: {Balanc33}\n\r\n Аватарка: {ProfilAva33}", option);
                }
            }
            else if (NameSimProfilPlzPl == "34" || NameSimProfilPlzPl == IDTelegram34 || NameSimProfilPlzPl == NameStandoff34 || NameSimProfilPlzPl == IDStandoff34 || NameSimProfilPlzPl == NameTelegram34)
            {

                if (ProfilAva34 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva34 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva34 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva34 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva34 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva34 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva34 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva34 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram34}" +
                    $"\n\r TelegramUserName: {UserNameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r\n " +
                    $"StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n Баланс: {Balanc34}\n\r\n Аватарка: {ProfilAva34}", option);
                }
            }
            else if (NameSimProfilPlzPl == "35" || NameSimProfilPlzPl == IDTelegram35 || NameSimProfilPlzPl == NameStandoff35 || NameSimProfilPlzPl == IDStandoff35 || NameSimProfilPlzPl == NameTelegram35)
            {

                if (ProfilAva35 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva35 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva35 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva35 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva35 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva35 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva35 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva35 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram35}" +
                    $"\n\r TelegramUserName: {UserNameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r\n " +
                    $"StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n Баланс: {Balanc35}\n\r\n Аватарка: {ProfilAva35}", option);
                }
            }
            else if (NameSimProfilPlzPl == "36" || NameSimProfilPlzPl == IDTelegram36 || NameSimProfilPlzPl == NameStandoff36 || NameSimProfilPlzPl == IDStandoff36 || NameSimProfilPlzPl == NameTelegram36)
            {

                if (ProfilAva36 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva36 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva36 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva36 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva36 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva36 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva36 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva36 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram36}" +
                    $"\n\r TelegramUserName: {UserNameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r\n " +
                    $"StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n Баланс: {Balanc36}\n\r\n Аватарка: {ProfilAva36}", option);
                }
            }
            else if (NameSimProfilPlzPl == "37" || NameSimProfilPlzPl == IDTelegram37 || NameSimProfilPlzPl == NameStandoff37 || NameSimProfilPlzPl == IDStandoff37 || NameSimProfilPlzPl == NameTelegram37)
            {

                if (ProfilAva37 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva37 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva37 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva37 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva37 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva37 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva37 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva37 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram37}" +
                    $"\n\r TelegramUserName: {UserNameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r\n " +
                    $"StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n Баланс: {Balanc37}\n\r\n Аватарка: {ProfilAva37}", option);
                }
            }
            else if (NameSimProfilPlzPl == "38" || NameSimProfilPlzPl == IDTelegram38 || NameSimProfilPlzPl == NameStandoff38 || NameSimProfilPlzPl == IDStandoff38 || NameSimProfilPlzPl == NameTelegram38)
            {

                if (ProfilAva38 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva38 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva38 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva38 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva38 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva38 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva38 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva38 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram38}" +
                    $"\n\r TelegramUserName: {UserNameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r\n " +
                    $"StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n Баланс: {Balanc38}\n\r\n Аватарка: {ProfilAva38}", option);
                }
            }
            else if (NameSimProfilPlzPl == "39" || NameSimProfilPlzPl == IDTelegram39 || NameSimProfilPlzPl == NameStandoff39 || NameSimProfilPlzPl == IDStandoff39 || NameSimProfilPlzPl == NameTelegram39)
            {

                if (ProfilAva39 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva39 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva39 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva39 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva39 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva39 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva39 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva39 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram39}" +
                    $"\n\r TelegramUserName: {UserNameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r\n " +
                    $"StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n Баланс: {Balanc39}\n\r\n Аватарка: {ProfilAva39}", option);
                }
            }
            else if (NameSimProfilPlzPl == "40" || NameSimProfilPlzPl == IDTelegram40 || NameSimProfilPlzPl == NameStandoff40 || NameSimProfilPlzPl == IDStandoff40 || NameSimProfilPlzPl == NameTelegram40)
            {

                if (ProfilAva40 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva40 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva40 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva40 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva40 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva40 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva40 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva40 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram40}" +
                    $"\n\r TelegramUserName: {UserNameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r\n " +
                    $"StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n Баланс: {Balanc40}\n\r\n Аватарка: {ProfilAva40}", option);
                }
            }
            else if (NameSimProfilPlzPl == "41" || NameSimProfilPlzPl == IDTelegram41 || NameSimProfilPlzPl == NameStandoff41 || NameSimProfilPlzPl == IDStandoff41 || NameSimProfilPlzPl == NameTelegram41)
            {

                if (ProfilAva41 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva41 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva41 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva41 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva41 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva41 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva41 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva41 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram41}" +
                    $"\n\r TelegramUserName: {UserNameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r\n " +
                    $"StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n Баланс: {Balanc41}\n\r\n Аватарка: {ProfilAva41}", option);
                }
            }
            else if (NameSimProfilPlzPl == "42" || NameSimProfilPlzPl == IDTelegram42 || NameSimProfilPlzPl == NameStandoff42 || NameSimProfilPlzPl == IDStandoff42 || NameSimProfilPlzPl == NameTelegram42)
            {

                if (ProfilAva42 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva42 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva42 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva42 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva42 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva42 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva42 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva42 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram42}" +
                    $"\n\r TelegramUserName: {UserNameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r\n " +
                    $"StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n Баланс: {Balanc42}\n\r\n Аватарка: {ProfilAva42}", option);
                }
            }
            else if (NameSimProfilPlzPl == "43" || NameSimProfilPlzPl == IDTelegram43 || NameSimProfilPlzPl == NameStandoff43 || NameSimProfilPlzPl == IDStandoff43 || NameSimProfilPlzPl == NameTelegram43)
            {

                if (ProfilAva43 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva43 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva43 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva43 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva43 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva43 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva43 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva43 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram43}" +
                    $"\n\r TelegramUserName: {UserNameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r\n " +
                    $"StandoffName: {NameStandoff43}\n\r StandoffID: {IDStandoff43}\n\r\n Баланс: {Balanc43}\n\r\n Аватарка: {ProfilAva43}", option);
                }
            }
            else if (NameSimProfilPlzPl == "44" || NameSimProfilPlzPl == IDTelegram44 || NameSimProfilPlzPl == NameStandoff44 || NameSimProfilPlzPl == IDStandoff44 || NameSimProfilPlzPl == NameTelegram44)
            {

                if (ProfilAva44 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva44 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva44 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva44 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva44 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva44 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva44 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva44 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram44}" +
                    $"\n\r TelegramUserName: {UserNameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r\n " +
                    $"StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n Баланс: {Balanc44}\n\r\n Аватарка: {ProfilAva44}", option);
                }
            }
            else if (NameSimProfilPlzPl == "45" || NameSimProfilPlzPl == IDTelegram45 || NameSimProfilPlzPl == NameStandoff45 || NameSimProfilPlzPl == IDStandoff45 || NameSimProfilPlzPl == NameTelegram45)
            {

                if (ProfilAva45 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva45 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva45 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva45 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva45 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva45 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva45 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva45 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram45}" +
                    $"\n\r TelegramUserName: {UserNameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r\n " +
                    $"StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n Баланс: {Balanc45}\n\r\n Аватарка: {ProfilAva45}", option);
                }
            }
            else if (NameSimProfilPlzPl == "46" || NameSimProfilPlzPl == IDTelegram46 || NameSimProfilPlzPl == NameStandoff46 || NameSimProfilPlzPl == IDStandoff46 || NameSimProfilPlzPl == NameTelegram46)
            {

                if (ProfilAva46 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva46 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva46 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva46 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva46 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva46 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva46 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva46 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram46}" +
                    $"\n\r TelegramUserName: {UserNameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r\n " +
                    $"StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n Баланс: {Balanc46}\n\r\n Аватарка: {ProfilAva46}", option);
                }
            }
            else if (NameSimProfilPlzPl == "47" || NameSimProfilPlzPl == IDTelegram47 || NameSimProfilPlzPl == NameStandoff47 || NameSimProfilPlzPl == IDStandoff47 || NameSimProfilPlzPl == NameTelegram47)
            {

                if (ProfilAva47 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva47 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva47 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva47 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva47 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva47 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva47 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva47 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram47}" +
                    $"\n\r TelegramUserName: {UserNameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r\n " +
                    $"StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n Баланс: {Balanc47}\n\r\n Аватарка: {ProfilAva47}", option);
                }
            }
            else if (NameSimProfilPlzPl == "48" || NameSimProfilPlzPl == IDTelegram48 || NameSimProfilPlzPl == NameStandoff48 || NameSimProfilPlzPl == IDStandoff48 || NameSimProfilPlzPl == NameTelegram48)
            {

                if (ProfilAva48 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram4}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva48 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva48 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva48 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva48 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva48 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva48 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva48 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram48}" +
                    $"\n\r TelegramUserName: {UserNameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r\n " +
                    $"StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n Баланс: {Balanc48}\n\r\n Аватарка: {ProfilAva48}", option);
                }
            }
            else if (NameSimProfilPlzPl == "49" || NameSimProfilPlzPl == IDTelegram49 || NameSimProfilPlzPl == NameStandoff49 || NameSimProfilPlzPl == IDStandoff49 || NameSimProfilPlzPl == NameTelegram49)
            {

                if (ProfilAva49 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva49 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva49 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva49 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva49 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva49 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva49 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva49 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram49}" +
                    $"\n\r TelegramUserName: {UserNameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r\n " +
                    $"StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n Баланс: {Balanc49}\n\r\n Аватарка: {ProfilAva49}", option);
                }
            }
            else if (NameSimProfilPlzPl == "50" || NameSimProfilPlzPl == IDTelegram50 || NameSimProfilPlzPl == NameStandoff50 || NameSimProfilPlzPl == IDStandoff50 || NameSimProfilPlzPl == NameTelegram50)
            {

                if (ProfilAva50 == "Member")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx5rdh", option);
                }
                else if (ProfilAva50 == "Elder")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8Z5C ", option);
                }
                else if (ProfilAva50 == "Co-Leader")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8DeE ", option);
                }
                else if (ProfilAva50 == "Красная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8EXD ", option);
                }
                else if (ProfilAva50 == "Зелёная")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8rZK ", option);
                }
                else if (ProfilAva50 == "Оранжевая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8Ghz ", option);
                }
                else if (ProfilAva50 == "Розовая")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx8Rld ", option);
                }
                else if (ProfilAva50 == "Синяя")
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", "https://radikal.host/i/Mx80p8 ", option);
                }
                else
                {
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Error Ava (Ошибка аватарки)", option);
                    await PRTelegramBot.Helpers.Message.SendPhotoWithUrl(botClient, update.GetChatId(), $"Ваш профиль:\n\r\n TelegramName: {NameTelegram50}" +
                    $"\n\r TelegramUserName: {UserNameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r\n " +
                    $"StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n Баланс: {Balanc50}\n\r\n Аватарка: {ProfilAva50}", option);
                }
            }
            else
            {
                await PRTelegramBot.Helpers.Message.Send(botClient, update.GetChatId(), "Данные не найдены.");
            }
        }
        #endregion
        //Просмотр профиля.

        #region ProfilDell

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.DellProfil)]
        public static async Task DellProfil(ITelegramBotClient botClient, Update update)
        {
            var DellProfilYes = new InlineCallback("Подтвердить", PRHeadlers.DellProfilYes);
            var list = new List<IInlineContent>();
            list.Add(DellProfilYes);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Подтвердите удание аккаунта. Номер аккаунта: {NameSimProfilPlz}", option1);
        }

        #endregion
        //Подтверждение удаление аккаунта.

        #region ProfilDellYes

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.DellProfilYes)]
        public static async Task DellProfilYes(ITelegramBotClient botClient, Update update)
        {
            DelProfil = true;
            var DellProfilAddS = new InlineCallback("Подтвердить", PRHeadlers.DellProfilAddS);
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(DellProfilAddS);
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Укажите в какой список добавить пользователя: {NameSimProfilPlz}.", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.DellProfilAddS)]
        public static async Task DellProfilAddS(ITelegramBotClient botClient, Update update)
        {
            AddS = DelProfilAdd;
            DelProfil = false;
            var DellProfilFinal = new InlineCallback("Подтвердить", PRHeadlers.DellProfilFinal);
            var DellProfilYes = new InlineCallback("Поменять список", PRHeadlers.DellProfilYes);
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(DellProfilFinal);
            list.Add(DellProfilYes);
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Вы указали: " + AddS, option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.DellProfilFinal)]
        public static async Task DellProfilFinal(ITelegramBotClient botClient, Update update)
        {
            if (AddS == "Черный" || AddS == "Ч" || AddS == "ч" || AddS == "Черный спикок")
            {
                #region Black
                if (NameSimProfilPlz == "1" || NameSimProfilPlz == IDTelegram1 || NameSimProfilPlz == IDStandoff1)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff1}\n\r\n TelegramName: {NameTelegram1}\n\r TelegramID: {IDTelegram1}\n\r TelegramUserName: {UserNameTelegram1}\n\r StandoffName: {NameStandoff1}\n\r StandoffID: {IDStandoff1}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff1 = null;
                    NameTelegram1 = null;
                    IDTelegram1 = null;
                    UserNameTelegram1 = null;
                    IDStandoff1 = null;
                    Console.WriteLine("Пользователь 1 удален");
                }
                else if (NameSimProfilPlz == "2" || NameSimProfilPlz == IDTelegram2 || NameSimProfilPlz == NameStandoff2 || NameSimProfilPlz == IDStandoff2 || NameSimProfilPlz == NameTelegram2)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff2}\n\r\n TelegramName: {NameTelegram2}\n\r TelegramID: {IDTelegram2}\n\r TelegramUserName: {UserNameTelegram2}\n\r StandoffName: {NameStandoff2}\n\r StandoffID: {IDStandoff2}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff2 = null;
                    NameTelegram2 = null;
                    IDTelegram2 = null;
                    UserNameTelegram2 = null;
                    IDStandoff2 = null;
                    Console.WriteLine("Пользователь 2 удален");
                }
                else if (NameSimProfilPlz == "3" || NameSimProfilPlz == IDTelegram3 || NameSimProfilPlz == NameStandoff3 || NameSimProfilPlz == IDStandoff3 || NameSimProfilPlz == NameTelegram3)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff3}\n\r\n TelegramName: {NameTelegram3}\n\r TelegramID: {IDTelegram3}\n\r TelegramUserName: {UserNameTelegram3}\n\r StandoffName: {NameStandoff3}\n\r StandoffID: {IDStandoff3}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff3 = null;
                    NameTelegram3 = null;
                    IDTelegram3 = null;
                    UserNameTelegram3 = null;
                    IDStandoff3 = null;
                    Console.WriteLine("Пользователь 3 удален");
                }
                else if (NameSimProfilPlz == "4" || NameSimProfilPlz == IDTelegram4 || NameSimProfilPlz == NameStandoff4 || NameSimProfilPlz == IDStandoff4 || NameSimProfilPlz == NameTelegram4)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff4}\n\r\n TelegramName: {NameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r TelegramUserName: {UserNameTelegram4}\n\r StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff4 = null;
                    NameTelegram4 = null;
                    IDTelegram4 = null;
                    UserNameTelegram4 = null;
                    IDStandoff4 = null;
                    Console.WriteLine("Пользователь 4 удален");
                }
                else if (NameSimProfilPlz == "5" || NameSimProfilPlz == IDTelegram5 || NameSimProfilPlz == NameStandoff5 || NameSimProfilPlz == IDStandoff5 || NameSimProfilPlz == NameTelegram5)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff5}\n\r\n TelegramName: {NameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r TelegramUserName: {UserNameTelegram5}\n\r StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff5 = null;
                    NameTelegram5 = null;
                    IDTelegram5 = null;
                    UserNameTelegram5 = null;
                    IDStandoff5 = null;
                    Console.WriteLine("Пользователь 5 удален");
                }
                else if (NameSimProfilPlz == "6" || NameSimProfilPlz == IDTelegram6 || NameSimProfilPlz == NameStandoff6 || NameSimProfilPlz == IDStandoff6 || NameSimProfilPlz == NameTelegram6)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff6}\n\r\n TelegramName: {NameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r TelegramUserName: {UserNameTelegram6}\n\r StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff6 = null;
                    NameTelegram6 = null;
                    IDTelegram6 = null;
                    UserNameTelegram6 = null;
                    IDStandoff6 = null;
                    Console.WriteLine("Пользователь 6 удален");
                }
                else if (NameSimProfilPlz == "7" || NameSimProfilPlz == IDTelegram7 || NameSimProfilPlz == NameStandoff7 || NameSimProfilPlz == IDStandoff7 || NameSimProfilPlz == NameTelegram7)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff7}\n\r\n TelegramName: {NameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r TelegramUserName: {UserNameTelegram7}\n\r StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff7 = null;
                    NameTelegram7 = null;
                    IDTelegram7 = null;
                    UserNameTelegram7 = null;
                    IDStandoff7 = null;
                    Console.WriteLine("Пользователь 7 удален");
                }
                else if (NameSimProfilPlz == "8" || NameSimProfilPlz == IDTelegram8 || NameSimProfilPlz == NameStandoff8 || NameSimProfilPlz == IDStandoff8 || NameSimProfilPlz == NameTelegram8)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff8}\n\r\n TelegramName: {NameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r TelegramUserName: {UserNameTelegram8}\n\r StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff8 = null;
                    NameTelegram8 = null;
                    IDTelegram8 = null;
                    UserNameTelegram8 = null;
                    IDStandoff8 = null;
                    Console.WriteLine("Пользователь 8 удален");
                }
                else if (NameSimProfilPlz == "9" || NameSimProfilPlz == IDTelegram9 || NameSimProfilPlz == NameStandoff9 || NameSimProfilPlz == IDStandoff9 || NameSimProfilPlz == NameTelegram9)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff9}\n\r\n TelegramName: {NameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r TelegramUserName: {UserNameTelegram9}\n\r StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff9 = null;
                    NameTelegram9 = null;
                    IDTelegram9 = null;
                    UserNameTelegram9 = null;
                    IDStandoff9 = null;
                    Console.WriteLine("Пользователь 9 удален");
                }
                else if (NameSimProfilPlz == "10" || NameSimProfilPlz == IDTelegram10 || NameSimProfilPlz == NameStandoff10 || NameSimProfilPlz == IDStandoff10 || NameSimProfilPlz == NameTelegram10)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff10}\n\r\n TelegramName: {NameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r TelegramUserName: {UserNameTelegram10}\n\r StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff10 = null;
                    NameTelegram10 = null;
                    IDTelegram10 = null;
                    UserNameTelegram10 = null;
                    IDStandoff10 = null;
                    Console.WriteLine("Пользователь 10 удален");
                }
                else if (NameSimProfilPlz == "11" || NameSimProfilPlz == IDTelegram11 || NameSimProfilPlz == NameStandoff11 || NameSimProfilPlz == IDStandoff11 || NameSimProfilPlz == NameTelegram11)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff11}\n\r\n TelegramName: {NameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r TelegramUserName: {UserNameTelegram11}\n\r StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff11 = null;
                    NameTelegram11 = null;
                    IDTelegram11 = null;
                    UserNameTelegram11 = null;
                    IDStandoff11 = null;
                    Console.WriteLine("Пользователь 11 удален");
                }
                else if (NameSimProfilPlz == "12" || NameSimProfilPlz == IDTelegram12 || NameSimProfilPlz == NameStandoff12 || NameSimProfilPlz == IDStandoff12 || NameSimProfilPlz == NameTelegram12)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff12}\n\r\n TelegramName: {NameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r TelegramUserName: {UserNameTelegram12}\n\r StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff12 = null;
                    NameTelegram12 = null;
                    IDTelegram12 = null;
                    UserNameTelegram12 = null;
                    IDStandoff12 = null;
                    Console.WriteLine("Пользователь 12 удален");
                }
                else if (NameSimProfilPlz == "13" || NameSimProfilPlz == IDTelegram13 || NameSimProfilPlz == NameStandoff13 || NameSimProfilPlz == IDStandoff13 || NameSimProfilPlz == NameTelegram13)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff13}\n\r\n TelegramName: {NameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r TelegramUserName: {UserNameTelegram13}\n\r StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff13 = null;
                    NameTelegram13 = null;
                    IDTelegram13 = null;
                    UserNameTelegram13 = null;
                    IDStandoff13 = null;
                    Console.WriteLine("Пользователь 13 удален");
                }
                else if (NameSimProfilPlz == "14" || NameSimProfilPlz == IDTelegram14 || NameSimProfilPlz == NameStandoff14 || NameSimProfilPlz == IDStandoff14 || NameSimProfilPlz == NameTelegram14)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff14}\n\r\n TelegramName: {NameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r TelegramUserName: {UserNameTelegram14}\n\r StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff14 = null;
                    NameTelegram14 = null;
                    IDTelegram14 = null;
                    UserNameTelegram14 = null;
                    IDStandoff14 = null;
                    Console.WriteLine("Пользователь 14 удален");
                }
                else if (NameSimProfilPlz == "15" || NameSimProfilPlz == IDTelegram15 || NameSimProfilPlz == NameStandoff15 || NameSimProfilPlz == IDStandoff15 || NameSimProfilPlz == NameTelegram15)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff15}\n\r\n TelegramName: {NameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r TelegramUserName: {UserNameTelegram15}\n\r StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff15 = null;
                    NameTelegram15 = null;
                    IDTelegram15 = null;
                    UserNameTelegram15 = null;
                    IDStandoff15 = null;
                    Console.WriteLine("Пользователь 15 удален");
                }
                else if (NameSimProfilPlz == "16" || NameSimProfilPlz == IDTelegram16 || NameSimProfilPlz == NameStandoff16 || NameSimProfilPlz == IDStandoff16 || NameSimProfilPlz == NameTelegram16)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff16}\n\r\n TelegramName: {NameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r TelegramUserName: {UserNameTelegram16}\n\r StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff16 = null;
                    NameTelegram16 = null;
                    IDTelegram16 = null;
                    UserNameTelegram16 = null;
                    IDStandoff16 = null;
                    Console.WriteLine("Пользователь 16 удален");
                }
                else if (NameSimProfilPlz == "17" || NameSimProfilPlz == IDTelegram17 || NameSimProfilPlz == NameStandoff17 || NameSimProfilPlz == IDStandoff17 || NameSimProfilPlz == NameTelegram17)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff17}\n\r\n TelegramName: {NameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r TelegramUserName: {UserNameTelegram17}\n\r StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff17 = null;
                    NameTelegram17 = null;
                    IDTelegram17 = null;
                    UserNameTelegram17 = null;
                    IDStandoff17 = null;
                    Console.WriteLine("Пользователь 17 удален");
                }
                else if (NameSimProfilPlz == "18" || NameSimProfilPlz == IDTelegram18 || NameSimProfilPlz == NameStandoff18 || NameSimProfilPlz == IDStandoff18 || NameSimProfilPlz == NameTelegram18)
                {

                    AllPlzBlack += $"Пользователь: {NameStandoff18}\n\r\n TelegramName: {NameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r TelegramUserName: {UserNameTelegram18}\n\r StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff18 = null;
                    NameTelegram18 = null;
                    IDTelegram18 = null;
                    UserNameTelegram18 = null;
                    IDStandoff18 = null;
                    Console.WriteLine("Пользователь 18 удален");
                }
                else if (NameSimProfilPlz == "19" || NameSimProfilPlz == IDTelegram19 || NameSimProfilPlz == NameStandoff19 || NameSimProfilPlz == IDStandoff19 || NameSimProfilPlz == NameTelegram19)
                {

                    AllPlzBlack += $"Пользователь: {NameStandoff19}\n\r\n TelegramName: {NameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r TelegramUserName: {UserNameTelegram19}\n\r StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff19 = null;
                    NameTelegram19 = null;
                    IDTelegram19 = null;
                    UserNameTelegram19 = null;
                    IDStandoff19 = null;
                    Console.WriteLine("Пользователь 19 удален");
                }
                else if (NameSimProfilPlz == "20" || NameSimProfilPlz == IDTelegram20 || NameSimProfilPlz == NameStandoff20 || NameSimProfilPlz == IDStandoff20 || NameSimProfilPlz == NameTelegram20)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff20}\n\r\n TelegramName: {NameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r TelegramUserName: {UserNameTelegram20}\n\r StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff20 = null;
                    NameTelegram20 = null;
                    IDTelegram20 = null;
                    UserNameTelegram20 = null;
                    IDStandoff20 = null;
                    Console.WriteLine("Пользователь 20 удален");
                }
                else if (NameSimProfilPlz == "21" || NameSimProfilPlz == IDTelegram21 || NameSimProfilPlz == NameStandoff21 || NameSimProfilPlz == IDStandoff21 || NameSimProfilPlz == NameTelegram21)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff21}\n\r\n TelegramName: {NameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r TelegramUserName: {UserNameTelegram21}\n\r StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff21 = null;
                    NameTelegram21 = null;
                    IDTelegram21 = null;
                    UserNameTelegram21 = null;
                    IDStandoff21 = null;
                    Console.WriteLine("Пользователь 21 удален");
                }
                else if (NameSimProfilPlz == "22" || NameSimProfilPlz == IDTelegram22 || NameSimProfilPlz == NameStandoff22 || NameSimProfilPlz == IDStandoff22 || NameSimProfilPlz == NameTelegram22)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff22}\n\r\n TelegramName: {NameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r TelegramUserName: {UserNameTelegram22}\n\r StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff22 = null;
                    NameTelegram22 = null;
                    IDTelegram22 = null;
                    UserNameTelegram22 = null;
                    IDStandoff22 = null;
                    Console.WriteLine("Пользователь 22 удален");
                }
                else if (NameSimProfilPlz == "23" || NameSimProfilPlz == IDTelegram23 || NameSimProfilPlz == NameStandoff23 || NameSimProfilPlz == IDStandoff23 || NameSimProfilPlz == NameTelegram23)
                {

                    AllPlzBlack += $"Пользователь: {NameStandoff23}\n\r\n TelegramName: {NameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r TelegramUserName: {UserNameTelegram23}\n\r StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff23 = null;
                    NameTelegram23 = null;
                    IDTelegram23 = null;
                    UserNameTelegram23 = null;
                    IDStandoff23 = null;
                    Console.WriteLine("Пользователь 23 удален");
                }
                else if (NameSimProfilPlz == "24" || NameSimProfilPlz == IDTelegram24 || NameSimProfilPlz == NameStandoff24 || NameSimProfilPlz == IDStandoff24 || NameSimProfilPlz == NameTelegram24)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff24}\n\r\n TelegramName: {NameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r TelegramUserName: {UserNameTelegram24}\n\r StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff24 = null;
                    NameTelegram24 = null;
                    IDTelegram24 = null;
                    UserNameTelegram24 = null;
                    IDStandoff24 = null;
                    Console.WriteLine("Пользователь 24 удален");
                }
                else if (NameSimProfilPlz == "25" || NameSimProfilPlz == IDTelegram25 || NameSimProfilPlz == NameStandoff25 || NameSimProfilPlz == IDStandoff25 || NameSimProfilPlz == NameTelegram25)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff25}\n\r\n TelegramName: {NameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r TelegramUserName: {UserNameTelegram25}\n\r StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff25 = null;
                    NameTelegram25 = null;
                    IDTelegram25 = null;
                    UserNameTelegram25 = null;
                    IDStandoff25 = null;
                    Console.WriteLine("Пользователь 25 удален");
                }
                else if (NameSimProfilPlz == "26" || NameSimProfilPlz == IDTelegram26 || NameSimProfilPlz == NameStandoff26 || NameSimProfilPlz == IDStandoff26 || NameSimProfilPlz == NameTelegram26)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff26}\n\r\n TelegramName: {NameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r TelegramUserName: {UserNameTelegram26}\n\r StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff26 = null;
                    NameTelegram26 = null;
                    IDTelegram26 = null;
                    UserNameTelegram26 = null;
                    IDStandoff26 = null;
                    Console.WriteLine("Пользователь 26 удален");
                }
                else if (NameSimProfilPlz == "27" || NameSimProfilPlz == IDTelegram27 || NameSimProfilPlz == NameStandoff27 || NameSimProfilPlz == IDStandoff27 || NameSimProfilPlz == NameTelegram27)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff27}\n\r\n TelegramName: {NameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r TelegramUserName: {UserNameTelegram27}\n\r StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff27 = null;
                    NameTelegram27 = null;
                    IDTelegram27 = null;
                    UserNameTelegram27 = null;
                    IDStandoff27 = null;
                    Console.WriteLine("Пользователь 27 удален");
                }
                else if (NameSimProfilPlz == "28" || NameSimProfilPlz == IDTelegram28 || NameSimProfilPlz == NameStandoff28 || NameSimProfilPlz == IDStandoff28 || NameSimProfilPlz == NameTelegram28)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff28}\n\r\n TelegramName: {NameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r TelegramUserName: {UserNameTelegram28}\n\r StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff28 = null;
                    NameTelegram28 = null;
                    IDTelegram28 = null;
                    UserNameTelegram28 = null;
                    IDStandoff28 = null;
                    Console.WriteLine("Пользователь 28 удален");
                }
                else if (NameSimProfilPlz == "29" || NameSimProfilPlz == IDTelegram29 || NameSimProfilPlz == NameStandoff29 || NameSimProfilPlz == IDStandoff29 || NameSimProfilPlz == NameTelegram29)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff29}\n\r\n TelegramName: {NameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r TelegramUserName: {UserNameTelegram29}\n\r StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff29 = null;
                    NameTelegram29 = null;
                    IDTelegram29 = null;
                    UserNameTelegram29 = null;
                    IDStandoff29 = null;
                    Console.WriteLine("Пользователь 29 удален");
                }
                else if (NameSimProfilPlz == "30" || NameSimProfilPlz == IDTelegram30 || NameSimProfilPlz == NameStandoff30 || NameSimProfilPlz == IDStandoff30 || NameSimProfilPlz == NameTelegram30)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff30}\n\r\n TelegramName: {NameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r TelegramUserName: {UserNameTelegram30}\n\r StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff30 = null;
                    NameTelegram30 = null;
                    IDTelegram30 = null;
                    UserNameTelegram30 = null;
                    IDStandoff30 = null;
                    Console.WriteLine("Пользователь 30 удален");
                }
                else if (NameSimProfilPlz == "31" || NameSimProfilPlz == IDTelegram31 || NameSimProfilPlz == NameStandoff31 || NameSimProfilPlz == IDStandoff31 || NameSimProfilPlz == NameTelegram31)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff31}\n\r\n TelegramName: {NameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r TelegramUserName: {UserNameTelegram31}\n\r StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff31 = null;
                    NameTelegram31 = null;
                    IDTelegram31 = null;
                    UserNameTelegram31 = null;
                    IDStandoff31 = null;
                    Console.WriteLine("Пользователь 31 удален");
                }
                else if (NameSimProfilPlz == "32" || NameSimProfilPlz == IDTelegram32 || NameSimProfilPlz == NameStandoff32 || NameSimProfilPlz == IDStandoff32 || NameSimProfilPlz == NameTelegram32)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff32}\n\r\n TelegramName: {NameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r TelegramUserName: {UserNameTelegram32}\n\r StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff32 = null;
                    NameTelegram32 = null;
                    IDTelegram32 = null;
                    UserNameTelegram32 = null;
                    IDStandoff32 = null;
                    Console.WriteLine("Пользователь 32 удален");
                }
                else if (NameSimProfilPlz == "33" || NameSimProfilPlz == IDTelegram33 || NameSimProfilPlz == NameStandoff33 || NameSimProfilPlz == IDStandoff33 || NameSimProfilPlz == NameTelegram33)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff33}\n\r\n TelegramName: {NameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r TelegramUserName: {UserNameTelegram33}\n\r StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff33 = null;
                    NameTelegram33 = null;
                    IDTelegram33 = null;
                    UserNameTelegram33 = null;
                    IDStandoff33 = null;
                    Console.WriteLine("Пользователь 33 удален");
                }
                else if (NameSimProfilPlz == "34" || NameSimProfilPlz == IDTelegram34 || NameSimProfilPlz == NameStandoff34 || NameSimProfilPlz == IDStandoff34 || NameSimProfilPlz == NameTelegram34)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff34}\n\r\n TelegramName: {NameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r TelegramUserName: {UserNameTelegram34}\n\r StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff34 = null;
                    NameTelegram34 = null;
                    IDTelegram34 = null;
                    UserNameTelegram34 = null;
                    IDStandoff34 = null;
                    Console.WriteLine("Пользователь 34 удален");
                }
                else if (NameSimProfilPlz == "35" || NameSimProfilPlz == IDTelegram35 || NameSimProfilPlz == NameStandoff35 || NameSimProfilPlz == IDStandoff35 || NameSimProfilPlz == NameTelegram35)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff35}\n\r\n TelegramName: {NameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r TelegramUserName: {UserNameTelegram35}\n\r StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff35 = null;
                    NameTelegram35 = null;
                    IDTelegram35 = null;
                    UserNameTelegram35 = null;
                    IDStandoff35 = null;
                    Console.WriteLine("Пользователь 35 удален");
                }
                else if (NameSimProfilPlz == "36" || NameSimProfilPlz == IDTelegram36 || NameSimProfilPlz == NameStandoff36 || NameSimProfilPlz == IDStandoff36 || NameSimProfilPlz == NameTelegram36)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff36}\n\r\n TelegramName: {NameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r TelegramUserName: {UserNameTelegram36}\n\r StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff36 = null;
                    NameTelegram36 = null;
                    IDTelegram36 = null;
                    UserNameTelegram36 = null;
                    IDStandoff36 = null;
                    Console.WriteLine("Пользователь 36 удален");
                }
                else if (NameSimProfilPlz == "37" || NameSimProfilPlz == IDTelegram37 || NameSimProfilPlz == NameStandoff37 || NameSimProfilPlz == IDStandoff37 || NameSimProfilPlz == NameTelegram37)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff37}\n\r\n TelegramName: {NameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r TelegramUserName: {UserNameTelegram37}\n\r StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff37 = null;
                    NameTelegram37 = null;
                    IDTelegram37 = null;
                    UserNameTelegram37 = null;
                    IDStandoff37 = null;
                    Console.WriteLine("Пользователь 37 удален");
                }
                else if (NameSimProfilPlz == "38" || NameSimProfilPlz == IDTelegram38 || NameSimProfilPlz == NameStandoff38 || NameSimProfilPlz == IDStandoff38 || NameSimProfilPlz == NameTelegram38)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff38}\n\r\n TelegramName: {NameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r TelegramUserName: {UserNameTelegram38}\n\r StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff38 = null;
                    NameTelegram38 = null;
                    IDTelegram38 = null;
                    UserNameTelegram38 = null;
                    IDStandoff38 = null;
                    Console.WriteLine("Пользователь 38 удален");
                }
                else if (NameSimProfilPlz == "39" || NameSimProfilPlz == IDTelegram39 || NameSimProfilPlz == NameStandoff39 || NameSimProfilPlz == IDStandoff39 || NameSimProfilPlz == NameTelegram39)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff39}\n\r\n TelegramName: {NameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r TelegramUserName: {UserNameTelegram39}\n\r StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff39 = null;
                    NameTelegram39 = null;
                    IDTelegram39 = null;
                    UserNameTelegram39 = null;
                    IDStandoff39 = null;
                    Console.WriteLine("Пользователь 39 удален");
                }
                else if (NameSimProfilPlz == "40" || NameSimProfilPlz == IDTelegram40 || NameSimProfilPlz == NameStandoff40 || NameSimProfilPlz == IDStandoff40 || NameSimProfilPlz == NameTelegram40)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff40}\n\r\n TelegramName: {NameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r TelegramUserName: {UserNameTelegram40}\n\r StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff40 = null;
                    NameTelegram40 = null;
                    IDTelegram40 = null;
                    UserNameTelegram40 = null;
                    IDStandoff40 = null;
                    Console.WriteLine("Пользователь 40 удален");
                }
                else if (NameSimProfilPlz == "41" || NameSimProfilPlz == IDTelegram41 || NameSimProfilPlz == NameStandoff41 || NameSimProfilPlz == IDStandoff41 || NameSimProfilPlz == NameTelegram41)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff41}\n\r\n TelegramName: {NameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r TelegramUserName: {UserNameTelegram41}\n\r StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff41 = null;
                    NameTelegram41 = null;
                    IDTelegram41 = null;
                    UserNameTelegram41 = null;
                    IDStandoff41 = null;
                    Console.WriteLine("Пользователь 41 удален");
                }
                else if (NameSimProfilPlz == "42" || NameSimProfilPlz == IDTelegram42 || NameSimProfilPlz == NameStandoff42 || NameSimProfilPlz == IDStandoff42 || NameSimProfilPlz == NameTelegram42)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff42}\n\r\n TelegramName: {NameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r TelegramUserName: {UserNameTelegram42}\n\r StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff42 = null;
                    NameTelegram42 = null;
                    IDTelegram42 = null;
                    UserNameTelegram42 = null;
                    IDStandoff42 = null;
                    Console.WriteLine("Пользователь 42 удален");
                }
                else if (NameSimProfilPlz == "43" || NameSimProfilPlz == IDTelegram43 || NameSimProfilPlz == NameStandoff43 || NameSimProfilPlz == IDStandoff43 || NameSimProfilPlz == NameTelegram43)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff43}\n\r\n TelegramName: {NameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r TelegramUserName: {UserNameTelegram43}\n\r StandoffName: {NameStandoff1}\n\r StandoffID: {IDStandoff43}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff43 = null;
                    NameTelegram43 = null;
                    IDTelegram43 = null;
                    UserNameTelegram43 = null;
                    IDStandoff43 = null;
                    Console.WriteLine("Пользователь 43 удален");
                }
                else if (NameSimProfilPlz == "44" || NameSimProfilPlz == IDTelegram44 || NameSimProfilPlz == NameStandoff44 || NameSimProfilPlz == IDStandoff44 || NameSimProfilPlz == NameTelegram44)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff44}\n\r\n TelegramName: {NameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r TelegramUserName: {UserNameTelegram44}\n\r StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff44 = null;
                    NameTelegram44 = null;
                    IDTelegram44 = null;
                    UserNameTelegram44 = null;
                    IDStandoff44 = null;
                    Console.WriteLine("Пользователь 44 удален");
                }
                else if (NameSimProfilPlz == "45" || NameSimProfilPlz == IDTelegram45 || NameSimProfilPlz == NameStandoff45 || NameSimProfilPlz == IDStandoff45 || NameSimProfilPlz == NameTelegram45)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff45}\n\r\n TelegramName: {NameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r TelegramUserName: {UserNameTelegram45}\n\r StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff45 = null;
                    NameTelegram45 = null;
                    IDTelegram45 = null;
                    UserNameTelegram45 = null;
                    IDStandoff45 = null;
                    Console.WriteLine("Пользователь 45 удален");
                }
                else if (NameSimProfilPlz == "46" || NameSimProfilPlz == IDTelegram46 || NameSimProfilPlz == NameStandoff46 || NameSimProfilPlz == IDStandoff46 || NameSimProfilPlz == NameTelegram46)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff46}\n\r\n TelegramName: {NameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r TelegramUserName: {UserNameTelegram46}\n\r StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff46 = null;
                    NameTelegram46 = null;
                    IDTelegram46 = null;
                    UserNameTelegram46 = null;
                    IDStandoff46 = null;
                    Console.WriteLine("Пользователь 46 удален");
                }
                else if (NameSimProfilPlz == "47" || NameSimProfilPlz == IDTelegram47 || NameSimProfilPlz == NameStandoff47 || NameSimProfilPlz == IDStandoff47 || NameSimProfilPlz == NameTelegram47)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff47}\n\r\n TelegramName: {NameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r TelegramUserName: {UserNameTelegram47}\n\r StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff47 = null;
                    NameTelegram47 = null;
                    IDTelegram47 = null;
                    UserNameTelegram47 = null;
                    IDStandoff47 = null;
                    Console.WriteLine("Пользователь 47 удален");
                }
                else if (NameSimProfilPlz == "48" || NameSimProfilPlz == IDTelegram48 || NameSimProfilPlz == NameStandoff48 || NameSimProfilPlz == IDStandoff48 || NameSimProfilPlz == NameTelegram48)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff48}\n\r\n TelegramName: {NameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r TelegramUserName: {UserNameTelegram48}\n\r StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff48 = null;
                    NameTelegram48 = null;
                    IDTelegram48 = null;
                    UserNameTelegram48 = null;
                    IDStandoff48 = null;
                    Console.WriteLine("Пользователь 48 удален");
                }
                else if (NameSimProfilPlz == "49" || NameSimProfilPlz == IDTelegram49 || NameSimProfilPlz == NameStandoff49 || NameSimProfilPlz == IDStandoff49 || NameSimProfilPlz == NameTelegram49)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff49}\n\r\n TelegramName: {NameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r TelegramUserName: {UserNameTelegram49}\n\r StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff49 = null;
                    NameTelegram49 = null;
                    IDTelegram49 = null;
                    UserNameTelegram49 = null;
                    IDStandoff49 = null;
                    Console.WriteLine("Пользователь 49 удален");
                }
                else if (NameSimProfilPlz == "50" || NameSimProfilPlz == IDTelegram50 || NameSimProfilPlz == NameStandoff50 || NameSimProfilPlz == IDStandoff50 || NameSimProfilPlz == NameTelegram50)
                {
                    AllPlzBlack += $"Пользователь: {NameStandoff50}\n\r\n TelegramName: {NameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r TelegramUserName: {UserNameTelegram50}\n\r StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\rСтатус: исключён\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff50 = null;
                    NameTelegram50 = null;
                    IDTelegram50 = null;
                    UserNameTelegram50 = null;
                    IDStandoff50 = null;
                    Console.WriteLine("Пользователь 50 удален");
                }
                #endregion
            }
            else if (AddS == "Белый" || AddS == "Б" || AddS == "б" || AddS == "Белый список")
            {
                #region Wfite
                if (NameSimProfilPlz == "1" || NameSimProfilPlz == IDTelegram1 || NameSimProfilPlz == IDStandoff1)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff1}\n\r\n TelegramName: {NameTelegram1}\n\r TelegramID: {IDTelegram1}\n\r TelegramUserName: {UserNameTelegram1}\n\r StandoffName: {NameStandoff1}\n\r StandoffID: {IDStandoff1}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff1 = null;
                    NameTelegram1 = null;
                    IDTelegram1 = null;
                    UserNameTelegram1 = null;
                    IDStandoff1 = null;
                    Console.WriteLine("Пользователь 1 удален");
                }
                else if (NameSimProfilPlz == "2" || NameSimProfilPlz == IDTelegram2 || NameSimProfilPlz == NameStandoff2 || NameSimProfilPlz == IDStandoff2 || NameSimProfilPlz == NameTelegram2)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff2}\n\r\n TelegramName: {NameTelegram2}\n\r TelegramID: {IDTelegram2}\n\r TelegramUserName: {UserNameTelegram2}\n\r StandoffName: {NameStandoff2}\n\r StandoffID: {IDStandoff2}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff2 = null;
                    NameTelegram2 = null;
                    IDTelegram2 = null;
                    UserNameTelegram2 = null;
                    IDStandoff2 = null;
                    Console.WriteLine("Пользователь 2 удален");
                }
                else if (NameSimProfilPlz == "3" || NameSimProfilPlz == IDTelegram3 || NameSimProfilPlz == NameStandoff3 || NameSimProfilPlz == IDStandoff3 || NameSimProfilPlz == NameTelegram3)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff3}\n\r\n TelegramName: {NameTelegram3}\n\r TelegramID: {IDTelegram3}\n\r TelegramUserName: {UserNameTelegram3}\n\r StandoffName: {NameStandoff3}\n\r StandoffID: {IDStandoff3}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff3 = null;
                    NameTelegram3 = null;
                    IDTelegram3 = null;
                    UserNameTelegram3 = null;
                    IDStandoff3 = null;
                    Console.WriteLine("Пользователь 3 удален");
                }
                else if (NameSimProfilPlz == "4" || NameSimProfilPlz == IDTelegram4 || NameSimProfilPlz == NameStandoff4 || NameSimProfilPlz == IDStandoff4 || NameSimProfilPlz == NameTelegram4)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff4}\n\r\n TelegramName: {NameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r TelegramUserName: {UserNameTelegram4}\n\r StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff4 = null;
                    NameTelegram4 = null;
                    IDTelegram4 = null;
                    UserNameTelegram4 = null;
                    IDStandoff4 = null;
                    Console.WriteLine("Пользователь 4 удален");
                }
                else if (NameSimProfilPlz == "5" || NameSimProfilPlz == IDTelegram5 || NameSimProfilPlz == NameStandoff5 || NameSimProfilPlz == IDStandoff5 || NameSimProfilPlz == NameTelegram5)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff5}\n\r\n TelegramName: {NameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r TelegramUserName: {UserNameTelegram5}\n\r StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff5 = null;
                    NameTelegram5 = null;
                    IDTelegram5 = null;
                    UserNameTelegram5 = null;
                    IDStandoff5 = null;
                    Console.WriteLine("Пользователь 5 удален");
                }
                else if (NameSimProfilPlz == "6" || NameSimProfilPlz == IDTelegram6 || NameSimProfilPlz == NameStandoff6 || NameSimProfilPlz == IDStandoff6 || NameSimProfilPlz == NameTelegram6)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff6}\n\r\n TelegramName: {NameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r TelegramUserName: {UserNameTelegram6}\n\r StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff6 = null;
                    NameTelegram6 = null;
                    IDTelegram6 = null;
                    UserNameTelegram6 = null;
                    IDStandoff6 = null;
                    Console.WriteLine("Пользователь 6 удален");
                }
                else if (NameSimProfilPlz == "7" || NameSimProfilPlz == IDTelegram7 || NameSimProfilPlz == NameStandoff7 || NameSimProfilPlz == IDStandoff7 || NameSimProfilPlz == NameTelegram7)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff7}\n\r\n TelegramName: {NameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r TelegramUserName: {UserNameTelegram7}\n\r StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff7 = null;
                    NameTelegram7 = null;
                    IDTelegram7 = null;
                    UserNameTelegram7 = null;
                    IDStandoff7 = null;
                    Console.WriteLine("Пользователь 7 удален");
                }
                else if (NameSimProfilPlz == "8" || NameSimProfilPlz == IDTelegram8 || NameSimProfilPlz == NameStandoff8 || NameSimProfilPlz == IDStandoff8 || NameSimProfilPlz == NameTelegram8)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff8}\n\r\n TelegramName: {NameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r TelegramUserName: {UserNameTelegram8}\n\r StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff8 = null;
                    NameTelegram8 = null;
                    IDTelegram8 = null;
                    UserNameTelegram8 = null;
                    IDStandoff8 = null;
                    Console.WriteLine("Пользователь 8 удален");
                }
                else if (NameSimProfilPlz == "9" || NameSimProfilPlz == IDTelegram9 || NameSimProfilPlz == NameStandoff9 || NameSimProfilPlz == IDStandoff9 || NameSimProfilPlz == NameTelegram9)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff9}\n\r\n TelegramName: {NameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r TelegramUserName: {UserNameTelegram9}\n\r StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff9 = null;
                    NameTelegram9 = null;
                    IDTelegram9 = null;
                    UserNameTelegram9 = null;
                    IDStandoff9 = null;
                    Console.WriteLine("Пользователь 9 удален");
                }
                else if (NameSimProfilPlz == "10" || NameSimProfilPlz == IDTelegram10 || NameSimProfilPlz == NameStandoff10 || NameSimProfilPlz == IDStandoff10 || NameSimProfilPlz == NameTelegram10)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff10}\n\r\n TelegramName: {NameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r TelegramUserName: {UserNameTelegram10}\n\r StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff10 = null;
                    NameTelegram10 = null;
                    IDTelegram10 = null;
                    UserNameTelegram10 = null;
                    IDStandoff10 = null;
                    Console.WriteLine("Пользователь 10 удален");
                }
                else if (NameSimProfilPlz == "11" || NameSimProfilPlz == IDTelegram11 || NameSimProfilPlz == NameStandoff11 || NameSimProfilPlz == IDStandoff11 || NameSimProfilPlz == NameTelegram11)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff11}\n\r\n TelegramName: {NameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r TelegramUserName: {UserNameTelegram11}\n\r StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff11 = null;
                    NameTelegram11 = null;
                    IDTelegram11 = null;
                    UserNameTelegram11 = null;
                    IDStandoff11 = null;
                    Console.WriteLine("Пользователь 11 удален");
                }
                else if (NameSimProfilPlz == "12" || NameSimProfilPlz == IDTelegram12 || NameSimProfilPlz == NameStandoff12 || NameSimProfilPlz == IDStandoff12 || NameSimProfilPlz == NameTelegram12)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff12}\n\r\n TelegramName: {NameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r TelegramUserName: {UserNameTelegram12}\n\r StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff12 = null;
                    NameTelegram12 = null;
                    IDTelegram12 = null;
                    UserNameTelegram12 = null;
                    IDStandoff12 = null;
                    Console.WriteLine("Пользователь 12 удален");
                }
                else if (NameSimProfilPlz == "13" || NameSimProfilPlz == IDTelegram13 || NameSimProfilPlz == NameStandoff13 || NameSimProfilPlz == IDStandoff13 || NameSimProfilPlz == NameTelegram13)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff13}\n\r\n TelegramName: {NameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r TelegramUserName: {UserNameTelegram13}\n\r StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff13 = null;
                    NameTelegram13 = null;
                    IDTelegram13 = null;
                    UserNameTelegram13 = null;
                    IDStandoff13 = null;
                    Console.WriteLine("Пользователь 13 удален");
                }
                else if (NameSimProfilPlz == "14" || NameSimProfilPlz == IDTelegram14 || NameSimProfilPlz == NameStandoff14 || NameSimProfilPlz == IDStandoff14 || NameSimProfilPlz == NameTelegram14)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff14}\n\r\n TelegramName: {NameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r TelegramUserName: {UserNameTelegram14}\n\r StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff14 = null;
                    NameTelegram14 = null;
                    IDTelegram14 = null;
                    UserNameTelegram14 = null;
                    IDStandoff14 = null;
                    Console.WriteLine("Пользователь 14 удален");
                }
                else if (NameSimProfilPlz == "15" || NameSimProfilPlz == IDTelegram15 || NameSimProfilPlz == NameStandoff15 || NameSimProfilPlz == IDStandoff15 || NameSimProfilPlz == NameTelegram15)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff15}\n\r\n TelegramName: {NameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r TelegramUserName: {UserNameTelegram15}\n\r StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff15 = null;
                    NameTelegram15 = null;
                    IDTelegram15 = null;
                    UserNameTelegram15 = null;
                    IDStandoff15 = null;
                    Console.WriteLine("Пользователь 15 удален");
                }
                else if (NameSimProfilPlz == "16" || NameSimProfilPlz == IDTelegram16 || NameSimProfilPlz == NameStandoff16 || NameSimProfilPlz == IDStandoff16 || NameSimProfilPlz == NameTelegram16)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff16}\n\r\n TelegramName: {NameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r TelegramUserName: {UserNameTelegram16}\n\r StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff16 = null;
                    NameTelegram16 = null;
                    IDTelegram16 = null;
                    UserNameTelegram16 = null;
                    IDStandoff16 = null;
                    Console.WriteLine("Пользователь 16 удален");
                }
                else if (NameSimProfilPlz == "17" || NameSimProfilPlz == IDTelegram17 || NameSimProfilPlz == NameStandoff17 || NameSimProfilPlz == IDStandoff17 || NameSimProfilPlz == NameTelegram17)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff17}\n\r\n TelegramName: {NameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r TelegramUserName: {UserNameTelegram17}\n\r StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff17 = null;
                    NameTelegram17 = null;
                    IDTelegram17 = null;
                    UserNameTelegram17 = null;
                    IDStandoff17 = null;
                    Console.WriteLine("Пользователь 17 удален");
                }
                else if (NameSimProfilPlz == "18" || NameSimProfilPlz == IDTelegram18 || NameSimProfilPlz == NameStandoff18 || NameSimProfilPlz == IDStandoff18 || NameSimProfilPlz == NameTelegram18)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff18}\n\r\n TelegramName: {NameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r TelegramUserName: {UserNameTelegram18}\n\r StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff18 = null;
                    NameTelegram18 = null;
                    IDTelegram18 = null;
                    UserNameTelegram18 = null;
                    IDStandoff18 = null;
                    Console.WriteLine("Пользователь 18 удален");
                }
                else if (NameSimProfilPlz == "19" || NameSimProfilPlz == IDTelegram19 || NameSimProfilPlz == NameStandoff19 || NameSimProfilPlz == IDStandoff19 || NameSimProfilPlz == NameTelegram19)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff19}\n\r\n TelegramName: {NameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r TelegramUserName: {UserNameTelegram19}\n\r StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff19 = null;
                    NameTelegram19 = null;
                    IDTelegram19 = null;
                    UserNameTelegram19 = null;
                    IDStandoff19 = null;
                    Console.WriteLine("Пользователь 19 удален");
                }
                else if (NameSimProfilPlz == "20" || NameSimProfilPlz == IDTelegram20 || NameSimProfilPlz == NameStandoff20 || NameSimProfilPlz == IDStandoff20 || NameSimProfilPlz == NameTelegram20)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff20}\n\r\n TelegramName: {NameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r TelegramUserName: {UserNameTelegram20}\n\r StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff20 = null;
                    NameTelegram20 = null;
                    IDTelegram20 = null;
                    UserNameTelegram20 = null;
                    IDStandoff20 = null;
                    Console.WriteLine("Пользователь 20 удален");
                }
                else if (NameSimProfilPlz == "21" || NameSimProfilPlz == IDTelegram21 || NameSimProfilPlz == NameStandoff21 || NameSimProfilPlz == IDStandoff21 || NameSimProfilPlz == NameTelegram21)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff21}\n\r\n TelegramName: {NameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r TelegramUserName: {UserNameTelegram21}\n\r StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff21 = null;
                    NameTelegram21 = null;
                    IDTelegram21 = null;
                    UserNameTelegram21 = null;
                    IDStandoff21 = null;
                    Console.WriteLine("Пользователь 21 удален");
                }
                else if (NameSimProfilPlz == "22" || NameSimProfilPlz == IDTelegram22 || NameSimProfilPlz == NameStandoff22 || NameSimProfilPlz == IDStandoff22 || NameSimProfilPlz == NameTelegram22)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff22}\n\r\n TelegramName: {NameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r TelegramUserName: {UserNameTelegram22}\n\r StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff22 = null;
                    NameTelegram22 = null;
                    IDTelegram22 = null;
                    UserNameTelegram22 = null;
                    IDStandoff22 = null;
                    Console.WriteLine("Пользователь 22 удален");
                }
                else if (NameSimProfilPlz == "23" || NameSimProfilPlz == IDTelegram23 || NameSimProfilPlz == NameStandoff23 || NameSimProfilPlz == IDStandoff23 || NameSimProfilPlz == NameTelegram23)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff23}\n\r\n TelegramName: {NameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r TelegramUserName: {UserNameTelegram23}\n\r StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff23 = null;
                    NameTelegram23 = null;
                    IDTelegram23 = null;
                    UserNameTelegram23 = null;
                    IDStandoff23 = null;
                    Console.WriteLine("Пользователь 23 удален");
                }
                else if (NameSimProfilPlz == "24" || NameSimProfilPlz == IDTelegram24 || NameSimProfilPlz == NameStandoff24 || NameSimProfilPlz == IDStandoff24 || NameSimProfilPlz == NameTelegram24)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff24}\n\r\n TelegramName: {NameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r TelegramUserName: {UserNameTelegram24}\n\r StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff24 = null;
                    NameTelegram24 = null;
                    IDTelegram24 = null;
                    UserNameTelegram24 = null;
                    IDStandoff24 = null;
                    Console.WriteLine("Пользователь 24 удален");
                }
                else if (NameSimProfilPlz == "25" || NameSimProfilPlz == IDTelegram25 || NameSimProfilPlz == NameStandoff25 || NameSimProfilPlz == IDStandoff25 || NameSimProfilPlz == NameTelegram25)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff25}\n\r\n TelegramName: {NameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r TelegramUserName: {UserNameTelegram25}\n\r StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff25 = null;
                    NameTelegram25 = null;
                    IDTelegram25 = null;
                    UserNameTelegram25 = null;
                    IDStandoff25 = null;
                    Console.WriteLine("Пользователь 25 удален");
                }
                else if (NameSimProfilPlz == "26" || NameSimProfilPlz == IDTelegram26 || NameSimProfilPlz == NameStandoff26 || NameSimProfilPlz == IDStandoff26 || NameSimProfilPlz == NameTelegram26)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff26}\n\r\n TelegramName: {NameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r TelegramUserName: {UserNameTelegram26}\n\r StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff26 = null;
                    NameTelegram26 = null;
                    IDTelegram26 = null;
                    UserNameTelegram26 = null;
                    IDStandoff26 = null;
                    Console.WriteLine("Пользователь 26 удален");
                }
                else if (NameSimProfilPlz == "27" || NameSimProfilPlz == IDTelegram27 || NameSimProfilPlz == NameStandoff27 || NameSimProfilPlz == IDStandoff27 || NameSimProfilPlz == NameTelegram27)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff27}\n\r\n TelegramName: {NameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r TelegramUserName: {UserNameTelegram27}\n\r StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff27 = null;
                    NameTelegram27 = null;
                    IDTelegram27 = null;
                    UserNameTelegram27 = null;
                    IDStandoff27 = null;
                    Console.WriteLine("Пользователь 27 удален");
                }
                else if (NameSimProfilPlz == "28" || NameSimProfilPlz == IDTelegram28 || NameSimProfilPlz == NameStandoff28 || NameSimProfilPlz == IDStandoff28 || NameSimProfilPlz == NameTelegram28)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff28}\n\r\n TelegramName: {NameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r TelegramUserName: {UserNameTelegram28}\n\r StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff28 = null;
                    NameTelegram28 = null;
                    IDTelegram28 = null;
                    UserNameTelegram28 = null;
                    IDStandoff28 = null;
                    Console.WriteLine("Пользователь 28 удален");
                }
                else if (NameSimProfilPlz == "29" || NameSimProfilPlz == IDTelegram29 || NameSimProfilPlz == NameStandoff29 || NameSimProfilPlz == IDStandoff29 || NameSimProfilPlz == NameTelegram29)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff29}\n\r\n TelegramName: {NameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r TelegramUserName: {UserNameTelegram29}\n\r StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff29 = null;
                    NameTelegram29 = null;
                    IDTelegram29 = null;
                    UserNameTelegram29 = null;
                    IDStandoff29 = null;
                    Console.WriteLine("Пользователь 29 удален");
                }
                else if (NameSimProfilPlz == "30" || NameSimProfilPlz == IDTelegram30 || NameSimProfilPlz == NameStandoff30 || NameSimProfilPlz == IDStandoff30 || NameSimProfilPlz == NameTelegram30)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff30}\n\r\n TelegramName: {NameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r TelegramUserName: {UserNameTelegram30}\n\r StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff30 = null;
                    NameTelegram30 = null;
                    IDTelegram30 = null;
                    UserNameTelegram30 = null;
                    IDStandoff30 = null;
                    Console.WriteLine("Пользователь 30 удален");
                }
                else if (NameSimProfilPlz == "31" || NameSimProfilPlz == IDTelegram31 || NameSimProfilPlz == NameStandoff31 || NameSimProfilPlz == IDStandoff31 || NameSimProfilPlz == NameTelegram31)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff31}\n\r\n TelegramName: {NameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r TelegramUserName: {UserNameTelegram31}\n\r StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff31 = null;
                    NameTelegram31 = null;
                    IDTelegram31 = null;
                    UserNameTelegram31 = null;
                    IDStandoff31 = null;
                    Console.WriteLine("Пользователь 31 удален");
                }
                else if (NameSimProfilPlz == "32" || NameSimProfilPlz == IDTelegram32 || NameSimProfilPlz == NameStandoff32 || NameSimProfilPlz == IDStandoff32 || NameSimProfilPlz == NameTelegram32)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff32}\n\r\n TelegramName: {NameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r TelegramUserName: {UserNameTelegram32}\n\r StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff32 = null;
                    NameTelegram32 = null;
                    IDTelegram32 = null;
                    UserNameTelegram32 = null;
                    IDStandoff32 = null;
                    Console.WriteLine("Пользователь 32 удален");
                }
                else if (NameSimProfilPlz == "33" || NameSimProfilPlz == IDTelegram33 || NameSimProfilPlz == NameStandoff33 || NameSimProfilPlz == IDStandoff33 || NameSimProfilPlz == NameTelegram33)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff33}\n\r\n TelegramName: {NameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r TelegramUserName: {UserNameTelegram33}\n\r StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff33 = null;
                    NameTelegram33 = null;
                    IDTelegram33 = null;
                    UserNameTelegram33 = null;
                    IDStandoff33 = null;
                    Console.WriteLine("Пользователь 33 удален");
                }
                else if (NameSimProfilPlz == "34" || NameSimProfilPlz == IDTelegram34 || NameSimProfilPlz == NameStandoff34 || NameSimProfilPlz == IDStandoff34 || NameSimProfilPlz == NameTelegram34)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff34}\n\r\n TelegramName: {NameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r TelegramUserName: {UserNameTelegram34}\n\r StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff34 = null;
                    NameTelegram34 = null;
                    IDTelegram34 = null;
                    UserNameTelegram34 = null;
                    IDStandoff34 = null;
                    Console.WriteLine("Пользователь 34 удален");
                }
                else if (NameSimProfilPlz == "35" || NameSimProfilPlz == IDTelegram35 || NameSimProfilPlz == NameStandoff35 || NameSimProfilPlz == IDStandoff35 || NameSimProfilPlz == NameTelegram35)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff35}\n\r\n TelegramName: {NameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r TelegramUserName: {UserNameTelegram35}\n\r StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff35 = null;
                    NameTelegram35 = null;
                    IDTelegram35 = null;
                    UserNameTelegram35 = null;
                    IDStandoff35 = null;
                    Console.WriteLine("Пользователь 35 удален");
                }
                else if (NameSimProfilPlz == "36" || NameSimProfilPlz == IDTelegram36 || NameSimProfilPlz == NameStandoff36 || NameSimProfilPlz == IDStandoff36 || NameSimProfilPlz == NameTelegram36)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff36}\n\r\n TelegramName: {NameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r TelegramUserName: {UserNameTelegram36}\n\r StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff36 = null;
                    NameTelegram36 = null;
                    IDTelegram36 = null;
                    UserNameTelegram36 = null;
                    IDStandoff36 = null;
                    Console.WriteLine("Пользователь 36 удален");
                }
                else if (NameSimProfilPlz == "37" || NameSimProfilPlz == IDTelegram37 || NameSimProfilPlz == NameStandoff37 || NameSimProfilPlz == IDStandoff37 || NameSimProfilPlz == NameTelegram37)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff37}\n\r\n TelegramName: {NameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r TelegramUserName: {UserNameTelegram37}\n\r StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff37 = null;
                    NameTelegram37 = null;
                    IDTelegram37 = null;
                    UserNameTelegram37 = null;
                    IDStandoff37 = null;
                    Console.WriteLine("Пользователь 37 удален");
                }
                else if (NameSimProfilPlz == "38" || NameSimProfilPlz == IDTelegram38 || NameSimProfilPlz == NameStandoff38 || NameSimProfilPlz == IDStandoff38 || NameSimProfilPlz == NameTelegram38)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff38}\n\r\n TelegramName: {NameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r TelegramUserName: {UserNameTelegram38}\n\r StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff38 = null;
                    NameTelegram38 = null;
                    IDTelegram38 = null;
                    UserNameTelegram38 = null;
                    IDStandoff38 = null;
                    Console.WriteLine("Пользователь 38 удален");
                }
                else if (NameSimProfilPlz == "39" || NameSimProfilPlz == IDTelegram39 || NameSimProfilPlz == NameStandoff39 || NameSimProfilPlz == IDStandoff39 || NameSimProfilPlz == NameTelegram39)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff39}\n\r\n TelegramName: {NameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r TelegramUserName: {UserNameTelegram39}\n\r StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff39 = null;
                    NameTelegram39 = null;
                    IDTelegram39 = null;
                    UserNameTelegram39 = null;
                    IDStandoff39 = null;
                    Console.WriteLine("Пользователь 39 удален");
                }
                else if (NameSimProfilPlz == "40" || NameSimProfilPlz == IDTelegram40 || NameSimProfilPlz == NameStandoff40 || NameSimProfilPlz == IDStandoff40 || NameSimProfilPlz == NameTelegram40)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff40}\n\r\n TelegramName: {NameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r TelegramUserName: {UserNameTelegram40}\n\r StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff40 = null;
                    NameTelegram40 = null;
                    IDTelegram40 = null;
                    UserNameTelegram40 = null;
                    IDStandoff40 = null;
                    Console.WriteLine("Пользователь 40 удален");
                }
                else if (NameSimProfilPlz == "41" || NameSimProfilPlz == IDTelegram41 || NameSimProfilPlz == NameStandoff41 || NameSimProfilPlz == IDStandoff41 || NameSimProfilPlz == NameTelegram41)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff41}\n\r\n TelegramName: {NameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r TelegramUserName: {UserNameTelegram41}\n\r StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff41 = null;
                    NameTelegram41 = null;
                    IDTelegram41 = null;
                    UserNameTelegram41 = null;
                    IDStandoff41 = null;
                    Console.WriteLine("Пользователь 41 удален");
                }
                else if (NameSimProfilPlz == "42" || NameSimProfilPlz == IDTelegram42 || NameSimProfilPlz == NameStandoff42 || NameSimProfilPlz == IDStandoff42 || NameSimProfilPlz == NameTelegram42)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff42}\n\r\n TelegramName: {NameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r TelegramUserName: {UserNameTelegram42}\n\r StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff42 = null;
                    NameTelegram42 = null;
                    IDTelegram42 = null;
                    UserNameTelegram42 = null;
                    IDStandoff42 = null;
                    Console.WriteLine("Пользователь 42 удален");
                }
                else if (NameSimProfilPlz == "43" || NameSimProfilPlz == IDTelegram43 || NameSimProfilPlz == NameStandoff43 || NameSimProfilPlz == IDStandoff43 || NameSimProfilPlz == NameTelegram43)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff43}\n\r\n TelegramName: {NameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r TelegramUserName: {UserNameTelegram43}\n\r StandoffName: {NameStandoff1}\n\r StandoffID: {IDStandoff43}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff43 = null;
                    NameTelegram43 = null;
                    IDTelegram43 = null;
                    UserNameTelegram43 = null;
                    IDStandoff43 = null;
                    Console.WriteLine("Пользователь 43 удален");
                }
                else if (NameSimProfilPlz == "44" || NameSimProfilPlz == IDTelegram44 || NameSimProfilPlz == NameStandoff44 || NameSimProfilPlz == IDStandoff44 || NameSimProfilPlz == NameTelegram44)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff44}\n\r\n TelegramName: {NameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r TelegramUserName: {UserNameTelegram44}\n\r StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff44 = null;
                    NameTelegram44 = null;
                    IDTelegram44 = null;
                    UserNameTelegram44 = null;
                    IDStandoff44 = null;
                    Console.WriteLine("Пользователь 44 удален");
                }
                else if (NameSimProfilPlz == "45" || NameSimProfilPlz == IDTelegram45 || NameSimProfilPlz == NameStandoff45 || NameSimProfilPlz == IDStandoff45 || NameSimProfilPlz == NameTelegram45)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff45}\n\r\n TelegramName: {NameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r TelegramUserName: {UserNameTelegram45}\n\r StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff45 = null;
                    NameTelegram45 = null;
                    IDTelegram45 = null;
                    UserNameTelegram45 = null;
                    IDStandoff45 = null;
                    Console.WriteLine("Пользователь 45 удален");
                }
                else if (NameSimProfilPlz == "46" || NameSimProfilPlz == IDTelegram46 || NameSimProfilPlz == NameStandoff46 || NameSimProfilPlz == IDStandoff46 || NameSimProfilPlz == NameTelegram46)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff46}\n\r\n TelegramName: {NameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r TelegramUserName: {UserNameTelegram46}\n\r StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff46 = null;
                    NameTelegram46 = null;
                    IDTelegram46 = null;
                    UserNameTelegram46 = null;
                    IDStandoff46 = null;
                    Console.WriteLine("Пользователь 46 удален");
                }
                else if (NameSimProfilPlz == "47" || NameSimProfilPlz == IDTelegram47 || NameSimProfilPlz == NameStandoff47 || NameSimProfilPlz == IDStandoff47 || NameSimProfilPlz == NameTelegram47)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff47}\n\r\n TelegramName: {NameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r TelegramUserName: {UserNameTelegram47}\n\r StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff47 = null;
                    NameTelegram47 = null;
                    IDTelegram47 = null;
                    UserNameTelegram47 = null;
                    IDStandoff47 = null;
                    Console.WriteLine("Пользователь 47 удален");
                }
                else if (NameSimProfilPlz == "48" || NameSimProfilPlz == IDTelegram48 || NameSimProfilPlz == NameStandoff48 || NameSimProfilPlz == IDStandoff48 || NameSimProfilPlz == NameTelegram48)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff48}\n\r\n TelegramName: {NameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r TelegramUserName: {UserNameTelegram48}\n\r StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff48 = null;
                    NameTelegram48 = null;
                    IDTelegram48 = null;
                    UserNameTelegram48 = null;
                    IDStandoff48 = null;
                    Console.WriteLine("Пользователь 48 удален");
                }
                else if (NameSimProfilPlz == "49" || NameSimProfilPlz == IDTelegram49 || NameSimProfilPlz == NameStandoff49 || NameSimProfilPlz == IDStandoff49 || NameSimProfilPlz == NameTelegram49)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff49}\n\r\n TelegramName: {NameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r TelegramUserName: {UserNameTelegram49}\n\r StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff49 = null;
                    NameTelegram49 = null;
                    IDTelegram49 = null;
                    UserNameTelegram49 = null;
                    IDStandoff49 = null;
                    Console.WriteLine("Пользователь 49 удален");
                }
                else if (NameSimProfilPlz == "50" || NameSimProfilPlz == IDTelegram50 || NameSimProfilPlz == NameStandoff50 || NameSimProfilPlz == IDStandoff50 || NameSimProfilPlz == NameTelegram50)
                {
                    AllPlzWhite += $"Пользователь: {NameStandoff50}\n\r\n TelegramName: {NameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r TelegramUserName: {UserNameTelegram50}\n\r StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\rСтатус: ушёл\n\r\n----------------------------------------------------\n\r\n";
                    NameStandoff50 = null;
                    NameTelegram50 = null;
                    IDTelegram50 = null;
                    UserNameTelegram50 = null;
                    IDStandoff50 = null;
                    Console.WriteLine("Пользователь 50 удален");
                }
                #endregion
            }
            else if (AddS == null)
            {
                #region Dell
                if (NameSimProfilPlz == "1" || NameSimProfilPlz == IDTelegram1 || NameSimProfilPlz == IDStandoff1)
                {
                    NameStandoff1 = null;
                    NameTelegram1 = null;
                    IDTelegram1 = null;
                    UserNameTelegram1 = null;
                    IDStandoff1 = null;
                    Console.WriteLine("Пользователь 1 удален");
                }
                else if (NameSimProfilPlz == "2" || NameSimProfilPlz == IDTelegram2 || NameSimProfilPlz == NameStandoff2 || NameSimProfilPlz == IDStandoff2 || NameSimProfilPlz == NameTelegram2)
                {
                    NameStandoff2 = null;
                    NameTelegram2 = null;
                    IDTelegram2 = null;
                    UserNameTelegram2 = null;
                    IDStandoff2 = null;
                    Console.WriteLine("Пользователь 2 удален");
                }
                else if (NameSimProfilPlz == "3" || NameSimProfilPlz == IDTelegram3 || NameSimProfilPlz == NameStandoff3 || NameSimProfilPlz == IDStandoff3 || NameSimProfilPlz == NameTelegram3)
                {
                    NameStandoff3 = null;
                    NameTelegram3 = null;
                    IDTelegram3 = null;
                    UserNameTelegram3 = null;
                    IDStandoff3 = null;
                    Console.WriteLine("Пользователь 3 удален");
                }
                else if (NameSimProfilPlz == "4" || NameSimProfilPlz == IDTelegram4 || NameSimProfilPlz == NameStandoff4 || NameSimProfilPlz == IDStandoff4 || NameSimProfilPlz == NameTelegram4)
                {
                    NameStandoff4 = null;
                    NameTelegram4 = null;
                    IDTelegram4 = null;
                    UserNameTelegram4 = null;
                    IDStandoff4 = null;
                    Console.WriteLine("Пользователь 4 удален");
                }
                else if (NameSimProfilPlz == "5" || NameSimProfilPlz == IDTelegram5 || NameSimProfilPlz == NameStandoff5 || NameSimProfilPlz == IDStandoff5 || NameSimProfilPlz == NameTelegram5)
                {
                    NameStandoff5 = null;
                    NameTelegram5 = null;
                    IDTelegram5 = null;
                    UserNameTelegram5 = null;
                    IDStandoff5 = null;
                    Console.WriteLine("Пользователь 5 удален");
                }
                else if (NameSimProfilPlz == "6" || NameSimProfilPlz == IDTelegram6 || NameSimProfilPlz == NameStandoff6 || NameSimProfilPlz == IDStandoff6 || NameSimProfilPlz == NameTelegram6)
                {
                    NameStandoff6 = null;
                    NameTelegram6 = null;
                    IDTelegram6 = null;
                    UserNameTelegram6 = null;
                    IDStandoff6 = null;
                    Console.WriteLine("Пользователь 6 удален");
                }
                else if (NameSimProfilPlz == "7" || NameSimProfilPlz == IDTelegram7 || NameSimProfilPlz == NameStandoff7 || NameSimProfilPlz == IDStandoff7 || NameSimProfilPlz == NameTelegram7)
                {
                    NameStandoff7 = null;
                    NameTelegram7 = null;
                    IDTelegram7 = null;
                    UserNameTelegram7 = null;
                    IDStandoff7 = null;
                    Console.WriteLine("Пользователь 7 удален");
                }
                else if (NameSimProfilPlz == "8" || NameSimProfilPlz == IDTelegram8 || NameSimProfilPlz == NameStandoff8 || NameSimProfilPlz == IDStandoff8 || NameSimProfilPlz == NameTelegram8)
                {
                    NameStandoff8 = null;
                    NameTelegram8 = null;
                    IDTelegram8 = null;
                    UserNameTelegram8 = null;
                    IDStandoff8 = null;
                    Console.WriteLine("Пользователь 8 удален");
                }
                else if (NameSimProfilPlz == "9" || NameSimProfilPlz == IDTelegram9 || NameSimProfilPlz == NameStandoff9 || NameSimProfilPlz == IDStandoff9 || NameSimProfilPlz == NameTelegram9)
                {
                    NameStandoff9 = null;
                    NameTelegram9 = null;
                    IDTelegram9 = null;
                    UserNameTelegram9 = null;
                    IDStandoff9 = null;
                    Console.WriteLine("Пользователь 9 удален");
                }
                else if (NameSimProfilPlz == "10" || NameSimProfilPlz == IDTelegram10 || NameSimProfilPlz == NameStandoff10 || NameSimProfilPlz == IDStandoff10 || NameSimProfilPlz == NameTelegram10)
                {
                    NameStandoff10 = null;
                    NameTelegram10 = null;
                    IDTelegram10 = null;
                    UserNameTelegram10 = null;
                    IDStandoff10 = null;
                    Console.WriteLine("Пользователь 10 удален");
                }
                else if (NameSimProfilPlz == "11" || NameSimProfilPlz == IDTelegram11 || NameSimProfilPlz == NameStandoff11 || NameSimProfilPlz == IDStandoff11 || NameSimProfilPlz == NameTelegram11)
                {
                    NameStandoff11 = null;
                    NameTelegram11 = null;
                    IDTelegram11 = null;
                    UserNameTelegram11 = null;
                    IDStandoff11 = null;
                    Console.WriteLine("Пользователь 11 удален");
                }
                else if (NameSimProfilPlz == "12" || NameSimProfilPlz == IDTelegram12 || NameSimProfilPlz == NameStandoff12 || NameSimProfilPlz == IDStandoff12 || NameSimProfilPlz == NameTelegram12)
                {
                    NameStandoff12 = null;
                    NameTelegram12 = null;
                    IDTelegram12 = null;
                    UserNameTelegram12 = null;
                    IDStandoff12 = null;
                    Console.WriteLine("Пользователь 12 удален");
                }
                else if (NameSimProfilPlz == "13" || NameSimProfilPlz == IDTelegram13 || NameSimProfilPlz == NameStandoff13 || NameSimProfilPlz == IDStandoff13 || NameSimProfilPlz == NameTelegram13)
                {
                    NameStandoff13 = null;
                    NameTelegram13 = null;
                    IDTelegram13 = null;
                    UserNameTelegram13 = null;
                    IDStandoff13 = null;
                    Console.WriteLine("Пользователь 13 удален");
                }
                else if (NameSimProfilPlz == "14" || NameSimProfilPlz == IDTelegram14 || NameSimProfilPlz == NameStandoff14 || NameSimProfilPlz == IDStandoff14 || NameSimProfilPlz == NameTelegram14)
                {
                    NameStandoff14 = null;
                    NameTelegram14 = null;
                    IDTelegram14 = null;
                    UserNameTelegram14 = null;
                    IDStandoff14 = null;
                    Console.WriteLine("Пользователь 14 удален");
                }
                else if (NameSimProfilPlz == "15" || NameSimProfilPlz == IDTelegram15 || NameSimProfilPlz == NameStandoff15 || NameSimProfilPlz == IDStandoff15 || NameSimProfilPlz == NameTelegram15)
                {
                    NameStandoff15 = null;
                    NameTelegram15 = null;
                    IDTelegram15 = null;
                    UserNameTelegram15 = null;
                    IDStandoff15 = null;
                    Console.WriteLine("Пользователь 15 удален");
                }
                else if (NameSimProfilPlz == "16" || NameSimProfilPlz == IDTelegram16 || NameSimProfilPlz == NameStandoff16 || NameSimProfilPlz == IDStandoff16 || NameSimProfilPlz == NameTelegram16)
                {
                    NameStandoff16 = null;
                    NameTelegram16 = null;
                    IDTelegram16 = null;
                    UserNameTelegram16 = null;
                    IDStandoff16 = null;
                    Console.WriteLine("Пользователь 16 удален");
                }
                else if (NameSimProfilPlz == "17" || NameSimProfilPlz == IDTelegram17 || NameSimProfilPlz == NameStandoff17 || NameSimProfilPlz == IDStandoff17 || NameSimProfilPlz == NameTelegram17)
                {
                    NameStandoff17 = null;
                    NameTelegram17 = null;
                    IDTelegram17 = null;
                    UserNameTelegram17 = null;
                    IDStandoff17 = null;
                    Console.WriteLine("Пользователь 17 удален");
                }
                else if (NameSimProfilPlz == "18" || NameSimProfilPlz == IDTelegram18 || NameSimProfilPlz == NameStandoff18 || NameSimProfilPlz == IDStandoff18 || NameSimProfilPlz == NameTelegram18)
                {
                    NameStandoff18 = null;
                    NameTelegram18 = null;
                    IDTelegram18 = null;
                    UserNameTelegram18 = null;
                    IDStandoff18 = null;
                    Console.WriteLine("Пользователь 18 удален");
                }
                else if (NameSimProfilPlz == "19" || NameSimProfilPlz == IDTelegram19 || NameSimProfilPlz == NameStandoff19 || NameSimProfilPlz == IDStandoff19 || NameSimProfilPlz == NameTelegram19)
                {
                    NameStandoff19 = null;
                    NameTelegram19 = null;
                    IDTelegram19 = null;
                    UserNameTelegram19 = null;
                    IDStandoff19 = null;
                    Console.WriteLine("Пользователь 19 удален");
                }
                else if (NameSimProfilPlz == "20" || NameSimProfilPlz == IDTelegram20 || NameSimProfilPlz == NameStandoff20 || NameSimProfilPlz == IDStandoff20 || NameSimProfilPlz == NameTelegram20)
                {
                    NameStandoff20 = null;
                    NameTelegram20 = null;
                    IDTelegram20 = null;
                    UserNameTelegram20 = null;
                    IDStandoff20 = null;
                    Console.WriteLine("Пользователь 20 удален");
                }
                else if (NameSimProfilPlz == "21" || NameSimProfilPlz == IDTelegram21 || NameSimProfilPlz == NameStandoff21 || NameSimProfilPlz == IDStandoff21 || NameSimProfilPlz == NameTelegram21)
                {
                    NameStandoff21 = null;
                    NameTelegram21 = null;
                    IDTelegram21 = null;
                    UserNameTelegram21 = null;
                    IDStandoff21 = null;
                    Console.WriteLine("Пользователь 21 удален");
                }
                else if (NameSimProfilPlz == "22" || NameSimProfilPlz == IDTelegram22 || NameSimProfilPlz == NameStandoff22 || NameSimProfilPlz == IDStandoff22 || NameSimProfilPlz == NameTelegram22)
                {
                    NameStandoff22 = null;
                    NameTelegram22 = null;
                    IDTelegram22 = null;
                    UserNameTelegram22 = null;
                    IDStandoff22 = null;
                    Console.WriteLine("Пользователь 22 удален");
                }
                else if (NameSimProfilPlz == "23" || NameSimProfilPlz == IDTelegram23 || NameSimProfilPlz == NameStandoff23 || NameSimProfilPlz == IDStandoff23 || NameSimProfilPlz == NameTelegram23)
                {
                    NameStandoff23 = null;
                    NameTelegram23 = null;
                    IDTelegram23 = null;
                    UserNameTelegram23 = null;
                    IDStandoff23 = null;
                    Console.WriteLine("Пользователь 23 удален");
                }
                else if (NameSimProfilPlz == "24" || NameSimProfilPlz == IDTelegram24 || NameSimProfilPlz == NameStandoff24 || NameSimProfilPlz == IDStandoff24 || NameSimProfilPlz == NameTelegram24)
                {
                    NameStandoff24 = null;
                    NameTelegram24 = null;
                    IDTelegram24 = null;
                    UserNameTelegram24 = null;
                    IDStandoff24 = null;
                    Console.WriteLine("Пользователь 24 удален");
                }
                else if (NameSimProfilPlz == "25" || NameSimProfilPlz == IDTelegram25 || NameSimProfilPlz == NameStandoff25 || NameSimProfilPlz == IDStandoff25 || NameSimProfilPlz == NameTelegram25)
                {
                    NameStandoff25 = null;
                    NameTelegram25 = null;
                    IDTelegram25 = null;
                    UserNameTelegram25 = null;
                    IDStandoff25 = null;
                    Console.WriteLine("Пользователь 25 удален");
                }
                else if (NameSimProfilPlz == "26" || NameSimProfilPlz == IDTelegram26 || NameSimProfilPlz == NameStandoff26 || NameSimProfilPlz == IDStandoff26 || NameSimProfilPlz == NameTelegram26)
                {
                    NameStandoff26 = null;
                    NameTelegram26 = null;
                    IDTelegram26 = null;
                    UserNameTelegram26 = null;
                    IDStandoff26 = null;
                    Console.WriteLine("Пользователь 26 удален");
                }
                else if (NameSimProfilPlz == "27" || NameSimProfilPlz == IDTelegram27 || NameSimProfilPlz == NameStandoff27 || NameSimProfilPlz == IDStandoff27 || NameSimProfilPlz == NameTelegram27)
                {
                    NameStandoff27 = null;
                    NameTelegram27 = null;
                    IDTelegram27 = null;
                    UserNameTelegram27 = null;
                    IDStandoff27 = null;
                    Console.WriteLine("Пользователь 27 удален");
                }
                else if (NameSimProfilPlz == "28" || NameSimProfilPlz == IDTelegram28 || NameSimProfilPlz == NameStandoff28 || NameSimProfilPlz == IDStandoff28 || NameSimProfilPlz == NameTelegram28)
                {
                    NameStandoff28 = null;
                    NameTelegram28 = null;
                    IDTelegram28 = null;
                    UserNameTelegram28 = null;
                    IDStandoff28 = null;
                    Console.WriteLine("Пользователь 28 удален");
                }
                else if (NameSimProfilPlz == "29" || NameSimProfilPlz == IDTelegram29 || NameSimProfilPlz == NameStandoff29 || NameSimProfilPlz == IDStandoff29 || NameSimProfilPlz == NameTelegram29)
                {
                    NameStandoff29 = null;
                    NameTelegram29 = null;
                    IDTelegram29 = null;
                    UserNameTelegram29 = null;
                    IDStandoff29 = null;
                    Console.WriteLine("Пользователь 29 удален");
                }
                else if (NameSimProfilPlz == "30" || NameSimProfilPlz == IDTelegram30 || NameSimProfilPlz == NameStandoff30 || NameSimProfilPlz == IDStandoff30 || NameSimProfilPlz == NameTelegram30)
                {
                    NameStandoff30 = null;
                    NameTelegram30 = null;
                    IDTelegram30 = null;
                    UserNameTelegram30 = null;
                    IDStandoff30 = null;
                    Console.WriteLine("Пользователь 30 удален");
                }
                else if (NameSimProfilPlz == "31" || NameSimProfilPlz == IDTelegram31 || NameSimProfilPlz == NameStandoff31 || NameSimProfilPlz == IDStandoff31 || NameSimProfilPlz == NameTelegram31)
                {
                    NameStandoff31 = null;
                    NameTelegram31 = null;
                    IDTelegram31 = null;
                    UserNameTelegram31 = null;
                    IDStandoff31 = null;
                    Console.WriteLine("Пользователь 31 удален");
                }
                else if (NameSimProfilPlz == "32" || NameSimProfilPlz == IDTelegram32 || NameSimProfilPlz == NameStandoff32 || NameSimProfilPlz == IDStandoff32 || NameSimProfilPlz == NameTelegram32)
                {
                    NameStandoff32 = null;
                    NameTelegram32 = null;
                    IDTelegram32 = null;
                    UserNameTelegram32 = null;
                    IDStandoff32 = null;
                    Console.WriteLine("Пользователь 32 удален");
                }
                else if (NameSimProfilPlz == "33" || NameSimProfilPlz == IDTelegram33 || NameSimProfilPlz == NameStandoff33 || NameSimProfilPlz == IDStandoff33 || NameSimProfilPlz == NameTelegram33)
                {
                    NameStandoff33 = null;
                    NameTelegram33 = null;
                    IDTelegram33 = null;
                    UserNameTelegram33 = null;
                    IDStandoff33 = null;
                    Console.WriteLine("Пользователь 33 удален");
                }
                else if (NameSimProfilPlz == "34" || NameSimProfilPlz == IDTelegram34 || NameSimProfilPlz == NameStandoff34 || NameSimProfilPlz == IDStandoff34 || NameSimProfilPlz == NameTelegram34)
                {
                    NameStandoff34 = null;
                    NameTelegram34 = null;
                    IDTelegram34 = null;
                    UserNameTelegram34 = null;
                    IDStandoff34 = null;
                    Console.WriteLine("Пользователь 34 удален");
                }
                else if (NameSimProfilPlz == "35" || NameSimProfilPlz == IDTelegram35 || NameSimProfilPlz == NameStandoff35 || NameSimProfilPlz == IDStandoff35 || NameSimProfilPlz == NameTelegram35)
                {
                    NameStandoff35 = null;
                    NameTelegram35 = null;
                    IDTelegram35 = null;
                    UserNameTelegram35 = null;
                    IDStandoff35 = null;
                    Console.WriteLine("Пользователь 35 удален");
                }
                else if (NameSimProfilPlz == "36" || NameSimProfilPlz == IDTelegram36 || NameSimProfilPlz == NameStandoff36 || NameSimProfilPlz == IDStandoff36 || NameSimProfilPlz == NameTelegram36)
                {
                    NameStandoff36 = null;
                    NameTelegram36 = null;
                    IDTelegram36 = null;
                    UserNameTelegram36 = null;
                    IDStandoff36 = null;
                    Console.WriteLine("Пользователь 36 удален");
                }
                else if (NameSimProfilPlz == "37" || NameSimProfilPlz == IDTelegram37 || NameSimProfilPlz == NameStandoff37 || NameSimProfilPlz == IDStandoff37 || NameSimProfilPlz == NameTelegram37)
                {
                    NameStandoff37 = null;
                    NameTelegram37 = null;
                    IDTelegram37 = null;
                    UserNameTelegram37 = null;
                    IDStandoff37 = null;
                    Console.WriteLine("Пользователь 37 удален");
                }
                else if (NameSimProfilPlz == "38" || NameSimProfilPlz == IDTelegram38 || NameSimProfilPlz == NameStandoff38 || NameSimProfilPlz == IDStandoff38 || NameSimProfilPlz == NameTelegram38)
                {
                    NameStandoff38 = null;
                    NameTelegram38 = null;
                    IDTelegram38 = null;
                    UserNameTelegram38 = null;
                    IDStandoff38 = null;
                    Console.WriteLine("Пользователь 38 удален");
                }
                else if (NameSimProfilPlz == "39" || NameSimProfilPlz == IDTelegram39 || NameSimProfilPlz == NameStandoff39 || NameSimProfilPlz == IDStandoff39 || NameSimProfilPlz == NameTelegram39)
                {
                    NameStandoff39 = null;
                    NameTelegram39 = null;
                    IDTelegram39 = null;
                    UserNameTelegram39 = null;
                    IDStandoff39 = null;
                    Console.WriteLine("Пользователь 39 удален");
                }
                else if (NameSimProfilPlz == "40" || NameSimProfilPlz == IDTelegram40 || NameSimProfilPlz == NameStandoff40 || NameSimProfilPlz == IDStandoff40 || NameSimProfilPlz == NameTelegram40)
                {
                    NameStandoff40 = null;
                    NameTelegram40 = null;
                    IDTelegram40 = null;
                    UserNameTelegram40 = null;
                    IDStandoff40 = null;
                    Console.WriteLine("Пользователь 40 удален");
                }
                else if (NameSimProfilPlz == "41" || NameSimProfilPlz == IDTelegram41 || NameSimProfilPlz == NameStandoff41 || NameSimProfilPlz == IDStandoff41 || NameSimProfilPlz == NameTelegram41)
                {
                    NameStandoff41 = null;
                    NameTelegram41 = null;
                    IDTelegram41 = null;
                    UserNameTelegram41 = null;
                    IDStandoff41 = null;
                    Console.WriteLine("Пользователь 41 удален");
                }
                else if (NameSimProfilPlz == "42" || NameSimProfilPlz == IDTelegram42 || NameSimProfilPlz == NameStandoff42 || NameSimProfilPlz == IDStandoff42 || NameSimProfilPlz == NameTelegram42)
                {
                    NameStandoff42 = null;
                    NameTelegram42 = null;
                    IDTelegram42 = null;
                    UserNameTelegram42 = null;
                    IDStandoff42 = null;
                    Console.WriteLine("Пользователь 42 удален");
                }
                else if (NameSimProfilPlz == "43" || NameSimProfilPlz == IDTelegram43 || NameSimProfilPlz == NameStandoff43 || NameSimProfilPlz == IDStandoff43 || NameSimProfilPlz == NameTelegram43)
                {
                    NameStandoff43 = null;
                    NameTelegram43 = null;
                    IDTelegram43 = null;
                    UserNameTelegram43 = null;
                    IDStandoff43 = null;
                    Console.WriteLine("Пользователь 43 удален");
                }
                else if (NameSimProfilPlz == "44" || NameSimProfilPlz == IDTelegram44 || NameSimProfilPlz == NameStandoff44 || NameSimProfilPlz == IDStandoff44 || NameSimProfilPlz == NameTelegram44)
                {
                    NameStandoff44 = null;
                    NameTelegram44 = null;
                    IDTelegram44 = null;
                    UserNameTelegram44 = null;
                    IDStandoff44 = null;
                    Console.WriteLine("Пользователь 44 удален");
                }
                else if (NameSimProfilPlz == "45" || NameSimProfilPlz == IDTelegram45 || NameSimProfilPlz == NameStandoff45 || NameSimProfilPlz == IDStandoff45 || NameSimProfilPlz == NameTelegram45)
                {
                    NameStandoff45 = null;
                    NameTelegram45 = null;
                    IDTelegram45 = null;
                    UserNameTelegram45 = null;
                    IDStandoff45 = null;
                    Console.WriteLine("Пользователь 45 удален");
                }
                else if (NameSimProfilPlz == "46" || NameSimProfilPlz == IDTelegram46 || NameSimProfilPlz == NameStandoff46 || NameSimProfilPlz == IDStandoff46 || NameSimProfilPlz == NameTelegram46)
                {
                    NameStandoff46 = null;
                    NameTelegram46 = null;
                    IDTelegram46 = null;
                    UserNameTelegram46 = null;
                    IDStandoff46 = null;
                    Console.WriteLine("Пользователь 46 удален");
                }
                else if (NameSimProfilPlz == "47" || NameSimProfilPlz == IDTelegram47 || NameSimProfilPlz == NameStandoff47 || NameSimProfilPlz == IDStandoff47 || NameSimProfilPlz == NameTelegram47)
                {
                    NameStandoff47 = null;
                    NameTelegram47 = null;
                    IDTelegram47 = null;
                    UserNameTelegram47 = null;
                    IDStandoff47 = null;
                    Console.WriteLine("Пользователь 47 удален");
                }
                else if (NameSimProfilPlz == "48" || NameSimProfilPlz == IDTelegram48 || NameSimProfilPlz == NameStandoff48 || NameSimProfilPlz == IDStandoff48 || NameSimProfilPlz == NameTelegram48)
                {
                    NameStandoff48 = null;
                    NameTelegram48 = null;
                    IDTelegram48 = null;
                    UserNameTelegram48 = null;
                    IDStandoff48 = null;
                    Console.WriteLine("Пользователь 48 удален");
                }
                else if (NameSimProfilPlz == "49" || NameSimProfilPlz == IDTelegram49 || NameSimProfilPlz == NameStandoff49 || NameSimProfilPlz == IDStandoff49 || NameSimProfilPlz == NameTelegram49)
                {
                    NameStandoff49 = null;
                    NameTelegram49 = null;
                    IDTelegram49 = null;
                    UserNameTelegram49 = null;
                    IDStandoff49 = null;
                    Console.WriteLine("Пользователь 49 удален");
                }
                else if (NameSimProfilPlz == "50" || NameSimProfilPlz == IDTelegram50 || NameSimProfilPlz == NameStandoff50 || NameSimProfilPlz == IDStandoff50 || NameSimProfilPlz == NameTelegram50)
                {
                    NameStandoff50 = null;
                    NameTelegram50 = null;
                    IDTelegram50 = null;
                    UserNameTelegram50 = null;
                    IDStandoff50 = null;
                    Console.WriteLine("Пользователь 50 удален");
                }
                #endregion
            }
            else
            {
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Удаление отменино.");
            }
        }
        #endregion
        //Удаление пользователя администратором.

        #region AddProfilEsport

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AddProfilEsport)]
        public static async Task AddProfilEsport(ITelegramBotClient botClient, Update update)
        {
            var AddProfilEsportYes = new InlineCallback("Подтвердить", PRHeadlers.AddProfilEsportYes);
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(AddProfilEsportYes);
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Подтвердите добавление пользователя в основной состав.", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AddProfilEsportYes)]
        public static async Task AddProfilEsportYes(ITelegramBotClient botClient, Update update)
        {
            #region Esport
            if (NameSimProfilPlz == "1" || NameSimProfilPlz == IDTelegram1 || NameSimProfilPlz == IDStandoff1)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff1}\n\r\n TelegramName: {NameTelegram1}\n\r TelegramID: {IDTelegram1}\n\r TelegramUserName: {UserNameTelegram1}\n\r StandoffName: {NameStandoff1}\n\r StandoffID: {IDStandoff1}\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (NameSimProfilPlz == "2" || NameSimProfilPlz == IDTelegram2 || NameSimProfilPlz == NameStandoff2 || NameSimProfilPlz == IDStandoff2 || NameSimProfilPlz == NameTelegram2)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff2}\n\r\n TelegramName: {NameTelegram2}\n\r TelegramID: {IDTelegram2}\n\r TelegramUserName: {UserNameTelegram2}\n\r StandoffName: {NameStandoff2}\n\r StandoffID: {IDStandoff2}\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (NameSimProfilPlz == "3" || NameSimProfilPlz == IDTelegram3 || NameSimProfilPlz == NameStandoff3 || NameSimProfilPlz == IDStandoff3 || NameSimProfilPlz == NameTelegram3)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff3}\n\r\n TelegramName: {NameTelegram3}\n\r TelegramID: {IDTelegram3}\n\r TelegramUserName: {UserNameTelegram3}\n\r StandoffName: {NameStandoff3}\n\r StandoffID: {IDStandoff3}\n\r\n----------------------------------------------------\n\r\n";
            }
            else if (NameSimProfilPlz == "4" || NameSimProfilPlz == IDTelegram4 || NameSimProfilPlz == NameStandoff4 || NameSimProfilPlz == IDStandoff4 || NameSimProfilPlz == NameTelegram4)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff4}\n\r\n TelegramName: {NameTelegram4}\n\r TelegramID: {IDTelegram4}\n\r TelegramUserName: {UserNameTelegram4}\n\r StandoffName: {NameStandoff4}\n\r StandoffID: {IDStandoff4}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "5" || NameSimProfilPlz == IDTelegram5 || NameSimProfilPlz == NameStandoff5 || NameSimProfilPlz == IDStandoff5 || NameSimProfilPlz == NameTelegram5)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff5}\n\r\n TelegramName: {NameTelegram5}\n\r TelegramID: {IDTelegram5}\n\r TelegramUserName: {UserNameTelegram5}\n\r StandoffName: {NameStandoff5}\n\r StandoffID: {IDStandoff5}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "6" || NameSimProfilPlz == IDTelegram6 || NameSimProfilPlz == NameStandoff6 || NameSimProfilPlz == IDStandoff6 || NameSimProfilPlz == NameTelegram6)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff6}\n\r\n TelegramName: {NameTelegram6}\n\r TelegramID: {IDTelegram6}\n\r TelegramUserName: {UserNameTelegram6}\n\r StandoffName: {NameStandoff6}\n\r StandoffID: {IDStandoff6}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "7" || NameSimProfilPlz == IDTelegram7 || NameSimProfilPlz == NameStandoff7 || NameSimProfilPlz == IDStandoff7 || NameSimProfilPlz == NameTelegram7)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff7}\n\r\n TelegramName: {NameTelegram7}\n\r TelegramID: {IDTelegram7}\n\r TelegramUserName: {UserNameTelegram7}\n\r StandoffName: {NameStandoff7}\n\r StandoffID: {IDStandoff7}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "8" || NameSimProfilPlz == IDTelegram8 || NameSimProfilPlz == NameStandoff8 || NameSimProfilPlz == IDStandoff8 || NameSimProfilPlz == NameTelegram8)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff8}\n\r\n TelegramName: {NameTelegram8}\n\r TelegramID: {IDTelegram8}\n\r TelegramUserName: {UserNameTelegram8}\n\r StandoffName: {NameStandoff8}\n\r StandoffID: {IDStandoff8}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "9" || NameSimProfilPlz == IDTelegram9 || NameSimProfilPlz == NameStandoff9 || NameSimProfilPlz == IDStandoff9 || NameSimProfilPlz == NameTelegram9)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff9}\n\r\n TelegramName: {NameTelegram9}\n\r TelegramID: {IDTelegram9}\n\r TelegramUserName: {UserNameTelegram9}\n\r StandoffName: {NameStandoff9}\n\r StandoffID: {IDStandoff9}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "10" || NameSimProfilPlz == IDTelegram10 || NameSimProfilPlz == NameStandoff10 || NameSimProfilPlz == IDStandoff10 || NameSimProfilPlz == NameTelegram10)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff10}\n\r\n TelegramName: {NameTelegram10}\n\r TelegramID: {IDTelegram10}\n\r TelegramUserName: {UserNameTelegram10}\n\r StandoffName: {NameStandoff10}\n\r StandoffID: {IDStandoff10}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "11" || NameSimProfilPlz == IDTelegram11 || NameSimProfilPlz == NameStandoff11 || NameSimProfilPlz == IDStandoff11 || NameSimProfilPlz == NameTelegram11)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff11}\n\r\n TelegramName: {NameTelegram11}\n\r TelegramID: {IDTelegram11}\n\r TelegramUserName: {UserNameTelegram11}\n\r StandoffName: {NameStandoff11}\n\r StandoffID: {IDStandoff11}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "12" || NameSimProfilPlz == IDTelegram12 || NameSimProfilPlz == NameStandoff12 || NameSimProfilPlz == IDStandoff12 || NameSimProfilPlz == NameTelegram12)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff12}\n\r\n TelegramName: {NameTelegram12}\n\r TelegramID: {IDTelegram12}\n\r TelegramUserName: {UserNameTelegram12}\n\r StandoffName: {NameStandoff12}\n\r StandoffID: {IDStandoff12}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "13" || NameSimProfilPlz == IDTelegram13 || NameSimProfilPlz == NameStandoff13 || NameSimProfilPlz == IDStandoff13 || NameSimProfilPlz == NameTelegram13)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff13}\n\r\n TelegramName: {NameTelegram13}\n\r TelegramID: {IDTelegram13}\n\r TelegramUserName: {UserNameTelegram13}\n\r StandoffName: {NameStandoff13}\n\r StandoffID: {IDStandoff13}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "14" || NameSimProfilPlz == IDTelegram14 || NameSimProfilPlz == NameStandoff14 || NameSimProfilPlz == IDStandoff14 || NameSimProfilPlz == NameTelegram14)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff14}\n\r\n TelegramName: {NameTelegram14}\n\r TelegramID: {IDTelegram14}\n\r TelegramUserName: {UserNameTelegram14}\n\r StandoffName: {NameStandoff14}\n\r StandoffID: {IDStandoff14}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "15" || NameSimProfilPlz == IDTelegram15 || NameSimProfilPlz == NameStandoff15 || NameSimProfilPlz == IDStandoff15 || NameSimProfilPlz == NameTelegram15)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff15}\n\r\n TelegramName: {NameTelegram15}\n\r TelegramID: {IDTelegram15}\n\r TelegramUserName: {UserNameTelegram15}\n\r StandoffName: {NameStandoff15}\n\r StandoffID: {IDStandoff15}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "16" || NameSimProfilPlz == IDTelegram16 || NameSimProfilPlz == NameStandoff16 || NameSimProfilPlz == IDStandoff16 || NameSimProfilPlz == NameTelegram16)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff16}\n\r\n TelegramName: {NameTelegram16}\n\r TelegramID: {IDTelegram16}\n\r TelegramUserName: {UserNameTelegram16}\n\r StandoffName: {NameStandoff16}\n\r StandoffID: {IDStandoff16}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "17" || NameSimProfilPlz == IDTelegram17 || NameSimProfilPlz == NameStandoff17 || NameSimProfilPlz == IDStandoff17 || NameSimProfilPlz == NameTelegram17)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff17}\n\r\n TelegramName: {NameTelegram17}\n\r TelegramID: {IDTelegram17}\n\r TelegramUserName: {UserNameTelegram17}\n\r StandoffName: {NameStandoff17}\n\r StandoffID: {IDStandoff17}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "18" || NameSimProfilPlz == IDTelegram18 || NameSimProfilPlz == NameStandoff18 || NameSimProfilPlz == IDStandoff18 || NameSimProfilPlz == NameTelegram18)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff18}\n\r\n TelegramName: {NameTelegram18}\n\r TelegramID: {IDTelegram18}\n\r TelegramUserName: {UserNameTelegram18}\n\r StandoffName: {NameStandoff18}\n\r StandoffID: {IDStandoff18}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "19" || NameSimProfilPlz == IDTelegram19 || NameSimProfilPlz == NameStandoff19 || NameSimProfilPlz == IDStandoff19 || NameSimProfilPlz == NameTelegram19)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff19}\n\r\n TelegramName: {NameTelegram19}\n\r TelegramID: {IDTelegram19}\n\r TelegramUserName: {UserNameTelegram19}\n\r StandoffName: {NameStandoff19}\n\r StandoffID: {IDStandoff19}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "20" || NameSimProfilPlz == IDTelegram20 || NameSimProfilPlz == NameStandoff20 || NameSimProfilPlz == IDStandoff20 || NameSimProfilPlz == NameTelegram20)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff20}\n\r\n TelegramName: {NameTelegram20}\n\r TelegramID: {IDTelegram20}\n\r TelegramUserName: {UserNameTelegram20}\n\r StandoffName: {NameStandoff20}\n\r StandoffID: {IDStandoff20}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "21" || NameSimProfilPlz == IDTelegram21 || NameSimProfilPlz == NameStandoff21 || NameSimProfilPlz == IDStandoff21 || NameSimProfilPlz == NameTelegram21)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff21}\n\r\n TelegramName: {NameTelegram21}\n\r TelegramID: {IDTelegram21}\n\r TelegramUserName: {UserNameTelegram21}\n\r StandoffName: {NameStandoff21}\n\r StandoffID: {IDStandoff21}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "22" || NameSimProfilPlz == IDTelegram22 || NameSimProfilPlz == NameStandoff22 || NameSimProfilPlz == IDStandoff22 || NameSimProfilPlz == NameTelegram22)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff22}\n\r\n TelegramName: {NameTelegram22}\n\r TelegramID: {IDTelegram22}\n\r TelegramUserName: {UserNameTelegram22}\n\r StandoffName: {NameStandoff22}\n\r StandoffID: {IDStandoff22}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "23" || NameSimProfilPlz == IDTelegram23 || NameSimProfilPlz == NameStandoff23 || NameSimProfilPlz == IDStandoff23 || NameSimProfilPlz == NameTelegram23)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff23}\n\r\n TelegramName: {NameTelegram23}\n\r TelegramID: {IDTelegram23}\n\r TelegramUserName: {UserNameTelegram23}\n\r StandoffName: {NameStandoff23}\n\r StandoffID: {IDStandoff23}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "24" || NameSimProfilPlz == IDTelegram24 || NameSimProfilPlz == NameStandoff24 || NameSimProfilPlz == IDStandoff24 || NameSimProfilPlz == NameTelegram24)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff24}\n\r\n TelegramName: {NameTelegram24}\n\r TelegramID: {IDTelegram24}\n\r TelegramUserName: {UserNameTelegram24}\n\r StandoffName: {NameStandoff24}\n\r StandoffID: {IDStandoff24}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "25" || NameSimProfilPlz == IDTelegram25 || NameSimProfilPlz == NameStandoff25 || NameSimProfilPlz == IDStandoff25 || NameSimProfilPlz == NameTelegram25)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff25}\n\r\n TelegramName: {NameTelegram25}\n\r TelegramID: {IDTelegram25}\n\r TelegramUserName: {UserNameTelegram25}\n\r StandoffName: {NameStandoff25}\n\r StandoffID: {IDStandoff25}n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "26" || NameSimProfilPlz == IDTelegram26 || NameSimProfilPlz == NameStandoff26 || NameSimProfilPlz == IDStandoff26 || NameSimProfilPlz == NameTelegram26)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff26}\n\r\n TelegramName: {NameTelegram26}\n\r TelegramID: {IDTelegram26}\n\r TelegramUserName: {UserNameTelegram26}\n\r StandoffName: {NameStandoff26}\n\r StandoffID: {IDStandoff26}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "27" || NameSimProfilPlz == IDTelegram27 || NameSimProfilPlz == NameStandoff27 || NameSimProfilPlz == IDStandoff27 || NameSimProfilPlz == NameTelegram27)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff27}\n\r\n TelegramName: {NameTelegram27}\n\r TelegramID: {IDTelegram27}\n\r TelegramUserName: {UserNameTelegram27}\n\r StandoffName: {NameStandoff27}\n\r StandoffID: {IDStandoff27}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "28" || NameSimProfilPlz == IDTelegram28 || NameSimProfilPlz == NameStandoff28 || NameSimProfilPlz == IDStandoff28 || NameSimProfilPlz == NameTelegram28)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff28}\n\r\n TelegramName: {NameTelegram28}\n\r TelegramID: {IDTelegram28}\n\r TelegramUserName: {UserNameTelegram28}\n\r StandoffName: {NameStandoff28}\n\r StandoffID: {IDStandoff28}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "29" || NameSimProfilPlz == IDTelegram29 || NameSimProfilPlz == NameStandoff29 || NameSimProfilPlz == IDStandoff29 || NameSimProfilPlz == NameTelegram29)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff29}\n\r\n TelegramName: {NameTelegram29}\n\r TelegramID: {IDTelegram29}\n\r TelegramUserName: {UserNameTelegram29}\n\r StandoffName: {NameStandoff29}\n\r StandoffID: {IDStandoff29}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "30" || NameSimProfilPlz == IDTelegram30 || NameSimProfilPlz == NameStandoff30 || NameSimProfilPlz == IDStandoff30 || NameSimProfilPlz == NameTelegram30)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff30}\n\r\n TelegramName: {NameTelegram30}\n\r TelegramID: {IDTelegram30}\n\r TelegramUserName: {UserNameTelegram30}\n\r StandoffName: {NameStandoff30}\n\r StandoffID: {IDStandoff30}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "31" || NameSimProfilPlz == IDTelegram31 || NameSimProfilPlz == NameStandoff31 || NameSimProfilPlz == IDStandoff31 || NameSimProfilPlz == NameTelegram31)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff31}\n\r\n TelegramName: {NameTelegram31}\n\r TelegramID: {IDTelegram31}\n\r TelegramUserName: {UserNameTelegram31}\n\r StandoffName: {NameStandoff31}\n\r StandoffID: {IDStandoff31}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "32" || NameSimProfilPlz == IDTelegram32 || NameSimProfilPlz == NameStandoff32 || NameSimProfilPlz == IDStandoff32 || NameSimProfilPlz == NameTelegram32)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff32}\n\r\n TelegramName: {NameTelegram32}\n\r TelegramID: {IDTelegram32}\n\r TelegramUserName: {UserNameTelegram32}\n\r StandoffName: {NameStandoff32}\n\r StandoffID: {IDStandoff32}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "33" || NameSimProfilPlz == IDTelegram33 || NameSimProfilPlz == NameStandoff33 || NameSimProfilPlz == IDStandoff33 || NameSimProfilPlz == NameTelegram33)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff33}\n\r\n TelegramName: {NameTelegram33}\n\r TelegramID: {IDTelegram33}\n\r TelegramUserName: {UserNameTelegram33}\n\r StandoffName: {NameStandoff33}\n\r StandoffID: {IDStandoff33}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "34" || NameSimProfilPlz == IDTelegram34 || NameSimProfilPlz == NameStandoff34 || NameSimProfilPlz == IDStandoff34 || NameSimProfilPlz == NameTelegram34)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff34}\n\r\n TelegramName: {NameTelegram34}\n\r TelegramID: {IDTelegram34}\n\r TelegramUserName: {UserNameTelegram34}\n\r StandoffName: {NameStandoff34}\n\r StandoffID: {IDStandoff34}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "35" || NameSimProfilPlz == IDTelegram35 || NameSimProfilPlz == NameStandoff35 || NameSimProfilPlz == IDStandoff35 || NameSimProfilPlz == NameTelegram35)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff35}\n\r\n TelegramName: {NameTelegram35}\n\r TelegramID: {IDTelegram35}\n\r TelegramUserName: {UserNameTelegram35}\n\r StandoffName: {NameStandoff35}\n\r StandoffID: {IDStandoff35}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "36" || NameSimProfilPlz == IDTelegram36 || NameSimProfilPlz == NameStandoff36 || NameSimProfilPlz == IDStandoff36 || NameSimProfilPlz == NameTelegram36)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff36}\n\r\n TelegramName: {NameTelegram36}\n\r TelegramID: {IDTelegram36}\n\r TelegramUserName: {UserNameTelegram36}\n\r StandoffName: {NameStandoff36}\n\r StandoffID: {IDStandoff36}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "37" || NameSimProfilPlz == IDTelegram37 || NameSimProfilPlz == NameStandoff37 || NameSimProfilPlz == IDStandoff37 || NameSimProfilPlz == NameTelegram37)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff37}\n\r\n TelegramName: {NameTelegram37}\n\r TelegramID: {IDTelegram37}\n\r TelegramUserName: {UserNameTelegram37}\n\r StandoffName: {NameStandoff37}\n\r StandoffID: {IDStandoff37}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "38" || NameSimProfilPlz == IDTelegram38 || NameSimProfilPlz == NameStandoff38 || NameSimProfilPlz == IDStandoff38 || NameSimProfilPlz == NameTelegram38)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff38}\n\r\n TelegramName: {NameTelegram38}\n\r TelegramID: {IDTelegram38}\n\r TelegramUserName: {UserNameTelegram38}\n\r StandoffName: {NameStandoff38}\n\r StandoffID: {IDStandoff38}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "39" || NameSimProfilPlz == IDTelegram39 || NameSimProfilPlz == NameStandoff39 || NameSimProfilPlz == IDStandoff39 || NameSimProfilPlz == NameTelegram39)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff39}\n\r\n TelegramName: {NameTelegram39}\n\r TelegramID: {IDTelegram39}\n\r TelegramUserName: {UserNameTelegram39}\n\r StandoffName: {NameStandoff39}\n\r StandoffID: {IDStandoff39}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "40" || NameSimProfilPlz == IDTelegram40 || NameSimProfilPlz == NameStandoff40 || NameSimProfilPlz == IDStandoff40 || NameSimProfilPlz == NameTelegram40)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff40}\n\r\n TelegramName: {NameTelegram40}\n\r TelegramID: {IDTelegram40}\n\r TelegramUserName: {UserNameTelegram40}\n\r StandoffName: {NameStandoff40}\n\r StandoffID: {IDStandoff40}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "41" || NameSimProfilPlz == IDTelegram41 || NameSimProfilPlz == NameStandoff41 || NameSimProfilPlz == IDStandoff41 || NameSimProfilPlz == NameTelegram41)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff41}\n\r\n TelegramName: {NameTelegram41}\n\r TelegramID: {IDTelegram41}\n\r TelegramUserName: {UserNameTelegram41}\n\r StandoffName: {NameStandoff41}\n\r StandoffID: {IDStandoff41}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "42" || NameSimProfilPlz == IDTelegram42 || NameSimProfilPlz == NameStandoff42 || NameSimProfilPlz == IDStandoff42 || NameSimProfilPlz == NameTelegram42)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff42}\n\r\n TelegramName: {NameTelegram42}\n\r TelegramID: {IDTelegram42}\n\r TelegramUserName: {UserNameTelegram42}\n\r StandoffName: {NameStandoff42}\n\r StandoffID: {IDStandoff42}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "43" || NameSimProfilPlz == IDTelegram43 || NameSimProfilPlz == NameStandoff43 || NameSimProfilPlz == IDStandoff43 || NameSimProfilPlz == NameTelegram43)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff43}\n\r\n TelegramName: {NameTelegram43}\n\r TelegramID: {IDTelegram43}\n\r TelegramUserName: {UserNameTelegram43}\n\r StandoffName: {NameStandoff1}\n\r StandoffID: {IDStandoff43}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "44" || NameSimProfilPlz == IDTelegram44 || NameSimProfilPlz == NameStandoff44 || NameSimProfilPlz == IDStandoff44 || NameSimProfilPlz == NameTelegram44)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff44}\n\r\n TelegramName: {NameTelegram44}\n\r TelegramID: {IDTelegram44}\n\r TelegramUserName: {UserNameTelegram44}\n\r StandoffName: {NameStandoff44}\n\r StandoffID: {IDStandoff44}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "45" || NameSimProfilPlz == IDTelegram45 || NameSimProfilPlz == NameStandoff45 || NameSimProfilPlz == IDStandoff45 || NameSimProfilPlz == NameTelegram45)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff45}\n\r\n TelegramName: {NameTelegram45}\n\r TelegramID: {IDTelegram45}\n\r TelegramUserName: {UserNameTelegram45}\n\r StandoffName: {NameStandoff45}\n\r StandoffID: {IDStandoff45}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "46" || NameSimProfilPlz == IDTelegram46 || NameSimProfilPlz == NameStandoff46 || NameSimProfilPlz == IDStandoff46 || NameSimProfilPlz == NameTelegram46)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff46}\n\r\n TelegramName: {NameTelegram46}\n\r TelegramID: {IDTelegram46}\n\r TelegramUserName: {UserNameTelegram46}\n\r StandoffName: {NameStandoff46}\n\r StandoffID: {IDStandoff46}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "47" || NameSimProfilPlz == IDTelegram47 || NameSimProfilPlz == NameStandoff47 || NameSimProfilPlz == IDStandoff47 || NameSimProfilPlz == NameTelegram47)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff47}\n\r\n TelegramName: {NameTelegram47}\n\r TelegramID: {IDTelegram47}\n\r TelegramUserName: {UserNameTelegram47}\n\r StandoffName: {NameStandoff47}\n\r StandoffID: {IDStandoff47}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "48" || NameSimProfilPlz == IDTelegram48 || NameSimProfilPlz == NameStandoff48 || NameSimProfilPlz == IDStandoff48 || NameSimProfilPlz == NameTelegram48)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff48}\n\r\n TelegramName: {NameTelegram48}\n\r TelegramID: {IDTelegram48}\n\r TelegramUserName: {UserNameTelegram48}\n\r StandoffName: {NameStandoff48}\n\r StandoffID: {IDStandoff48}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "49" || NameSimProfilPlz == IDTelegram49 || NameSimProfilPlz == NameStandoff49 || NameSimProfilPlz == IDStandoff49 || NameSimProfilPlz == NameTelegram49)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff49}\n\r\n TelegramName: {NameTelegram49}\n\r TelegramID: {IDTelegram49}\n\r TelegramUserName: {UserNameTelegram49}\n\r StandoffName: {NameStandoff49}\n\r StandoffID: {IDStandoff49}\n\r\n----------------------------------------------------\n\r\n";
            }

            else if (NameSimProfilPlz == "50" || NameSimProfilPlz == IDTelegram50 || NameSimProfilPlz == NameStandoff50 || NameSimProfilPlz == IDStandoff50 || NameSimProfilPlz == NameTelegram50)
            {
                AllPlzEsport += $"Пользователь: {NameStandoff50}\n\r\n TelegramName: {NameTelegram50}\n\r TelegramID: {IDTelegram50}\n\r TelegramUserName: {UserNameTelegram50}\n\r StandoffName: {NameStandoff50}\n\r StandoffID: {IDStandoff50}\n\r\n----------------------------------------------------\n\r\n";
            }
            #endregion
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AddAvaO)]
        public static async Task AddAvaO(ITelegramBotClient botClient, Update update)
        {
            var msg = update.Message;
            ProfilAva = true;
            var ProfilPlz = new InlineCallback("Подтвердить", PRHeadlers.AddAvaOYes);

            var list = new List<IInlineContent>();
            list.Add(ProfilPlz);

            var menu = MenuGenerator.InlineKeyboard(1, list);

            var option = new OptionMessage();
            option.MenuInlineKeyboardMarkup = menu;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Введите цвет аватарки которую хотите выдать.", option);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AddAvaOYes)]
        public static async Task AddAvaOYes(ITelegramBotClient botClient, Update update)
        {
            #region AddAva
            if (NameSimProfilPlz == "1" || NameSimProfilPlz == IDTelegram1 || NameSimProfilPlz == IDStandoff1)
            {
                ProfilAva1 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "2" || NameSimProfilPlz == IDTelegram2 || NameSimProfilPlz == NameStandoff2 || NameSimProfilPlz == IDStandoff2 || NameSimProfilPlz == NameTelegram2)
            {
                ProfilAva2 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "3" || NameSimProfilPlz == IDTelegram3 || NameSimProfilPlz == NameStandoff3 || NameSimProfilPlz == IDStandoff3 || NameSimProfilPlz == NameTelegram3)
            {
                ProfilAva3 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "4" || NameSimProfilPlz == IDTelegram4 || NameSimProfilPlz == NameStandoff4 || NameSimProfilPlz == IDStandoff4 || NameSimProfilPlz == NameTelegram4)
            {
                ProfilAva4 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "5" || NameSimProfilPlz == IDTelegram5 || NameSimProfilPlz == NameStandoff5 || NameSimProfilPlz == IDStandoff5 || NameSimProfilPlz == NameTelegram5)
            {
                ProfilAva5 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "6" || NameSimProfilPlz == IDTelegram6 || NameSimProfilPlz == NameStandoff6 || NameSimProfilPlz == IDStandoff6 || NameSimProfilPlz == NameTelegram6)
            {
                ProfilAva6 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "7" || NameSimProfilPlz == IDTelegram7 || NameSimProfilPlz == NameStandoff7 || NameSimProfilPlz == IDStandoff7 || NameSimProfilPlz == NameTelegram7)
            {
                ProfilAva7 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "8" || NameSimProfilPlz == IDTelegram8 || NameSimProfilPlz == NameStandoff8 || NameSimProfilPlz == IDStandoff8 || NameSimProfilPlz == NameTelegram8)
            {
                ProfilAva8 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "9" || NameSimProfilPlz == IDTelegram9 || NameSimProfilPlz == NameStandoff9 || NameSimProfilPlz == IDStandoff9 || NameSimProfilPlz == NameTelegram9)
            {
                ProfilAva9 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "10" || NameSimProfilPlz == IDTelegram10 || NameSimProfilPlz == NameStandoff10 || NameSimProfilPlz == IDStandoff10 || NameSimProfilPlz == NameTelegram10)
            {
                ProfilAva10 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "11" || NameSimProfilPlz == IDTelegram11 || NameSimProfilPlz == NameStandoff11 || NameSimProfilPlz == IDStandoff11 || NameSimProfilPlz == NameTelegram11)
            {
                ProfilAva11 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "12" || NameSimProfilPlz == IDTelegram12 || NameSimProfilPlz == NameStandoff12 || NameSimProfilPlz == IDStandoff12 || NameSimProfilPlz == NameTelegram12)
            {
                ProfilAva12 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "13" || NameSimProfilPlz == IDTelegram13 || NameSimProfilPlz == NameStandoff13 || NameSimProfilPlz == IDStandoff13 || NameSimProfilPlz == NameTelegram13)
            {
                ProfilAva13 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "14" || NameSimProfilPlz == IDTelegram14 || NameSimProfilPlz == NameStandoff14 || NameSimProfilPlz == IDStandoff14 || NameSimProfilPlz == NameTelegram14)
            {
                ProfilAva14 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "15" || NameSimProfilPlz == IDTelegram15 || NameSimProfilPlz == NameStandoff15 || NameSimProfilPlz == IDStandoff15 || NameSimProfilPlz == NameTelegram15)
            {
                ProfilAva15 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "16" || NameSimProfilPlz == IDTelegram16 || NameSimProfilPlz == NameStandoff16 || NameSimProfilPlz == IDStandoff16 || NameSimProfilPlz == NameTelegram16)
            {
                ProfilAva16 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "17" || NameSimProfilPlz == IDTelegram17 || NameSimProfilPlz == NameStandoff17 || NameSimProfilPlz == IDStandoff17 || NameSimProfilPlz == NameTelegram17)
            {
                ProfilAva17 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "18" || NameSimProfilPlz == IDTelegram18 || NameSimProfilPlz == NameStandoff18 || NameSimProfilPlz == IDStandoff18 || NameSimProfilPlz == NameTelegram18)
            {
                ProfilAva18 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "19" || NameSimProfilPlz == IDTelegram19 || NameSimProfilPlz == NameStandoff19 || NameSimProfilPlz == IDStandoff19 || NameSimProfilPlz == NameTelegram19)
            {
                ProfilAva19 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "20" || NameSimProfilPlz == IDTelegram20 || NameSimProfilPlz == NameStandoff20 || NameSimProfilPlz == IDStandoff20 || NameSimProfilPlz == NameTelegram20)
            {
                ProfilAva20 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "21" || NameSimProfilPlz == IDTelegram21 || NameSimProfilPlz == NameStandoff21 || NameSimProfilPlz == IDStandoff21 || NameSimProfilPlz == NameTelegram21)
            {
                ProfilAva21 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "22" || NameSimProfilPlz == IDTelegram22 || NameSimProfilPlz == NameStandoff22 || NameSimProfilPlz == IDStandoff22 || NameSimProfilPlz == NameTelegram22)
            {
                ProfilAva22 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "23" || NameSimProfilPlz == IDTelegram23 || NameSimProfilPlz == NameStandoff23 || NameSimProfilPlz == IDStandoff23 || NameSimProfilPlz == NameTelegram23)
            {
                ProfilAva23 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "24" || NameSimProfilPlz == IDTelegram24 || NameSimProfilPlz == NameStandoff24 || NameSimProfilPlz == IDStandoff24 || NameSimProfilPlz == NameTelegram24)
            {
                ProfilAva24 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "25" || NameSimProfilPlz == IDTelegram25 || NameSimProfilPlz == NameStandoff25 || NameSimProfilPlz == IDStandoff25 || NameSimProfilPlz == NameTelegram25)
            {
                ProfilAva25 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "26" || NameSimProfilPlz == IDTelegram26 || NameSimProfilPlz == NameStandoff26 || NameSimProfilPlz == IDStandoff26 || NameSimProfilPlz == NameTelegram26)
            {
                ProfilAva26 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "27" || NameSimProfilPlz == IDTelegram27 || NameSimProfilPlz == NameStandoff27 || NameSimProfilPlz == IDStandoff27 || NameSimProfilPlz == NameTelegram27)
            {
                ProfilAva27 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "28" || NameSimProfilPlz == IDTelegram28 || NameSimProfilPlz == NameStandoff28 || NameSimProfilPlz == IDStandoff28 || NameSimProfilPlz == NameTelegram28)
            {
                ProfilAva28 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "29" || NameSimProfilPlz == IDTelegram29 || NameSimProfilPlz == NameStandoff29 || NameSimProfilPlz == IDStandoff29 || NameSimProfilPlz == NameTelegram29)
            {
                ProfilAva29 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "30" || NameSimProfilPlz == IDTelegram30 || NameSimProfilPlz == NameStandoff30 || NameSimProfilPlz == IDStandoff30 || NameSimProfilPlz == NameTelegram30)
            {
                ProfilAva30 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "31" || NameSimProfilPlz == IDTelegram31 || NameSimProfilPlz == NameStandoff31 || NameSimProfilPlz == IDStandoff31 || NameSimProfilPlz == NameTelegram31)
            {
                ProfilAva31 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "32" || NameSimProfilPlz == IDTelegram32 || NameSimProfilPlz == NameStandoff32 || NameSimProfilPlz == IDStandoff32 || NameSimProfilPlz == NameTelegram32)
            {
                ProfilAva32 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "33" || NameSimProfilPlz == IDTelegram33 || NameSimProfilPlz == NameStandoff33 || NameSimProfilPlz == IDStandoff33 || NameSimProfilPlz == NameTelegram33)
            {
                ProfilAva33 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "34" || NameSimProfilPlz == IDTelegram34 || NameSimProfilPlz == NameStandoff34 || NameSimProfilPlz == IDStandoff34 || NameSimProfilPlz == NameTelegram34)
            {
                ProfilAva34 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "35" || NameSimProfilPlz == IDTelegram35 || NameSimProfilPlz == NameStandoff35 || NameSimProfilPlz == IDStandoff35 || NameSimProfilPlz == NameTelegram35)
            {
                ProfilAva35 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "36" || NameSimProfilPlz == IDTelegram36 || NameSimProfilPlz == NameStandoff36 || NameSimProfilPlz == IDStandoff36 || NameSimProfilPlz == NameTelegram36)
            {
                ProfilAva36 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "37" || NameSimProfilPlz == IDTelegram37 || NameSimProfilPlz == NameStandoff37 || NameSimProfilPlz == IDStandoff37 || NameSimProfilPlz == NameTelegram37)
            {
                ProfilAva37 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "38" || NameSimProfilPlz == IDTelegram38 || NameSimProfilPlz == NameStandoff38 || NameSimProfilPlz == IDStandoff38 || NameSimProfilPlz == NameTelegram38)
            {
                ProfilAva38 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "39" || NameSimProfilPlz == IDTelegram39 || NameSimProfilPlz == NameStandoff39 || NameSimProfilPlz == IDStandoff39 || NameSimProfilPlz == NameTelegram39)
            {
                ProfilAva39 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "40" || NameSimProfilPlz == IDTelegram40 || NameSimProfilPlz == NameStandoff40 || NameSimProfilPlz == IDStandoff40 || NameSimProfilPlz == NameTelegram40)
            {
                ProfilAva40 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "41" || NameSimProfilPlz == IDTelegram41 || NameSimProfilPlz == NameStandoff41 || NameSimProfilPlz == IDStandoff41 || NameSimProfilPlz == NameTelegram41)
            {
                ProfilAva41 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "42" || NameSimProfilPlz == IDTelegram42 || NameSimProfilPlz == NameStandoff42 || NameSimProfilPlz == IDStandoff42 || NameSimProfilPlz == NameTelegram42)
            {
                ProfilAva42 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "43" || NameSimProfilPlz == IDTelegram43 || NameSimProfilPlz == NameStandoff43 || NameSimProfilPlz == IDStandoff43 || NameSimProfilPlz == NameTelegram43)
            {
                ProfilAva43 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "44" || NameSimProfilPlz == IDTelegram44 || NameSimProfilPlz == NameStandoff44 || NameSimProfilPlz == IDStandoff44 || NameSimProfilPlz == NameTelegram44)
            {
                ProfilAva44 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "45" || NameSimProfilPlz == IDTelegram45 || NameSimProfilPlz == NameStandoff45 || NameSimProfilPlz == IDStandoff45 || NameSimProfilPlz == NameTelegram45)
            {
                ProfilAva45 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "46" || NameSimProfilPlz == IDTelegram46 || NameSimProfilPlz == NameStandoff46 || NameSimProfilPlz == IDStandoff46 || NameSimProfilPlz == NameTelegram46)
            {
                ProfilAva46 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "47" || NameSimProfilPlz == IDTelegram47 || NameSimProfilPlz == NameStandoff47 || NameSimProfilPlz == IDStandoff47 || NameSimProfilPlz == NameTelegram47)
            {
                ProfilAva47 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "48" || NameSimProfilPlz == IDTelegram48 || NameSimProfilPlz == NameStandoff48 || NameSimProfilPlz == IDStandoff48 || NameSimProfilPlz == NameTelegram48)
            {
                ProfilAva48 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "49" || NameSimProfilPlz == IDTelegram49 || NameSimProfilPlz == NameStandoff49 || NameSimProfilPlz == IDStandoff49 || NameSimProfilPlz == NameTelegram49)
            {
                ProfilAva49 = ProfilAvaAdd;
            }
            else if (NameSimProfilPlz == "50" || NameSimProfilPlz == IDTelegram50 || NameSimProfilPlz == NameStandoff50 || NameSimProfilPlz == IDStandoff50 || NameSimProfilPlz == NameTelegram50)
            {
                ProfilAva50 = ProfilAvaAdd;
            }
            #endregion
        }


        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AddMember)]
        public static async Task AddMember(ITelegramBotClient botClient, Update update)
        {
            #region AddMember
            if (NameSimProfilPlz == "1" || NameSimProfilPlz == IDTelegram1 || NameSimProfilPlz == IDStandoff1)
            {
                ProfilAva1 = "Member";
            }
            else if (NameSimProfilPlz == "2" || NameSimProfilPlz == IDTelegram2 || NameSimProfilPlz == NameStandoff2 || NameSimProfilPlz == IDStandoff2 || NameSimProfilPlz == NameTelegram2)
            {
                ProfilAva2 = "Member";
            }
            else if (NameSimProfilPlz == "3" || NameSimProfilPlz == IDTelegram3 || NameSimProfilPlz == NameStandoff3 || NameSimProfilPlz == IDStandoff3 || NameSimProfilPlz == NameTelegram3)
            {
                ProfilAva3 = "Member";
            }
            else if (NameSimProfilPlz == "4" || NameSimProfilPlz == IDTelegram4 || NameSimProfilPlz == NameStandoff4 || NameSimProfilPlz == IDStandoff4 || NameSimProfilPlz == NameTelegram4)
            {
                ProfilAva4 = "Member";
            }
            else if (NameSimProfilPlz == "5" || NameSimProfilPlz == IDTelegram5 || NameSimProfilPlz == NameStandoff5 || NameSimProfilPlz == IDStandoff5 || NameSimProfilPlz == NameTelegram5)
            {
                ProfilAva5 = "Member";
            }
            else if (NameSimProfilPlz == "6" || NameSimProfilPlz == IDTelegram6 || NameSimProfilPlz == NameStandoff6 || NameSimProfilPlz == IDStandoff6 || NameSimProfilPlz == NameTelegram6)
            {
                ProfilAva6 = "Member";
            }
            else if (NameSimProfilPlz == "7" || NameSimProfilPlz == IDTelegram7 || NameSimProfilPlz == NameStandoff7 || NameSimProfilPlz == IDStandoff7 || NameSimProfilPlz == NameTelegram7)
            {
                ProfilAva7 = "Member";
            }
            else if (NameSimProfilPlz == "8" || NameSimProfilPlz == IDTelegram8 || NameSimProfilPlz == NameStandoff8 || NameSimProfilPlz == IDStandoff8 || NameSimProfilPlz == NameTelegram8)
            {
                ProfilAva8 = "Member";
            }
            else if (NameSimProfilPlz == "9" || NameSimProfilPlz == IDTelegram9 || NameSimProfilPlz == NameStandoff9 || NameSimProfilPlz == IDStandoff9 || NameSimProfilPlz == NameTelegram9)
            {
                ProfilAva9 = "Member";
            }
            else if (NameSimProfilPlz == "10" || NameSimProfilPlz == IDTelegram10 || NameSimProfilPlz == NameStandoff10 || NameSimProfilPlz == IDStandoff10 || NameSimProfilPlz == NameTelegram10)
            {
                ProfilAva10 = "Member";
            }
            else if (NameSimProfilPlz == "11" || NameSimProfilPlz == IDTelegram11 || NameSimProfilPlz == NameStandoff11 || NameSimProfilPlz == IDStandoff11 || NameSimProfilPlz == NameTelegram11)
            {
                ProfilAva11 = "Member";
            }
            else if (NameSimProfilPlz == "12" || NameSimProfilPlz == IDTelegram12 || NameSimProfilPlz == NameStandoff12 || NameSimProfilPlz == IDStandoff12 || NameSimProfilPlz == NameTelegram12)
            {
                ProfilAva12 = "Member";
            }
            else if (NameSimProfilPlz == "13" || NameSimProfilPlz == IDTelegram13 || NameSimProfilPlz == NameStandoff13 || NameSimProfilPlz == IDStandoff13 || NameSimProfilPlz == NameTelegram13)
            {
                ProfilAva13 = "Member";
            }
            else if (NameSimProfilPlz == "14" || NameSimProfilPlz == IDTelegram14 || NameSimProfilPlz == NameStandoff14 || NameSimProfilPlz == IDStandoff14 || NameSimProfilPlz == NameTelegram14)
            {
                ProfilAva14 = "Member";
            }
            else if (NameSimProfilPlz == "15" || NameSimProfilPlz == IDTelegram15 || NameSimProfilPlz == NameStandoff15 || NameSimProfilPlz == IDStandoff15 || NameSimProfilPlz == NameTelegram15)
            {
                ProfilAva15 = "Member";
            }
            else if (NameSimProfilPlz == "16" || NameSimProfilPlz == IDTelegram16 || NameSimProfilPlz == NameStandoff16 || NameSimProfilPlz == IDStandoff16 || NameSimProfilPlz == NameTelegram16)
            {
                ProfilAva16 = "Member";
            }
            else if (NameSimProfilPlz == "17" || NameSimProfilPlz == IDTelegram17 || NameSimProfilPlz == NameStandoff17 || NameSimProfilPlz == IDStandoff17 || NameSimProfilPlz == NameTelegram17)
            {
                ProfilAva17 = "Member";
            }
            else if (NameSimProfilPlz == "18" || NameSimProfilPlz == IDTelegram18 || NameSimProfilPlz == NameStandoff18 || NameSimProfilPlz == IDStandoff18 || NameSimProfilPlz == NameTelegram18)
            {
                ProfilAva18 = "Member";
            }
            else if (NameSimProfilPlz == "19" || NameSimProfilPlz == IDTelegram19 || NameSimProfilPlz == NameStandoff19 || NameSimProfilPlz == IDStandoff19 || NameSimProfilPlz == NameTelegram19)
            {
                ProfilAva19 = "Member";
            }
            else if (NameSimProfilPlz == "20" || NameSimProfilPlz == IDTelegram20 || NameSimProfilPlz == NameStandoff20 || NameSimProfilPlz == IDStandoff20 || NameSimProfilPlz == NameTelegram20)
            {
                ProfilAva20 = "Member";
            }
            else if (NameSimProfilPlz == "21" || NameSimProfilPlz == IDTelegram21 || NameSimProfilPlz == NameStandoff21 || NameSimProfilPlz == IDStandoff21 || NameSimProfilPlz == NameTelegram21)
            {
                ProfilAva21 = "Member";
            }
            else if (NameSimProfilPlz == "22" || NameSimProfilPlz == IDTelegram22 || NameSimProfilPlz == NameStandoff22 || NameSimProfilPlz == IDStandoff22 || NameSimProfilPlz == NameTelegram22)
            {
                ProfilAva22 = "Member";
            }
            else if (NameSimProfilPlz == "23" || NameSimProfilPlz == IDTelegram23 || NameSimProfilPlz == NameStandoff23 || NameSimProfilPlz == IDStandoff23 || NameSimProfilPlz == NameTelegram23)
            {
                ProfilAva23 = "Member";
            }
            else if (NameSimProfilPlz == "24" || NameSimProfilPlz == IDTelegram24 || NameSimProfilPlz == NameStandoff24 || NameSimProfilPlz == IDStandoff24 || NameSimProfilPlz == NameTelegram24)
            {
                ProfilAva24 = "Member";
            }
            else if (NameSimProfilPlz == "25" || NameSimProfilPlz == IDTelegram25 || NameSimProfilPlz == NameStandoff25 || NameSimProfilPlz == IDStandoff25 || NameSimProfilPlz == NameTelegram25)
            {
                ProfilAva25 = "Member";
            }
            else if (NameSimProfilPlz == "26" || NameSimProfilPlz == IDTelegram26 || NameSimProfilPlz == NameStandoff26 || NameSimProfilPlz == IDStandoff26 || NameSimProfilPlz == NameTelegram26)
            {
                ProfilAva26 = "Member";
            }
            else if (NameSimProfilPlz == "27" || NameSimProfilPlz == IDTelegram27 || NameSimProfilPlz == NameStandoff27 || NameSimProfilPlz == IDStandoff27 || NameSimProfilPlz == NameTelegram27)
            {
                ProfilAva27 = "Member";
            }
            else if (NameSimProfilPlz == "28" || NameSimProfilPlz == IDTelegram28 || NameSimProfilPlz == NameStandoff28 || NameSimProfilPlz == IDStandoff28 || NameSimProfilPlz == NameTelegram28)
            {
                ProfilAva28 = "Member";
            }
            else if (NameSimProfilPlz == "29" || NameSimProfilPlz == IDTelegram29 || NameSimProfilPlz == NameStandoff29 || NameSimProfilPlz == IDStandoff29 || NameSimProfilPlz == NameTelegram29)
            {
                ProfilAva29 = "Member";
            }
            else if (NameSimProfilPlz == "30" || NameSimProfilPlz == IDTelegram30 || NameSimProfilPlz == NameStandoff30 || NameSimProfilPlz == IDStandoff30 || NameSimProfilPlz == NameTelegram30)
            {
                ProfilAva30 = "Member";
            }
            else if (NameSimProfilPlz == "31" || NameSimProfilPlz == IDTelegram31 || NameSimProfilPlz == NameStandoff31 || NameSimProfilPlz == IDStandoff31 || NameSimProfilPlz == NameTelegram31)
            {
                ProfilAva31 = "Member";
            }
            else if (NameSimProfilPlz == "32" || NameSimProfilPlz == IDTelegram32 || NameSimProfilPlz == NameStandoff32 || NameSimProfilPlz == IDStandoff32 || NameSimProfilPlz == NameTelegram32)
            {
                ProfilAva32 = "Member";
            }
            else if (NameSimProfilPlz == "33" || NameSimProfilPlz == IDTelegram33 || NameSimProfilPlz == NameStandoff33 || NameSimProfilPlz == IDStandoff33 || NameSimProfilPlz == NameTelegram33)
            {
                ProfilAva33 = "Member";
            }
            else if (NameSimProfilPlz == "34" || NameSimProfilPlz == IDTelegram34 || NameSimProfilPlz == NameStandoff34 || NameSimProfilPlz == IDStandoff34 || NameSimProfilPlz == NameTelegram34)
            {
                ProfilAva34 = "Member";
            }
            else if (NameSimProfilPlz == "35" || NameSimProfilPlz == IDTelegram35 || NameSimProfilPlz == NameStandoff35 || NameSimProfilPlz == IDStandoff35 || NameSimProfilPlz == NameTelegram35)
            {
                ProfilAva35 = "Member";
            }
            else if (NameSimProfilPlz == "36" || NameSimProfilPlz == IDTelegram36 || NameSimProfilPlz == NameStandoff36 || NameSimProfilPlz == IDStandoff36 || NameSimProfilPlz == NameTelegram36)
            {
                ProfilAva36 = "Member";
            }
            else if (NameSimProfilPlz == "37" || NameSimProfilPlz == IDTelegram37 || NameSimProfilPlz == NameStandoff37 || NameSimProfilPlz == IDStandoff37 || NameSimProfilPlz == NameTelegram37)
            {
                ProfilAva37 = "Member";
            }
            else if (NameSimProfilPlz == "38" || NameSimProfilPlz == IDTelegram38 || NameSimProfilPlz == NameStandoff38 || NameSimProfilPlz == IDStandoff38 || NameSimProfilPlz == NameTelegram38)
            {
                ProfilAva38 = "Member";
            }
            else if (NameSimProfilPlz == "39" || NameSimProfilPlz == IDTelegram39 || NameSimProfilPlz == NameStandoff39 || NameSimProfilPlz == IDStandoff39 || NameSimProfilPlz == NameTelegram39)
            {
                ProfilAva39 = "Member";
            }
            else if (NameSimProfilPlz == "40" || NameSimProfilPlz == IDTelegram40 || NameSimProfilPlz == NameStandoff40 || NameSimProfilPlz == IDStandoff40 || NameSimProfilPlz == NameTelegram40)
            {
                ProfilAva40 = "Member";
            }
            else if (NameSimProfilPlz == "41" || NameSimProfilPlz == IDTelegram41 || NameSimProfilPlz == NameStandoff41 || NameSimProfilPlz == IDStandoff41 || NameSimProfilPlz == NameTelegram41)
            {
                ProfilAva41 = "Member";
            }
            else if (NameSimProfilPlz == "42" || NameSimProfilPlz == IDTelegram42 || NameSimProfilPlz == NameStandoff42 || NameSimProfilPlz == IDStandoff42 || NameSimProfilPlz == NameTelegram42)
            {
                ProfilAva42 = "Member";
            }
            else if (NameSimProfilPlz == "43" || NameSimProfilPlz == IDTelegram43 || NameSimProfilPlz == NameStandoff43 || NameSimProfilPlz == IDStandoff43 || NameSimProfilPlz == NameTelegram43)
            {
                ProfilAva43 = "Member";
            }
            else if (NameSimProfilPlz == "44" || NameSimProfilPlz == IDTelegram44 || NameSimProfilPlz == NameStandoff44 || NameSimProfilPlz == IDStandoff44 || NameSimProfilPlz == NameTelegram44)
            {
                ProfilAva44 = "Member";
            }
            else if (NameSimProfilPlz == "45" || NameSimProfilPlz == IDTelegram45 || NameSimProfilPlz == NameStandoff45 || NameSimProfilPlz == IDStandoff45 || NameSimProfilPlz == NameTelegram45)
            {
                ProfilAva45 = "Member";
            }
            else if (NameSimProfilPlz == "46" || NameSimProfilPlz == IDTelegram46 || NameSimProfilPlz == NameStandoff46 || NameSimProfilPlz == IDStandoff46 || NameSimProfilPlz == NameTelegram46)
            {
                ProfilAva46 = "Member";
            }
            else if (NameSimProfilPlz == "47" || NameSimProfilPlz == IDTelegram47 || NameSimProfilPlz == NameStandoff47 || NameSimProfilPlz == IDStandoff47 || NameSimProfilPlz == NameTelegram47)
            {
                ProfilAva47 = "Member";
            }
            else if (NameSimProfilPlz == "48" || NameSimProfilPlz == IDTelegram48 || NameSimProfilPlz == NameStandoff48 || NameSimProfilPlz == IDStandoff48 || NameSimProfilPlz == NameTelegram48)
            {
                ProfilAva48 = "Member";
            }
            else if (NameSimProfilPlz == "49" || NameSimProfilPlz == IDTelegram49 || NameSimProfilPlz == NameStandoff49 || NameSimProfilPlz == IDStandoff49 || NameSimProfilPlz == NameTelegram49)
            {
                ProfilAva49 = "Member";
            }
            else if (NameSimProfilPlz == "50" || NameSimProfilPlz == IDTelegram50 || NameSimProfilPlz == NameStandoff50 || NameSimProfilPlz == IDStandoff50 || NameSimProfilPlz == NameTelegram50)
            {
                ProfilAva50 = "Member";
            }
            #endregion
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AddElder)]
        public static async Task AddElder(ITelegramBotClient botClient, Update update)
        {
            #region AddElder
            if (NameSimProfilPlz == "1" || NameSimProfilPlz == IDTelegram1 || NameSimProfilPlz == IDStandoff1)
            {
                ProfilAva1 = "Elder";
            }
            else if (NameSimProfilPlz == "2" || NameSimProfilPlz == IDTelegram2 || NameSimProfilPlz == NameStandoff2 || NameSimProfilPlz == IDStandoff2 || NameSimProfilPlz == NameTelegram2)
            {
                ProfilAva2 = "Elder";
            }
            else if (NameSimProfilPlz == "3" || NameSimProfilPlz == IDTelegram3 || NameSimProfilPlz == NameStandoff3 || NameSimProfilPlz == IDStandoff3 || NameSimProfilPlz == NameTelegram3)
            {
                ProfilAva3 = "Elder";
            }
            else if (NameSimProfilPlz == "4" || NameSimProfilPlz == IDTelegram4 || NameSimProfilPlz == NameStandoff4 || NameSimProfilPlz == IDStandoff4 || NameSimProfilPlz == NameTelegram4)
            {
                ProfilAva4 = "Elder";
            }
            else if (NameSimProfilPlz == "5" || NameSimProfilPlz == IDTelegram5 || NameSimProfilPlz == NameStandoff5 || NameSimProfilPlz == IDStandoff5 || NameSimProfilPlz == NameTelegram5)
            {
                ProfilAva5 = "Elder";
            }
            else if (NameSimProfilPlz == "6" || NameSimProfilPlz == IDTelegram6 || NameSimProfilPlz == NameStandoff6 || NameSimProfilPlz == IDStandoff6 || NameSimProfilPlz == NameTelegram6)
            {
                ProfilAva6 = "Elder";
            }
            else if (NameSimProfilPlz == "7" || NameSimProfilPlz == IDTelegram7 || NameSimProfilPlz == NameStandoff7 || NameSimProfilPlz == IDStandoff7 || NameSimProfilPlz == NameTelegram7)
            {
                ProfilAva7 = "Elder";
            }
            else if (NameSimProfilPlz == "8" || NameSimProfilPlz == IDTelegram8 || NameSimProfilPlz == NameStandoff8 || NameSimProfilPlz == IDStandoff8 || NameSimProfilPlz == NameTelegram8)
            {
                ProfilAva8 = "Elder";
            }
            else if (NameSimProfilPlz == "9" || NameSimProfilPlz == IDTelegram9 || NameSimProfilPlz == NameStandoff9 || NameSimProfilPlz == IDStandoff9 || NameSimProfilPlz == NameTelegram9)
            {
                ProfilAva9 = "Elder";
            }
            else if (NameSimProfilPlz == "10" || NameSimProfilPlz == IDTelegram10 || NameSimProfilPlz == NameStandoff10 || NameSimProfilPlz == IDStandoff10 || NameSimProfilPlz == NameTelegram10)
            {
                ProfilAva10 = "Elder";
            }
            else if (NameSimProfilPlz == "11" || NameSimProfilPlz == IDTelegram11 || NameSimProfilPlz == NameStandoff11 || NameSimProfilPlz == IDStandoff11 || NameSimProfilPlz == NameTelegram11)
            {
                ProfilAva11 = "Elder";
            }
            else if (NameSimProfilPlz == "12" || NameSimProfilPlz == IDTelegram12 || NameSimProfilPlz == NameStandoff12 || NameSimProfilPlz == IDStandoff12 || NameSimProfilPlz == NameTelegram12)
            {
                ProfilAva12 = "Elder";
            }
            else if (NameSimProfilPlz == "13" || NameSimProfilPlz == IDTelegram13 || NameSimProfilPlz == NameStandoff13 || NameSimProfilPlz == IDStandoff13 || NameSimProfilPlz == NameTelegram13)
            {
                ProfilAva13 = "Elder";
            }
            else if (NameSimProfilPlz == "14" || NameSimProfilPlz == IDTelegram14 || NameSimProfilPlz == NameStandoff14 || NameSimProfilPlz == IDStandoff14 || NameSimProfilPlz == NameTelegram14)
            {
                ProfilAva14 = "Elder";
            }
            else if (NameSimProfilPlz == "15" || NameSimProfilPlz == IDTelegram15 || NameSimProfilPlz == NameStandoff15 || NameSimProfilPlz == IDStandoff15 || NameSimProfilPlz == NameTelegram15)
            {
                ProfilAva15 = "Elder";
            }
            else if (NameSimProfilPlz == "16" || NameSimProfilPlz == IDTelegram16 || NameSimProfilPlz == NameStandoff16 || NameSimProfilPlz == IDStandoff16 || NameSimProfilPlz == NameTelegram16)
            {
                ProfilAva16 = "Elder";
            }
            else if (NameSimProfilPlz == "17" || NameSimProfilPlz == IDTelegram17 || NameSimProfilPlz == NameStandoff17 || NameSimProfilPlz == IDStandoff17 || NameSimProfilPlz == NameTelegram17)
            {
                ProfilAva17 = "Elder";
            }
            else if (NameSimProfilPlz == "18" || NameSimProfilPlz == IDTelegram18 || NameSimProfilPlz == NameStandoff18 || NameSimProfilPlz == IDStandoff18 || NameSimProfilPlz == NameTelegram18)
            {
                ProfilAva18 = "Elder";
            }
            else if (NameSimProfilPlz == "19" || NameSimProfilPlz == IDTelegram19 || NameSimProfilPlz == NameStandoff19 || NameSimProfilPlz == IDStandoff19 || NameSimProfilPlz == NameTelegram19)
            {
                ProfilAva19 = "Elder";
            }
            else if (NameSimProfilPlz == "20" || NameSimProfilPlz == IDTelegram20 || NameSimProfilPlz == NameStandoff20 || NameSimProfilPlz == IDStandoff20 || NameSimProfilPlz == NameTelegram20)
            {
                ProfilAva20 = "Elder";
            }
            else if (NameSimProfilPlz == "21" || NameSimProfilPlz == IDTelegram21 || NameSimProfilPlz == NameStandoff21 || NameSimProfilPlz == IDStandoff21 || NameSimProfilPlz == NameTelegram21)
            {
                ProfilAva21 = "Elder";
            }
            else if (NameSimProfilPlz == "22" || NameSimProfilPlz == IDTelegram22 || NameSimProfilPlz == NameStandoff22 || NameSimProfilPlz == IDStandoff22 || NameSimProfilPlz == NameTelegram22)
            {
                ProfilAva22 = "Elder";
            }
            else if (NameSimProfilPlz == "23" || NameSimProfilPlz == IDTelegram23 || NameSimProfilPlz == NameStandoff23 || NameSimProfilPlz == IDStandoff23 || NameSimProfilPlz == NameTelegram23)
            {
                ProfilAva23 = "Elder";
            }
            else if (NameSimProfilPlz == "24" || NameSimProfilPlz == IDTelegram24 || NameSimProfilPlz == NameStandoff24 || NameSimProfilPlz == IDStandoff24 || NameSimProfilPlz == NameTelegram24)
            {
                ProfilAva24 = "Elder";
            }
            else if (NameSimProfilPlz == "25" || NameSimProfilPlz == IDTelegram25 || NameSimProfilPlz == NameStandoff25 || NameSimProfilPlz == IDStandoff25 || NameSimProfilPlz == NameTelegram25)
            {
                ProfilAva25 = "Elder";
            }
            else if (NameSimProfilPlz == "26" || NameSimProfilPlz == IDTelegram26 || NameSimProfilPlz == NameStandoff26 || NameSimProfilPlz == IDStandoff26 || NameSimProfilPlz == NameTelegram26)
            {
                ProfilAva26 = "Elder";
            }
            else if (NameSimProfilPlz == "27" || NameSimProfilPlz == IDTelegram27 || NameSimProfilPlz == NameStandoff27 || NameSimProfilPlz == IDStandoff27 || NameSimProfilPlz == NameTelegram27)
            {
                ProfilAva27 = "Elder";
            }
            else if (NameSimProfilPlz == "28" || NameSimProfilPlz == IDTelegram28 || NameSimProfilPlz == NameStandoff28 || NameSimProfilPlz == IDStandoff28 || NameSimProfilPlz == NameTelegram28)
            {
                ProfilAva28 = "Elder";
            }
            else if (NameSimProfilPlz == "29" || NameSimProfilPlz == IDTelegram29 || NameSimProfilPlz == NameStandoff29 || NameSimProfilPlz == IDStandoff29 || NameSimProfilPlz == NameTelegram29)
            {
                ProfilAva29 = "Elder";
            }
            else if (NameSimProfilPlz == "30" || NameSimProfilPlz == IDTelegram30 || NameSimProfilPlz == NameStandoff30 || NameSimProfilPlz == IDStandoff30 || NameSimProfilPlz == NameTelegram30)
            {
                ProfilAva30 = "Elder";
            }
            else if (NameSimProfilPlz == "31" || NameSimProfilPlz == IDTelegram31 || NameSimProfilPlz == NameStandoff31 || NameSimProfilPlz == IDStandoff31 || NameSimProfilPlz == NameTelegram31)
            {
                ProfilAva31 = "Elder";
            }
            else if (NameSimProfilPlz == "32" || NameSimProfilPlz == IDTelegram32 || NameSimProfilPlz == NameStandoff32 || NameSimProfilPlz == IDStandoff32 || NameSimProfilPlz == NameTelegram32)
            {
                ProfilAva32 = "Elder";
            }
            else if (NameSimProfilPlz == "33" || NameSimProfilPlz == IDTelegram33 || NameSimProfilPlz == NameStandoff33 || NameSimProfilPlz == IDStandoff33 || NameSimProfilPlz == NameTelegram33)
            {
                ProfilAva33 = "Elder";
            }
            else if (NameSimProfilPlz == "34" || NameSimProfilPlz == IDTelegram34 || NameSimProfilPlz == NameStandoff34 || NameSimProfilPlz == IDStandoff34 || NameSimProfilPlz == NameTelegram34)
            {
                ProfilAva34 = "Elder";
            }
            else if (NameSimProfilPlz == "35" || NameSimProfilPlz == IDTelegram35 || NameSimProfilPlz == NameStandoff35 || NameSimProfilPlz == IDStandoff35 || NameSimProfilPlz == NameTelegram35)
            {
                ProfilAva35 = "Elder";
            }
            else if (NameSimProfilPlz == "36" || NameSimProfilPlz == IDTelegram36 || NameSimProfilPlz == NameStandoff36 || NameSimProfilPlz == IDStandoff36 || NameSimProfilPlz == NameTelegram36)
            {
                ProfilAva36 = "Elder";
            }
            else if (NameSimProfilPlz == "37" || NameSimProfilPlz == IDTelegram37 || NameSimProfilPlz == NameStandoff37 || NameSimProfilPlz == IDStandoff37 || NameSimProfilPlz == NameTelegram37)
            {
                ProfilAva37 = "Elder";
            }
            else if (NameSimProfilPlz == "38" || NameSimProfilPlz == IDTelegram38 || NameSimProfilPlz == NameStandoff38 || NameSimProfilPlz == IDStandoff38 || NameSimProfilPlz == NameTelegram38)
            {
                ProfilAva38 = "Elder";
            }
            else if (NameSimProfilPlz == "39" || NameSimProfilPlz == IDTelegram39 || NameSimProfilPlz == NameStandoff39 || NameSimProfilPlz == IDStandoff39 || NameSimProfilPlz == NameTelegram39)
            {
                ProfilAva39 = "Elder";
            }
            else if (NameSimProfilPlz == "40" || NameSimProfilPlz == IDTelegram40 || NameSimProfilPlz == NameStandoff40 || NameSimProfilPlz == IDStandoff40 || NameSimProfilPlz == NameTelegram40)
            {
                ProfilAva40 = "Elder";
            }
            else if (NameSimProfilPlz == "41" || NameSimProfilPlz == IDTelegram41 || NameSimProfilPlz == NameStandoff41 || NameSimProfilPlz == IDStandoff41 || NameSimProfilPlz == NameTelegram41)
            {
                ProfilAva41 = "Elder";
            }
            else if (NameSimProfilPlz == "42" || NameSimProfilPlz == IDTelegram42 || NameSimProfilPlz == NameStandoff42 || NameSimProfilPlz == IDStandoff42 || NameSimProfilPlz == NameTelegram42)
            {
                ProfilAva42 = "Elder";
            }
            else if (NameSimProfilPlz == "43" || NameSimProfilPlz == IDTelegram43 || NameSimProfilPlz == NameStandoff43 || NameSimProfilPlz == IDStandoff43 || NameSimProfilPlz == NameTelegram43)
            {
                ProfilAva43 = "Elder";
            }
            else if (NameSimProfilPlz == "44" || NameSimProfilPlz == IDTelegram44 || NameSimProfilPlz == NameStandoff44 || NameSimProfilPlz == IDStandoff44 || NameSimProfilPlz == NameTelegram44)
            {
                ProfilAva44 = "Elder";
            }
            else if (NameSimProfilPlz == "45" || NameSimProfilPlz == IDTelegram45 || NameSimProfilPlz == NameStandoff45 || NameSimProfilPlz == IDStandoff45 || NameSimProfilPlz == NameTelegram45)
            {
                ProfilAva45 = "Elder";
            }
            else if (NameSimProfilPlz == "46" || NameSimProfilPlz == IDTelegram46 || NameSimProfilPlz == NameStandoff46 || NameSimProfilPlz == IDStandoff46 || NameSimProfilPlz == NameTelegram46)
            {
                ProfilAva46 = "Elder";
            }
            else if (NameSimProfilPlz == "47" || NameSimProfilPlz == IDTelegram47 || NameSimProfilPlz == NameStandoff47 || NameSimProfilPlz == IDStandoff47 || NameSimProfilPlz == NameTelegram47)
            {
                ProfilAva47 = "Elder";
            }
            else if (NameSimProfilPlz == "48" || NameSimProfilPlz == IDTelegram48 || NameSimProfilPlz == NameStandoff48 || NameSimProfilPlz == IDStandoff48 || NameSimProfilPlz == NameTelegram48)
            {
                ProfilAva48 = "Elder";
            }
            else if (NameSimProfilPlz == "49" || NameSimProfilPlz == IDTelegram49 || NameSimProfilPlz == NameStandoff49 || NameSimProfilPlz == IDStandoff49 || NameSimProfilPlz == NameTelegram49)
            {
                ProfilAva49 = "Elder";
            }
            else if (NameSimProfilPlz == "50" || NameSimProfilPlz == IDTelegram50 || NameSimProfilPlz == NameStandoff50 || NameSimProfilPlz == IDStandoff50 || NameSimProfilPlz == NameTelegram50)
            {
                ProfilAva50 = "Elder";
            }
            #endregion
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AddCoLeader)]
        public static async Task AddCoLeader(ITelegramBotClient botClient, Update update)
        {
            #region AddCoLeader
            if (NameSimProfilPlz == "1" || NameSimProfilPlz == IDTelegram1 || NameSimProfilPlz == IDStandoff1)
            {
                ProfilAva1 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "2" || NameSimProfilPlz == IDTelegram2 || NameSimProfilPlz == NameStandoff2 || NameSimProfilPlz == IDStandoff2 || NameSimProfilPlz == NameTelegram2)
            {
                ProfilAva2 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "3" || NameSimProfilPlz == IDTelegram3 || NameSimProfilPlz == NameStandoff3 || NameSimProfilPlz == IDStandoff3 || NameSimProfilPlz == NameTelegram3)
            {
                ProfilAva3 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "4" || NameSimProfilPlz == IDTelegram4 || NameSimProfilPlz == NameStandoff4 || NameSimProfilPlz == IDStandoff4 || NameSimProfilPlz == NameTelegram4)
            {
                ProfilAva4 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "5" || NameSimProfilPlz == IDTelegram5 || NameSimProfilPlz == NameStandoff5 || NameSimProfilPlz == IDStandoff5 || NameSimProfilPlz == NameTelegram5)
            {
                ProfilAva5 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "6" || NameSimProfilPlz == IDTelegram6 || NameSimProfilPlz == NameStandoff6 || NameSimProfilPlz == IDStandoff6 || NameSimProfilPlz == NameTelegram6)
            {
                ProfilAva6 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "7" || NameSimProfilPlz == IDTelegram7 || NameSimProfilPlz == NameStandoff7 || NameSimProfilPlz == IDStandoff7 || NameSimProfilPlz == NameTelegram7)
            {
                ProfilAva7 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "8" || NameSimProfilPlz == IDTelegram8 || NameSimProfilPlz == NameStandoff8 || NameSimProfilPlz == IDStandoff8 || NameSimProfilPlz == NameTelegram8)
            {
                ProfilAva8 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "9" || NameSimProfilPlz == IDTelegram9 || NameSimProfilPlz == NameStandoff9 || NameSimProfilPlz == IDStandoff9 || NameSimProfilPlz == NameTelegram9)
            {
                ProfilAva9 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "10" || NameSimProfilPlz == IDTelegram10 || NameSimProfilPlz == NameStandoff10 || NameSimProfilPlz == IDStandoff10 || NameSimProfilPlz == NameTelegram10)
            {
                ProfilAva10 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "11" || NameSimProfilPlz == IDTelegram11 || NameSimProfilPlz == NameStandoff11 || NameSimProfilPlz == IDStandoff11 || NameSimProfilPlz == NameTelegram11)
            {
                ProfilAva11 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "12" || NameSimProfilPlz == IDTelegram12 || NameSimProfilPlz == NameStandoff12 || NameSimProfilPlz == IDStandoff12 || NameSimProfilPlz == NameTelegram12)
            {
                ProfilAva12 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "13" || NameSimProfilPlz == IDTelegram13 || NameSimProfilPlz == NameStandoff13 || NameSimProfilPlz == IDStandoff13 || NameSimProfilPlz == NameTelegram13)
            {
                ProfilAva13 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "14" || NameSimProfilPlz == IDTelegram14 || NameSimProfilPlz == NameStandoff14 || NameSimProfilPlz == IDStandoff14 || NameSimProfilPlz == NameTelegram14)
            {
                ProfilAva14 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "15" || NameSimProfilPlz == IDTelegram15 || NameSimProfilPlz == NameStandoff15 || NameSimProfilPlz == IDStandoff15 || NameSimProfilPlz == NameTelegram15)
            {
                ProfilAva15 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "16" || NameSimProfilPlz == IDTelegram16 || NameSimProfilPlz == NameStandoff16 || NameSimProfilPlz == IDStandoff16 || NameSimProfilPlz == NameTelegram16)
            {
                ProfilAva16 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "17" || NameSimProfilPlz == IDTelegram17 || NameSimProfilPlz == NameStandoff17 || NameSimProfilPlz == IDStandoff17 || NameSimProfilPlz == NameTelegram17)
            {
                ProfilAva17 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "18" || NameSimProfilPlz == IDTelegram18 || NameSimProfilPlz == NameStandoff18 || NameSimProfilPlz == IDStandoff18 || NameSimProfilPlz == NameTelegram18)
            {
                ProfilAva18 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "19" || NameSimProfilPlz == IDTelegram19 || NameSimProfilPlz == NameStandoff19 || NameSimProfilPlz == IDStandoff19 || NameSimProfilPlz == NameTelegram19)
            {
                ProfilAva19 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "20" || NameSimProfilPlz == IDTelegram20 || NameSimProfilPlz == NameStandoff20 || NameSimProfilPlz == IDStandoff20 || NameSimProfilPlz == NameTelegram20)
            {
                ProfilAva20 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "21" || NameSimProfilPlz == IDTelegram21 || NameSimProfilPlz == NameStandoff21 || NameSimProfilPlz == IDStandoff21 || NameSimProfilPlz == NameTelegram21)
            {
                ProfilAva21 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "22" || NameSimProfilPlz == IDTelegram22 || NameSimProfilPlz == NameStandoff22 || NameSimProfilPlz == IDStandoff22 || NameSimProfilPlz == NameTelegram22)
            {
                ProfilAva22 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "23" || NameSimProfilPlz == IDTelegram23 || NameSimProfilPlz == NameStandoff23 || NameSimProfilPlz == IDStandoff23 || NameSimProfilPlz == NameTelegram23)
            {
                ProfilAva23 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "24" || NameSimProfilPlz == IDTelegram24 || NameSimProfilPlz == NameStandoff24 || NameSimProfilPlz == IDStandoff24 || NameSimProfilPlz == NameTelegram24)
            {
                ProfilAva24 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "25" || NameSimProfilPlz == IDTelegram25 || NameSimProfilPlz == NameStandoff25 || NameSimProfilPlz == IDStandoff25 || NameSimProfilPlz == NameTelegram25)
            {
                ProfilAva25 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "26" || NameSimProfilPlz == IDTelegram26 || NameSimProfilPlz == NameStandoff26 || NameSimProfilPlz == IDStandoff26 || NameSimProfilPlz == NameTelegram26)
            {
                ProfilAva26 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "27" || NameSimProfilPlz == IDTelegram27 || NameSimProfilPlz == NameStandoff27 || NameSimProfilPlz == IDStandoff27 || NameSimProfilPlz == NameTelegram27)
            {
                ProfilAva27 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "28" || NameSimProfilPlz == IDTelegram28 || NameSimProfilPlz == NameStandoff28 || NameSimProfilPlz == IDStandoff28 || NameSimProfilPlz == NameTelegram28)
            {
                ProfilAva28 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "29" || NameSimProfilPlz == IDTelegram29 || NameSimProfilPlz == NameStandoff29 || NameSimProfilPlz == IDStandoff29 || NameSimProfilPlz == NameTelegram29)
            {
                ProfilAva29 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "30" || NameSimProfilPlz == IDTelegram30 || NameSimProfilPlz == NameStandoff30 || NameSimProfilPlz == IDStandoff30 || NameSimProfilPlz == NameTelegram30)
            {
                ProfilAva30 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "31" || NameSimProfilPlz == IDTelegram31 || NameSimProfilPlz == NameStandoff31 || NameSimProfilPlz == IDStandoff31 || NameSimProfilPlz == NameTelegram31)
            {
                ProfilAva31 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "32" || NameSimProfilPlz == IDTelegram32 || NameSimProfilPlz == NameStandoff32 || NameSimProfilPlz == IDStandoff32 || NameSimProfilPlz == NameTelegram32)
            {
                ProfilAva32 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "33" || NameSimProfilPlz == IDTelegram33 || NameSimProfilPlz == NameStandoff33 || NameSimProfilPlz == IDStandoff33 || NameSimProfilPlz == NameTelegram33)
            {
                ProfilAva33 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "34" || NameSimProfilPlz == IDTelegram34 || NameSimProfilPlz == NameStandoff34 || NameSimProfilPlz == IDStandoff34 || NameSimProfilPlz == NameTelegram34)
            {
                ProfilAva34 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "35" || NameSimProfilPlz == IDTelegram35 || NameSimProfilPlz == NameStandoff35 || NameSimProfilPlz == IDStandoff35 || NameSimProfilPlz == NameTelegram35)
            {
                ProfilAva35 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "36" || NameSimProfilPlz == IDTelegram36 || NameSimProfilPlz == NameStandoff36 || NameSimProfilPlz == IDStandoff36 || NameSimProfilPlz == NameTelegram36)
            {
                ProfilAva36 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "37" || NameSimProfilPlz == IDTelegram37 || NameSimProfilPlz == NameStandoff37 || NameSimProfilPlz == IDStandoff37 || NameSimProfilPlz == NameTelegram37)
            {
                ProfilAva37 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "38" || NameSimProfilPlz == IDTelegram38 || NameSimProfilPlz == NameStandoff38 || NameSimProfilPlz == IDStandoff38 || NameSimProfilPlz == NameTelegram38)
            {
                ProfilAva38 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "39" || NameSimProfilPlz == IDTelegram39 || NameSimProfilPlz == NameStandoff39 || NameSimProfilPlz == IDStandoff39 || NameSimProfilPlz == NameTelegram39)
            {
                ProfilAva39 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "40" || NameSimProfilPlz == IDTelegram40 || NameSimProfilPlz == NameStandoff40 || NameSimProfilPlz == IDStandoff40 || NameSimProfilPlz == NameTelegram40)
            {
                ProfilAva40 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "41" || NameSimProfilPlz == IDTelegram41 || NameSimProfilPlz == NameStandoff41 || NameSimProfilPlz == IDStandoff41 || NameSimProfilPlz == NameTelegram41)
            {
                ProfilAva41 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "42" || NameSimProfilPlz == IDTelegram42 || NameSimProfilPlz == NameStandoff42 || NameSimProfilPlz == IDStandoff42 || NameSimProfilPlz == NameTelegram42)
            {
                ProfilAva42 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "43" || NameSimProfilPlz == IDTelegram43 || NameSimProfilPlz == NameStandoff43 || NameSimProfilPlz == IDStandoff43 || NameSimProfilPlz == NameTelegram43)
            {
                ProfilAva43 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "44" || NameSimProfilPlz == IDTelegram44 || NameSimProfilPlz == NameStandoff44 || NameSimProfilPlz == IDStandoff44 || NameSimProfilPlz == NameTelegram44)
            {
                ProfilAva44 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "45" || NameSimProfilPlz == IDTelegram45 || NameSimProfilPlz == NameStandoff45 || NameSimProfilPlz == IDStandoff45 || NameSimProfilPlz == NameTelegram45)
            {
                ProfilAva45 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "46" || NameSimProfilPlz == IDTelegram46 || NameSimProfilPlz == NameStandoff46 || NameSimProfilPlz == IDStandoff46 || NameSimProfilPlz == NameTelegram46)
            {
                ProfilAva46 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "47" || NameSimProfilPlz == IDTelegram47 || NameSimProfilPlz == NameStandoff47 || NameSimProfilPlz == IDStandoff47 || NameSimProfilPlz == NameTelegram47)
            {
                ProfilAva47 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "48" || NameSimProfilPlz == IDTelegram48 || NameSimProfilPlz == NameStandoff48 || NameSimProfilPlz == IDStandoff48 || NameSimProfilPlz == NameTelegram48)
            {
                ProfilAva48 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "49" || NameSimProfilPlz == IDTelegram49 || NameSimProfilPlz == NameStandoff49 || NameSimProfilPlz == IDStandoff49 || NameSimProfilPlz == NameTelegram49)
            {
                ProfilAva49 = "Co-Leader";
            }
            else if (NameSimProfilPlz == "50" || NameSimProfilPlz == IDTelegram50 || NameSimProfilPlz == NameStandoff50 || NameSimProfilPlz == IDStandoff50 || NameSimProfilPlz == NameTelegram50)
            {
                ProfilAva50 = "Co-Leader";
            }
            #endregion
        }

        #endregion
        //Добавление в основной состав/Выдача аватарки и повышение/понижение

        #region HelloInline

        [ReplyMenuHandler(PRTelegramBot.Models.Enums.CommandComparison.Contains, "Привет", "Здравствуйте", "Hello", "Салют", "Хай", "Хелло", "Хи", "Салам", "Ку")]
        public static async Task HelloInLine(ITelegramBotClient botClient, Update update)
        {
            var example = new InlineCallback("Правила 📃", PRHeadlers.Example);
            var example2 = new InlineCallback("Роли", PRHeadlers.Example2);
            var exampleAddPlyaer = new InlineCallback("С какого звания принимать?", PRHeadlers.ExampleAddPlyaer);
            var Roule = new InlineCallback("Игровые команды ", PRHeadlers.Roule);
            var Profil = new InlineCallback("Профиль", PRHeadlers.Profil);
            var Commands = new InlineCallback("Slash Команды", PRHeadlers.Commands);
            //varCaseMain =new InlineCallback("Case 📦",PRHeadlers.CaseMain);

            var list = new List<IInlineContent>();
            list.Add(example);
            list.Add(example2);
            list.Add(exampleAddPlyaer);
            list.Add(Roule);
            list.Add(Profil);
            list.Add(Commands);
            //listAddCaseMain);

            var menu = MenuGenerator.InlineKeyboard(3, list);

            var option = new OptionMessage();
            option.MenuInlineKeyboardMarkup = menu;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Здравствуйте. Меню успешно открыто. {News}", option);
        }
        #endregion
        //Открытие меню на приветствие.

        #region UpdateList

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.UpdateListBlack)]
        public static async Task UpdateListBlack(ITelegramBotClient botClient, Update update)
        {
            BlackSpisoc = false;
            var msg = update.Message;
            AllPlzBlack = BlackSpisocAdd;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Чёрный список обнавлен.");
            await PRTelegramBot.Helpers.Message.Send(botClient, update, $"{AllPlzBlack}");
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.UpdateListWhite)]
        public static async Task UpdateListWhite(ITelegramBotClient botClient, Update update)
        {
            WhiteSpisoc = false;
            var msg = update.Message;
            AllPlzWhite = WhiteSpisocAdd;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Белый список обнавлен.");
            await PRTelegramBot.Helpers.Message.Send(botClient, update, $"{AllPlzWhite}");
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.UpdateListEsport)]
        public static async Task UpdateListEsport(ITelegramBotClient botClient, Update update)
        {
            EsportSpisoc = false;
            var msg = update.Message;
            AllPlzEsport = EsportSpisocAdd;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Список основного состава обнавлен.");
            await PRTelegramBot.Helpers.Message.Send(botClient, update, $"{AllPlzEsport}");
        }
        #endregion
        //Обновляет списки.

        #region Case

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.CaseMain)]
        public static async Task CaseMain(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var CaseShop = new InlineCallback("Shop case", PRHeadlers.CaseShop);

            var list = new List<IInlineContent>();
            list.Add(example3);
            list.Add(CaseShop);

            var menuPrav = MenuGenerator.InlineKeyboard(1, list);

            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Меню с кейсами успешно открыто.", option1);
        }

        #region CaseShop

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.CaseShop)]
        public static async Task CaseShop(ITelegramBotClient botClient, Update update)
        {
            var CaseMain = new InlineCallback("Case", PRHeadlers.CaseMain);
            var Fable = new InlineCallback("Fable - 100", PRHeadlers.Fable);

            var list = new List<IInlineContent>();
            list.Add(CaseMain);
            list.Add(Fable);

            var menuPrav = MenuGenerator.InlineKeyboard(1, list);

            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Магазин кейсов успешно открыт.", option1);
        }

        #endregion

        #endregion
        //Покупка кейсов, их открытие и статистика.

        #region RedactProfil

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RedactProfil)]
        public static async Task RedactProfil(ITelegramBotClient botClient, Update update)
        {
            var RedactStandoffName = new InlineCallback("StandoffName", PRHeadlers.RedactStandoffName);
            var RedactStandoffID = new InlineCallback("StandoffID", PRHeadlers.RedactStandoffID);

            var list = new List<IInlineContent>();
            list.Add(RedactStandoffName);
            list.Add(RedactStandoffID);

            var menuPrav = MenuGenerator.InlineKeyboard(1, list);

            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Выберите, что хотите изменить.", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RedactStandoffName)]
        public static async Task RedactStandoffName(ITelegramBotClient botClient, Update update)
        {
            var RedactStandoffNameYes = new InlineCallback("Подтвердить", PRHeadlers.RedactStandoffNameYes);

            var list = new List<IInlineContent>();
            list.Add(RedactStandoffNameYes);

            var menuPrav = MenuGenerator.InlineKeyboard(1, list);

            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Укажите новый StandoffName, после нажмите подтвердить.", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RedactStandoffNameYes)]
        public static async Task RedactStandoffNameYes(ITelegramBotClient botClient, Update update)
        {
            if (IDConverts4 != null)
            {
                if (IDConverts4 == IDTelegram1)
                    NameStandoff1 = MessSim;
                else if (IDConverts4 == IDTelegram2)
                    NameStandoff2 = MessSim;
                else if (IDConverts4 == IDTelegram3)
                    NameStandoff3 = MessSim;
                else if (IDConverts4 == IDTelegram4)
                    NameStandoff4 = MessSim;
                else if (IDConverts4 == IDTelegram5)
                    NameStandoff5 = MessSim;
                else if (IDConverts4 == IDTelegram6)
                    NameStandoff6 = MessSim;
                else if (IDConverts4 == IDTelegram7)
                    NameStandoff7 = MessSim;
                else if (IDConverts4 == IDTelegram8)
                    NameStandoff8 = MessSim;
                else if (IDConverts4 == IDTelegram9)
                    NameStandoff9 = MessSim;
                else if (IDConverts4 == IDTelegram10)
                    NameStandoff10 = MessSim;
                else if (IDConverts4 == IDTelegram11)
                    NameStandoff11 = MessSim;
                else if (IDConverts4 == IDTelegram12)
                    NameStandoff12 = MessSim;
                else if (IDConverts4 == IDTelegram13)
                    NameStandoff13 = MessSim;
                else if (IDConverts4 == IDTelegram14)
                    NameStandoff14 = MessSim;
                else if (IDConverts4 == IDTelegram15)
                    NameStandoff15 = MessSim;
                else if (IDConverts4 == IDTelegram16)
                    NameStandoff16 = MessSim;
                else if (IDConverts4 == IDTelegram17)
                    NameStandoff17 = MessSim;
                else if (IDConverts4 == IDTelegram18)
                    NameStandoff18 = MessSim;
                else if (IDConverts4 == IDTelegram19)
                    NameStandoff19 = MessSim;
                else if (IDConverts4 == IDTelegram20)
                    NameStandoff20 = MessSim;
                else if (IDConverts4 == IDTelegram21)
                    NameStandoff21 = MessSim;
                else if (IDConverts4 == IDTelegram22)
                    NameStandoff22 = MessSim;
                else if (IDConverts4 == IDTelegram23)
                    NameStandoff23 = MessSim;
                else if (IDConverts4 == IDTelegram24)
                    NameStandoff24 = MessSim;
                else if (IDConverts4 == IDTelegram25)
                    NameStandoff25 = MessSim;
                else if (IDConverts4 == IDTelegram26)
                    NameStandoff26 = MessSim;
                else if (IDConverts4 == IDTelegram27)
                    NameStandoff27 = MessSim;
                else if (IDConverts4 == IDTelegram28)
                    NameStandoff28 = MessSim;
                else if (IDConverts4 == IDTelegram29)
                    NameStandoff29 = MessSim;
                else if (IDConverts4 == IDTelegram30)
                    NameStandoff30 = MessSim;
                else if (IDConverts4 == IDTelegram31)
                    NameStandoff31 = MessSim;
                else if (IDConverts4 == IDTelegram32)
                    NameStandoff32 = MessSim;
                else if (IDConverts4 == IDTelegram33)
                    NameStandoff33 = MessSim;
                else if (IDConverts4 == IDTelegram34)
                    NameStandoff34 = MessSim;
                else if (IDConverts4 == IDTelegram35)
                    NameStandoff35 = MessSim;
                else if (IDConverts4 == IDTelegram36)
                    NameStandoff36 = MessSim;
                else if (IDConverts4 == IDTelegram37)
                    NameStandoff37 = MessSim;
                else if (IDConverts4 == IDTelegram38)
                    NameStandoff38 = MessSim;
                else if (IDConverts4 == IDTelegram39)
                    NameStandoff39 = MessSim;
                else if (IDConverts4 == IDTelegram40)
                    NameStandoff40 = MessSim;
                else if (IDConverts4 == IDTelegram41)
                    NameStandoff41 = MessSim;
                else if (IDConverts4 == IDTelegram42)
                    NameStandoff42 = MessSim;
                else if (IDConverts4 == IDTelegram43)
                    NameStandoff43 = MessSim;
                else if (IDConverts4 == IDTelegram44)
                    NameStandoff44 = MessSim;
                else if (IDConverts4 == IDTelegram45)
                    NameStandoff45 = MessSim;
                else if (IDConverts4 == IDTelegram46)
                    NameStandoff46 = MessSim;
                else if (IDConverts4 == IDTelegram47)
                    NameStandoff47 = MessSim;
                else if (IDConverts4 == IDTelegram48)
                    NameStandoff48 = MessSim;
                else if (IDConverts4 == IDTelegram49)
                    NameStandoff49 = MessSim;
                else if (IDConverts4 == IDTelegram50)
                    NameStandoff50 = MessSim;

                var example3 = new InlineCallback("Меню", PRHeadlers.Example3);

                var list = new List<IInlineContent>();
                list.Add(example3);

                var menuPrav = MenuGenerator.InlineKeyboard(1, list);

                var option1 = new OptionMessage();
                option1.MenuInlineKeyboardMarkup = menuPrav;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Установлен новый StandoffName.", option1);
            }
            else
            {
                var example3 = new InlineCallback("Меню", PRHeadlers.Example3);

                var list = new List<IInlineContent>();
                list.Add(example3);

                var menuPrav = MenuGenerator.InlineKeyboard(1, list);

                var option1 = new OptionMessage();
                option1.MenuInlineKeyboardMarkup = menuPrav;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Вы не указали новый ник, либо у вас нет профиля. Редакция отменина.", option1);
            }
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RedactStandoffID)]
        public static async Task RedactStandoffID(ITelegramBotClient botClient, Update update)
        {
            var RedactStandoffIDYes = new InlineCallback("Подтвердить", PRHeadlers.RedactStandoffIDYes);

            var list = new List<IInlineContent>();
            list.Add(RedactStandoffIDYes);

            var menuPrav = MenuGenerator.InlineKeyboard(1, list);

            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Укажите новое StandoffID, после нажмите подтвердить.", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.RedactStandoffIDYes)]
        public static async Task RedactStandoffIDYes(ITelegramBotClient botClient, Update update)
        {
            if (IDConverts4 != null)
            {
                if (IDConverts4 == IDTelegram1)
                    IDStandoff1 = MessSim;
                else if (IDConverts4 == IDTelegram2)
                    IDStandoff2 = MessSim;
                else if (IDConverts4 == IDTelegram3)
                    IDStandoff3 = MessSim;
                else if (IDConverts4 == IDTelegram4)
                    IDStandoff4 = MessSim;
                else if (IDConverts4 == IDTelegram5)
                    IDStandoff5 = MessSim;
                else if (IDConverts4 == IDTelegram6)
                    IDStandoff6 = MessSim;
                else if (IDConverts4 == IDTelegram7)
                    IDStandoff7 = MessSim;
                else if (IDConverts4 == IDTelegram8)
                    IDStandoff8 = MessSim;
                else if (IDConverts4 == IDTelegram9)
                    IDStandoff9 = MessSim;
                else if (IDConverts4 == IDTelegram10)
                    IDStandoff10 = MessSim;
                else if (IDConverts4 == IDTelegram11)
                    IDStandoff11 = MessSim;
                else if (IDConverts4 == IDTelegram12)
                    IDStandoff12 = MessSim;
                else if (IDConverts4 == IDTelegram13)
                    IDStandoff13 = MessSim;
                else if (IDConverts4 == IDTelegram14)
                    IDStandoff14 = MessSim;
                else if (IDConverts4 == IDTelegram15)
                    IDStandoff15 = MessSim;
                else if (IDConverts4 == IDTelegram16)
                    IDStandoff16 = MessSim;
                else if (IDConverts4 == IDTelegram17)
                    IDStandoff17 = MessSim;
                else if (IDConverts4 == IDTelegram18)
                    IDStandoff18 = MessSim;
                else if (IDConverts4 == IDTelegram19)
                    IDStandoff19 = MessSim;
                else if (IDConverts4 == IDTelegram20)
                    IDStandoff20 = MessSim;
                else if (IDConverts4 == IDTelegram21)
                    IDStandoff21 = MessSim;
                else if (IDConverts4 == IDTelegram22)
                    IDStandoff22 = MessSim;
                else if (IDConverts4 == IDTelegram23)
                    IDStandoff23 = MessSim;
                else if (IDConverts4 == IDTelegram24)
                    IDStandoff24 = MessSim;
                else if (IDConverts4 == IDTelegram25)
                    IDStandoff25 = MessSim;
                else if (IDConverts4 == IDTelegram26)
                    IDStandoff26 = MessSim;
                else if (IDConverts4 == IDTelegram27)
                    IDStandoff27 = MessSim;
                else if (IDConverts4 == IDTelegram28)
                    IDStandoff28 = MessSim;
                else if (IDConverts4 == IDTelegram29)
                    IDStandoff29 = MessSim;
                else if (IDConverts4 == IDTelegram30)
                    IDStandoff30 = MessSim;
                else if (IDConverts4 == IDTelegram31)
                    IDStandoff31 = MessSim;
                else if (IDConverts4 == IDTelegram32)
                    IDStandoff32 = MessSim;
                else if (IDConverts4 == IDTelegram33)
                    IDStandoff33 = MessSim;
                else if (IDConverts4 == IDTelegram34)
                    IDStandoff34 = MessSim;
                else if (IDConverts4 == IDTelegram35)
                    IDStandoff35 = MessSim;
                else if (IDConverts4 == IDTelegram36)
                    IDStandoff36 = MessSim;
                else if (IDConverts4 == IDTelegram37)
                    IDStandoff37 = MessSim;
                else if (IDConverts4 == IDTelegram38)
                    IDStandoff38 = MessSim;
                else if (IDConverts4 == IDTelegram39)
                    IDStandoff39 = MessSim;
                else if (IDConverts4 == IDTelegram40)
                    IDStandoff40 = MessSim;
                else if (IDConverts4 == IDTelegram41)
                    IDStandoff41 = MessSim;
                else if (IDConverts4 == IDTelegram42)
                    IDStandoff42 = MessSim;
                else if (IDConverts4 == IDTelegram43)
                    IDStandoff43 = MessSim;
                else if (IDConverts4 == IDTelegram44)
                    IDStandoff44 = MessSim;
                else if (IDConverts4 == IDTelegram45)
                    IDStandoff45 = MessSim;
                else if (IDConverts4 == IDTelegram46)
                    IDStandoff46 = MessSim;
                else if (IDConverts4 == IDTelegram47)
                    IDStandoff47 = MessSim;
                else if (IDConverts4 == IDTelegram48)
                    IDStandoff48 = MessSim;
                else if (IDConverts4 == IDTelegram49)
                    IDStandoff49 = MessSim;
                else if (IDConverts4 == IDTelegram50)
                    IDStandoff50 = MessSim;

                var example3 = new InlineCallback("Меню", PRHeadlers.Example3);

                var list = new List<IInlineContent>();
                list.Add(example3);

                var menuPrav = MenuGenerator.InlineKeyboard(1, list);

                var option1 = new OptionMessage();
                option1.MenuInlineKeyboardMarkup = menuPrav;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Установлено новое StandoffID.", option1);
            }
            else
            {
                var example3 = new InlineCallback("Меню", PRHeadlers.Example3);

                var list = new List<IInlineContent>();
                list.Add(example3);

                var menuPrav = MenuGenerator.InlineKeyboard(1, list);

                var option1 = new OptionMessage();
                option1.MenuInlineKeyboardMarkup = menuPrav;
                await PRTelegramBot.Helpers.Message.Send(botClient, update, "Вы не указали новое айди, либо у вас нет профиля. Редакция отменина.", option1);
            }
        }
        #endregion
        //Редактирование StandoffNAme или StandoffID.

        #region NewsAdd

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AddNews)]
        public static async Task AddNews(ITelegramBotClient botClient, Update update)
        {
            NewsProverca = true;

            var AddNewsYes = new InlineCallback("Подтвердить", PRHeadlers.AddNewsYes);
            var list = new List<IInlineContent>();
            list.Add(AddNewsYes);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Отправьте новости одним сообщением.", option1);
        }

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AddNewsYes)]
        public static async Task AddNewsYes(ITelegramBotClient botClient, Update update)
        {
            NewsProverca = false;

            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, $"Новости: {News}", option1);
        }

        #endregion
        //Добавление новых новостей.

        #region Maps

        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.Maps)]
        public static async Task Maps(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "Карты на которых играет клан:\n\r\n1. <b>Sandstone</b>\n\r2. <b>Province</b>\n\r3. <b>Rast</b>\n\r4. <b>Dune</b>\n\r5. <b>Breeze</b>", option1);
        }

        #endregion
        //Карты на которых играем.

        #region AvaAdds
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AvaMember)]
        public static async Task AvaAddMember(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "https://radikal.host/i/Mx5rdh", option1);
        }
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AvaElder)]
        public static async Task AvaAddElder(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "https://radikal.host/i/Mx8Z5C", option1);
        }
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AvaCoLeader)]
        public static async Task AvaAddCoLeader(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "https://radikal.host/i/Mx8DeE", option1);
        }
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AvaRed)]
        public static async Task AvaRed(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "https://radikal.host/i/Mx8EXD", option1);
        }
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AvaBirch)]
        public static async Task AvaBirch(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "https://radikal.host/i/MDVPjK", option1);
        }
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AvaOrange)]
        public static async Task AvaOrange(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "https://radikal.host/i/Mx8Ghz", option1);
        }
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AvaBlack)]
        public static async Task AvaBlack(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "https://radikal.host/i/M7MbXA", option1);
        }
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AvaBlue)]
        public static async Task AvaBlue(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "https://radikal.host/i/Mx80p8", option1);
        }
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AvaPersonalize)]
        public static async Task AvaPersonalize(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "https://radikal.host/i/M7MIQE", option1);
        }
        [InlineCallbackHandler<PRHeadlers>(PRHeadlers.AvaPink)]
        public static async Task AvaPink(ITelegramBotClient botClient, Update update)
        {
            var example3 = new InlineCallback("Меню", PRHeadlers.Example3);
            var list = new List<IInlineContent>();
            list.Add(example3);
            var menuPrav = MenuGenerator.InlineKeyboard(1, list);
            var option1 = new OptionMessage();
            option1.MenuInlineKeyboardMarkup = menuPrav;
            await PRTelegramBot.Helpers.Message.Send(botClient, update, "https://radikal.host/i/Mx8Rld", option1);
        }
        #endregion
        //Получение аватарки
    }
}
#endregion