using System;

class Program 
{
  public static void Main (string[] args) 
  {
    //declare the required variables 
    double Measurement_in_inches  = 2.54;
    int Input_value  = 15994;
    
    // convert inches to centimeters aka multiply the entered value '5' by 2.54.
    double centimeters = Input_value  * Measurement_in_inches;
    
    // output the result of the conversion to the console.
    Console.WriteLine((Input_value ) + " inches is "+ (centimeters)+ " centimeters");
  }
}