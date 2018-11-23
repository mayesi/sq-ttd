/*  
 *  File:       TriangleTests.cs
 *  Project:    Software Quality 1 Assignment 2
 *  Programmer: Maye Inwood
 *  Date:       November 23, 2018
 *  Description:
 *      This file contains the unit testing class TriangleTests. This class contains
 *      unit tests for the Triangle class.
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sq_ttd;

namespace TriangleTests
{
    /*
     *  Name:       TriangleTests
     *  Description:
     *      This class contains unit tests for the Triangle class.
     */
    [TestClass]
    public class TriangleTests
    {
        /*  
         *  Name:       SetTwoValidAngles_CalculateTheThird()
         *  Description:
         *      Tests for the successful calculation of the third angle, given two valid
         *      angles (positive integers between 0 and 180).
         */
        [TestMethod]
        public void SetTwoValidAngles_CalculateTheThird()
        {
            UInt32 angle1 = 30;         // input 1
            UInt32 angle2 = 90;         // input 2
            UInt32 expectedResult = 60; // expected output

            // Create a Triangle object and set two angles.
            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);

            // Get the results, the third angle is calculated and returned.
            UInt32 third = t1.CalculateThirdAngle();

            // Compare the result to expected
            Assert.AreEqual(expectedResult, third);
        }


        /*  
         *  Name:       CheckIfRightAngleTriangle_GivenTwoAngles()
         *  Description:
         *      Tests for the successful determination of a right angle triangle given
         *      two valid angles (positive integers between 0 and 180) that would result 
         *      in the third being 90.
         */
        [TestMethod]
        public void CheckIfRightAngleTriangle_GivenTwoAngles()
        {
            UInt32 angle1 = 35;         // input 1
            UInt32 angle2 = 55;         // input 2
            bool expectedResult = true; // expected result

            // Create a Triangle object and set two angles.
            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);

            // Get the results.
            bool result = t1.IsRightAngleTriangle();

            // Compare the result to expected.
            Assert.AreEqual(expectedResult, result);
        }


        /*  
         *  Name:       FindHypotenuse_GivenValidInput()
         *  Description:
         *      Tests for the successful calculation of the hypotenuse, given two valid
         *      angles (positive integers between 0 and 180) that result in the triangle
         *      being a right angle triangle.
         */
        [TestMethod]
        public void FindHypotenuse_GivenValidInput()
        {
            // inputs and expected result
            uint angle1 = 90;
            uint angle2 = 45;
            double side1 = 4.0;
            double side2 = 5.0;
            double expectedResult = Math.Round(Math.Sqrt(Math.Pow(side1, 2.0) + Math.Pow(side2, 2.0)), 1);

            // Create a triangle and set it up.
            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);
            t1.SetSides(side1, side2);

            // Get the result
            double result = t1.GetHypotenuse();

            Assert.AreEqual(expectedResult, result);
        }


        /*  
         *  Name:       CalculateArea_GivenRightAngleTriangle()
         *  Description:
         *      Tests for the successful calculation of the area, given two valid
         *      angles (positive integers between 0 and 180) that result in the triangle
         *      being a right angle triangle. Also, given two valid sides (positive 
         *      numbers).
         */
        [TestMethod]
        public void CalculateArea_GivenRightAngleTriangle()
        {
            // inputs and expected result
            uint angle1 = 90;
            uint angle2 = 45;
            double side1 = 4.0;
            double side2 = 5.0;
            double expectedResult = side1 * side2 / 2.0;

            // Create a triangle and set it up.
            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);
            t1.SetSides(side1, side2);

            // Get the result
            double area = t1.CalculateArea();

            Assert.AreEqual(expectedResult, area);
        }


        /*  
         *  Name:       CalculateHypotenuse_ThrowExceptionWhenNotRightTriangle()
         *  Description:
         *      Tests for the GetHypotenuse() method throwing an exception when used
         *      when the triangle is not a right angle triangle.
         */
        [TestMethod]
        [ExpectedException(typeof(Triangle.NotRightAngleTriangleException))]
        public void CalculateHypotenuse_ThrowExceptionWhenNotRightTriangle()
        {
            // Inputs
            uint angle1 = 120;
            uint angle2 = 30;
            double side1 = 4.0;
            double side2 = 5.0;

            // Create a triangle and set it up.
            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);
            t1.SetSides(side1, side2);

            // Get the result.
            double result = t1.GetHypotenuse();
        }


        /*  
         *  Name:       CalculateHypotenuse_ThrowExceptionWhenNotRightTriangle()
         *  Description:
         *      Tests for the CalculateArea() method throwing an exception when used
         *      when the triangle is not a right angle triangle.
         */
        [TestMethod]
        [ExpectedException(typeof(Triangle.NotRightAngleTriangleException))]
        public void CalculateArea_ThrowExceptionWhenNotRightTriangle()
        {
            // Inputs
            uint angle1 = 120;
            uint angle2 = 30;
            double side1 = 4.0;
            double side2 = 5.0;

            // Create a triangle and set it up.
            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);
            t1.SetSides(side1, side2);

            // Get the result
            double result = t1.CalculateArea();
        }


        /*  
         *  Name:       AngleOutOfBoundsException()
         *  Description:
         *      Tests for the SetAngles() method throwing an exception when using
         *      inputs that are out of range (outside 0 to 180).
         */
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void AngleOutOfBoundsException()
        {
            // Inputs
            uint angle1 = 300;
            uint angle2 = 30;

            // Create a triangle and set it up.
            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);
        }


        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void InputValueIsZeroException_Angles()
        {
            // Inputs
            uint angle1 = 0;
            uint angle2 = 90;

            // Create a triangle and set it up.
            Triangle t1 = new Triangle();
            t1.SetAngles(angle1, angle2);
        }
    }
}
