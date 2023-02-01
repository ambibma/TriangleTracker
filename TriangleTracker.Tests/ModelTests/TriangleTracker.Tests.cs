using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void IsTriangle_HasThreeSides_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual (true,testTriangle.IsTriangle(3,4,5));
    }
    [TestMethod]
    public void IsTriangle_AllSidesArePositive_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(3,4,5));
    }
    [TestMethod]
    public void IsTriangle_AllSidesArePositive_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsTriangle(-3,4,5));
    }
    [TestMethod]
    public void IsTriangle_IsAnyTriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsTriangle(3,4,5));
    }
    [TestMethod]
    public void IsTriangle_IsAnyTriangle_False()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(false, testTriangle.IsTriangle(3000,4,5));
    }
    [TestMethod]
    public void TriangleType_HasTypeNone_None()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Hey, this ain't no got dang triangle", testTriangle.TriangleType(50,4,5));
    }
    [TestMethod]
    public void TriangleType_HasTypeScalene_Scalene()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Scalene", testTriangle.TriangleType(3,4,5));
    }
    [TestMethod]
    public void TriangleType_HasTypeIsosceles_Isosceles()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("Isosceles", testTriangle.TriangleType(3,3,5));    
    }

  }

}
// [TestMethod]
// public void MethodTest()
// {
//     try
//     {
//         var obj = new ClassRequiringNonNullParameter( null );
//         Assert.Fail("An exception should have been thrown");
//     }
//     catch (ArgumentNullException ae)
//     {
//         Assert.AreEqual( "Parameter cannot be null or empty.", ae.Message );
//     }
//     catch (Exception e)
//     {
//         Assert.Fail(
//              string.Format( "Unexpected exception of type {0} caught: {1}",
//                             e.GetType(), e.Message )
//         );
//     }
// }