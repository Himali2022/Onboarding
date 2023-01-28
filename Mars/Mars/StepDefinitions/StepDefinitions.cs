using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Mars.StepDefinitions
{
    [Binding]
    public class StepDefinitions : CommonDriver
    {
        Mars.Pages.loginPage logging;
        Mars.Pages.ProfilePage profile;

        [Given(@"I logged into Mars page and navigate to profile page successfully")]
        public void GivenILoggedIntoMarsPageAndNavigateToProfilePageSuccessfully()
        {
            logging= new Mars.Pages.loginPage();
            logging.LoginAction();
        }

        [When(@"I add my '([^']*)','([^']*)' to the profile page")]
        public void WhenIAddMyToTheProfilePage(string Language, string Level)
        {
            profile= new Mars.Pages.ProfilePage();
            profile.CreateLanguage(Language, Level);
        }

        [Then(@"I able to see '([^']*)','([^']*)' in the profile page")]
        public void ThenIAbleToSeeInTheProfilePage(string Language, string Level)
        {
            profile = new Mars.Pages.ProfilePage();
            string addedLanguage = profile.GetAddedLanguage();
            Assert.That(addedLanguage); == Language;
        }

        
        [When(@"I add my Education details to the profile page")]
        public void WhenIAddMyEducationDetailsToTheProfilePage()
        {
            profile = new Mars.Pages.ProfilePage();
            profile.CreateEducation();
        }
        [Then(@"I able to see my Education details in the profile page")]
        public void ThenIAbleToSeeMyEducationDetailsInTheProfilePage()
        {
            logging.CloseDriver();
        }

    }



}

