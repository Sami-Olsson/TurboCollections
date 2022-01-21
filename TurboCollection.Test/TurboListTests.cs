using System;
using NUnit.Framework;
using TurboCollections;

namespace TurboCollection.Test 
{

  public class TurboListTests
  {

    [Test]
    public void NewListIsEmpty()
    {
        var list = new TurboList<int>();
        Assert.Zero(list.Count);
    }

    [Test]
    public void AddingAnElementIncreasesCountToOne()
    {
        var list = new TurboList<int>();
        list.Add(5);
        Assert.AreEqual(1, list.Count);
    }
    
    
    [TestCase(5), TestCase(7)]
    public void AddingMultipleElementsIncreasesTheCount(int numberOfElements)
    {
        var list = new TurboList<int>();
        for (int i = 0; i < numberOfElements; i++)
            list.Add(5);
       
        Assert.AreEqual(numberOfElements, list.Count);
    }

    [Test]
    public void AnAddedElementCanBeGotten()
    {
        var list = new TurboList<int>();
        list.Add(1337);
        Assert.AreEqual(1337, list.Get(0));
    }
    
    [Test]
    public void MultipleAnAddedElementCanBeGotten()
    {
         var (numbers, list) = CreateTestData();
        for (int i = 0; i < numbers.Length; i++)
        {
            Assert.AreEqual(numbers[i], list.Get(i));
        }
        
    }
    
    [TestCase(666)]
    public void ExistingItemsCanBeOverwrittenBySetting(int item)
    {
        var (_, list) = CreateTestData();
        list.Set(2, item);
        Assert.AreEqual(item, list.Get(2));
    } 
    
    [Test]
    public void CanNotBeExtendedBySetting()
    {
        const int setIndex = 100;
        var (_, list) = CreateTestData();
        Assert.Throws<IndexOutOfRangeException>(()=>list.Set(setIndex, 666));
      
    }
    
  

    (int[] numbers, TurboList<int>) CreateTestData()
    {
        int[] numbers = {5, 7, -12, 9, 3, -4, 104, 12};
        var list = new TurboList<int>();
        foreach(var number in numbers)
            list.Add(number);
        
        return (numbers, list);
    }
    
  } 

}