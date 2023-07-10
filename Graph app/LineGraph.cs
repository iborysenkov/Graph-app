using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph_app
{
    internal class LineGraph
    {
        #region Properties
        public double xAxisMax { get; set; }
        public double xAxisMin { get; set; }
        public double xAxisInterval { get; set; }
        public double yAxisMax { get; set; }
        public double yAxisMin { get; set; }
        public double yAxisInterval { get; set; }
        public int lineWidth { get; set; }
        public Color lineColor { get; set; }
        public double yMinorInt { get; set; }

        #endregion



        #region Constructor

        public LineGraph(Chart chart1, double xAxisMin, double xAxisMax, double xAxisInterval,
            double yAxisMin, double yAxisMax, double yAxisInterval, int lineWidth, int numMinorYGrid)

        {
            this.xAxisMin = yAxisMin;
            this.yAxisMax = yAxisMax;
            this.yAxisInterval = yAxisInterval;
            this.lineWidth = lineWidth;
            this.yMinorInt = yAxisInterval / (1.0 + numMinorYGrid);

            chart1.Series["Series1"].ChartType = SeriesChartType.Line;
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = xAxisMin;
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = xAxisMax;

            chart1.Series["Series1"].BorderWidth = lineWidth;
            chart1.Legends.Clear();


            //chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            //chart1.ChartAreas["ChartArea1"].AxisX.Maximum = 2;
            //chart1.Legends.Clear();
            //chart1.Series["Series1"].BorderWidth = 10;
            //chart1.Series["Series1"].Points.AddXY(0, 10);
            //chart1.Series["Series1"].Points.AddXY(1, 20);
            //chart1.Series["Series1"].ChartType = SeriesChartType.Line;



        }

        #endregion
    }
}
