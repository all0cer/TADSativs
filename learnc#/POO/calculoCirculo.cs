using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            circulo x = new circulo();
            x.raio = 13;
            Console.WriteLine($"circunferencia: {x.circunferencia()}");
            Console.WriteLine($"area do circulo: {x.AreaCirculo()}");
        }
    }
}

class circulo{
    public double raio;
    public double AreaCirculo(){
        return 3.14 * (raio * raio);
    }
    public double circunferencia(){
        return 2*3.14*raio;
    }
}