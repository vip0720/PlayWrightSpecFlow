using Microsoft.Playwright;
using PageObjectModel.Flows;
using PageObjectModel.Pages;

namespace PlayWrightSpecFlow.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        LoginPage lPage = new LoginPage(page);
        LoginFlow lFlow = new LoginFlow(lPage);

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            throw new PendingStepException();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            throw new PendingStepException();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            throw new PendingStepException();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            throw new PendingStepException();
        }

        [Given(@"Launch the orangehrmlive website")]
        public void GivenLaunchTheGoogleWebsite()
        {
            
        }

        [When(@"Search for '([^']*)'")]
        public void WhenSearchFor(string arsenal)
        {
            throw new PendingStepException();
        }

        [Then(@"User is able to see results for Arsenal")]
        public void ThenUserIsAbleToSeeResultsForArsenal()
        {
            throw new PendingStepException();
        }

    }
}
