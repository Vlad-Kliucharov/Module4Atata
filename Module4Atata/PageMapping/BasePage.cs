using Atata;

namespace Module4Atata.PageMapping
{
    public class BasePage<TOwner> : Page<TOwner>
    where TOwner : BasePage<TOwner>
    {
        public HeaderMainMenu<TOwner> Menu { get; private set; }
    }
}
