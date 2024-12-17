// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Enter your height");
string Height = Console.ReadLine();
Console.WriteLine("Enter your weight");
string Weight = Console.ReadLine();
int height = Convert.ToInt32(Height);
int weight = Convert.ToInt32(Weight);
double BMI = (weight / (Math.Pow(height,2 )/100))*100;
if (BMI < 18.5)
    Console.WriteLine("Your BMI is: " + BMI + " underweight.");
else if (BMI >= 18.5 && BMI <= 24.9) {
    Console.WriteLine("Your BMI is: " + BMI + " healthy.");
}

else if (BMI >= 25 && BMI <= 29.9) Console.WriteLine("Your BMI is: " + BMI + " overweight.");
else if (BMI >= 30) Console.WriteLine("Your BMI is: " + BMI + " obese.");

Console.WriteLine("Enter your age");
string Age = Console.ReadLine();
int age = Convert.ToInt32(Age);
var BMIState = "BMI State";
if (age >= 19 && age <= 24 && BMI <= 24 && BMI >= 19)
        Console.WriteLine($"Your  {BMIState} is healthy");
else if (age >= 25 && age <= 34 && BMI <= 25 && BMI >= 20)
    Console.WriteLine("Your " + BMIState + " is healthy");
else if (age >= 35 && age <= 44 && BMI <= 26 && BMI >= 21)
    Console.WriteLine("Your " + BMIState + " is healthy");
else if (age >= 45 && age <= 54 && BMI <= 27 && BMI >= 22)
    Console.WriteLine("Your " + BMIState + " is healthy");
else if (age >= 55 && age <= 64 && BMI <= 28 && BMI >= 23)
    Console.WriteLine("Your " + BMIState + " is healthy");
else if (age >= 65 && BMI <= 29 && BMI >= 24)
    Console.WriteLine("Your " + BMIState + " is healthy");
 else Console.WriteLine("Your "+ BMIState+" is not healthy");

