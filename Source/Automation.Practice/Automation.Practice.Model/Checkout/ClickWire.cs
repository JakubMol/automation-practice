using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.Checkout
{
    public class ClickWire : IActorAction<ActionHelpers>
    {
        public void Execute(ActionHelpers helpers)
        {
            helpers.Click(By.XPath("//*[@class='bankwire']"));           
        }
    }
}
