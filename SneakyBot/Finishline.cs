using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Threading;

// bans me

namespace SneakyBot
{
    public class Finishline
    {
        public static void fl()
        {
            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Actions actions = new Actions(driver);
            
            driver.Navigate().GoToUrl("https://www.finishline.com/store/product/mens-nike-pg-3-x-nasa-basketball-shoes/prod2790938?styleId=CI2666&colorId=400");
            
            var size = driver.FindElement(By.XPath("//button[@data-size='10.0']"));
            size.Click();
            //js.ExecuteScript("arguments[0].click();", size);
           
            Thread.Sleep(2500);
            var addtocart = driver.FindElement(By.XPath("//button[@id='buttonAddToCart']"));
            addtocart.Click();
            //addtocart.Click();
            //actions.DoubleClick(addtocart);

            Thread.Sleep(2500);
            var cart = driver.FindElement(By.XPath("//span[@class='icon icon-large icon-bag']"));
            js.ExecuteScript("arguments[0].click();", cart);
            
            Console.ReadKey(); // type key to end program
        }
    }
}