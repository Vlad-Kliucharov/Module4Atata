using Atata;

namespace Module4Atata.PageMapping
{
    using _ = WebDriverCoursePage;

    public class WebDriverCoursePage : BasePage<_>
    {
        [FindByXPath("//*[contains(text(),'Поиск элементов на странице')]"), ControlDefinition]
        public Link<SearchElementsPage, _> ArticlesSearchElements { get; private set; }
    }
}
