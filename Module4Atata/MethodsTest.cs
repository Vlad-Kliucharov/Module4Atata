using Atata;
using Module4Atata.PageMapping;

namespace Module4Atata
{
    public class MethodsTest : YeskMainPage
    {
        public MethodsTest()
        {
            Go.To<HeaderMainMenu>().
            MenuAllArticles.Hover().
            WebDriverCourse.Click();
        }
    }
}
