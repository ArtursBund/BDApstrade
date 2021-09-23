using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Optimization;

namespace BD_apstrade
{
    public static class FitFunc
    {
        public static (double P0, double P1, double P2, double P3, double P4, double P5, double P6, double P7) OfFunction(Func<double, double, double, double, double, double, double, double, double> function, double initialGuess0, double initialGuess1, double initialGuess2, double initialGuess3, double initialGuess4, double initialGuess5, double initialGuess6, double initialGuess7, double tolerance = 1e-8, int maxIterations = 1000)
        {
            var objective = ObjectiveFunction.Value(v => function(v[0], v[1], v[2], v[3], v[4], v[5], v[6], v[7]));
            var result = NelderMeadSimplex.Minimum(objective, CreateVector.Dense(new[] { initialGuess0, initialGuess1, initialGuess2, initialGuess3, initialGuess4, initialGuess5, initialGuess6, initialGuess7 }), tolerance, maxIterations);
            return (result.MinimizingPoint[0], result.MinimizingPoint[1], result.MinimizingPoint[2], result.MinimizingPoint[3], result.MinimizingPoint[4], result.MinimizingPoint[5], result.MinimizingPoint[6], result.MinimizingPoint[7]);
        }
        public static (double P0, double P1, double P2, double P3, double P4, double P5, double P6, double P7) Curve(double[] x, double[] y, Func<double, double, double, double, double, double, double, double, double, double> f, double initialGuess0, double initialGuess1, double initialGuess2, double initialGuess3, double initialGuess4, double initialGuess5, double initialGuess6, double initialGuess7, double tolerance = 1e-8, int maxIterations = 1000)
        {
            return OfFunction((p0, p1, p2, p3, p4, p5, p6, p7) => Distance.Euclidean(Generate.Map(x, t => f(p0, p1, p2, p3, p4, p5, p6, p7, t)), y), initialGuess0, initialGuess1, initialGuess2, initialGuess3, initialGuess4, initialGuess5, initialGuess6, initialGuess7, tolerance, maxIterations);
        }
    }
}
