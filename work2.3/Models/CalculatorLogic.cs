using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace work2._3
{
    public class CalculatorLogic
    {
        public string ast { get; set; }
        public string bst { get; set; }
        public string cst { get; set; }

        private double A;
        private double B;
        private double C;

        public double X1 { get;private set; }
        public double X2 { get;private set; }
        private double D;

        public string ErrorMessage { get;private set; }

        public void Validator()
        {
            try
            {
                A = Convert.ToDouble(ast);
                if (A == 0.0)
                {
                    ErrorMessage = "!'a' -  не должно быть равным НУЛЮ//";
                }

                B = Convert.ToDouble(bst);

                C = Convert.ToDouble(cst);
            }
            catch
            {
                ErrorMessage ="! Не верный формат ввода, проветри поля a,b,c!//";
            }

        }

         public void DiscriminantCalculations()
        {
            
            if (A != 0.0)
            {
                D = (B * B) - (4 * A * C);
                
                if (D < 0.0)
                {
                    ErrorMessage = "!Уравнение корней не имеет (и не пытайтесь морочить голову с мнимыми корнями)//";
                }
            }
            
        }

        public void CalculationsX()
        {
            
            if (D == 0.0)
            {
                X1 = X2 = (-B) / (2 * A);
            }
            else
            {
                X1 = (-B - (Math.Sqrt(D))) / (2 * A);

                X2 = (-B + (Math.Sqrt(D))) / (2 * A);

            }
        }
    }
}