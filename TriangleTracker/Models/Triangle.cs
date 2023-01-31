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
      if ((side1 >= side2 + side3) || (side2 >= side1 + side3) || (side3 >= side2 + side1))
      {
        return false;
      }
      else
      {
        return true;
      }
    }
    public string TriangleType(int side1, int side2, int side3)
    {
      return "Hey, this ain't no got dang triangle";
      // if (!IsTriangle)
      // {
      //   return "Hey, this ain't no got dang triangle";
      // }
      // return "";

    }
  }
}
