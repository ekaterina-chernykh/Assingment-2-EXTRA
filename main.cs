// Created by: Ekaterina
// Created on: Oct 2022
//
// This program calculates area of an ellipse

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        decimal radius_a;
        decimal radius_b;
        decimal area;

        const Decimal PI = (Decimal)3.14159;

        Console.WriteLine("This program calculates the area of an ellipse");
        Console.WriteLine(" ");

        Console.WriteLine("Formula: Area= π × (a × b) ");
        Console.WriteLine(" ");
        Console.Write("Enter length of the semi-major axis 'a': ");
        radius_a = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter length of the semi-major axis 'b': ");
        radius_b = Convert.ToDecimal(Console.ReadLine());

        area = (radius_a * radius_b) * PI;

        Console.WriteLine(" ");
        Console.WriteLine("Your area will be: " + area.ToString("0.00") + "u²");

        Console.WriteLine("\nDone.");
    }
}