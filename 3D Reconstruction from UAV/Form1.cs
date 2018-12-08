using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTKLib;

namespace _3D_Reconstruction_from_UAV
{
    public partial class Form1 : Form
    {

        List<double> coordinateX = new List<double>();
        List<double> coordinateY = new List<double>();
        List<double> coordinateZ = new List<double>();
        List<double> distance = new List<double>();
        List<double> angle = new List<double>();

        public Form1()
        {
            InitializeComponent();
            tabPage1.Text = @"UAV";
            tabPage2.Text = @"Point Cloud";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void licenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("License by BCEPNEZ & Kridasda\nSenior Project");
        }

        private void developerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BCEPNEZ 58070501043 \nKridasda 58070501003\nCPE402 : Senior Project");
        }
        List<double> distances = new List<double>();
        List<double> angles = new List<double>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog2.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                String data;
                int count = 0;
                List<double> heights = new List<double>();

                Clearbox();
                Clearbox2();
                while ((data = sr.ReadLine()) != null)
                {
                    String[] token = data.Split(',');
                    distances.Add(Double.Parse(token[0]));
                    angles.Add(Double.Parse(token[1]));
                    heights.Add(Double.Parse(token[2]));
                    tab1Show.AppendText(count +
                        "\ndistances : " + distances.ElementAt(count) +
                        "\nangles : " + angles.ElementAt(count) +
                        "\nheights : " + heights.ElementAt(count) +
                        "\nCOX : " + distances.ElementAt(count) * (Math.Sin(toRadians(angles.ElementAt(count)))) +
                        "\nCOY : " + distances.ElementAt(count) * (Math.Cos(toRadians(angles.ElementAt(count)))) +
                        "\n");

                    sendata(distances.ElementAt(count) * (Math.Sin(toRadians(angles.ElementAt(count)))),
                        distances.ElementAt(count) * (Math.Cos(toRadians(angles.ElementAt(count)))),
                        heights.ElementAt(count),
                        count
                        );
                    count++;
                }
                //MessageBox.Show(distances.Count().ToString() + " Data added to UAV tab!");
                sr.Close();
            }
        }
        private void Clearbox()
        {
            showArea.Clear();
            coordinateX.Clear();
            coordinateY.Clear();
            coordinateZ.Clear();
        }
        private void Clearbox2()
        {
            tab1Show.Clear();
            distances.Clear();
            angles.Clear();
            coordinateX.Clear();
            coordinateY.Clear();
            coordinateZ.Clear();
        }
        private void sendata(double coX, double coY, double coZ, int counter)
        {
            coordinateX.Add(coX);
            coordinateY.Add(coY);
            coordinateZ.Add(coZ);
            showArea.AppendText(counter +
                "\nX : " + coordinateX.ElementAt(counter) +
                "\nY : " + coordinateY.ElementAt(counter) +
                "\nZ : " + coordinateZ.ElementAt(counter) + "\n");

        }
        private double toRadians(double angleVal)
        {
            return (Math.PI / 180) * angleVal;
        }

        private double percent(int per)
        {
            return (per / 100);
        }

        private void clickToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uAVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tab1Show.Text != "")
            {
                saveFileDialogUAV.InitialDirectory = @"C:\";
                saveFileDialogUAV.RestoreDirectory = true;
                saveFileDialogUAV.DefaultExt = "csv";
                saveFileDialogUAV.Title = "Browse CSV Files";
                saveFileDialogUAV.Filter = "Drone data files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialogUAV.FilterIndex = 1;
                if (saveFileDialogUAV.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(saveFileDialogUAV.FileName, FileMode.CreateNew))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        int i = 0;
                        while (i < coordinateX.Count)
                        {
                            sw.Write(distances.ElementAt(i) + "," +
                                angles.ElementAt(i) + "," +
                                coordinateX.ElementAt(i) + "," +
                                coordinateY.ElementAt(i) + "," +
                                coordinateZ.ElementAt(i) + "\n");
                            i++;
                        }
                        MessageBox.Show("Save Complete!");
                    }

                }
            }
            else
            {
                MessageBox.Show("No data to Save!");
            }
        }

        private void tab1Show_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uAVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog2.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                String data;
                int count = 0;
                List<double> heights = new List<double>();

                Clearbox();
                Clearbox2();
                while ((data = sr.ReadLine()) != null)
                {
                    String[] token = data.Split(',');
                    distances.Add(Double.Parse(token[0]));
                    angles.Add(Double.Parse(token[1]));
                    heights.Add(Double.Parse(token[2]));
                    tab1Show.AppendText(count +
                        "\ndistances : " + distances.ElementAt(count) +
                        "\nangles : " + angles.ElementAt(count) +
                        "\nheights : " + heights.ElementAt(count) +
                        "\nCOX : " + distances.ElementAt(count) * (Math.Sin(toRadians(angles.ElementAt(count)))) +
                        "\nCOY : " + distances.ElementAt(count) * (Math.Cos(toRadians(angles.ElementAt(count)))) +
                        "\n");

                    sendata(distances.ElementAt(count) * (Math.Sin(toRadians(angles.ElementAt(count)))),
                        distances.ElementAt(count) * (Math.Cos(toRadians(angles.ElementAt(count)))),
                        heights.ElementAt(count),
                        count
                        );
                    count++;
                }
                //MessageBox.Show(distances.Count().ToString() + " Data added to UAV tab!");
                sr.Close();
            }
        }

        private void pointCloudToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                //MessageBox.Show(sr.ReadToEnd());
                String data;
                int count = 0;
                while ((data = sr.ReadLine()) != null)
                {
                    String[] token = data.Split(',');
                    distance.Add(Double.Parse(token[0]));
                    angle.Add(Double.Parse(token[1]));
                    coordinateX.Add(Double.Parse(token[2]));
                    coordinateY.Add(Double.Parse(token[3]));
                    coordinateZ.Add(Double.Parse(token[4]));
                    showArea.AppendText(count +
                        "\nX : " + coordinateX.ElementAt(count) +
                        "\nY : " + coordinateY.ElementAt(count) +
                        "\nZ : " + coordinateZ.ElementAt(count) + "\n");
                    count++;
                }
                MessageBox.Show(distance.Count().ToString() + " Data added to Point cloud tab!");
                sr.Close();
            }
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphics = this.panel1.CreateGraphics();
            graphics.Clear(System.Drawing.Color.Black);
            int startRec = 20;
            int startRecY = 50;
            int Maxrec = 500;
            int hightdraw = 5;
            //System.Drawing.Point point = new System.Drawing.Point(20,20);
            //System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(startRec, startRecY, Maxrec, hightdraw);
            //graphics.DrawRectangle(System.Drawing.Pens.White, rectangle);
            Pen myPen = new Pen(Color.White);
            myPen.Width = 3;
            if (coordinateX.Count() > 1)
            {
                int i = 0;
                while (i < coordinateX.Count() - 1)
                {
                    graphics.DrawLine(myPen, (int)(coordinateX.ElementAt(i) + 300), (int)(coordinateY.ElementAt(i) + 300), (int)(coordinateX.ElementAt(i + 1) + 300), (int)(coordinateY.ElementAt(i + 1) + 300));
                    i++;
                }
                graphics.DrawLine(myPen, (int)(coordinateX.ElementAt(i) + 300), (int)(coordinateY.ElementAt(i) + 300), (int)(coordinateX.ElementAt(0) + 300), (int)(coordinateY.ElementAt(0) + 300));
            }
        }

        private void pointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Graphics graphics = this.panel1.CreateGraphics();
            graphics.Clear(System.Drawing.Color.Black);
            int startRec = 20;
            int startRecY = 50;
            int Maxrec = 500;
            int hightdraw = 5;
            //System.Drawing.Point point = new System.Drawing.Point(20,20);
            //System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(startRec, startRecY, Maxrec, hightdraw);
            //graphics.DrawRectangle(System.Drawing.Pens.White, rectangle);
            Pen myPen = new Pen(Color.White);
            myPen.Width = 3;
            List<double> PlotX = new List<double>();
            List<double> PlotY = new List<double>();
            PlotX.Clear();
            PlotY.Clear();
            if (coordinateX.Count() > 1)
            {
                int i = 0;
                while (i < coordinateX.Count() - 1)
                {
                    PlotX.Add(coordinateX.ElementAt(i) * (panel1.Width / 2) / 800);
                    PlotY.Add(coordinateY.ElementAt(i) * (panel1.Height / 2) / 800);
                    //graphics.DrawLine(myPen, (int)(coordinateX.ElementAt(i) + 300), (int)(coordinateY.ElementAt(i) + 300), (int)(coordinateX.ElementAt(i + 1) + 300), (int)(coordinateY.ElementAt(i + 1) + 300));
                    graphics.DrawLine(myPen, (int)(PlotX.ElementAt(i)), (int)(PlotY.ElementAt(i)), (int)(coordinateX.ElementAt(i + 1) * (panel1.Width / 2) / 800), (int)(coordinateY.ElementAt(i + 1) * (panel1.Height / 2) / 800));
                    i++;
                }
                //graphics.DrawLine(myPen, (int)(coordinateX.ElementAt(i) + 300), (int)(coordinateY.ElementAt(i) + 300), (int)(coordinateX.ElementAt(0) + 300), (int)(coordinateY.ElementAt(0) + 300));
            }
        }
    }
}
