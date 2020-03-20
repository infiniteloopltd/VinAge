using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3ML.Model;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();

            input.VIN = "VF1BRCF0H37276882";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            Console.WriteLine(result.Prediction);
        }
    }
}
