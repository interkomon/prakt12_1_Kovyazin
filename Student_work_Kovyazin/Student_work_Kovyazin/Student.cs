using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_work_Kovyazin
{
    class Student
    {
        public string name;
        public int rost; 
        private double ves = 70;

        public double SetEat(double eda) 
        {
            int callories = 1800;
         //   ves += (eda * 1000 - calories) / 1000;
          //  return ves;
            if (eda > 5 && eda < 10)
            {
                rost = rost - 1;
                ves += ((eda * 1000 - callories) / 1000)*1.7;
            }             
           else if (eda > 10)
            {
                rost = rost - 2;
                ves += ((eda * 1000 - callories) / 1000)*1.5;
            }
           else
                ves += (eda * 1000 - callories) / 1000;

            return ves;
             

        }
        public double GetEat()
        {
            return ves;
        }
           

    }
}
