using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sq_ttd;

namespace TriangleTests
{
    [TestClass]
    public class TriangleTests
    {
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

    }
}
