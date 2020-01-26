using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.Checkout
{
    public class AgreeToTnc : IActorAction<ActionHelpers>
    {
        public void Execute(ActionHelpers helpers)
        {
            helpers.Click(By.XPath("//*[text()='I agree to the terms of service and will adhere to them unconditionally.']"));           
        }
    }
}
