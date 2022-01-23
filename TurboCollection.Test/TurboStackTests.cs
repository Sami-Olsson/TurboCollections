using NUnit.Framework;
using TurboCollections;

namespace TurboCollection.Test
{
    [TestFixture]
    public class TurboStackTests
    {
        [Test]
        public void HasEmptyConstuctor()
        {
            new TurboStack<int>();
            Assert.Pass();
        } 
        
        public class ANewStack
        {
            private TurboStack<int> stack;

            [SetUp]
            public void Setup()
            {
                this.stack = new TurboStack<int>();
            }
            
            [Test]
            public void HasAcountOfZero()
            {
                Assert.Zero(stack.Count);
            }
        }
        
        
        public class WhenPushing
        {
            [Test]
            public void IncreasesCount()
            {
                TurboStack<int> stack = new();
            }
        }
    }
}