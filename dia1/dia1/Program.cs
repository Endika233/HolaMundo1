using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(2/2);


            /*Console.WriteLine(-5+8*6);
            Console.WriteLine((55+9)%9);
            Console.WriteLine(20+-3*5/8);
            Console.WriteLine(5+15/3*2-8%3);*/


            /*Console.WriteLine("Escribe un número");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Y otro más"  );
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("La multiplicación de ambos números es " +num1*num2);*/


            /*Console.WriteLine("Escribe un número");
            int num1, num2;
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Y otro más");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("La suma es "+(num1+num2));
            Console.WriteLine("La resta es "+(num1-num2));
            Console.WriteLine("La multiplicación es "+(num1*num2));
            Console.WriteLine("La división es "+num1/num2);
            Console.WriteLine("El resto de la división es "+num1%num2);*/


            /*Console.WriteLine("Dime un número");
            int num1;
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num1 + " x 0 = "+num1*0);
            Console.WriteLine(num1 + " x 1 = " + num1 * 1);
            Console.WriteLine(num1 + " x 2 = " + num1 * 2);
            Console.WriteLine(num1 + " x 3 = " + num1 * 3);
            Console.WriteLine(num1 + " x 4 = " + num1 * 4);
            Console.WriteLine(num1 + " x 5 = " + num1 * 5);
            Console.WriteLine(num1 + " x 6 = " + num1 * 6);
            Console.WriteLine(num1 + " x 7 = " + num1 * 7);
            Console.WriteLine(num1 + " x 8 = " + num1 * 8);
            Console.WriteLine(num1 + " x 9 = " + num1 * 9);
            Console.WriteLine(num1 + " x 10 = " + num1 * 10);*/


            // Console.WriteLine(((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5)));


            //Console.WriteLine(4.0 * (1 - (1.0 / 3) + (1.0 / 5) - (1.0 / 7) + (1.0 / 9) - (1.0 / 11)));


            /*const double PI = 3.141593;//PARA DECIMALES USAR DOUBLE CONST+LO QUE VAYAS A METER
            Console.WriteLine("Introduce el perímetro del círculo");
            double radio = Double.Parse(Console.ReadLine());
            Console.WriteLine("El área del círculo es "+PI*(Math.Pow(radio, 2)));//Math.Pow(número, Potencia) PARA HACER POTENCIA CUADRADA CUBICA...
            Console.WriteLine("El perimetro del círculo es "+radio*2*PI);*/


            /*Console.WriteLine("Introduzca 3 números (pulsa enter cada vez que introduzcas 1)");
            Double num1 = Double.Parse(Console.ReadLine()), num2 = Double.Parse(Console.ReadLine()), num3 = Double.Parse(Console.ReadLine());
            Console.WriteLine((num1 + num2 + num3) / 3);*/


            /*Console.WriteLine("Escribe la altura del rectángulo");
            double anchura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y ahora la anchura");
            double altura =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El área del rectángulo es " + altura * anchura + " cm2, y el perímetro es " + 2 * (anchura + altura)+"cm");*/


            /*Console.WriteLine("Introduce 2 números");
            int num1 = Convert.ToInt32(Console.ReadLine()), num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Num1 es " + num1 + " y num2 es "+num2);
            int num3 = num2;
            num2 = num1;
            num1 = num3;
            Console.WriteLine("Num1 es " + num1 + " y num2 es "+num2);*/



            /*Console.WriteLine("Introduce un números de 3 dígitos");
            int numero3digitos=Int32.Parse(Console.ReadLine());
            int centena, decena, unidad;
            centena = numero3digitos / 100;
            decena = (numero3digitos - centena * 100)//10;O PODRIAS HABER USADO EL% PARA CALCULAR LO QUE SOBRA DE %100
            unidad = numero3digitos - centena * 100 - decena * 10;
            Console.WriteLine("La unidad es " + unidad + " la decena es " + decena + " y la centena es " + centena);*/


            /*Console.WriteLine("Introduce un dígito");
            int num1, num2, num3;
            num1 = Int32.Parse(Console.ReadLine());
            num2 = num1 * 11;
            num3 = num1 * 111;
            Console.WriteLine (num1 + "+" + num2+"+"+num3+"+"+"="+(num1 + num2 + num3));*/


            /*Console.WriteLine("Escribe un número");
            int numero = Int32.Parse(Console.ReadLine());//Convert.ToString()IMPORTANTE
            Console.WriteLine("El número es " + numero);*/


            /*Console.WriteLine("Escribe 2 números");
            int num1 = Int32.Parse(Console.ReadLine()), num2 = Int32.Parse(Console.ReadLine()), num3 = num1 / num2;
            Console.WriteLine("El resto de dividir " + num1 + " entre " + num2 + " es "+(num1-num3*num2));*/


            /*Console.WriteLine("Introduce las pulgadas que pasaremos a metros");
            double pulgadas=Int32.Parse(Console.ReadLine()), metros=pulgadas*0.0254;
            Console.WriteLine(pulgadas + " pulgadas, es igual a " + metros + " metros");*/


            /*Console.WriteLine("Escribe los minutos a convertir");
            int minutos=Convert.ToInt32(Console.ReadLine()), dias=(minutos/(60*24))%365,años=(minutos/(60*24))/365;
            Console.WriteLine("Eso son " + años + " años y " + dias + " días.");*/


            /*Console.WriteLine("Escribe la distancia en metros.");
            double metros=Double.Parse(Console.ReadLine());
            Console.WriteLine("El tiempo tardado en horas, minutos y segundos");
            double horas=Int32.Parse(Console.ReadLine()), minutos=Int32.Parse(Console.ReadLine()), segundos=Int32.Parse(Console.ReadLine());
            double metroSegundo = metros / (horas * 3600 + minutos * 60 + segundos);
            double kmHora = (metros / 1000) /( horas + minutos / 60 + segundos / 3600);
            Console.WriteLine("Eso son " + metroSegundo + " m/s, o " + kmHora + " km/h");*/




            Random rnd = new Random();
            int aleatorio100 = rnd.Next(0,100);
            Console.WriteLine("Tú número aleatorio es "+aleatorio100);




            Console.ReadKey();
            
            /*Console.WriteLine("Escribe dos números.");
            double num1 = Double.Parse(Console.ReadLine()), num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
            Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
            Console.WriteLine("La media de " + num1 + " y " + num2 + " es " + (num1 + num2) / 2);
            Console.WriteLine("El número más alto es ");
            Console.WriteLine("El número más bajo es ");*/



            
        }
    }
}
