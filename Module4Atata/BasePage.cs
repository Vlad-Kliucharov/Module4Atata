using Atata;
using NUnit.Framework;

namespace Module4Atata
{
    public class BasePage : BaseTest
    {
        [Test]
        public void MainPageYesk()
        {
            Go.ToUrl("http://www.yesk.com.ua/");
        }
    }
}
