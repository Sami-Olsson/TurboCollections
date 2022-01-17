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

    //[Test]
    //public void AddingAnElementIncreasesCountToOne()
    //{
        //var list = new TurboList<int>();
        //list.Add(5);
        //Assert.AreEqual(1, list.Count);
    //}
    
  } 

}