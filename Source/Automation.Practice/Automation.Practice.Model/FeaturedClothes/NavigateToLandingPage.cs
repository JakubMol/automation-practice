using Automation.Practice.WebDriver;

namespace Automation.Practice.Model.FeaturedClothes
{
    public class NavigateToLandingPage : IActorAction<ActionHelpers>
    {
        public void Execute(ActionHelpers helpers)
        {
            helpers.Navigate("http://automationpractice.com/index.php");
        }
    }
}
