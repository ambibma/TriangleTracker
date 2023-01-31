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
  }
}