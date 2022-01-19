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
        int[] numbers = {5, 7, -12, 9, 3, -4, 104, 12};
        var list = new TurboList<int>();
        foreach(var number in numbers)
                list.Add(number);
        for (int i = 0; i < numbers.Length; i++)
        {
            Assert.AreEqual(numbers[i], list.Get(i));
        }
        
    }
    
    
    
  } 

}