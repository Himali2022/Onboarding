using Mars.Utilities;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace Mars.Pages
{
    public class ProfilePage : CommonDriver
    {
        #region page objects
        IWebElement addNewButton => driver.FindElement(By.XPath("//th/div[@class=\"ui teal button \"]"));
        IWebElement addLanguageButton => driver.FindElement(By.XPath("//input[@name='name']"));
        IWebElement chooseLanguageLevelDropdown => driver.FindElement(By.XPath("//select[@name='level']"));
        IWebElement addButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        IWebElement skillButton => driver.FindElement(By.XPath("//a[@data-tab='second']"));
        IWebElement addSkillButton => driver.FindElement(By.XPath("//input[@name='name']"));
        IWebElement chooseSkillLevelDropdown => driver.FindElement(By.XPath("//select[@name='level']"));
        IWebElement saddButton => driver.FindElement(By.XPath("//input[@class='ui teal button ']"));
        IWebElement educationButton => driver.FindElement(By.XPath("//a[@class='item active']"));        
        IWebElement collegeUniversityNameButton => driver.FindElement(By.XPath("//input[@name='instituteName']"));
        IWebElement countryOfCollegeUniversityDropdown => driver.FindElement(By.XPath("//select[@name='country']"));
        IWebElement titleDropdown => driver.FindElement(By.XPath("//select[@name='title']"));
        IWebElement degreeButton => driver.FindElement(By.XPath("//input[@name='degree']"));
        IWebElement yearOfGraduationDropdown => driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
        IWebElement eaddButton => driver.FindElement(By.XPath("//input[@class='ui teal button ']"));
        #endregion


        public void CreateLanguage(string Language, string Level)
        {
            Wait.WaitForElementToBeClickable(driver, "XPath", "//th/div[@class=\"ui teal button \"]", 20);

            //click on Add New button
            addNewButton.Click();

            //click on Add Language button and enter language
            addLanguageButton.SendKeys(Language);
            Wait.WaitForElementToBeClickable(driver, "XPath", "//select[@name='level']", 5);

            //click on Choose Language Level button and select level from dropdown
            chooseLanguageLevelDropdown.Click();
            SelectElement selectChooseLanguageLevel = new SelectElement(driver.FindElement(By.Name("Level")));
            selectChooseLanguageLevel.SelectByText(Level);

            //click on Add button            
            addButton.Click();

        }

        public string GetAddedLanguage()
        {
            IWebElement addedLanguage = driver.FindElement(By.XPath("//input[@name='name']"));
            return addedLanguage.Text;
        }
        public string GetAddedLanguageLevel()
        {
            IWebElement addedLanguageLevel = driver.FindElement(By.XPath("//select[@name=\"level\"]"));
            return addedLanguageLevel.Text;
        }
            
        public void CreateSkill(string Skill, string Level)
        {

            //click on skill button
            skillButton.Click();

            Wait.WaitForElementToBeClickable(driver, "XPath", "//th/div[@class='ui teal button']", 5);
            //click on Add new button
            addNewButton.Click();

            //click on Add Skill button and enter skill            
            addSkillButton.SendKeys(Skill);
            
            //click on Choose Skill Level dropdown and select level from dropdown           
            chooseSkillLevelDropdown.Click();
            SelectElement selectchooseSkillLevel = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']")));
            selectchooseSkillLevel.SelectByText(Level);

            //click on Add button
            saddButton.Click();
           
            
        }
        public string GetAddedSkill()
        {
            IWebElement addedSkill = driver.FindElement(By.XPath("//input[@name='name']"));
            return addedSkill.Text;
        }
        public string GetAddedSkillLevel()
        {
            IWebElement addedSkillLevel = driver.FindElement(By.XPath("//select[@name='level']"));
            return addedSkillLevel.Text;
        }


        public void CreateEducation(String Country,String University, String Title, String Degree, String GraduationYear)
        {
            //click on Education button            
            educationButton.Click();
            Wait.WaitForElementToBeClickable(driver, "XPath", "//th/div[@class='ui teal button']", 5);

            //click on Add New button            
            addNewButton.Click();

            //click on College/University Name button            
            collegeUniversityNameButton.SendKeys(University);
            Wait.WaitForElementToBeClickable(driver, "XPath", "//select[@name='country']", 5);

            //click Country of College/University dropdown and choose country from dropdown            
            countryOfCollegeUniversityDropdown.Click();
            SelectElement selectCountryOfCollegeUniversity = new SelectElement(driver.FindElement(By.XPath("//select[@name='country']")));
            selectCountryOfCollegeUniversity.SelectByText(Country);
            Wait.WaitForElementToBeClickable(driver, "XPath", "//select[@name='title']", 5);

            //click on Title dropdown and select title            
            titleDropdown.Click();
            SelectElement selectTitleDropdown = new SelectElement(driver.FindElement(By.XPath("//select[@name='title']")));
            selectTitleDropdown.SelectByText(Title);
            Wait.WaitForElementToBeClickable(driver, "XPath", "//input[@name='degree']", 5);

            //click on Degree button and enter degree            
            degreeButton.SendKeys(Degree);
            Wait.WaitForElementToBeClickable(driver, "XPath", "//select[@name='yearOfGraduation']", 5);

            //click on Year of graduation dropdown and select year            
            yearOfGraduationDropdown.Click();
            SelectElement yearOfGraduationDropdown1 = new SelectElement(driver.FindElement(By.XPath("//select[@name='yearOfGraduation']")));
            yearOfGraduationDropdown1.SelectByText(GraduationYear);

            //click on Add button           
            eaddButton.Click();
        }

        public string GetAddedUniversity()
        {
            IWebElement addedUniversity = driver.FindElement(By.XPath("//input[@name='instituteName']"));
            return addedUniversity.Text;
        }
        public string GetAddedCountry()
        {
            IWebElement addedCountry = driver.FindElement(By.XPath("//select[@name='country']"));
            return addedCountry.Text;
        }
        public string GetAddedTitle()
        {
            IWebElement addedTitle = driver.FindElement(By.XPath("//select[@name='title']"));
            return addedTitle.Text;
        }
        public string GetAddedDegree()
        {
            IWebElement addedDegree = driver.FindElement(By.XPath("//input[@name='degree']"));
            return addedDegree.Text;
        }
        public string GetAddedGraduationYear()
        {
            IWebElement addedGraduationYear = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
            return addedGraduationYear.Text;
        }
    }
}
