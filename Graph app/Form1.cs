using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Graph_app
{
    public partial class Form1 : Form
    {
        List<double> xVals = new List<double>();
        List<double> yVals = new List<double>();

        public Random rnd = new Random();
        double tick = 0.0;


        public Form1()
        {


            InitializeComponent();

            LineGraph graph1 = new LineGraph(chart1, 0, 10, 0, 0, 15, 5, 3, 0);
            configStripline();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xVals.Add(tick);
            yVals.Add(10.0 * rnd.NextDouble());

            if (tick > 10.0)
            {
                xVals.RemoveAt(0);
                yVals.RemoveAt(0);
            }

            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = xVals[0];
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = tick;

            chart1.Series["Series1"].Points.DataBindXY(xVals, yVals);

            tick = tick + 0.5;

        }

        public void configStripline()
        {
            StripLine stripline1 = new StripLine();
            stripline1.StripWidth = 5;
            stripline1.Interval = 0;
            stripline1.IntervalOffset = 3.5;
            stripline1.BackColor = Color.FromArgb(120, Color.Red);

            chart1.ChartAreas["ChartArea1"].AxisY.StripLines.Add(stripline1);

        }
    }

}

