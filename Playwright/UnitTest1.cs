using Microsoft.Playwright;
namespace PlaywrightWithPOM
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task TestMethod1()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            { Headless = false, SlowMo = 1, });
            var context = await browser.NewContextAsync();
            var page = await context.NewPageAsync();
            await page.GotoAsync("https://adactinhotelapp.com/");
            await page.FillAsync("#username", "AmirImam");
            await page.FillAsync("#password", "AmirImam");
            await page.ClickAsync("#login");
        }
    }
}