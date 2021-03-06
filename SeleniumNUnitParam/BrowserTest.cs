﻿using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumNUnitParam
{
    public class BrowserTest : Hooks
    {


        [Test]
        public void GoogleTest()
        {
            Thread.Sleep(3000);

            Driver.Navigate().GoToUrl("https://www.gograph.com");
            Thread.Sleep(3000);
            var url = this.Driver.Url;
            var title = Driver.Title;
            Assert.AreEqual("https://www.gograph.com/", url);
            Assert.AreEqual("Great ClipArt, Illustrations, and Vectors at Low Prices - GoGraph", title, "Title doesnt match");

            ////Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            ////System.Threading.Thread.Sleep(5000);
            ////Driver.FindElement(By.Name("btnG")).Click();
            ////Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
            ////                                "The text selenium doest not exist");

        }

        [Test] 
        public void ExecuteAutomationTest()
        {
            Thread.Sleep(3000);

            Driver.Navigate().GoToUrl("https://www.gograph.com");
            Thread.Sleep(3000);
            var url = this.Driver.Url;
            var title = Driver.Title;
            Assert.AreEqual("https://www.gograph.com/", url);
            Assert.AreEqual("Great ClipArt, Illustrations, and Vectors at Low Prices - GoGraph", title, "Title doesnt match");

        }


    }
}
