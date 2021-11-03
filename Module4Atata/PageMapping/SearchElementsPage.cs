using Atata;

namespace Module4Atata.PageMapping 
{
    using _ = SearchElementsPage;

    public class SearchElementsPage : BasePage<_>
    {
        [FindByXPath("//*[contains(text(),'CONTROLS PAGE')]")]
        public Control<_> LinkControlPage { get; private set; } 
    }
}

