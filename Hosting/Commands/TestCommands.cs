using DisCatSharp.CommandsNext;
using DisCatSharp.CommandsNext.Attributes;

using System.Threading.Tasks;

namespace DisCatSharp.Examples.Hosting.Commands;

public class TestCommands : BaseCommandModule
{
	[Command("ping"), Description("Test command for Hosting")]
	public async Task TestAsync(CommandContext ctx) => await ctx.RespondAsync($"Pong! Latency is {ctx.Client.Ping}ms");
}
