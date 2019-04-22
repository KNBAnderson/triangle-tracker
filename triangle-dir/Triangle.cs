using System;

namespace Tracker {
  class Triangle
  {
    public float Side1;
    public float Side2;
    public float Side3;

    public Triangle(float side1, float side2, float side3) {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

    public bool IsTriangle() {
      if(Side1 + Side2 > Side3 && Side2 + Side3 > Side1 && Side1 + Side3 > Side2) {
        return true;
      } else {
        return false;
      }
    }

    public string TriangleType() {
      if(Side1 == Side2 && Side2 == Side3) {
        return "equilateral";
      } else if(Side1 == Side2 || Side2 == Side3 || Side3 == Side1) {
        return "isosceles";
      }
      else
      {
        return "scalene";
      }
    }
  }
}
