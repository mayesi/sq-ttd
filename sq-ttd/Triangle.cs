using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace sq_ttd
{
    public class Triangle
    {
        private uint angle1 = 0;
        private uint angle2 = 0;
        private uint angle3 = 0;
        private double sideA = 0;
        private double sideB = 0;
        private double sideC = 0;

        public uint Angle1 { get => angle1; set => angle1 = value; }
        public uint Angle2 { get => angle2; set => angle2 = value; }
        public uint Angle3 { get => angle3; set => angle3 = value; }
        public double SideA { get => sideA; set => sideA = value; }
        public double SideB { get => sideB; set => sideB = value; }
        public double SideC { get => sideC; set => sideC = value; }

        public Triangle()
        {

        }

        public void SetAngles(uint angle1, uint angle2)
        {
            if (angle1 > 180 || angle2 > 180)
            {
                throw new ArgumentException("Angle out of bounds.");
            }
            Angle1 = angle1;
            Angle2 = angle2;
            SetThirdAngle();
        }

        private void SetThirdAngle()
        {
            Angle3 = 180 - Angle1 - Angle2;
        }

        public uint CalculateThirdAngle()
        {
            return Angle3;
        }

        public bool IsRightAngleTriangle()
        {
            bool retVal = false;
            if (Angle1 == 90 || Angle2 == 90 || Angle3 == 90)
            {
                retVal = true;
            }
            return retVal;
        }

        public void SetSides(double side1, double side2)
        {
            SideA = side1;
            SideB = side2;
            SetSideC();
        }

        private void SetSideC()
        {
            SideC = Math.Sqrt(Math.Pow(SideA, 2.0) + Math.Pow(SideB, 2.0));
        }

        public double GetHypotenuse()
        {
            if(!IsRightAngleTriangle())
            {
                NotRightAngleTriangleException ex = new NotRightAngleTriangleException("Cannot calculate: not a right angle triangle.");
                throw ex;
            }
            return Math.Round(SideC, 1);
        }

        public double CalculateArea()
        {
            if (!IsRightAngleTriangle())
            {
                NotRightAngleTriangleException ex = new NotRightAngleTriangleException("Cannot calculate: not a right angle triangle.");
                throw ex;
            }
            return Math.Round(SideA * SideB / 2.0, 1);
        }

        public class NotRightAngleTriangleException : Exception
        {
            public NotRightAngleTriangleException()
            {
            }

            public NotRightAngleTriangleException(string message) : base(message)
            {
            }

            public NotRightAngleTriangleException(string message, Exception innerException) : base(message, innerException)
            {
            }

        }
    }
}
