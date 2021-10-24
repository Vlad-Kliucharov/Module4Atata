using Atata;
using NUnit.Framework;
using System.Configuration;

namespace Module4Atata
{
    public abstract class ConfigTest
    {
        [SetUp]
        public void SetUp()
        {
            AtataContext.Configure()
            .UseChrome()
            .WithArguments("start-maximized")
            .UseBaseUrl(ConfigurationManager.AppSettings["MainPage"])
            .Build();
            
        }
        [TearDown]
        public void TearDown()
        {
            AtataContext.Current.CleanUp();
        }
    }
}
