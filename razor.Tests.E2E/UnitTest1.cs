using Microsoft.Playwright;
using Microsoft.Playwright.Xunit;
using System.Text.RegularExpressions;

namespace razor.Tests.E2E;

public class UnitTest1 : PageTest
{
    [Fact]
    public async Task TesteDaHome_DeveTerTituloCorreto()
    {
        await Page.GotoAsync("http://localhost:5107/schedules");

        await Expect(Page).ToHaveTitleAsync(new Regex("Home"));
    }
}