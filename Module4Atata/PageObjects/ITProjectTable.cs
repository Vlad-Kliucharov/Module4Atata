using Atata;

namespace Module4Atata.PageObjects
{

    using _ = ITProjectTable;

    public class ITProjectTable : Page<_>
    {
        [FindByXPath("//th[text()='Name']//following::tr")]
        public Table<ProductTableRow, _> ITProjects { get; private set; }

        public class ProductTableRow : TableRow<_>
        {
            public Text<_> Name { get; private set; }
            public Number<_> Budget { get; private set; }
        }
    }
}
