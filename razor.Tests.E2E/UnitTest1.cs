using Microsoft.Playwright.Xunit;

namespace razor.Tests.E2E;

public class UnitTest1 : PageTest
{
    [Fact]
    public async Task TesteDaHome_DeveTerTituloCorreto()
    {
        await Page.GotoAsync("http://localhost:5107/schedules");

        await Expect(Page.GetByText("Welcome2")).ToBeVisibleAsync();
    }
}