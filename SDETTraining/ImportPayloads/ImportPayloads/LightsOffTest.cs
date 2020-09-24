using System;
using NUnit.Framework;
using OpenQA.Selenium;
using PayloadImport;

namespace ImportPayloads
{
    [TestFixture]
    public class LightsOffTest
    {
        private CXResponse _response;
        private IWebDriver _driver;

        [Test, Category(Helpers.TestLevel.BasePass)]
        public void LightsOff()
        {
            var payload = new CXPayload(Helpers.Payloads.MiniLoan);
            var apikey = TestContext.Parameters["apikey"];
            var secret = TestContext.Parameters["secret"];

            payload.InjectApiKey(apikey, secret);

            _response = payload.Import(Helpers.Engines.QA);
        }
    }
}
