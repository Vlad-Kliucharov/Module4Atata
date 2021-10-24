using Atata;
using NUnit.Framework;

namespace Module4Atata
{
    public abstract class ConfigTest
    {
        [SetUp]
        public void SetUp()
        {
            AtataContext.Configure()
            .UseChrome()
          //.WithArguments("start-maximized")
            .Build();
            AtataContext.Current.Driver.Manage().Window.Maximize();

        }
        //[TearDown]
        //public void TearDown()
        //{
        //    AtataContext.Current.CleanUp();
        //}
    }
}
