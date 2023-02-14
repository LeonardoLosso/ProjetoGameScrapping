using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProjetoGameScrapping
{
    internal class WebScrapper
    {
        public IWebDriver driver;

        public WebScrapper()
        {
            driver = new ChromeDriver();
        }

        public void Teste()
        {
            driver.Navigate().GoToUrl("https://www.google.com.br/");

            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[1]/div/div[2]/input")).SendKeys("Lançamentos de jogos");

            driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Click();

            var divDeGames = driver.FindElements(By.Name("I4kCu"));
            
            Console.WriteLine(divDeGames);
            Console.WriteLine("-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-");
            Console.ReadLine();
        }
    }
}
