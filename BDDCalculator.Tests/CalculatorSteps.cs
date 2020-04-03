using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BDDCalculator.Tests
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator calculator = new Calculator();
        private int result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.FirstNumber = number;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculator.SecondNumber = number;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.Add();
        }

        [When(@"I press substract")]
        public void WhenIPressSubstract()
        {
            result = calculator.Substract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            result = calculator.Multiply();
        }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
