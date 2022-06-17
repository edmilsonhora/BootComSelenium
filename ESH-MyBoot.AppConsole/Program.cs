using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESH_MyBoot.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Threading.Thread.Sleep(3000);


            string path = Directory.GetCurrentDirectory();
          

            var linhas = File.ReadAllLines($@"{path}\Assets\Planilha.csv",Encoding.UTF8);

            IWebDriver driver;
            driver = new FirefoxDriver();

            Console.WriteLine("testando Boot - Clique algo...");
            Console.ReadKey();

            driver.Navigate().GoToUrl("http://localhost:63386/Index.aspx");

            foreach (var linha in linhas)
            {
                var item = linha.Split(';', (char)StringSplitOptions.RemoveEmptyEntries);                

               
                driver.FindElement(By.Id("txtNome")).Click();
                driver.FindElement(By.Id("txtNome")).Clear();
                driver.FindElement(By.Id("txtNome")).SendKeys(item[0]);
                driver.FindElement(By.Id("txtCPF")).Click();
                driver.FindElement(By.Id("txtCPF")).Clear();
                driver.FindElement(By.Id("txtCPF")).SendKeys(item[4]);
                driver.FindElement(By.Id("txtEmail")).Click();
                driver.FindElement(By.Id("txtEmail")).Clear();
                driver.FindElement(By.Id("txtEmail")).SendKeys(item[3]);
                driver.FindElement(By.Id("dropSexo")).Click();
                new SelectElement(driver.FindElement(By.Id("dropSexo"))).SelectByText(item[1]);
                driver.FindElement(By.Id("dropPerfil")).Click();
                new SelectElement(driver.FindElement(By.Id("dropPerfil"))).SelectByText(item[2]);
                driver.FindElement(By.Id("btnSalvar")).Click();
            }

            driver.Close();
            driver.Dispose();

            Console.WriteLine("Executado...");

        }
    }
}
