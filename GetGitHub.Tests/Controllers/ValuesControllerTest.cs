using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetGitHub;
using GetGitHub.Controllers;
using GetGitHub.Domain;
using GetGitHub.Domain.Entities;

namespace GetGitHub.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void TestWebScraping()
        {
            var ws = new WebScraping();

            var data = ws.GetGitHub("gilbelei", "testegithub");

            Assert.AreEqual(9, data.Count);


            AssertData(data, "docx", 114688, 0);
            AssertData(data, "exe", 879616, 0);
            AssertData(data, "html", 6488680, 11276);
            AssertData(data, "jpg", 807936, 0);
            AssertData(data, "mp3", 1315962880, 0);
            AssertData(data, "mpeg", 1028653056, 0);
            AssertData(data, "pdf", 111149056, 0);
            AssertData(data, "wmv", 204472320, 0);
            AssertData(data, "xlsx", 210944, 0);

        }

        void AssertData(List<WebScrapingResult> data, string extension, int size, long numberOfLines)
        {
            var ext = data.SingleOrDefault(x => x.FileExtension == extension);

            Assert.AreEqual(size, ext.Size);
            Assert.AreEqual(numberOfLines, ext.NumberOfLines);
        }


    }
}
