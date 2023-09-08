using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_Karelin
{
    class Program
    {
        static void Main(string[] args)
        {  
            ///////////////////////////////////////
            // учебная часть 
            /////////////////////////////
            
              sbyte a = -15;
              sbyte c = 100;
              sbyte b=Math.Abs(a);
            // Console.WriteLine(b);
            sbyte d = Math.Max( a, c);            
             // Console.WriteLine(d);

            
                        double R = 46.8;
                        double e = Math.Sqrt(R);
                       // Console.WriteLine(e);

            ////////////////////////////////////////////////////
            //Индивидуальное задание
            ////////////////////////////////
            /* 8. Вычислить площадь круга радиуса R. Максимально задействовать
* имеющиеся в распоряжении функции модуля «Математика».
    */
            double r = 5;
            double area = Math.PI * Math.Pow(r,2);
            Console.WriteLine("Площадь круга =" + area);
            // ответ 78,5398163...

        }
    }
}
