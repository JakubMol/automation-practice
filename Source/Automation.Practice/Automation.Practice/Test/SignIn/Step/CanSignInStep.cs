using TechTalk.SpecFlow;

namespace Automation.Practice.Test.SignIn.Step
{
    [Binding]
    public class CanSignInStep
    {
        [Given("I am on the landing page")]
        public void LandingPage()
        {
            ScenarioContext.Current.Pending();
        }

        [When("I attempt to sign in ")]
        public void AttemptToSignIn()
        {
            ScenarioContext.Current.Pending();
        }

        [Then("I can access the system")]
        public void CanAccessSystem()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
