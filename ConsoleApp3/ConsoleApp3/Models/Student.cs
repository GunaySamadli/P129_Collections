using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    class Student
    {
        public Dictionary<string, int> Exams;

        public Student()
        {
            Exams = new Dictionary<string, int>();
        }

        public double CalcAvgPoint()
        {
            double sum=0;
            foreach (var item in Exams)
            {
                sum += item.Value;
            }
            return sum / Exams.Count;
        }
    }
}
