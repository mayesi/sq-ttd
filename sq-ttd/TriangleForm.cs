/*  
 *  File:       TriangleForm.cs
 *  Project:    Software Quality 1 Assignment 2
 *  Programmer: Maye Inwood
 *  Date:       November 23, 2018
 *  Description:
 *      This file contains the Windows Form code for handling events for the 
 *      application.
 */
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
    /*
     *  Name:       TriangleForm
     *  Description:
     *      This class contains Windows Form methods for handling events for the 
     *      application..
     */
    public partial class TriangleForm : Form
    {
        /*
         *  Name: TriangleForm()
         *  Description: Constructor
         *  Parameters: none
         *  Return: none
         */
        public TriangleForm()
        {
            InitializeComponent();
        }


        /*
         *  Name: calcAnglesButton_Click()
         *  Description: Event handler for the button to calculate the third angle for the
         *      triangle. Takes input from the other two boxes and puts the result in the
         *      third box.
         *  Parameters: object sender, EventArgs e
         *  Return: none
         */
        private void CalcAnglesButton_Click(object sender, EventArgs e)
        {
            uint angle1 = Convert.ToUInt32(Math.Round(Convert.ToDouble(angleBox1.Text)));
            uint angle2 = Convert.ToUInt32(Math.Round(Convert.ToDouble(angleBox2.Text)));

            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);

            double third = t1.CalculateThirdAngle();

            angleBox3.Text = third.ToString();
        }


        /*
         *  Name: AreaButton_Click()
         *  Description: Event handler for the button to calculate the area for the
         *      triangle. Takes input from the other four boxes and puts the result in the
         *      area box.
         *  Parameters: object sender, EventArgs e
         *  Return: none
         */
        private void AreaButton_Click(object sender, EventArgs e)
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


        /*
         *  Name: hypButton_Click()
         *  Description: Event handler for the button to calculate the hypotenuse for the
         *      triangle. Takes input from the other four boxes and puts the result in the
         *      hypotenuse box.
         *  Parameters: object sender, EventArgs e
         *  Return: none
         */
        private void HypButton_Click(object sender, EventArgs e)
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
