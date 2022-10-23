// See https://aka.ms/new-console-template for more information
using PuppeteerSharp;


using var browserFetcher = new BrowserFetcher();
await browserFetcher.DownloadAsync(BrowserFetcher.DefaultRevision);
var browser = await Puppeteer.LaunchAsync(new LaunchOptions
{
    Headless = false
});
var page = await browser.NewPageAsync();
await page.GoToAsync("https://www.google.com/");
await page.ScreenshotAsync("image.jpg");

Console.WriteLine("Hello, World!");