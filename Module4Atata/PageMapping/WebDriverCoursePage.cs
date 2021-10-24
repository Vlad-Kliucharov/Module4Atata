using Atata;

namespace Module4Atata.PageMapping
{
    using _ = WebDriverCoursePage;

    public class WebDriverCoursePage : Page<_>
    {
        [FindByXPath("//*[contains(text(),'Поиск элементов на странице')]")]
        public Control<_> ArticlesSearchElements { get; private set; }
    }
}
