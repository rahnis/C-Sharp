﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeStatistics
    {
        public float HighestGrade;
        public float AverageGrade;
        public float LowestGrade;
        public string LetterGrade
        {
            get
            {
                string result;
                if (AverageGrade >= 90)
                    result = "A";
                else if (AverageGrade >= 80)
                    result = "B";
                else if (AverageGrade >= 70)
                    result = "C";
                else if (AverageGrade >= 60)
                    result = "D";
                else
                    result = "F";

                return result;
            }
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Execellent";
                        break;

                    case "B":
                        result = "Good";
                        break;

                    case "C":
                        result = "Average";
                        break;

                    case "D":
                        result = "Below Average";
                        break;

                    default:
                        result = "Faling";
                        break;
                }
                return result;
            }
        }

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
    }
}
