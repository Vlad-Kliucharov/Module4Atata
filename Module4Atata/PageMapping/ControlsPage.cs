using Atata;
using OpenQA.Selenium.Support.UI;

namespace Module4Atata.PageMapping
{
    using _ = ControlsPage;

    public class ControlsPage : Page<_>
    {
        [FindByClass("elementor-counter-number")]
        [WaitFor(Until.Visible)]
        public Control<_> WaitProgressLoading { get; private set; }
    }
}