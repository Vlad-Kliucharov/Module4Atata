using Atata;
using System.Threading;

namespace Module4Atata.PageMapping
{
    using _ = ControlsPage;

    public class ControlsPage : Page<_>
    {
        [FindByClass("elementor-counter-number")]
        public Control<_> ProgressLoading { get; private set; }

        public _ WaitProgressBarLoading()
        {
            Thread.Sleep(1000);
            ProgressLoading.Content.Should.Equal("100");
            return Go.To<_>();
        }

        [FindByXPath("//th[text()='Name']//following::tr")]
        public Table<ITTableRows, _> ITProjects { get; private set; }

        public class ITTableRows : TableRow<_>
        {
            [FindByXPath("//td[1]")]
            public Text<_> Name { get; private set; }
            [FindByXPath("//td[2]")]
            public Number<_> Budget { get; private set; }
        }
    }
}
