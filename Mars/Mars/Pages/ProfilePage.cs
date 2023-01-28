using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.Events;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;

namespace Mars.Pages
{
    public class ProfilePage : CommonDriver
    {
        public void CreateLanguage(string Language, string Level)
        {

            //click on Add New button
            IWebElement addNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            //click on Add Language button and enter language
            IWebElement addLanguageButton = driver.FindElement(By.XPath("//input[@name='name']"));
            addLanguageButton.SendKeys(Language);
            Thread.Sleep(2000);

            //click on Choose Language Level button and select level from dropdown
            IWebElement chooseLanguageLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            chooseLanguageLevelDropdown.Click();
            Thread.Sleep(2000);
            SelectElement selectChooseLanguageLevel = new SelectElement(driver.FindElement(By.XPath("//select[@name=\"level\"]")));
            selectChooseLanguageLevel.SelectByText(Level);

            //click on Add button
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
        }

        public string GetAddedLanguage()
        {
            IWebElement addedLanguage = driver.FindElement(By.XPath("//input[@name='name']"));
            return addedLanguage.Text;
        }
        public string GetAddedLevel()
        {
            IWebElement addedLevel = driver.FindElement(By.XPath("//select[@name=\"level\"]"));
            return addedLevel.Text;
        }
            
        public void CreateSkill(string Skill, string Level)
        {

            //click on skill button
            IWebElement skillButton = driver.FindElement(By.XPath("//a[@data-tab='second']"));
            skillButton.Click();

            //click on Add new button
            IWebElement addNewButton = driver.FindElement(By.XPath("//th/div[@class='ui teal button']"));
            addNewButton.Click();

            //click on Add Skill button and enter skill
            IWebElement addSkillButton = driver.FindElement(By.XPath("//input[@name='name']"));
            addSkillButton.SendKeys(Skill);
            Thread.Sleep(2000);

            //click on Choose Skill Level dropdown and select level from dropdown
            IWebElement chooseSkillLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            chooseSkillLevelDropdown.Click();
            SelectElement selectchooseSkillLevel = new SelectElement(driver.FindElement(By.XPath("//select[@name='level']")));
            selectchooseSkillLevel.SelectByText(Level);
            Thread.Sleep(2000);

            //click on Add button
            IWebElement addButton = driver.FindElement(By.XPath("//input[@class='ui teal button ']"));
            addButton.Click();
            
        }
        public string GetAddedSkill()
        {
            IWebElement addedLanguage = driver.FindElement(By.XPath("//input[@name='name']"));
            return addedLanguage.Text;
        }
        public string GetAddedLevel()
        {
            IWebElement addedLevel = driver.FindElement(By.XPath("//select[@name='level']"));
            return addedLevel.Text;
        }


        public void CreateEducation()
        {
            //click on Education button
            IWebElement educationButton = driver.FindElement(By.XPath("//a[@class='item active']"));
            educationButton.Click();

            //click on Add New button
            IWebElement addButton = driver.FindElement(By.XPath("//th/div[@class='ui teal button']"));
            addButton.Click();

            //click on College/University Name button
            IWebElement collegeUniversityNameButton = driver.FindElement(By.XPath("//input[@name='instituteName']"));
            collegeUniversityNameButton.SendKeys("University of Peradeniya");
            Thread.Sleep(3000);

            //click Country of College/University dropdown and choose country from dropdown
            IWebElement countryOfCollegeUniversityDropdown = driver.FindElement(By.XPath("//select[@name='country']"));
            countryOfCollegeUniversityDropdown.Click();
            SelectElement selectCountryOfCollegeUniversity = new SelectElement(driver.FindElement(By.XPath("//select[@name='country']")));
            selectCountryOfCollegeUniversity.SelectByText("Sri Lanka");
            Thread.Sleep(2000);

            //click on Title dropdown and select title
            IWebElement titleDropdown = driver.FindElement(By.XPath("//select[@name='title']"));
            titleDropdown.Click();
            SelectElement selectTitleDropdown = new SelectElement(driver.FindElement(By.XPath("//select[@name='title']")));
            selectTitleDropdown.SelectByText("M.Tech");
            Thread.Sleep(2000);

            //click on Degree button and enter degree
            IWebElement degreeButton = driver.FindElement(By.XPath("//input[@name='degree']"));
            degreeButton.SendKeys("Food Siecne and Technology");
            Thread.Sleep(2000);

            //click on Year of graduation dropdown and select year
            IWebElement yearOfGraduationDropdown = driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
            yearOfGraduationDropdown.Click();
            SelectElement yearOfGraduationDropdown1 = new SelectElement(driver.FindElement(By.XPath("//select[@name='yearOfGraduation']")));
            yearOfGraduationDropdown1.SelectByText("2007");
            Thread.Sleep(2000);

            //click on Add button
            addButton = driver.FindElement(By.XPath("//input[@class='ui teal button ']"));
            addButton.Click();
        }

        
    }
}
