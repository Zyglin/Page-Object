using NUnit.Framework;

namespace WebDriverTest
{
    [TestFixture]
    public class PageObjectPattern
    {
     
       
        [Test]
        public void Test_spechialoffer()
        {
          using (var page = new Main())
            {
                Assert.AreEqual(true,page.Search());
            }
        }
    }
}
