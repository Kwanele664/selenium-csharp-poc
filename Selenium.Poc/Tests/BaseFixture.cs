using Selenium.Poc.Assembly;
using Selenium.Poc.Browsers;
using Selenium.Poc.Reporting;
using Selenium.Poc.Utils;

namespace Selenium.Poc.Tests;

public class BaseFixture : IDisposable
{
    public readonly BrowserHelpers BrowserHelpers;
    public readonly PageLoader PageLoader;

    public BaseFixture()
    {
        var factory = new BrowserFactory(TestParameter.RemoteUrl);
        var driver = factory.GetDriver(Browser.Chrome);
        
        BrowserHelpers = new BrowserHelpers(driver);
        PageLoader = new PageLoader(driver);
    }

    public void Dispose()
    {
        BrowserHelpers.QuitBrowser();
        ExtentService.Instance.Flush();
    }
}