using System.Windows;


namespace ChartingSample
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void LineChartButton_Click(object sender, RoutedEventArgs e)
        {
            ChartTypeLine lineChart = new ChartTypeLine();
            lineChart.Owner = this;
            lineChart.Show();
        }
    }
}
