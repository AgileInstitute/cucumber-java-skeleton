using MyLib;
using System;
using TechTalk.SpecFlow;

namespace Test
{
    [Binding]
    public class BellySteps
    {
        [Given(@"I have (.*) cukes in my belly")]
        public void GivenIHaveCukesInMyBelly(int cukes)
        {
            Belly belly = new Belly();
            belly.Eat(cukes);
        }
        
        [When(@"I wait (.*) hour")]
        public void WhenIWaitHour(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"my belly should growl")]
        public void ThenMyBellyShouldGrowl()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
