using System;
using TriangleTracker;

namespace TriangleTrackerProgram
{
  public class Program
  {
    public static void Main()
    {
      while (true)
      {
      Console.WriteLine("Enter 3 Numbers... ");
      int side1 = int.Parse(Console.ReadLine());
      int side2 = int.Parse(Console.ReadLine());
      int side3 = int.Parse(Console.ReadLine());
      Triangle TrackTriangle = new Triangle();
      Console.WriteLine(TrackTriangle.TriangleType(side1, side2, side3));      
      }
    }
  }
}

