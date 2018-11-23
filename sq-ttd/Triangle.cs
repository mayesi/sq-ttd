using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sq_ttd
{
    public class Triangle
    {
        private uint angle1 = 0;
        private uint angle2 = 0;
        private uint angle3 = 0;

        public uint Angle1 { get => angle1; set => angle1 = value; }
        public uint Angle2 { get => angle2; set => angle2 = value; }
        public uint Angle3 { get => angle3; set => angle3 = value; }

        public Triangle()
        {

        }

        public void SetAngles(uint angle1, uint angle2)
        {
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
    }
}
