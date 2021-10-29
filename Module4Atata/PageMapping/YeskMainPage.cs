using Atata;


namespace Module4Atata.PageMapping
{
    using _ = YeskMainPage;
    public class YeskMainPage : Page<_>
    {
        public HeaderMainMenu<_> Menu { get; private set; }
    }
}