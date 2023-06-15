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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.DataVisualization;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.DataVisualization.Charting;


namespace ChartingSample
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void BarChartButton_Click(object sender, RoutedEventArgs e)
        {
            ChartTypeBar barChart = new ChartTypeBar();
            barChart.Owner = this;
            barChart.Show();
        }

        private void ColumnChartButton_Click(object sender, RoutedEventArgs e)
        {
            ChartTypeColumn columnChart = new ChartTypeColumn();
            columnChart.Owner = this;
            columnChart.Show();
        }

        private void LineChartButton_Click(object sender, RoutedEventArgs e)
        {
            ChartTypeLine lineChart = new ChartTypeLine();
            lineChart.Owner = this;
            lineChart.Show();
        }

        private void PieChartButton_Click(object sender, RoutedEventArgs e)
        {
            ChartTypePie pieChart = new ChartTypePie();
            pieChart.Owner = this;
            pieChart.Show();
        }

        private void ScatterChartButton_Click(object sender, RoutedEventArgs e)
        {
            ChartTypeScatter scatterChart = new ChartTypeScatter();
            scatterChart.Owner = this;
            scatterChart.Show();
        }

        private void AreaChartButton_Click(object sender, RoutedEventArgs e)
        {
            ChartTyperArea areaChart = new ChartTyperArea();
            areaChart.Owner = this;
            areaChart.Show();
        }


    }
}
