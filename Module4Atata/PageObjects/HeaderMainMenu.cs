using Atata;

namespace Module4Atata
{
    using _ = HeaderMainMenu;

    public class HeaderMainMenu : Page<_>
    {
        [FindById("menu-item-130")]
        public Control<_> MenuAllArticles { get; private set; }

        [FindById("menu-item-470")]
        public Control<_> WebDriverCourse { get; private set; }
    }
}
