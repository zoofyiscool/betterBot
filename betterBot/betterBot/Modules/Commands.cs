using System.Threading.Tasks;
using Discord.Commands;
// using Discord;
// using Discord.WebSocket;

namespace betterBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        // help command

        [Command("help")]
        public async Task Help()
        {
            await ReplyAsync("``` Commands: \n 1. bb!ping \n 2. bb!supercoolfact ```");
        }

        // simple ping command

        [Command("ping")]
        public async Task Ping()
        {
            await ReplyAsync(Context.Message.Author.Mention + " Pong!");
           // await message.Author.SendMessageAsync("Poggers");
        }

        // super cool fact

        [Command("supercoolfact")]
        public async Task SuperCoolFact()
        {
            await ReplyAsync("your not cool");
        }
    }
}
