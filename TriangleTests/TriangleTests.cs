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
    }
}
