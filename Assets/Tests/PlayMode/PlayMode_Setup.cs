using NUnit.Framework;

namespace Tests
{
    [SetUpFixture]
    public class PlayMode_Setup : SetUp
    {
        [OneTimeSetUp]
        public void Test_OneTimeSetUp1()
        {
        }

        [OneTimeTearDown]
        public void Test_OneTimeTearDown1()
        {
        }
    }
}
