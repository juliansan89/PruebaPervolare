using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebaAutomatizada
{
    class Program
    {

        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();
            //_driver = new FirefoxDriver(Directory.GetCurrentDirectory());
            driver.Navigate().GoToUrl("https://www.segurodeviajemundial.com.co/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//option[contains(text(),'Latinoamerica. Caribe y Cánada (No USA)')]")).Click();
            driver.FindElement(By.XPath("//input[@id='fecha_regreso']")).Click();
            driver.FindElement(By.XPath("//option[contains(text(),'Jul')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'20')]")).Click();
            driver.FindElement(By.XPath("//input[@id='fecha_regreso']")).Click();
            driver.FindElement(By.XPath("//body/div[@id='ui-datepicker-div']/div[1]/div[1]/select[1]")).Click();
            driver.FindElement(By.XPath("//option[contains(text(),'Aug')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'24')]")).Click();
            driver.FindElement(By.XPath("//tbody/tr[2]/td[2]/div[1]/input[1]")).SendKeys("juliandavidsanchezsanchez@gmail.com");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//tbody/tr[2]/td[1]/button[1]")).Click();

        }
    }
}
