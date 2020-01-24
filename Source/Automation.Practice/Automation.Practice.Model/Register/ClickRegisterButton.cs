using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.Register
{
    public class ClickRegisterButton : IActorAction<ActionHelpers>
    {
        public void Execute(ActionHelpers helpers)
        {
            helpers.Click(By.Id("submitAccount"));
        }
    }
}
