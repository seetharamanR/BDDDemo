using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace BDDDemo.Steps
{
    [Binding]
    public class AddTwoNumberSteps
    {
        private int arg1 = 0;
        private int arg2 = 0;
        private int arg3 = 0;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            arg1 = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            arg2 = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            arg3 = arg1 + arg2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            arg3.Should().Be(p0);
        }
    }
}
