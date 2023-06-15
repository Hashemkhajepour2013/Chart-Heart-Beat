using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Windows.Controls.DataVisualization;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.DataVisualization.Charting;

namespace ChartingSample
{
    /// <summary>
    /// Interaction logic for ChartTyperArea.xaml
    /// </summary>
    public partial class ChartTyperArea : Window
    {
        public ChartTyperArea()
        {
            InitializeComponent();

           // LoadAreaChartData();
        }


        private void LoadAreaChartData()
        {

            ((AreaSeries)mcChart.Series[0]).ItemsSource =
                new KeyValuePair<string, int>[]{
            new KeyValuePair<string, int>("Q1Y09", 100),
            new KeyValuePair<string, int>("Q2Y09", 180),
            new KeyValuePair<string, int>("Q3Y09", 110),
            new KeyValuePair<string, int>("Q4Y09", 95),      
            new KeyValuePair<string, int>("Q1Y10", 210)
            };
        }
    }
}
