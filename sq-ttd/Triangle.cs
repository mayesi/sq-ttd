/*  
 *  File:       Triangle.cs
 *  Project:    Software Quality 1 Assignment 2
 *  Programmer: Maye Inwood
 *  Date:       November 23, 2018
 *  Description:
 *      This file contains the Class Triangle.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace sq_ttd
{
    /*
     *  Name:       Triangle
     *  Description:
     *      This class contains methods for calculating the third angle, hypotenuse and
     *      area of a triangle given some information about the angles and sides.
     */
    public class Triangle
    {
        // The angles of the triangle
        private uint angle1 = 0;
        private uint angle2 = 0;
        private uint angle3 = 0;

        // The sides of the triangle
        private double sideA = 0;
        private double sideB = 0;
        private double sideC = 0;

        // Getters and Setters...
        public uint Angle1 { get => angle1; set => angle1 = value; }
        public uint Angle2 { get => angle2; set => angle2 = value; }
        public uint Angle3 { get => angle3; set => angle3 = value; }
        public double SideA { get => sideA; set => sideA = value; }
        public double SideB { get => sideB; set => sideB = value; }
        public double SideC { get => sideC; set => sideC = value; }


        /*
         *  Name: Triangle()
         *  Description: Constructor
         *  Parameters: none
         *  Return: none
         */
        public Triangle()
        {
        }


        /*
         *  Name: SetAngles()
         *  Description: Sets two angles for the triangle if they are within 0 and 180. 
         *      Also sets the third angle using SetThirdAngle().
         *  Parameters: uint angle1, uint angle2 - two angles
         *  Return: none
         */
        public void SetAngles(uint angle1, uint angle2)
        {
            if (angle1 > 180 || angle2 > 180)
            {
                throw new ArgumentException("Angle out of bounds.");
            }
            if (angle1 == 0 || angle2 == 0)
            {
                throw new ArgumentException("Angle of zero is not allowed.");
            }
            Angle1 = angle1;
            Angle2 = angle2;
            SetThirdAngle();
        }


        /*
         *  Name: SetThirdAngle()
         *  Description: Calculates and sets the third angle based on Angle1 and Angle2.
         *  Parameters: none
         *  Return: none
         */
        private void SetThirdAngle()
        {
            Angle3 = 180 - Angle1 - Angle2;
        }


        /*
         *  Name: CalculateThirdAngle()
         *  Description: Public method to get the third angle.
         *  Parameters: none
         *  Return: uint Angle3
         */
        public uint CalculateThirdAngle()
        {
            return Angle3;
        }


        /*
         *  Name: IsRightAngleTriangle()
         *  Description: Determines whether the triangle is a right angle triangle based on
         *      the set angles.
         *  Parameters: none
         *  Return: bool true - is a right angle triangle, false - is not
         */
        public bool IsRightAngleTriangle()
        {
            bool retVal = false;
            if (Angle1 == 90 || Angle2 == 90 || Angle3 == 90)
            {
                retVal = true;
            }
            return retVal;
        }


        /*
         *  Name: SetSides()
         *  Description: Sets the sides for the triangle. 
         *  Parameters: 
         *      double side1, double side2 - the sides
         *  Return: none
         */
        public void SetSides(double side1, double side2)
        {
            if(side1 == 0 || side2 == 0)
            {
                throw new ArgumentException("Side length of zero is invalid.");
            }
            if(side1 < 0 || side2 < 0)
            {
                throw new ArgumentException("Side length cannot be a negative value.");
            }
            SideA = side1;
            SideB = side2;
            SetSideC();
        }


        /*
         *  Name: SetSideC()
         *  Description: Sets the third side for the triangle. It is correct only
         *      for right angle triangles.
         *  Parameters: none
         *  Return: none
         */
        private void SetSideC()
        {
            SideC = Math.Sqrt(Math.Pow(SideA, 2.0) + Math.Pow(SideB, 2.0));
        }


        /*
         *  Name: GetHypotenuse()
         *  Description: Returns the value of the hypotenuse rounded to one decimal point. 
         *      An exception will be thrown if the triangle is not a right angle triangle.
         *      Does not guarantee that the triangle is a real triangle.
         *  Parameters: none
         *  Return: double - the hypotenuse
         */
        public double GetHypotenuse()
        {
            if(!IsRightAngleTriangle())
            {
                NotRightAngleTriangleException ex = new NotRightAngleTriangleException("Cannot calculate: not a right angle triangle.");
                throw ex;
            }
            return Math.Round(SideC, 1);
        }


        /*
         *  Name: CalculateArea()
         *  Description: Calculates and returns the area of a triangle. An exception will 
         *      be thrown if the triangle is not a right angle triangle.
         *  Parameters: none
         *  Return: double - the area rounded to one decimal point.
         */
        public double CalculateArea()
        {
            if (!IsRightAngleTriangle())
            {
                NotRightAngleTriangleException ex = new NotRightAngleTriangleException("Cannot calculate: not a right angle triangle.");
                throw ex;
            }
            return Math.Round(SideA * SideB / 2.0, 1);
        }


        /*
         *  Name:       NotRightAngleTriangleException
         *  Description:
         *      This class 
         */
        public class NotRightAngleTriangleException : Exception
        {
            /*
             *  Name: NotRightAngleTriangleException()
             *  Description: Constructor
             */
            public NotRightAngleTriangleException()
            {
            }

            /*
             *  Name: NotRightAngleTriangleException(string message)
             *  Description: Alternate constructor, specify a message 
             *  Parameters: 
             *      string message - a message
             */
            public NotRightAngleTriangleException(string message) : base(message)
            {
            }

            /*
             *  Name: NotRightAngleTriangleException(string message, Exception innerException)
             *  Description: Alternate constructor, specify a message and inner exception
             *  Parameters: 
             *      string message - a message
             *      Exception innerException
             *  Return:
             */
            public NotRightAngleTriangleException(string message, Exception innerException) : base(message, innerException)
            {
            }

        }
    }
}
