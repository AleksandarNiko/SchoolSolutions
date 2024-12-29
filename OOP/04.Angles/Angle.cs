using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Angles
{
    public class Angle
    {
        private byte angle;

        public  byte AngleSize { get; set; }

        public Angle(byte angle)
        {
            AngleSize = angle;
        }

        private double Sinus(double angle)
        {
            return Math.Sin(angle);
        }

        private double Cosinus(double angle) 
        {
            return Math.Cos(angle);
        }

        private double Tangens(double angle)
        {
            return Math.Tan(angle);
        }

        private double Cotangens(double angle)
        {
            return Math.Atan(1 / angle);
        }

        public override string ToString()
        {
            return $"Sin({AngleSize})={Sinus(AngleSize):f2} \n" +
                $"Cos({AngleSize})={Cosinus(AngleSize):f2} \n" +
                $"Tangens({AngleSize})={Tangens(AngleSize):f2} \n" +
                $"Cotangens({AngleSize} )= {Cotangens(AngleSize):f2} \n" 
                .ToString()
                .Trim();
        }

    }
}
