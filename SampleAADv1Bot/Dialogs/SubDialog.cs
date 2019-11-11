using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace SampleAADv1Bot.Dialogs
{
    [LuisModel("6932da23-e550-40e0-acb9-b4821bd9f2e3", "9c8fdf4a41fc4e80a30e64e147af1e52")]
    public class SubDialog : LuisDialog<IMessageActivity>
    {

        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("sorry, I cannot undersand.");
        }
    }
}