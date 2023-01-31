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
      Assert.AreEqual(true, testTriangle.IsTriangle(3,4,5));
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
      Assert.AreEqual("Hey that ain't no got dang triangle", testTriangle.TriangleType(50,4,5));
    }
    // [TestMethod]
    // public void TriangleType_HasTypeScalene_Scalene()
    // {
    //   Triangle testTriangle = new Triangle();
    //   Assert.AreEqual("Scalene", testTriangle.TriangleType(3,4,5));
    // }
  }
}