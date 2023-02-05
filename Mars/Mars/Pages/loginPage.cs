

namespace Mars.Pages
{
    public class LoginPage: CommonDriver 
    {
        
        public void LoginAction()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            
            //launch Mars page

            driver.Navigate().GoToUrl("http://localhost:5000");

            Wait.WaitForElementToBeClickable(driver,"XPath","//a[@class='item']", 20);

            // click on sign in button
            IWebElement signinButton = driver.FindElement(By.XPath("//a[@class='item']"));
            signinButton.Click();

            // identify emailtextbox and enter email address 
            IWebElement emailTextbox = driver.FindElement(By.XPath("//input[@name='email']"));
            emailTextbox.SendKeys("himalipranasinghe@gmail.com");

            // identify passwordtextbox and enter password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("//input[@name='password']"));
            passwordTextbox.SendKeys("InternHimo22");

            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//button[text()='Login']"));
            loginButton.Click();

        }
        public void CloseDriver()
        {
            driver.Close();
        }
}

}
