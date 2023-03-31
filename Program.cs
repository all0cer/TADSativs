
using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.distancia();

        }
         static void nome1()
        {
            var nome =  Console.ReadLine();
            var primeiro = nome.Split(' ');
            Console.WriteLine($"Bem vindo ao C# {primeiro[0]}");
        }

        static void media()
        {
            int n1 =  int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            int n2 = int.Parse(Console.ReadLine());
            if ((n1/n2) > 60){
                Console.WriteLine("Aprovado");
            }       
            else {
                Console.WriteLine("Reprovado");
            }
        }

        static void km(){
            var n1 = Console.ReadLine();
            var s = n1.Split(':');
            double segundos_total = ( (double.Parse(s[0])*3600) + (double.Parse(s[1])*60) + (double.Parse(s[2])) );
            var km = segundos_total*300000;
            Console.WriteLine($"{km}km");

        }
        static void vol(){
            Console.WriteLine("Digite a base e a altura do retângulo");
            var b = int.Parse(Console.ReadLine());
            var a = int.Parse(Console.ReadLine());
            var area = (b*a)/2;
            var perimetro = (2*b) + (2*a);
            var diagonal = Math.Sqrt((Math.Pow(b,2)) + (Math.Pow(a,2)));
            Console.WriteLine($"Area= {area}   Perimetro= {perimetro}   Diagonal={diagonal}");
        }

        static void salario(){
            var nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());
            double total = salario + (vendas*0.15);   
            Console.WriteLine($"TOTAL = R$ {total:0.00}");     
        }

        static void maior(){
            string[] d = Console.ReadLine().Split(' ');
            var a  = long.Parse(d[0]);
            var b = long.Parse(d[1]);
            var c = long.Parse(d[2]);
            long maiorAB = (a+b+Math.Abs(a-b))/2;

            if (maiorAB<c){
                Console.WriteLine($"{c} eh o maior");
            }
            else if (maiorAB==a){
                Console.WriteLine($"{a} eh o maior");
            }
            else if(maiorAB==b){
                Console.WriteLine($"{b} eh o maior");
            }
        }
        static void consumo(){
            var distancia = float.Parse(Console.ReadLine());
            var consumo = float.Parse(Console.ReadLine());
            var gasto = distancia/consumo;
            Console.WriteLine($"{gasto:0.000} km/l");
        }
        static void distancia(){
            string[] entrada = Console.ReadLine().Split(' ');
            double x1 = double.Parse(entrada[0]); double y1 = double.Parse(entrada[1]);
            string[] entrada2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(entrada2[0]); double y2 = double.Parse(entrada2[1]);
            double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"{distancia:0.0000}");
        }

    }
}

       