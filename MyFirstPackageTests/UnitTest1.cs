using MyFirstPackage;

namespace MyFirstPackageTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello User!", Class1.SayHello());
        }
    }
}