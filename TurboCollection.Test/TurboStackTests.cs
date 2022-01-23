﻿using NUnit.Framework;
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
                private static TurboStack<int> GiveAndPush(int count)
                {
                   var stack = Give();
                   for (int i = 0; i < count; i++)
                   {
                       stack.Push(3);
                   }

                   return stack;

                }
               
                [TestCase(1), TestCase(5), TestCase(1337)]
                public void ItIncreasesCount(int count)
                {
                    var stack = GiveAndPush(count);
                    
                    Assert.AreEqual(count, stack.Count);
                }

                [TestCase(1, -7)] 
                [TestCase(5, 0)]
                [TestCase(1337, 777)]
                public void TheLastestItemCanBePeeked(int count, int item)
                {
                    var stack = GiveAndPush(count);
                    stack.Push(item);
                    Assert.AreEqual(item, stack.Peek());
                    
                } 
                
                [TestCase(1, -7)] 
                [TestCase(5, 0)]
                [TestCase(1337, 777)]
                public void TheLastestItemCanBePopped(int count, int item)
                {
                    var stack = GiveAndPush(count);
                    
                    stack.Push(item);
                    Assert.AreEqual(item, stack.Pop());
                    
                }
                
                
                
                
            }
        } 
        
        public class GivenAStackWithContent
        {
            private static  TurboStack<int> Give(int count)
            {
                var stack = new TurboStack<int>();
                for (int i = 0; i < count; i++)
                {
                    stack.Push(3);
                }

                return stack;
            }

            [Test]
            public void CountIsNotZero()
            {
                var stack = Give(7);
                Assert.NotZero(stack.Count);
            }
            
            public class WhenPopping
            {
                [TestCase(1)]
                [TestCase(7)]
                [TestCase(999)]
                public void ItDecreasesCount(int count)
                {
                    var stack = Give(count);
                    stack.Pop();
                    Assert.AreEqual(count - 1, stack.Count);
                }
            }
        }
    }
}