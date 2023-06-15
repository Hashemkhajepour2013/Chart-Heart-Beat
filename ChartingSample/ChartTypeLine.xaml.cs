using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Controls.Primitives;

namespace ChartingSample
{
    public partial class ChartTypeLine : Window
    {
        ObservableCollection<Data> generatedData = new ObservableCollection<Data>();

        public ChartTypeLine()
        {
            InitializeComponent();
            generatedData = GenerateData();
            LoadLineChartData(0);
        }

        private new ObservableCollection<Data> GenerateData()
        {            
            Random rnd = new Random();

            for (int i = 0; i < 500; i++)
            {
                generatedData.Add(new Data
                {
                    Time = (double)i,
                    Value = rnd.Next(-2, 2)
                });
            }

            return generatedData;
        }

        private void LoadLineChartData(int scroll)
        {        


            List<KeyValuePair<double, double>> d = new List<KeyValuePair<double, double>>();
            int oldscroll = scroll + 50;
                for (; scroll <= oldscroll; scroll++)
                {
                    d.Add(new KeyValuePair<double, double>(generatedData[scroll].Time, generatedData[scroll].Value));
                }

            ((LineSeries)mcChart.Series[0]).ItemsSource = d;
        }

        private void scroll_Scroll(object sender, ScrollEventArgs e)
        {
            var scroll = (int)e.NewValue;
            LoadLineChartData(scroll);
        }
    }

    public class Data
    {
        public double Time { get; set; }

        public double Value { get; set; }
    }
}
