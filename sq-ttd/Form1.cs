using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sq_ttd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcAnglesButton_Click(object sender, EventArgs e)
        {
            uint angle1 = Convert.ToUInt32(Math.Round(Convert.ToDouble(angleBox1.Text)));
            uint angle2 = Convert.ToUInt32(Math.Round(Convert.ToDouble(angleBox2.Text)));

            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);

            double third = t1.CalculateThirdAngle();

            angleBox3.Text = third.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint angle1 = Convert.ToUInt32(angleBox1.Text);
            uint angle2 = Convert.ToUInt32(angleBox2.Text);
            double side1 = Convert.ToDouble(sideBox1.Text);
            double side2 = Convert.ToDouble(sideBox2.Text);

            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);
            t1.SetSides(side1, side2);

            double area = 0;
            if(t1.IsRightAngleTriangle())
            {
                area = t1.CalculateArea();
            }

            areaBox.Text = area.ToString();
        }

        private void hypButton_Click(object sender, EventArgs e)
        {
            uint angle1 = Convert.ToUInt32(angleBox1.Text);
            uint angle2 = Convert.ToUInt32(angleBox2.Text);
            double side1 = Convert.ToDouble(sideBox1.Text);
            double side2 = Convert.ToDouble(sideBox2.Text);

            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);
            t1.SetSides(side1, side2);

            double hypotenuse = 0;
            if (t1.IsRightAngleTriangle())
            {
                hypotenuse = t1.GetHypotenuse();
            }

            sideBox3.Text = hypotenuse.ToString();
        }
    }
}
