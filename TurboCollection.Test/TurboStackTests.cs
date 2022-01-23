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
        
        public class GivenANewStack
        {
            private static  TurboStack<int> Give()
            {
                return new TurboStack<int>();
            }
            
            [Test]
            public void ItHasAcountOfZero()
            {
                Assert.Zero(Give().Count);
            }
            
            public class WhenPushing
            {
                [TestCase(1), TestCase(5), TestCase(1337)]
                public void ItIncreasesCount(int count)
                {
                    var stack = Give();
                    for (int i = 0; i < count; i++)
                    {
                        stack.Push(3);
                    }
                    Assert.AreEqual(count, stack.Count);
                }
            }
        }
        
        
       
    }
}