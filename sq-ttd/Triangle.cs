using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sq_ttd
{
    public class Triangle
    {
        private UInt32 angle1;
        private UInt32 angle2;
        private UInt32 angle3;

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
        }

        public uint CalculateThirdAngle()
        {
            Angle3 = 180 - Angle1 - Angle2;
            return Angle3;
        }
    }
}
