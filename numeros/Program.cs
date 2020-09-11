using System;

namespace numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=19,b=20,sum=a+b,sub=a-b,mul=a*b,div=a/b,res=a%b;
                       
            Console.WriteLine($"soma: {sum}\nsubtração: {sub}\nmultiplicação: {mul}\ndivisão: {div}\nresto: {res}");

            int mv=int.MaxValue;
            float mnv=int.MinValue;
            Console.WriteLine($"Int max value: {mv}\nFloat min value: {mnv}");

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            float thirdd = 1 / 3;
            Console.WriteLine($"Resultado de 1.0/3.0 em double: {third}\nResultado de 1/3 em float: {thirdd}");

            double aa = 1.0;
            double bb = 3.0;
            double divdbl = aa/bb;
            decimal cc = 1.0M;
            decimal dd = 3.0M;
            decimal divM = cc/dd;
            Console.WriteLine($"Resultado da divisão 1.0/3.0 em double: {divdbl}\nResultado em decimal: {divM}");

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Área de um círculo de raio = 2.50cm (em double): {area}cm");
        }
    }
}