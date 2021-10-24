using Atata;
using NUnit.Framework;

namespace Module4Atata.PageMapping
{
    public class YeskMainPage : ConfigTest
    {
        [Test]
        public void MainPage()
        {
            Go.ToUrl("http://www.yesk.com.ua/");
        }
    }
}