using System;

namespace GPA_Calculator_App
{
    internal class GPA_Methods
    {
        public double CalculateGPA(double s1)
        {
            return (s1 / 100) * 4;
        }
        public double CalculateGPA(double s1, double s2)
        {
            return ((s1 + s2) / 2 / 100) * 4;
        }

        public double CalculateGPA(double s1, double s2, double s3)
        {
            return ((s1 + s2 + s3) / 3 / 100) * 4;
        }

        public double CalculateGPA(double s1, double s2, double s3, double s4)
        {
            return ((s1 + s2 + s3 + s4) / 4 / 100) * 4;
        }

        public double CalculateGPA(double s1, double s2, double s3, double s4, double s5)
        {
            return ((s1 + s2 + s3 + s4 + s5) / 5 / 100) * 4;
        }
    }
}
