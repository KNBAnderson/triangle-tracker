using System;
using System.Collections.Generic;

namespace Tracker {
  public class Program
  {
    public static void Main() {

      float side1 = GetSides("side1");
      float side2 = GetSides("side2");
      float side3 = GetSides("side3");
      Triangle triangle = new Triangle(side1, side2, side3);
      Console.WriteLine(triangle.Side2);
      if(triangle.IsTriangle()) {
        string type = triangle.TriangleType();
        Console.WriteLine("Your triangle is a " + type + ".");
      } else {
        Console.WriteLine("The numbers you entered are not a triangle!");
      }
    }

    static float GetSides(string side) {
      Console.WriteLine("How long is " + side + "?");
      string yourSide = Console.ReadLine();
      float sideFloat = float.Parse(yourSide);
      return sideFloat;
    }
  }
}
