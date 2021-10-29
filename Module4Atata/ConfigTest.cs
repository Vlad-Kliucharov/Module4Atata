using Atata;
using Module4Atata.PageMapping;
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
            .Build();
        }
        [TearDown]
        public void TearDown()
        {
            AtataContext.Current.CleanUp();
        }
        public YeskMainPage OpenMainPage() => Go.To<YeskMainPage>(url: ConfigurationManager.AppSettings["MainPage"]);
    }
}
