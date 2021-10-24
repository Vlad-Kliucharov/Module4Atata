using Atata;

namespace Module4Atata.PageMapping
{
    using _ = WebDriverCourse;

    public class WebDriverCourse : Page<_>
    {
        [FindByContent("Поиск элементов на странице")]
        public Control<_> ArticlesSearchElements { get; private set; }
    }
}
