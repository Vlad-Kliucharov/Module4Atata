using Atata;
using System;
using System.Threading;

namespace Module4Atata.PageMapping
{
    using _ = ControlsPage;

    public class ControlsPage : BasePage<_>
    {
        [FindByClass("elementor-counter-number")]
        public Control<_> ProgressLoading { get; private set; }

        public _ WaitProgressBarLoading()
        {
            Thread.Sleep(1000);
            ProgressLoading.Content.Should.Equal("100");
            return Go.To<_>();
        }

        [FindByXPath("//th[text()='Budget $']//ancestor::table[1]")]
        public Table<ITTableRows, _> ITProjects { get; private set; }

        public class ITTableRows : TableRow<_>
        {
            [FindByColumnHeader("Name")]
            public Text<_> Name { get; private set; }

            [FindByColumnIndex(1)]
            public Number<_> Budget { get; private set; }
        }
    }
}
