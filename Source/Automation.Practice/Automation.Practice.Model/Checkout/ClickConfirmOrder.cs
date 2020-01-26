using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.Checkout
{
    public class ClickConfirmOrder : IActorAction<ActionHelpers>
    {
        public void Execute(ActionHelpers helpers)
        {
            helpers.Click(By.XPath("//*[text()='I confirm my order']"));
        }
    }
}
