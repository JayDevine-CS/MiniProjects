// Project assigned by CodeCademy, Completed and Commented by Jay Devine
using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to this application where you can find out the area of the floorplan, and total cost of flooring materials for some amzing landmarks!");
      Console.Write("Please Typea number from the list:\n\n 1 - Teotihuacan in Mexico City, Mexico\n 2 - Taj Mahal, Agra, India\n 3 - Al-Masjid al-haram (Great Mosque), Mecca, Saudi Arabia\n 4 - Pantheon, Rome, Italy\n\n");
      string location = Console.ReadLine();
      location = location.ToUpper();
      // Running the method with the argument set as the location selected by the user.
      CalculateTotalCost(location);
    }
    
    static void CalculateTotalCost(string location)
    {
    // IF statement taking in the users selected location and then calculating the total area of the location. 
    // Then taking the total area and the material cost and finding the total cost for the floor of the location.
    if (location == "1")  // Teotihuacan
    {
      Console.WriteLine("---- Teotihuacan, Mexico City, Mexico ----");
      double rectangleArea = Rectangle(2500, 1500);
      Console.WriteLine("Rectangle Area: " + rectangleArea);

      double circleArea = Circle(375);
      double halfCircleArea = circleArea / 2;
      Console.WriteLine("Semi-Circle Area: " + halfCircleArea);

      double triangleArea = Triangle(750, 500);
      Console.WriteLine("Triangle Area: " + triangleArea + "\n");

      double totalArea = rectangleArea + halfCircleArea + triangleArea;
      Console.WriteLine("Total Area: " + totalArea + "\n");

      double materialCost = 180;
      double totalCost = totalArea * 180;
      totalCost = Math.Round(totalCost, 2);
      Console.WriteLine($"The total cost when the materials cost {materialCost} Mexican Pesos, and the total area of the Teotihuacan is {totalArea} would be:\n\n{totalCost} Mexican Pesos.\n");
    }
    else if (location == "2") // Taj Mahal
    {
      Console.WriteLine("---- Taj Mahal, Agra, India ----");
      double squareArea = Rectangle(90.5, 90.5);
      Console.WriteLine("Square Area: " + squareArea);

      double triangleArea = Triangle(48, 24);
      triangleArea = triangleArea * 4;
      Console.WriteLine("4 Triangles Total Area: " + triangleArea);

      double totalArea = squareArea - triangleArea;
      double materialCost = 667;
      double totalCost = totalArea * materialCost;
      totalCost = Math.Round(totalCost, 2);
      Console.WriteLine($"The total cost when the materials cost {materialCost} Indian Rupees, and the total area of the Taj Mahal is {totalArea} would be:\n\n{totalCost} Indian Rupees.\n");
    }
    else if (location == "3") // Great Mosque, Mecca
    {
      Console.WriteLine("---- Great Mosque of Mecca ----");
      double smallRectangleArea = Rectangle(180, 106);
      Console.WriteLine("Small Rectangle Area: " + smallRectangleArea);

      double largeRectangleArea = Rectangle(200, 264);
      Console.WriteLine("Large Rectangle Area: " + largeRectangleArea);

      double triangleArea = Triangle(264, 84);
      Console.WriteLine("Triangle Area: " + triangleArea);

      double totalArea = smallRectangleArea + largeRectangleArea + triangleArea;
      double materialCost = 33.50;
      double totalCost = totalArea * materialCost;
      totalCost = Math.Round(totalCost, 2);
      Console.WriteLine($"The total cost when the materials cost {materialCost} Saudi riyal, and the total area of the Great Mosque of Mecca is {totalArea} would be:\n\n{totalCost} Saudi riyal.\n");
    }
    else if (location == "4") // Pantheon
    {
      Console.WriteLine("---- Pantheon, Rome, Italy ----");
      double rectangleArea = Rectangle(15, 18);
      Console.WriteLine("Rectangle Area: " + rectangleArea);

      double circleArea = Circle(21.5);
      Console.WriteLine("Circle Area: " + circleArea);

      double totalArea = circleArea + rectangleArea;
      double materialCost = 7.63;
      double totalCost = totalArea * materialCost;
      totalCost = Math.Round(totalCost, 2);
      Console.WriteLine($"The total cost when the materials cost {materialCost} Euros, and the total area of the Pantheon in Italy is {totalArea} would be:\n\n{totalCost} Euros.\n");
    }
    else
    {
      // Error catchment in case a location is not selected
      Console.WriteLine("You have not entered any of the featured landmarks. Please Try Again.");
    }
    }

    // Method to calculate the area of Rectangles, also works for squares
    static double Rectangle(double length, double width)
    {
      return length * width;
    }

    // Calculates the area of a Circle
    static double Circle(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }

    // Calculates the area of a Triangle
    static double Triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
  }
}
