
using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.salario();

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
    }
}

       