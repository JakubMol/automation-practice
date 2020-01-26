using Automation.Practice.WebDriver;
using OpenQA.Selenium;

namespace Automation.Practice.Model.ItemDetails
{
    public enum Size { S = 1, M = 2, L = 3 }
    public class SelectSize : IActorAction<ActionHelpers>
    {
        private readonly Size _size;
        public SelectSize(Size size)
        {
            _size = size;
        }
        public void Execute(ActionHelpers helpers)
        {
            helpers.Select(By.XPath("//*[@id='group_1']"), _size.ToString());
        }
    }
}
