using OpenQA.Selenium;

namespace Automation.Practice.WebDriver
{
    public class ActionHelpers : WebDriverInteractionBase
    {
        public ActionHelpers()
        {
        }
        public void Click(By by)
        {
            GetClickableElement(by).Click();
        }

        public void SendKeys(By by, string text)
        {
            GetClickableElement(by).SendKeys(text);
        }

        public string GetText(By by)
        {
            return GetVisableElement(by)
                    .Text;
        }

        public void Select(By by, string text)
        {
            GetSelectElement(by).SelectByText(text);
        }
    }
}
