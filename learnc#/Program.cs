using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.intervalo();

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
        static void cedulas(){
            int valor = int.Parse(Console.ReadLine());
  
            int nota100 = valor/100;
            int nota50 = (valor%100)/50;
            int nota20 = (valor%50)/20;
            int nota10 = (valor%20)/10;
            int nota5 = (valor%10)/5;
            int nota2 = (valor%5)/2;
            int nota1 = (valor%2)/1;
            Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
            Console.WriteLine($"{nota1} nota(s) de R$ 1,00");
        }
        static void rodovia(){
            string[] via = Console.ReadLine().Split(' ');
            long tamanho = long.Parse(via[0]);
            long radarkm = long.Parse(via[1]);
            string[] preco = Console.ReadLine().Split(' ');
            int gas = int.Parse(preco[0]);
            int front = int.Parse(preco[1]);
            long precoporkm = tamanho*gas;
            long pedagio = (tamanho/radarkm)*front;
            long valor = precoporkm+pedagio;
            Console.WriteLine(valor);
        }
        static void area(){
            string[] valores = Console.ReadLine().Split(' ');
            double a =   double.Parse(valores[0]);
            double b = double.Parse(valores[1]);
            double c = double.Parse(valores[2]);
            double triangulo = (a*c)/2; double circulo = 3.14159*(c*c); double trapezio = ((a+b)*c)/2; double quadrado = b*b; double retangulo = b*a;
            Console.WriteLine($"TRIANGULO: {triangulo:0.000}");
            Console.WriteLine($"CIRCULO: {circulo:0.000}");
            Console.WriteLine($"TRAPEZIO: {trapezio:0.000}");
            Console.WriteLine($"QUADRADO: {quadrado:0.000}");
            Console.WriteLine($"RETANGULO: {retangulo:0.000}");
        }
        static void gastogasolinha(){
            float tempo = float.Parse(Console.ReadLine());
            float velocidade = float.Parse(Console.ReadLine());
            float gasto = (velocidade*tempo)/12;
            Console.WriteLine($"{gasto:0.000}");
        }

        //Lista 05 - Decisão
        static void testeselecao(){
        string[] valores = Console.ReadLine().Split(' ');
            int a =   int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);
            int d = int.Parse(valores[3]);
            if (b>c && d>a && (c+d)>(a+b) && c>0 && d>0 && (a%2==0)){
                Console.WriteLine("Valores aceitos");
            }
            else{Console.WriteLine("Valores nao aceitos");}

        }
        static void intervalo(){
            float n = float.Parse(Console.ReadLine());
            if (n>=0 && n<=25.000000){Console.WriteLine("Intervalor [0,25]");}
            if (n>=25.000001 && n<=50.0000000){Console.WriteLine("Intervalor [25,50]");}
            if (n>=50.000001 && n<=75.0000000){Console.WriteLine("Intervalor [50,75]");}
            if (n>=70.000001 && n<=100.000000){Console.WriteLine("Intervalor [50,100]");}
            if (n>100.00 || n<0){Console.WriteLine("Fora do intervalo");}
        }


    }
}
