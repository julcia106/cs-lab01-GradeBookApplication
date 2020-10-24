using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isBool) :base(name, isBool)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade) // not finished
        {

            if (Students.Count < 5)
            { 
                throw new System.InvalidOperationException();
            }
            var count = 0;
            
            for (var i=0; i< Students.Count; ++i)
            {
                if(Students[i].AverageGrade > averageGrade)
                {
                    count++;
                }
            }

            var countPercentage = count / Students.Count;

            if (countPercentage >= 0.8)
                return 'A';
            else if (countPercentage >= 0.6 && countPercentage < 0.8)
                return 'B';
            else if (countPercentage >= 0.4 && countPercentage < 0.6)
                return 'C';
            else if (countPercentage >= 0.2 && countPercentage < 0.4)
                return 'D';
            else 
                return 'F';

        }

        public override void CalculateStatistics()
        {
            if(Students.Count < 5)
            {
                Console.WriteLine("Ranked gradingrequires at least 5 students.");
            }
            else if (Students.Count >= 5)
            {
                base.CalculateStatistics();
            }
        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked gradingrequires at least 5 students.");
            }
            else if (Students.Count >= 5)
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}
