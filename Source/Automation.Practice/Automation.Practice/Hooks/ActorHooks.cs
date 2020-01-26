using Automation.Practice.Constants;
using Automation.Practice.Model;
using TechTalk.SpecFlow;

namespace Automation.Practice.Hooks
{
    [Binding]
    public class ActorHooks
    {
        private ScenarioContext _context;
        public ActorHooks(ScenarioContext context)
        {
            _context = context;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            try
            {
                _context.Add(ContextKeys.Actor, new Actor());
            }
            catch
            {
                //TODO: This should be logged
                _context.Pending();
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            try
            {
                _context.Get<Actor>(ContextKeys.Actor).CleanUp();
                _context.Remove(ContextKeys.Actor);
            }
            catch
            {
                //TODO: This should be logged
                _context.Pending();
            }
        }
    }
}
