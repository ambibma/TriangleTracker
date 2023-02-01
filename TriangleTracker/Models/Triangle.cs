namespace TriangleTracker
{
  /// <summary>
  /// Class <c>Triangle</c> models a two-dimensional triangle.
  /// </summary>
  public class Triangle
  {
    /// <summary>
    /// This method checks to see if the input sides can
    /// form a valid triangle.
    /// </summary>
    /// <param><c>side1</c> is the first side.</param>
    /// <param><c>side2</c> is the second side.</param>
    /// <param><c>side3</c> is the third side.</param>
    /// <returns>
    /// True if the sides can form a triangle; otherwise,
    /// false.
    /// </returns>
    public bool IsTriangle(int side1, int side2, int side3)
    {
      if ((side1 < 0) || (side2 < 0) || (side3 < 0))
      {
        return false;
      }
      if ((side1 >= side2 + side3) || (side2 >= side1 + side3) || (side3 >= side2 + side1))
      {
        return false;
      }
      else
      {
        return true;
      }
    }
    
    /// <summary>
    /// This method checks to see what type of triangle is
    /// formed by the three input sides.
    /// </summary>
    /// <param><c>side1</c> is the first side.</param>
    /// <param><c>side2</c> is the second side.</param>
    /// <param><c>side3</c> is the third side.</param>
    /// <returns>
    /// A string describing the type of triangle.
    /// </returns>
    public string TriangleType(int side1, int side2, int side3)
    {
      if (!IsTriangle(side1, side2, side3))
      {
        return "Hey, this ain't no got dang triangle";
      }
      if ((side1 != side2) && (side1 != side3) && (side2 != side3))
      {
        return "Scalene";
      } 
      if ((side1 == side2) && (side1 == side3)) 
      {
        return "Equilateral";
      }
      else
      {
        return "";
      }
    }
  }
}