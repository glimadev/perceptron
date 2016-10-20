using System;

namespace Perceptron
{
    public class Perceptron
    {
        private const double _threshold = 0.2;
        private double[,] _inputs;
        private double[] _weights;
        private double[] _outputs;
        private int _epoch = 0;

        public Perceptron(double[,] inputs, double[] outputs)
        {
            _inputs = inputs;
            _outputs = outputs;
        }

        public int Predict(double[] inputs)
        {
            double u = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                u += inputs[i] * _weights[i];
            }

            return StepFunction(u);
        }

        public int Fit()
        {
            InitialiseRandomWeights(_inputs);

            bool error = true;

            while (error)
            {
                error = false;

                for (int i = 0; i < _inputs.GetLength(0); i++)
                {
                    int y = StepFunction(WeightedSum(i));

                    if (y != _outputs[i])
                    {
                        Learn(i, y);

                        error = true;
                    }
                }

                _epoch++;
            }

            return _epoch;
        }

        private void Learn(int i, int y)
        {
            for (int w = 0; w < _weights.Length; w++)
            {
                double learnCoefficient = _threshold * (_outputs[i] - y);               

                for (int b = 0; b < _inputs.GetLength(1); b++)
                {
                    _weights[i] += learnCoefficient * _inputs[i, b];
                }
            }
        }

        private double WeightedSum(int i)
        {
            double u = 0;

            for (int j = 0; j < _inputs.GetLength(1); j++)
            {
                u += _inputs[i, j] * _weights[i];
            }

            return u;
        }

        private int StepFunction(double u)
        {
            return (u >= 0.5) ? 1 : 0;
        }

        private void InitialiseRandomWeights(double[,] inputs)
        {
            Random rnd = new Random();

            int i = inputs.GetLength(1);

            _weights = new double[i];

            for (int j = 0; j < i; j++)
            {
                _weights[j] = rnd.NextDouble();
            }
        }
    }
}
