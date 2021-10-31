using Atata;
using System;
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

        public Table<ITTableRows, _> ITProjects { get; private set; }
        public class ITTableRows : TableRow<_>
        {
            //[FindByColumnHeader("Name")]
            [FindByColumnIndex(0)]
            public Text<_> Name { get; private set; }
            //[FindByColumnHeader("Budget ($)")]
            [FindByColumnIndex(1)]
            public Number<_> Budget { get; private set; }
            public int budgetNumber => Convert.ToInt32(Budget);
        }
    }
}
