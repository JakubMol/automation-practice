using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.Register
{
    public class InputEmailCreate : IActorAction<ActionHelpers>
    {
        private readonly string _email;
        public InputEmailCreate(string email)
        {
            _email = email;
        }
        public void Execute(ActionHelpers helpers)
        {
            helpers.SendKeys(By.Id("email_create"), _email);
            helpers.Click(By.Id("SubmitCreate"));
        }
    }
}
