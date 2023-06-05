using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boids.Model;
using System.Windows.Threading;
using ScottPlot;
using ScottPlot.WPF;
using ScottPlot.Plottable;

namespace RandomPlotVisualizer
{
    public class MainViewModel
    {
        Field field = new Field(500D, 500D, 150);
        PointArray myPoints;
        double[] singleData;
        double[,] data;

        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        WpfPlot figure = new WpfPlot();
        
        
        

        public MainViewModel()
        {
            
            
            singleData = new double[500];
            for (int x = 0; x < 100; ++x)
            {
                singleData[x] = Math.Exp((-1.0 / 2.0) * Math.Pow(((double)x - 50.0) / 20.0, 2.0));
            }

            data = new double[500, 500];
            for (int x = 0; x < 100; ++x)
            {
                for (int y = 0; y < 100; ++y)
                {
                    data[y, x] = singleData[x] * singleData[(y + 30) % 100] * 100;
                }
            }

            foreach (Boid boid in field.Boids)
            {
                continue;
            }

            double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            double[] dataY = new double[] { 1, 4, 9, 16, 25 };

            this.figure.Plot.AddScatter(dataX, dataY);
            this.figure.Refresh();
            dispatcherTimer.Tick += new EventHandler(timer1_Tick);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(1);
            //dispatcherTimer.Start();

        }

        private void AddBoidsToModel()
        {

            foreach (Boid boid in field.Boids)
            {
                continue;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            field.Advance();
            AddBoidsToModel();
        }
    }
}
