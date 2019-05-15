using System;
using System.Numerics;

using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double R;
        private double C;
        LineSeries dataList = new LineSeries();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            if (RInput.Text == string.Empty || CInput.Text == string.Empty)
            {
                MessageBox.Show("Вdедите данные");
                return;
            }

            R = Double.Parse(RInput.Text);
            C = Double.Parse(CInput.Text);
            var t = R * C;
            var a = 1.84;
            double w0 = 1 / (R * C);
            w0Out.Text = "w0 = " + w0.ToString();
            ROut.Text = "R = " + R.ToString();
            COut.Text = "C = " + C.ToString();
            dataGridView1.Columns.Add("w", "w");
            dataGridView1.Columns.Add("1/2K(w)1/2", "1/2K(w)1/2");
            for (double w = w0; w <= w0+100; w+=(100-w0)/20)
            {
                Complex p = new Complex(0, w);
                var chisl = a * t * t * (-1) * w * w;
                var znam = Complex.Add(Complex.Multiply((3 - a) * t, p), 1 + t * t * (-1) * w * w);
                var res = Complex.Divide(chisl, znam);
                res = Complex.Pow(res, 0.5);
                res = Complex.Divide(res, 2);

                var r = Math.Sqrt(res.Real * res.Real + res.Phase * res.Phase);
                dataList.Points.Add(new DataPoint(w, r));
                dataGridView1.Rows.Add(w, r);
            }
           
            var myModel = new PlotModel { Title = "График" };
            myModel.Series.Add(dataList);
            this.plotView1.Model = myModel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;

            var fileText = System.IO.File.ReadAllLines(filename);
            RInput.Text = fileText[0];
            CInput.Text = fileText[1];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            var s = $"R = {R}\n";
            s += $"C = {C}\n";
            s += "w  K\n";
            foreach(var point in dataList.Points)
            {
                s += $"{point.X}  {point.Y}\n";
            }
            System.IO.File.WriteAllText(filename, s);
        }
    }
}
