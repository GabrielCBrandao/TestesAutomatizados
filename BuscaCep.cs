using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TesteCorreios.Core;

namespace TesteCorreios
{
    class BuscaCep : Begin
    {
        [Test]
        public void Test()
        {
            driver.FindElement(By.Id("endereco")).SendKeys("25963130");
            driver.FindElement(By.Id("btn_pesquisar")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id=\'resultado-DNEC\']/tbody/tr/td[1]")).Text, Does.Contain("Rua Armando Farjado"));
            




        }
    }
}
