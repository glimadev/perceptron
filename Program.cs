using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] inputs = {
		        { 1d, 1d, 1d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d },
		        { 0d, 0d, 0d, 0d, 1d, 1d, 1d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d },
		        { 1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d },
		        { 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 1d, 1d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d },
		        { 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 1d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d },
		        { 0d, 0d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 1d, 1d, 0d, 0d, 0d, 0d, 0d, 1d },
		        { 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 0d, 0d, 0d, 0d, 1d, 1d, 0d, 0d, 0d, 1d },
		        { 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 1d, 0d, 1d },
		        { 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 0d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 0d, 1d, 1d }
            };

            double[] outputs = { 1d, 0d, 0d, 1d, 0d, 1d, 0d, 1d, 1d };

            Console.WriteLine(inputs.Length);

            //Fit data 
            Perceptron perceptron = new Perceptron(inputs, outputs);
            int epoch = perceptron.Fit();
            Console.WriteLine(epoch);

            double[] data = { 0d, 0d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 0d, 0d, 1d, 0d, 1d, 1d };
            int r = perceptron.Predict(data);
            Console.WriteLine(r);

            double[] data2 = { 1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 0d, 1d, 0d, 0d, 0d, 0d, 1d };
            int r2 = perceptron.Predict(data2);
            Console.WriteLine(r2);

            Console.ReadLine();
        }
    }
}
