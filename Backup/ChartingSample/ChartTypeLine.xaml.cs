﻿using System;
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
    /// Interaction logic for ChartTypeLine.xaml
    /// </summary>
    public partial class ChartTypeLine : Window
    {
        public ChartTypeLine()
        {
            InitializeComponent();

            LoadLineChartData();
        }



        private void LoadLineChartData()
        {
            ((LineSeries)mcChart.Series[0]).ItemsSource =
                new KeyValuePair<DateTime, int>[]{
            new KeyValuePair<DateTime, int>(DateTime.Now, 100),
            new KeyValuePair<DateTime, int>(DateTime.Now.AddMonths(1), 130),
            new KeyValuePair<DateTime, int>(DateTime.Now.AddMonths(2), 150),
            new KeyValuePair<DateTime, int>(DateTime.Now.AddMonths(3), 125),
            new KeyValuePair<DateTime, int>(DateTime.Now.AddMonths(4), 155) };
        }


    }
}
