using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double stp = double.Parse(textBox3.Text);
            int count = (int)Math.Ceiling((Xmax - Xmin) / stp);
            double[] x=new double[count];
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            for(int i = 0;i<count; i++)
            {
                x[i] = Xmin + stp * i;
                y1[i] = 0.0025 * 2.5 * Math.Pow(x[i], 3) + Math.Sqrt(x[i] + Math.Exp(0.82));
                y2[i]= Math.Sin(x[i]);
            }
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.Interval = stp;

            chart1.Series[0].Points.DataBindXY(x, y1);
            chart1.Series[1].Points.DataBindXY(x, y2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
