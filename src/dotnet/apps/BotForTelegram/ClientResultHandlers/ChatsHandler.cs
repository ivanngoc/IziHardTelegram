using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Telegram.Td;
using Telegram.Td.Api;

namespace IziHardGames.ForTelegram.ClientResultHandlers
{
    public class ChatsHandler : ClientResultHandler
    {
        TaskCompletionSource<BaseObject> tcs = new();
        public void OnResult(BaseObject @object)
        {
            if (@object is Error e)
            {
                Console.WriteLine(e.Message);
            }
            else
            {
                tcs.SetResult(@object);
            }
        }

        internal async IAsyncEnumerable<string> AsyncEble()
        {
            var v = await tcs.Task;
            yield return v.GetType().AssemblyQualifiedName!;
        }
    }
}
