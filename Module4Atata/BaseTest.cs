using Atata;
using NUnit.Framework;

namespace Module4Atata
{
    public abstract class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            AtataContext.Configure()
                .UseChrome()
                .WithArguments("start-maximized")
                .Build();

        }
        //[TearDown]
        //public void TearDown()
        //{
        //    AtataContext.Current.CleanUp();
        //}
    }
}
