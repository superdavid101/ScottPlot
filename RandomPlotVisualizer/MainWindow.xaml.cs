using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using ScottPlot.Plottable;
using RandomPlotVisualizer;


namespace RandomPlotVisualizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double[] data = new double[100_000];
        int nextDataIndex = 1;
        SignalPlot signalPlot;
        Random rand = new Random(0);

        public MainWindow()
        {
            
            InitializeComponent();

            DataContext = new MainViewModel();

            /*
            signalPlot = figure.Plot.AddSignal(data);
            figure.Plot.YLabel("Value");
            figure.Plot.XLabel("Sample Number");
            figure.Refresh();
            */
        }

       

    }

   
}
