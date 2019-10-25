using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SneakyBot
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            IWebDriver driver = new FirefoxDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Actions actions = new Actions(driver);
            
            driver.Navigate().GoToUrl("https://www.nike.com/t/air-jordan-10-retro-mens-shoe-Vo4nXN/310805-137");
            
            var size = driver.FindElement(By.XPath("//input[@aria-label='10']"));
            js.ExecuteScript("arguments[0].click();", size);
           
            var addtocart = driver.FindElement(By.XPath("//button[@aria-label='Add to Cart']"));
            addtocart.Click();
            addtocart.Click();
            //actions.DoubleClick(addtocart);

            var cart = driver.FindElement(By.XPath("//span[@class='cart-jewel']"));
            js.ExecuteScript("arguments[0].click();", cart);
            
            Console.ReadKey(); // type key to end program
            //Close the browser
            //driver.Close();

        }
    }
}