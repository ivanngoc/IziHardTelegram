//#pragma warning disable
using BotForTelegram.IziHardGames;
using IziHardGames.BotForTelegram;
using IziHardGames.ForTelegram.ClientResultHandlers;
using IziHardGames.ForTelegram.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Td;
using Telegram.Td.Api;

namespace IziHardGames.ForTelegram.Accounting
{
    /// <summary>
    /// Example class for TDLib usage from C#.
    /// </summary>
    /// <see cref="GetCommand"/>
    /// https://core.telegram.org/tdlib/docs/td__api_8h.html
    public class IziTgAccount : IDisposable, ITgAccount
    {
        //private Client? client;
        ///// <summary>
        ///// </summary>
        ///// <see cref="DefaultHandler"/>
        //private readonly ClientResultHandler defaultHandler;

        //private AuthorizationState _authorizationState = null;
        //private volatile bool isHaveAuthorization = false;
        //private volatile bool isNeedQuit = false;
        //private volatile bool isCanQuit = false;

        //private volatile AutoResetEvent _gotAuthorization = new AutoResetEvent(false);

        //private readonly string newLine = Environment.NewLine;
        //private const string commandsLine = "Enter command:\n" +
        //    "gc <chatId> - GetChat\n" +
        //    "me - GetMe\n" +
        //    "sm <chatId> <message> - SendMessage\n" +
        //    "lo - LogOut\n" +
        //    "r - Restart\n" +
        //    "q - Quit\n" +
        //    "chats - Load Chats\n" +
        //    "sc - <chatId> Select Chat";

        //private volatile string currentPrompt = null;

        private ConfigForBotForTelegram config;
        //private Chat? chatSelected;
        //private static Task task;

        public IziTgAccount(ConfigForBotForTelegram configForBotForTelegram)
        {
            config = configForBotForTelegram;
            //defaultHandler = new DefaultHandler(this);
            //client = Client.Create(new UpdateHandler(this));
        }

        //private Client CreateTdClient()
        //{
        //    return Client.Create(new UpdateHandler(this));
        //}

        //private void Print(string str)
        //{
        //    if (currentPrompt != null)
        //    {
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine(str);

        //    if (currentPrompt != null)
        //    {
        //        Console.Write(currentPrompt);
        //    }
        //}

        //private string ReadLine(string str)
        //{
        //    Console.WriteLine(str);
        //    currentPrompt = str;
        //    var result = Console.ReadLine();
        //    currentPrompt = null;
        //    return result;
        //}

        //private void OnAuthorizationStateUpdated(AuthorizationState authorizationState)
        //{
        //    if (authorizationState != null)
        //    {
        //        _authorizationState = authorizationState;
        //    }
        //    if (_authorizationState is AuthorizationStateWaitTdlibParameters)
        //    {
        //        TdlibParameters parameters = new TdlibParameters();
        //        parameters.DatabaseDirectory = "tdlib";
        //        parameters.UseMessageDatabase = true;
        //        parameters.UseSecretChats = true;
        //        parameters.ApiId = config.ApiId;
        //        parameters.ApiHash = config.ApiHash;
        //        parameters.SystemLanguageCode = config.SystemLanguageCode;
        //        parameters.DeviceModel = "Desktop";
        //        parameters.ApplicationVersion = "202209230424";
        //        parameters.EnableStorageOptimizer = true;

        //        client.Send(new SetTdlibParameters(parameters), new AuthorizationRequestHandler(this));
        //    }
        //    else if (_authorizationState is AuthorizationStateWaitEncryptionKey)
        //    {
        //        client.Send(new CheckDatabaseEncryptionKey(), new AuthorizationRequestHandler(this));
        //    }
        //    else if (_authorizationState is AuthorizationStateWaitPhoneNumber)
        //    {
        //        client.Send(new SetAuthenticationPhoneNumber(config.Number, null), new AuthorizationRequestHandler(this));
        //    }
        //    else if (_authorizationState is AuthorizationStateWaitOtherDeviceConfirmation state)
        //    {
        //        Console.WriteLine("Please confirm this login link on another device: " + state.Link);
        //    }
        //    else if (_authorizationState is AuthorizationStateWaitCode)
        //    {
        //        string code = ReadLine("Please enter authentication code: ");
        //        client.Send(new CheckAuthenticationCode(code), new AuthorizationRequestHandler(this));
        //    }
        //    else if (_authorizationState is AuthorizationStateWaitRegistration)
        //    {
        //        string firstName = ReadLine("Please enter your first name: ");
        //        string lastName = ReadLine("Please enter your last name: ");
        //        client.Send(new RegisterUser(firstName, lastName, false), new AuthorizationRequestHandler(this));
        //    }
        //    else if (_authorizationState is AuthorizationStateWaitPassword)
        //    {
        //        client.Send(new CheckAuthenticationPassword(config.Password), new AuthorizationRequestHandler(this));
        //    }
        //    else if (_authorizationState is AuthorizationStateReady)
        //    {
        //        isHaveAuthorization = true;
        //        _gotAuthorization.Set();
        //    }
        //    else if (_authorizationState is AuthorizationStateLoggingOut)
        //    {
        //        isHaveAuthorization = false;
        //        Print("Logging out");
        //    }
        //    else if (_authorizationState is AuthorizationStateClosing)
        //    {
        //        isHaveAuthorization = false;
        //        Print("Closing");
        //    }
        //    else if (_authorizationState is AuthorizationStateClosed)
        //    {
        //        Print("Closed");

        //        if (!isNeedQuit)
        //        {
        //            client = CreateTdClient(); // recreate _client after previous has closed
        //        }
        //        else
        //        {
        //            Dispose();
        //            isCanQuit = true;
        //        }
        //    }
        //    else
        //    {
        //        Print("Unsupported authorization state:" + newLine + _authorizationState);
        //    }
        //}

        //private long GetChatId(string arg)
        //{
        //    long chatId = 0;
        //    try
        //    {
        //        chatId = Convert.ToInt64(arg);
        //    }
        //    catch (FormatException)
        //    {
        //    }
        //    catch (OverflowException)
        //    {
        //    }
        //    return chatId;
        //}

        //private void GetCommand()
        //{
        //    string command = ReadLine(commandsLine);
        //    string[] commands = command.Split(new char[] { ' ' }, 2);
        //    try
        //    {
        //        switch (commands[0])
        //        {
        //            case "gc":
        //                client.Send(new GetChat(GetChatId(commands[1])), defaultHandler);
        //                break;
        //            case "me":
        //                client.Send(new GetMe(), defaultHandler);
        //                break;
        //            case "sm":
        //                string[] args = commands[1].Split(new char[] { ' ' }, 2);
        //                SendMessage(GetChatId(args[0]), args[1]);
        //                break;
        //            case "lo":
        //                isHaveAuthorization = false;
        //                client.Send(new LogOut(), defaultHandler);
        //                break;
        //            case "r":
        //                isHaveAuthorization = false;
        //                client.Send(new Close(), defaultHandler);
        //                break;
        //            case "q":
        //                isNeedQuit = true;
        //                isHaveAuthorization = false;
        //                client.Send(new Close(), defaultHandler);
        //                break;
        //            case "chats":
        //                {
        //                    client.Send(new GetChats(null, 1000), defaultHandler);
        //                    //_client.Send(new Telegram.Td.Api.Chats(), _defaultHandler);
        //                    break;
        //                }
        //            default:
        //                Print("Unsupported command: " + command);
        //                break;
        //        }
        //    }
        //    catch (IndexOutOfRangeException)
        //    {
        //        Print("Not enough arguments");
        //    }
        //}

        //private void SendMessage(long chatId, string message)
        //{
        //    // initialize reply markup just for testing
        //    InlineKeyboardButton[] row = { new InlineKeyboardButton("https://telegram.org?1", new InlineKeyboardButtonTypeUrl()), new InlineKeyboardButton("https://telegram.org?2", new InlineKeyboardButtonTypeUrl()), new InlineKeyboardButton("https://telegram.org?3", new InlineKeyboardButtonTypeUrl()) };
        //    ReplyMarkup replyMarkup = new ReplyMarkupInlineKeyboard(new InlineKeyboardButton[][] { row, row, row });

        //    InputMessageContent content = new InputMessageText(new FormattedText(message, null), false, true);
        //    client.Send(new SendMessage(chatId, 0, 0, null, replyMarkup, content), defaultHandler);
        //}

        public async Task RunAsync()
        {
            throw new System.NotImplementedException();
            //// disable TDLib log
            //Client.Execute(new SetLogVerbosityLevel(0));
            //if (Client.Execute(new SetLogStream(new LogStreamFile("tdlib.log", 1 << 27, false))) is Error)
            //{
            //    throw new System.IO.IOException("Write access to the current directory is required");
            //}
            //var t1 = Task.Run(() => Client.Run());
            //// create Td.Client
            //client = CreateTdClient();

            //// test Client.Execute
            //defaultHandler.OnResult(Client.Execute(new GetTextEntities("@telegram /test_command https://telegram.org telegram.me @gif @test")));

            //// main loop
            //while (!isNeedQuit)
            //{
            //    // await authorization
            //    _gotAuthorization.Reset();
            //    _gotAuthorization.WaitOne();

            //    client.Send(new LoadChats(null, 100), defaultHandler); // preload main chat list

            //    while (isHaveAuthorization)
            //    {
            //        GetCommand();
            //    }
            //}
            //while (!isCanQuit)
            //{
            //    Thread.Sleep(1);
            //}
        }

        //private class DefaultHandler : ClientResultHandler
        //{
        //    private IziTgAccount exampleClient;
        //    public DefaultHandler(IziTgAccount exampleClient)
        //    {
        //        this.exampleClient = exampleClient;
        //    }

        //    /// <see cref="TextEntities"/>
        //    /// <see cref="ChatLists"/>
        //    void ClientResultHandler.OnResult(BaseObject obj)
        //    {
        //        //Console.WriteLine($"{obj.GetType()}{Environment.NewLine}{obj.ToString()}");
        //        //exampleClient.Print(obj.ToString());

        //        if (obj is Chats chats)
        //        {
        //            Console.WriteLine(chats);

        //            foreach (var item in chats.ChatIds)
        //            {
        //                exampleClient.client.Send(new GetChat(item), this);
        //            }
        //        }
        //        else if (obj is Chat chat)
        //        {
        //            Console.WriteLine(chat.Title);
        //        }
        //    }
        //}

        //private class UpdateHandler : ClientResultHandler
        //{
        //    private IziTgAccount exampleClient;

        //    public UpdateHandler(IziTgAccount exampleClient)
        //    {
        //        this.exampleClient = exampleClient;
        //    }

        //    void ClientResultHandler.OnResult(BaseObject obj)
        //    {
        //        //Console.WriteLine($"{obj.GetType()}{Environment.NewLine}{obj.ToString()}");
        //        //Console.WriteLine($"{obj.GetType()}");

        //        if (obj is UpdateAuthorizationState)
        //        {
        //            exampleClient.OnAuthorizationStateUpdated((obj as UpdateAuthorizationState).AuthorizationState);
        //        }
        //        else if (obj is UpdateNewChat unc)
        //        {
        //            //Console.WriteLine($"UpdateNewChat:{unc.ToString()}");
        //        }
        //        else
        //        {
        //            // Print("Unsupported update: " + @object);
        //        }
        //    }
        //}

        //private class AuthorizationRequestHandler : ClientResultHandler
        //{
        //    private IziTgAccount exampleClient;
        //    public AuthorizationRequestHandler(IziTgAccount exampleClient)
        //    {
        //        this.exampleClient = exampleClient;
        //    }
        //    void ClientResultHandler.OnResult(BaseObject obj)
        //    {
        //        //Console.WriteLine($"{obj.GetType()}{Environment.NewLine}{obj.ToString()}");

        //        if (obj is Error)
        //        {
        //            exampleClient.Print("Receive an error:" + exampleClient.newLine + obj);
        //            exampleClient.OnAuthorizationStateUpdated(null); // repeat last action
        //        }
        //        else
        //        {
        //            // result is already received through UpdateAuthorizationState, nothing to do
        //        }
        //    }
        //}

        public void Dispose()
        {

        }

        public IAsyncEnumerable<string> Chats()
        {
            throw new System.NotImplementedException();
            //var chats = new Chats();
            //var chatList = new ChatListMain();
            //var handler = new ChatsHandler();
            //client!.Send(new GetChats(chatList, 1000), handler);
            //return handler.AsyncEble();
        }

        internal static async Task<IziTgAccount> Default()
        {
            throw new System.NotImplementedException();
            //string json = await System.IO.File.ReadAllTextAsync("config.json").ConfigureAwait(false);
            //ConfigForBotForTelegram[] configs = JsonSerializer.Deserialize<ConfigForBotForTelegram[]>(json) ?? throw new NullReferenceException();
            //IziTgAccount telegramClient = new IziTgAccount(configs.First(x => x.Active));
            //Client.Execute(new SetLogVerbosityLevel(0));
            //task = Task.Run(() => Client.Run());
            //return telegramClient;
        }
    }
}
