﻿namespace Operations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();
            Console.WriteLine(mathOperations.Add(2, 3));
            Console.WriteLine(mathOperations.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mathOperations.Add(2.2m, 3.3m, 4.4m));
        }
    }
}