using Mars.Pages;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace Mars.StepDefinitions
{
    [Binding]
    public class ProfileStepDefinitions :CommonDriver
    {
        Mars.Pages.LoginPage loginPageObj;
        Mars.Pages.ProfilePage profilePageObj;
        public ProfileStepDefinitions()
        {
            loginPageObj = new Mars.Pages.LoginPage();
            profilePageObj = new Mars.Pages.ProfilePage();
        }
        
        [Given(@"I logged into Mars page and navigate to profile page successfully")]
        public void GivenILoggedIntoMarsPageAndNavigateToProfilePageSuccessfully()
        {
            loginPageObj.LoginAction();
        }

        [When(@"I add my '([^']*)','([^']*)' to the profile page")]
        public void WhenIAddMyToTheProfilePage(string Language, string Level)
        {
            profilePageObj.CreateLanguage(Language, Level);
        }

        [Then(@"I able to see '([^']*)','([^']*)' in the profile page")]
        public void ThenIAbleToSeeInTheProfilePage(string Language, string Level)
        {
            string addedLanguage = profilePageObj.GetAddedLanguage();
            Assert.That(addedLanguage == Language, "Actual language and expected language do not match");

            string addedLanguageLevel = profilePageObj.GetAddedLanguageLevel();
            Assert.That(addedLanguageLevel == Level, "Actual language level and expected language level do not match");
        }


        [When(@"I add '([^']*)','([^']*)' to the profile page")]
        public void WhenIAddToTheProfilePage(string Skill, string Level)
        {
            profilePageObj.CreateSkill(Skill, Level);
        }

        [Then(@"I able to see '([^']*)','([^']*)' in my profile page")]
        public void ThenIAbleToSeeInMyProfilePage(string Skill, string Level)
        {
            string addedSkill = profilePageObj.GetAddedSkill();
            Assert.That(addedSkill == Skill, "Actual skill and expected skill do not match");

            string addedSkillLevel = profilePageObj.GetAddedSkillLevel();
            Assert.That(addedSkillLevel == Level, "Actual skill level and expected skill level do not match");
            
        }


        [When(@"I add my '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'to the profile page")]
        public void WhenIAddMyToTheProfilePage(string University, string Country, string Title, string Degree, string GraduationYear)
        {
            profilePageObj.CreateEducation(Country, University, Title, Degree, GraduationYear);
        }

        [Then(@"I able to see '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' in the profile page")]
        public void ThenIAbleToSeeInTheProfilePage(string University, string Country, string Title, string Degree, string GraduationYear)
        {
            string addedUniversity = profilePageObj.GetAddedUniversity();
            Assert.That(addedUniversity == University, "Actual university and expected university do not match");

            string addedCountry = profilePageObj.GetAddedCountry();
            Assert.That(addedCountry == Country, "Actual country and expected country do not match");

            string addedTitle = profilePageObj.GetAddedTitle();
            Assert.That(addedTitle == Title, "Actual title and expected title do not match");

            string addedDegree = profilePageObj.GetAddedDegree();
            Assert.That(addedDegree == Degree, "Actual degree and expected degree do not match");

            string addedGraduationYear = profilePageObj.GetAddedGraduationYear();
            Assert.That(addedGraduationYear == GraduationYear, "Actual graduation year and expected graduation year do not match");

        }
                 
    }



}

