

namespace Mars.Pages
{
    public class loginPage : CommonDriver 

    {
        public void CloseDriver()
        {
            driver.Quit();
        }
        public void LoginAction()
        {
            driver = new ChromeDriver();

            //launch Mars page

            driver.Navigate().GoToUrl("http://localhost:5000");

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
    }
}
