using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultCalculationApp
{
    class Result
    {
        private double marksOfPhysics;

        private double markOfChemistry;
        private double markOfMath;
        private double averageMark;
        private string grade;

        public Result(double marksOfPhysics, double markOfChemistry, double markOfMath)
        {
            this.marksOfPhysics = marksOfPhysics;
            this.markOfChemistry = markOfChemistry;
            this.markOfMath = markOfMath;
        }

        public double CalculateAverage()
        {
            averageMark = (markOfMath + markOfChemistry + marksOfPhysics) / 3;
            return averageMark;
        }

        public string CalculateGrade()
        {
            if (averageMark >= 80)
            {
                grade = "A+";
            }
            else if (averageMark >= 70)
            {
                grade = "B+";
            }
            else if (averageMark >= 60)
            {
                grade = "C+";
            }
            else if (averageMark >= 50)
            {
                grade = "D+";
            }
            else if (averageMark < 50)
            {
                grade = "F";
            }

            return grade;
        }



    }
}
