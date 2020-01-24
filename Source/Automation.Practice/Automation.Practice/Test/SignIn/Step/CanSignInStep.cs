using Automation.Practice.Constants;
using Automation.Practice.Model;
using Automation.Practice.Model.FeaturedClothes;
using TechTalk.SpecFlow;

namespace Automation.Practice.Test.SignIn.Step
{
    [Binding]
    public class CanSignInStep
    {
        private ScenarioContext _context;
        public CanSignInStep(ScenarioContext context)
        {
            _context = context;
        }
        [Given("I am on the landing page")]
        public void LandingPage()
        {
            Actor newUser = _context.Get<Actor>(ContextKeys.Actor);
            newUser.Can(new NavigateToLandingPage())
                .Can(new SelectFeatured());
        }

        [When("I attempt to sign in ")]
        public void AttemptToSignIn()
        {
        }

        [Then("I can access the system")]
        public void CanAccessSystem()
        {
        }
    }
}
