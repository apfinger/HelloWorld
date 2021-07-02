using NUnit.Framework;

namespace HelloWorld.Tests.Unit
{
    [TestFixture]
    public class WorldTests
    {
        private IWorld _world;

        [SetUp]
        public void Setup()
        {
            _world = new World();
        }

        [Test]
        public void Greeting_Says_Hello_World()
        {
            var result = _world.Greeting();
            Assert.That(result.Equals("Hello, World!"), "The greeting should be perfect!");
        }
    }
}