using System;
using ConsoleApp3ML.Model;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("AI Prediction of age of vin numbers");
            Console.WriteLine("Training data: 10,000 rows spanish data");
            // Add input data
            var input = new ModelInput();
            Console.WriteLine("Please enter a VIN:");
            input.VIN = Console.ReadLine();

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine("The year is predicted to be: " + result.Prediction);
            Console.ReadLine();
        }
    }
}
