using System;
using System.Collections.Generic;

namespace sbscmentor
{
    public class gpacalculator
    {
        double totalUnit = 0;
        double qualityPoint = 0;
        double cgpa = 0;
        string Lettergrade;

        double newValue =0;

        double value = 0;
        public void calculategpa(List<Course> courses)
        {
            foreach (var course in courses)
            {
                double score = course.CourseScore;
                if (score >= 70 && score <= 100)
                {
                    Lettergrade = "A";
                    qualityPoint = 5;
                }
                else if (score >= 60 && score <= 69)
                {
                    Lettergrade = "B";
                    qualityPoint = 4;
                }
                else if (score >= 50 && score <= 59)
                {
                    Lettergrade = "C";
                    qualityPoint = 3;
                }
                else if (score >= 46 && score <= 49)
                {
                    Lettergrade = "D";
                    qualityPoint = 2;
                }
                else if (score >= 40 && score <= 44)
                {
                    Lettergrade = "E";
                    qualityPoint = 1;
                }
                else
                {
                    Lettergrade = "F";
                    qualityPoint = 0;
                }

                value = course.NumberOfUnits;
                qualityPoint = totalUnit*qualityPoint;
                 newValue = qualityPoint+newValue;
                 totalUnit += course.NumberOfUnits;
                 Console.WriteLine($"{course.CourseCode}                 {course.CourseScore}                    {course.NumberOfUnits}");


            }
            cgpa = newValue/totalUnit;
            Console.WriteLine("total unit is " + totalUnit );
            Console.WriteLine("qualitypoint is " + newValue );
            Console.WriteLine("cgpa is " + Math.Round(cgpa, 2) );
            
            
        }
       
    }
}