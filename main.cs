using System;

class Program {
  public static void Main (string[] args) {
       const double centimeters = 2.54;
    //Input number
    Console.WriteLine("Enter number of inches  ");

    string inchestyped = Console.ReadLine();

    //If input is decimal form, it gives the output and continues
    if (double.TryParse(inchestyped, out double inches))
    {
      var x = inches * centimeters;
      //Displays conversion of inches to centimeters//
      Console.WriteLine($"{inches} inches is {x} centimeters.");
    }
    else
      
      Console.WriteLine("Invalid");
    
      
  }
}


  
