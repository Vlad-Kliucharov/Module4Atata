using Atata;
using Module4Atata.PageMapping;
using NUnit.Framework;

namespace Module4Atata
{
    public class BasePage : BaseTest
    {
        public MainMenu Menu => new MainMenu();
    }
}