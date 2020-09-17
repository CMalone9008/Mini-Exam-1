using System;

class MainClass {
  public static void Main (string[] args) {
    
    double height, weight, BMI;
    Console.WriteLine("Enter name");
    Console.ReadLine();
    Console.WriteLine("Enter height:");
    height = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter weight:");
    weight = Convert.ToDouble(Console.ReadLine());
    BMI = (703 * weight) / (height * height);
    Console.WriteLine("BMI = " + BMI);
    
    if (BMI<18.5)
    {
      Console.WriteLine("Underweight");
    }
    else if ((BMI>18.5) && (BMI<24.9))
    {
      Console.WriteLine("Normal or Healthy Weight");
    }
    else if ((BMI>25) && (BMI<29.9))
    {
      Console.WriteLine("Overweight");
    }
    else
    {
      Console.WriteLine("Obese");
    }
    
    
  }
}