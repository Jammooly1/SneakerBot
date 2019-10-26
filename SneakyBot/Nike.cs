using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace SneakyBot
{
    public class Nike
    {
        public static void nk()
        {
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new FirefoxDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Actions actions = new Actions(driver);
            
            driver.Navigate().GoToUrl("https://www.nike.com/t/air-jordan-10-retro-mens-shoe-Vo4nXN/310805-137");
            //driver.Manage().Window.Maximize();
            
            var size = driver.FindElement(By.XPath("//input[@aria-label='10']"));
            js.ExecuteScript("arguments[0].click();", size);
           
            var addtocart = driver.FindElement(By.XPath("//button[@aria-label='Add to Cart']"));
            addtocart.Click();
            addtocart.Click();
            //actions.DoubleClick(addtocart);

            Thread.Sleep(100);
            var cart = driver.FindElement(By.XPath("//span[@class='cart-jewel']"));
            js.ExecuteScript("arguments[0].click();", cart);
            
            Console.ReadKey(); // type key to end program
        }
    }
}