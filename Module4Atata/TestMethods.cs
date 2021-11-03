using Atata;
using Module4Atata.PageMapping;
using NUnit.Framework;

namespace Module4Atata
{
    public class TestMethods : ConfigTest
    {
        [Test]
        public void Test()
        {
            OpenMainPage()
            .Menu.MenuAllArticles.Hover()
            .Menu.SubMenuWebDriverCourse.ClickAndGo<WebDriverCoursePage>()
            .ArticlesSearchElements.ClickAndGo()
            .LinkControlPage.ClickAndGo<ControlsPage>()
            .WaitProgressBarLoading()
            .ITProjects.Rows[x => x.Name == "Facebook"].Budget.Should.Equal(12300);
        }
    }
}
