using Atata;
using Module4Atata.PageMapping;
using NUnit.Framework;

namespace Module4Atata
{
    public class TestMethods : YeskMainPage
    {
        [Test]
        public void Test()
        {
            Go.To<HeaderMainMenu>().
            MenuAllArticles.Hover().
            SubMenuWebDriverCourse.ClickAndGo<WebDriverCoursePage>().
            ArticlesSearchElements.ClickAndGo<SearchElementsPage>().
            LinkControlPage.ClickAndGo<ControlsPage>().
            WaitProgressLoading.WaitTo.Equals("100");
        }
    }
}
