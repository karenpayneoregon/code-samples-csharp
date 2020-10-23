using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesktopUtilsUnitTest.Classes
{
    public class BaseClass
    {
        protected TestContext TestContextInstance;
        public TestContext TestContext
        {
            get => TestContextInstance;
            set => TestContextInstance = value;
        }
    }
}