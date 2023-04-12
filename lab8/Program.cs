/**
*--------------------------------------------------------------------
* File name: Program.cs
* Project name: lab8
*--------------------------------------------------------------------
* Author’s name and email: Justin Dubin, dubinj@etsu.edu
* Course-Section: CSCI 1250-001
* Creation Date: 14 Apr 2022
*
-------------------------------------------------------------------
*/
public class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Enter a radius for a circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        DisplayCircleInformation(radius);

        System.Console.WriteLine();
        System.Console.Write("Enter your Name: ");
        string name = Console.ReadLine();

        System.Console.Write("Enter your Address: ");
        string address = Console.ReadLine();

        System.Console.Write("Eter your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Enter your Phone Number: ");
        int phoneNumber = Convert.ToInt32(Console.ReadLine());

        PersonalInformation info = new PersonalInformation(name, address, age, phoneNumber);
        System.Console.WriteLine($"Name:\t{info.GetName()}");
        System.Console.WriteLine($"Age:\t{info.GetAge()}");
        System.Console.WriteLine($"Address:\t{info.GetAddress()}");
        System.Console.WriteLine($"Phone Number:\t{info.GetPhoneNumber()}");
    }

    static void DisplayCircleInformation(double radius)
    {
        Circle circle1 = new Circle(radius);
        System.Console.WriteLine($"Diameter:\t{circle1.GetDiameter()}");
        System.Console.WriteLine($"Circumference:\t{circle1.GetCircumference()}");
        System.Console.WriteLine($"Area:\t{circle1.GetArea()}");
    }


}