using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDocs.GettingStarted;

public static class FirstScript {
    public static void Main() {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("https://www.google.com/");
        driver.FindElement(By.XPath("//*[@id=\"APjFqb\"]")).SendKeys("Tymotheo da Silva Trisch de Oliveira");
        driver.FindElement(By.XPath("/html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]")).Click();
        driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div[1]/div/div/span/a/h3")).Click();
        var name = driver.FindElement(By.XPath("//*[@id=\"main-content\"]/section[1]/div/section/section[1]/div/div[2]/div[1]/h1")).Text;
        var description = driver.FindElement(By.XPath("//*[@id=\"main-content\"]/section[1]/div/section/section[1]/div/div[2]/div[1]/h2")).Text;
        var local = driver.FindElement(By.XPath("//*[@id=\"main-content\"]/section[1]/div/section/section[1]/div/div[2]/div[1]/h3/div")).Text;

        Console.WriteLine(name);
        Console.WriteLine(description);
        Console.WriteLine(local);

        driver.Quit();
    }
}