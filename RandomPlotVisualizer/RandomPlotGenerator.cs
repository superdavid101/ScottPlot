using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RandomPlotVisualizer
{
    class RandomPlotGenerator
    {

        public (double, double) RandomPoint(double lowerBound, double upperBound)
        {
            Random random = new Random();
            return ((random.NextDouble() * (upperBound - lowerBound) + lowerBound), (random.NextDouble() * (upperBound - lowerBound) + lowerBound));
        }


        public double[] RandomDoubleArray(double lowerBound, double upperBound, int numPoints)
        {
            double[] array = new double[numPoints];
            for (int i = 0; i < numPoints; i++)
            {
                Random random = new Random();
                array[i] = random.NextDouble() * (upperBound - lowerBound) + lowerBound;
            }

            return array;
        }

        public void MovePoints(double[] xPoints, double[] yPoints)
        {
            double distance = 0.01D * Math.Sqrt(Math.Pow(xPoints.Max() - xPoints.Min(),2) + Math.Pow(yPoints.Max() - yPoints.Min(),2));
            Random random = new Random();

            for(int i = 0; i < xPoints.Length; i++)
            {
                double heading = random.NextDouble() * (2*Math.PI - 0) + 0;

                xPoints[i] += distance * Math.Cos(heading);
                yPoints[i] += distance * Math.Sin(heading);
            }

        }

    }

    class PointArray
    {
        public double[] x;
        public double[] y;

        public PointArray(double[] xPoints, double[] yPoints)
        {
            x = xPoints;
            y = yPoints;
        }
            

    }


}
