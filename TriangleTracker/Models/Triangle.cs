namespace TriangleTracker
{
  /// <summary>
  /// Class <c>Triangle</c> models a two-dimensional triangle.
  /// </summary>
  public class Triangle
  {
    public bool IsTriangle(int side1, int side2, int side3)
    {
      if ((side1 < 0) || (side2 < 0) || (side3 < 0))
      {
        return false;
      }
      else
      {
        return true;
      }
      // if ((side1 >= side2 + side3) || (side2 >= side1 + side3) || (side3 >= side2 + side1))
      // {
      //   return false;
      // }
      // else
      // {
      //   return true;
      // }
    }
  }
}
