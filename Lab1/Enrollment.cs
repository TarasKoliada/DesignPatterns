using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Enrollment
    {
        private float[] GetMarks()//filling the arr with random float marks[2, 5]
        {
            Random random = new Random();
            float[] receivedMarks = new float[10];
            for (int i = 0; i < receivedMarks.Length; i++)
            {
                receivedMarks[i] = random.Next(2, 5);
            }
            return receivedMarks;
        }
        public void SetAverage(Student student)//calculation of average mark and setting it to the student field
        {
            
            float sumOfMarks = 0;
            for (int i = 0; i < GetMarks().Length; i++)
            {
                sumOfMarks += GetMarks()[i];
            }
            student.AverageMark = sumOfMarks / GetMarks().Length;
        }
        public int SetFinalMark(Student student)//Calculating final mark(rounding a number to the nearest whole number and setting it to the student field)
        {
            int finalMark = (int)Math.Round(student.AverageMark);
            student.FinalMark = finalMark;
            return finalMark;
        }
    }
}
