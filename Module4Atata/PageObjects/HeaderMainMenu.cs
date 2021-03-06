using Atata;

namespace Module4Atata
{
    [FindByClass("item--inner builder-item--primary-menu has_menu")]
    public class HeaderMainMenu<TOwner> : Control<TOwner>
    where TOwner : PageObject<TOwner>
    {
        [FindById("menu-item-130")]
        public Control<TOwner> MenuAllArticles { get; private set; }

        [FindById("menu-item-470")]
        public Control<TOwner> SubMenuWebDriverCourse { get; private set; }
    }
}
